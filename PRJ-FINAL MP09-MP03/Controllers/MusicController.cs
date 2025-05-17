using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using PRJ_FINAL_MP09_MP03.Data;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;
using PRJ_FINAL_MP09_MP03.Models;
using System.Web; // para HttpUtility.UrlEncode
using System.Text.Json;
using System.Security.Claims;

namespace PRJ_FINAL_MP09_MP03.Controllers
{
    public class MusicController : Controller
    {
        private readonly TodoContext _context;
        private readonly IHttpClientFactory _httpClientFactory;


        public MusicController(TodoContext context, IHttpClientFactory httpClientFactory)
        {
            _context = context;
            _httpClientFactory = httpClientFactory;
        }

        private List<string?> GetValidApiKey() //  Obtiene una clave API válida
        {
            List<string?> apiKeys = new List<string?>();
            var apiKey = _context.ApiKeys
                .Where(a => a.EsValida && a.Funcion == "Trending" && !string.IsNullOrEmpty(a.ApiKeyValue))
                .AsEnumerable() // pasa el resto del LINQ al lado cliente
                .OrderBy(a => Guid.NewGuid()) // ahora sí puedes usar Guid.NewGuid()
                .ToList();


            return apiKeys;
        }

        private async Task<string?> HacerPeticionConApiKey(Func<string, Task<HttpResponseMessage>> generarPeticion)
        {
            var clavesDisponibles = _context.ApiKeys
                .Where(a => a.EsValida && !string.IsNullOrEmpty(a.ApiKeyValue))
                .AsEnumerable()
                .OrderBy(a => Guid.NewGuid())
                .ToList();

            foreach (var clave in clavesDisponibles)
            {
                var response = await generarPeticion(clave.ApiKeyValue);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }

                if ((int)response.StatusCode == 404 || (int)response.StatusCode == 429)
                {
                    clave.EsValida = false;
                    _context.Update(clave);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    break;
                }
            }

            return null;
        }


        // public async Task<string?> ObtenerTrackId(string nombreCancion)
        // {
        //     // Codifica el nombre de la canción para la URL
        //     var encodedName = HttpUtility.UrlEncode(nombreCancion);
        //     var client = _httpClientFactory.CreateClient();


        //     // Lógica para intentar con cada API Key válida
        //     var json = await HacerPeticionConApiKey(apiKey =>
        //     {
        //         var request = new HttpRequestMessage
        //         {
        //             Method = HttpMethod.Get,
        //             RequestUri = new Uri($"https://spotify-scraper.p.rapidapi.com/v1/track/search?name={encodedName}"),
        //             Headers =
        //             {
        //                 { "x-rapidapi-key", "86a7bf4e34mshaf5f880211c2826p15185djsnd747916cda85" },
        //                 { "x-rapidapi-host", "spotify-scraper.p.rapidapi.com" },
        //             }
        //         };
        //         return client.SendAsync(request);
        //     });

        //     if (string.IsNullOrEmpty(json))
        //         return null;

        //     // Deserializa con case-insensitive
        //     var opts = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        //     var resultado = JsonSerializer.Deserialize<RootScraper>(json, opts);

        //     // Devuelve únicamente el id del track (o null si algo falla)
        //     return resultado?.id;
        // }

        public async Task<string?> ObtenerTrackId(string nombreCancion)
        {
            var encodedName = HttpUtility.UrlEncode(nombreCancion);
            var client = _httpClientFactory.CreateClient();

            // Lista de API Keys disponibles
            var apiKeys = new List<string>
            {
                "48da421e5cmshede3a32b145be6cp11c965jsn8ada1c95370a",
                "ca15f4ff05msh47e7259b07555e0p1cc0abjsnf5cb9726aaa1",
                "ef818b1aecmsh79827fc8797dd58p1dd2eajsn8f080457a53a",
                "68487643c5mshe3db2baf52846c4p115085jsn4eb5204b61b9",
                "dd6fe17c30msh67fbaec763cfb74p11e836jsn92e674d92f50",
                "478218197amshd30b0d9d273cc0ap18b41ejsnff2ef884be54",
                "d09e880361msh8e4af3eca60f00bp123ceejsn2b2c95b0e10e",
                "aaf7330c73mshf9c8c253d9d98c4p168bc3jsn71b3c8e5b784",
                "00d4898e62msh780845403496f42p18f327jsn788acc6c8e53",
                "6401f7ec16mshbb3b159f0e3395ep1e4da4jsnbb14774b241b"
            };

            var random = new Random();
            var randomApiKey = apiKeys[random.Next(apiKeys.Count)];

            // Hacer la petición con la API Key aleatoria
            var json = await HacerPeticionConApiKey(_ =>
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://spotify-scraper.p.rapidapi.com/v1/track/search?name={encodedName}"),
                };
                request.Headers.Add("x-rapidapi-key", randomApiKey);
                request.Headers.Add("x-rapidapi-host", "spotify-scraper.p.rapidapi.com");

                return client.SendAsync(request);
            });

            if (string.IsNullOrEmpty(json))
                return null;

            var opts = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var resultado = JsonSerializer.Deserialize<RootScraper>(json, opts);

            return resultado?.id;
        }

        [HttpGet]
        public async Task<IActionResult> BuscarTrackId(string nombreCancion)
        {
            if (string.IsNullOrWhiteSpace(nombreCancion))
                return RedirectToAction("Dashboard");

            var trackId = await ObtenerTrackId(nombreCancion);

            if (trackId == null)
            {
                TempData["Error"] = $"No se encontró el ID para la canción '{nombreCancion}'.";
                return RedirectToAction("Dashboard");
            }

            TempData["TrackId"] = trackId;
            return RedirectToAction("Dashboard", new { nombreCancion });
        }


        [HttpGet]
        public async Task<IActionResult> BuscarTrackIdLyrics(string nombreCancion)
        {
            if (string.IsNullOrWhiteSpace(nombreCancion))
                return RedirectToAction("Lyrics");

            var trackId = await ObtenerTrackId(nombreCancion);

            if (trackId == null)
            {
                TempData["Error"] = $"No se encontró el ID para la canción '{nombreCancion}'.";
                return RedirectToAction("Lyrics");
            }

            TempData["TrackId"] = trackId;
            return RedirectToAction("Lyrics", new { nombreCancion });
        }



        [HttpPost]
        public IActionResult GuardarPlaylist([FromBody] Playlist datos)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            Console.WriteLine("Datos recibidos:");
            Console.WriteLine($"Nombre Canción: {datos.NombreCancion}");
            Console.WriteLine($"Artista: {datos.Artista}");
            Console.WriteLine($"Descripción: {datos.Descripcion}");
            Console.WriteLine($"URL Música: {datos.UrlMusica}");
            Console.WriteLine($"URL Descarga: {datos.UrlDescarga}");
            Console.WriteLine($"URL Imagen: {datos.UrlImg}");
            Console.WriteLine($"ID Track: {datos.IdTrack}");

            if (userId == null)
            {
                return Unauthorized(new { success = false, message = "Usuario no autenticado." });
            }

            if (string.IsNullOrWhiteSpace(datos.Descripcion))
            {
                datos.Descripcion = "";  // O un texto por defecto, por ejemplo "Sin descripción"
            }

            datos.UserId = userId.Value;
            datos.DateCreated = DateTime.Now;

            try
            {
                _context.Playlists.Add(datos);
                _context.SaveChanges();

                return Ok(new { success = true, message = "Track guardado en Playlist." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = $"Error al guardar en la base de datos: {ex.Message}", detalle = ex.InnerException?.Message });
            }
        }




        [HttpGet]
        public async Task<IActionResult> Dashboard()
        {
            var username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Login", "Account");
            }

            var client = _httpClientFactory.CreateClient();
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true
            };


            var SongsIds = new List<string>
            {
                "811",
                "207",
                "9103956",
                "9152241"
            };

            var random = new Random();

            var randomIndex = random.Next(SongsIds.Count);
            var randomSongId = SongsIds[randomIndex];
            // Obtener recomendaciones  
            var recommendations = new List<Recommendation>();
            try
            {
                var recJson = await HacerPeticionConApiKey(apiKey =>
                {
                    Console.WriteLine($"Usando API Key: {apiKey}");
                    var request = new HttpRequestMessage
                    {

                        Method = HttpMethod.Get,
                        RequestUri = new Uri("https://genius-song-lyrics1.p.rapidapi.com/song/recommendations/?id=" + randomSongId),
                        Headers =
                        {
                            { "x-rapidapi-key", "7083048a72mshb59a7266445f98bp1a8744jsn8bf9f4a86a4c" },
                            { "x-rapidapi-host", "genius-song-lyrics1.p.rapidapi.com" }
                        }
                    };
                    return client.SendAsync(request);
                });


                if (recJson != null)
                {
                    var recRoot = JsonSerializer.Deserialize<Root>(recJson, options);
                    recommendations = recRoot?.song_recommendations?.recommendations ?? new List<Recommendation>();
                }
            }
            catch { }

            ViewBag.Username = username;

            return View(new MusicViewModel
            {
                Recommendations = recommendations
            });
        }

        [HttpGet]
        public async Task<IActionResult> Trending(string timePeriod = "week")
        {
            var username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrEmpty(username))
                return RedirectToAction("Login", "Account");

            var client = _httpClientFactory.CreateClient();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var trending = new List<ChartItem>();
            var trendingArtists = new List<ChartItemArtis>();
            var trendingAlbums = new List<ChartItemAlbum>();

            try
            {
                var jsonSongs = await HacerPeticionConApiKey(apiKey =>
                {
                    var request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Get,
                        RequestUri = new Uri($"https://genius-song-lyrics1.p.rapidapi.com/chart/songs/?time_period={timePeriod}&chart_genre=all&per_page=10&page=1"),
                        Headers = {
                            { "x-rapidapi-key", "bd2b56823emshb5d70237dcab7bbp13f132jsn24bb921372d4" },
                            { "x-rapidapi-host", "genius-song-lyrics1.p.rapidapi.com" }
                        }
                    };
                    return client.SendAsync(request);
                });
                if (jsonSongs != null)
                {
                    var result = JsonSerializer.Deserialize<RootTrending>(jsonSongs, options);
                    trending = result?.chart_items ?? new List<ChartItem>();
                }

                var jsonArtists = await HacerPeticionConApiKey(apiKey =>
                {
                    var request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Get,
                        RequestUri = new Uri($"https://genius-song-lyrics1.p.rapidapi.com/chart/artists/?time_period={timePeriod}&per_page=13&page=1"),
                        Headers = {
                            { "x-rapidapi-key", "ce26e71f94msh97113bead13891dp1434a2jsn490dcda0d410" },
                            { "x-rapidapi-host", "genius-song-lyrics1.p.rapidapi.com" }
                        }
                    };
                    return client.SendAsync(request);
                });
                if (jsonArtists != null)
                {
                    var result = JsonSerializer.Deserialize<RootArtist>(jsonArtists, options);
                    trendingArtists = result?.chart_items ?? new List<ChartItemArtis>();
                }

                var jsonAlbums = await HacerPeticionConApiKey(apiKey =>
                {
                    var request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Get,
                        RequestUri = new Uri($"https://genius-song-lyrics1.p.rapidapi.com/chart/albums/?time_period={timePeriod}&per_page=10&page=1"),
                        Headers = {
                            { "x-rapidapi-key", "192d2262e6mshf6b3b0127645b23p19689djsn647e99dc1e6c" },
                            { "x-rapidapi-host", "genius-song-lyrics1.p.rapidapi.com" }
                        }
                    };
                    return client.SendAsync(request);
                });
                if (jsonAlbums != null)
                {
                    var result = JsonSerializer.Deserialize<RootAlbum>(jsonAlbums, options);
                    trendingAlbums = result?.chart_items ?? new List<ChartItemAlbum>();
                }
            }
            catch { }

            ViewBag.Username = username;
            return View(new MusicViewModel
            {
                Trending = trending,
                TrendingArtists = trendingArtists,
                TrendingAlbums = trendingAlbums
            });
        }



        [HttpGet]
        public IActionResult Recomendaciones()
        {
            return View();
        }

        public IActionResult Playlist()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                // Usuario no autenticado, redirigir a login o mostrar error
                return RedirectToAction("Login");
            }

            // Traer sólo los playlists del usuario con ese Id
            var playlists = _context.Playlists
                                    .Where(p => p.UserId == userId.Value)
                                    .ToList();

            return View(playlists);
        }



        [HttpGet]
        public IActionResult Lyrics()
        {
            var username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        [HttpGet]
        public IActionResult TopTracksArtista()
        {
            var username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> TopTracksArtista(string nombreArtista)
        {
            var username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Login", "Account");
            }

            if (string.IsNullOrWhiteSpace(nombreArtista))
            {
                TempData["Error"] = "Debes introducir el nombre de un artista.";
                return View();
            }

            var client = _httpClientFactory.CreateClient();

            // API Keys disponibles
            var spotifyDataKeys = new List<string>
            {
                "c2790e14a8msh6dcd708484e07fdp127ddejsn0d093079485c",
                "9afd7e374amsh00a9dfff402b214p10749djsn93d3676d4b5e",
                "ad0fbde44fmshd54e28ad35d243ap15a66djsn48194130d1a6",
                "40de99330fmshb0f43bc4a60568dp1e2a13jsn0d04e07e9e57",
                "f50cea3032msh4935bfd9af5d90ap10772ajsn71ad1a132980"
            };

            var spotifyDownloaderKeys = new List<string>
            {
                "f8ae66a71cmsh49ce049de8abc19p1d3bfbjsn14952a7179cd",
                "f85b2031a8msh46e01e2150cd46cp186027jsne553139a06ed",
                "fa19469f67msh3d6b4ca2cfee502p1e1f44jsn02da718c5a45",
                "32528e58camsh619cff676f16cdfp16445ejsn4e8640400af3",
                "1027cc1a88msh5bf573078f0992bp1a1587jsnf578b096ec38"
            };

            var random = new Random();
            var spotifyDataKey = spotifyDataKeys[random.Next(spotifyDataKeys.Count)];
            var spotifyDownloaderKey = spotifyDownloaderKeys[random.Next(spotifyDownloaderKeys.Count)];

            try
            {
                // 1. Buscar artista y obtener su ID
                var searchUri = $"https://spotify-data.p.rapidapi.com/search/?q={Uri.EscapeDataString(nombreArtista)}&type=artists&offset=0&limit=10&numberOfTopResults=5";
                var artistRequest = new HttpRequestMessage(HttpMethod.Get, searchUri);
                artistRequest.Headers.Add("x-rapidapi-key", spotifyDataKey);
                artistRequest.Headers.Add("x-rapidapi-host", "spotify-data.p.rapidapi.com");

                var artistResponse = await client.SendAsync(artistRequest);
                artistResponse.EnsureSuccessStatusCode();
                var artistJson = await artistResponse.Content.ReadAsStringAsync();
                var artistData = JsonSerializer.Deserialize<RootArtistInfo>(artistJson, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                var artistUri = artistData?.artists?.items?.FirstOrDefault()?.data?.uri;
                if (string.IsNullOrEmpty(artistUri))
                {
                    TempData["Error"] = "Artista no encontrado.";
                    return View();
                }

                var artistId = artistUri.Split(':').Last();

                // 2. Obtener top tracks
                var topTracksUri = $"https://spotify-downloader9.p.rapidapi.com/artistTopTracks?id={artistId}&country=US";
                var tracksRequest = new HttpRequestMessage(HttpMethod.Get, topTracksUri);
                tracksRequest.Headers.Add("x-rapidapi-key", spotifyDownloaderKey);
                tracksRequest.Headers.Add("x-rapidapi-host", "spotify-downloader9.p.rapidapi.com");

                var tracksResponse = await client.SendAsync(tracksRequest);
                tracksResponse.EnsureSuccessStatusCode();
                var tracksJson = await tracksResponse.Content.ReadAsStringAsync();
                var topTracks = JsonSerializer.Deserialize<PRJ_FINAL_MP09_MP03.Models.TopTracks.Root>(tracksJson, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return View(topTracks.data.tracks);
            }
            catch (Exception ex)
            {
                TempData["Error"] = $"Ocurrió un error: {ex.Message}";
                return View();
            }
        }

        // public async Task<IActionResult> TopTracksArtista(string nombreArtista)
        // {
        //     var username = HttpContext.Session.GetString("Username");
        //     if (string.IsNullOrEmpty(username))
        //     {
        //         return RedirectToAction("Login", "Account");
        //     }

        //     if (string.IsNullOrWhiteSpace(nombreArtista))
        //     {
        //         TempData["Error"] = "Debes introducir el nombre de un artista.";
        //         return View();
        //     }

        //     var client = _httpClientFactory.CreateClient();
        //     try
        //     {
        //         // 1. Buscar artista y obtener su ID
        //         var searchUri = $"https://spotify-data.p.rapidapi.com/search/?q={Uri.EscapeDataString(nombreArtista)}&type=artists&offset=0&limit=10&numberOfTopResults=5";
        //         var artistRequest = new HttpRequestMessage(HttpMethod.Get, searchUri);
        //         artistRequest.Headers.Add("x-rapidapi-key", "0f241b01a0mshc94f0461604b45cp19f633jsn0f0b8d225e7a");
        //         artistRequest.Headers.Add("x-rapidapi-host", "spotify-data.p.rapidapi.com");

        //         var artistResponse = await client.SendAsync(artistRequest);
        //         artistResponse.EnsureSuccessStatusCode();
        //         var artistJson = await artistResponse.Content.ReadAsStringAsync();
        //         var artistData = JsonSerializer.Deserialize<RootArtistInfo>(artistJson, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        //         var artistUri = artistData?.artists?.items?.FirstOrDefault()?.data?.uri;
        //         if (string.IsNullOrEmpty(artistUri))
        //         {
        //             TempData["Error"] = "Artista no encontrado.";
        //             return View();
        //         }

        //         var artistId = artistUri.Split(':').Last();

        //         // 2. Obtener top tracks
        //         var topTracksUri = $"https://spotify-downloader9.p.rapidapi.com/artistTopTracks?id={artistId}&country=US";
        //         var tracksRequest = new HttpRequestMessage(HttpMethod.Get, topTracksUri);
        //         tracksRequest.Headers.Add("x-rapidapi-key", "96bb08b856mshb13c721600c4091p1ba0e9jsn028e0f356aa6");
        //         tracksRequest.Headers.Add("x-rapidapi-host", "spotify-downloader9.p.rapidapi.com");

        //         var tracksResponse = await client.SendAsync(tracksRequest);
        //         tracksResponse.EnsureSuccessStatusCode();
        //         var tracksJson = await tracksResponse.Content.ReadAsStringAsync();
        //         var topTracks = JsonSerializer.Deserialize<PRJ_FINAL_MP09_MP03.Models.TopTracks.Root>(tracksJson, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        //         return View(topTracks.data.tracks);
        //     }
        //     catch (Exception ex)
        //     {
        //         TempData["Error"] = $"Ocurrió un error: {ex.Message}";
        //         return View();
        //     }
        // }



        [HttpGet]
        public async Task<IActionResult> ArtistDetails(int id)
        {
            var client = _httpClientFactory.CreateClient();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://genius-song-lyrics1.p.rapidapi.com/artist/details/?id={id}"),
                Headers =
                {
                    { "x-rapidapi-key", "f53c3d29e5msh1ad93ef4647fcc3p15f2b0jsndbd33c0c17c6" },
                    { "x-rapidapi-host", "genius-song-lyrics1.p.rapidapi.com" },
                },
            };

            try
            {
                using var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var root = JsonSerializer.Deserialize<ArtistDetaille.Root>(json, options);

                return View("ArtistDetail", root.artist); // Crea una vista `ArtistDetail.cshtml`
            }
            catch (Exception ex)
            {
                return Content($"Error: {ex.Message}");
            }
        }


        [HttpGet]
        public async Task<IActionResult> AlbumDetails(int id)
        {
            var client = _httpClientFactory.CreateClient();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://genius-song-lyrics1.p.rapidapi.com/album/details/?id={id}"),
                Headers =
                {
                    { "x-rapidapi-key", "f53c3d29e5msh1ad93ef4647fcc3p15f2b0jsndbd33c0c17c6" },
                    { "x-rapidapi-host", "genius-song-lyrics1.p.rapidapi.com" },
                },
            };

            try
            {
                using var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var root = JsonSerializer.Deserialize<AlbumsDetaille.Root>(json, options);

                return View("AlbumDetail", root.album); // Asegúrate de crear `AlbumDetail.cshtml`
            }
            catch (Exception ex)
            {
                return Content($"Error: {ex.Message}");
            }
        }


        [HttpGet]
        public async Task<IActionResult> SongDetails(int id)
        {
            var client = _httpClientFactory.CreateClient();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://genius-song-lyrics1.p.rapidapi.com/song/details/?id={id}"),
                Headers =
                {
                    { "x-rapidapi-key", "f53c3d29e5msh1ad93ef4647fcc3p15f2b0jsndbd33c0c17c6" },
                    { "x-rapidapi-host", "genius-song-lyrics1.p.rapidapi.com" },
                },
            };

            try
            {
                using var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var root = JsonSerializer.Deserialize<SongDetaille.Root>(json, options);

                return View("SongDetail", root.song); // Asegúrate de crear `AlbumDetail.cshtml`
            }
            catch (Exception ex)
            {
                return Content($"Error: {ex.Message}");
            }
        }










    }
}
