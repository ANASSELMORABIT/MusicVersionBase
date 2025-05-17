using PRJ_FINAL_MP09_MP03.Models;
using Microsoft.EntityFrameworkCore;

namespace PRJ_FINAL_MP09_MP03.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider, TodoContext context)
        {
            // Verifica si la base de datos ya tiene datos
            if (context.ApiKeys.Any())
            {
                return;   // La base de datos ya tiene datos, no inserta nada
            }

            var apiKeys = new ApiKey[]
            {
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "4c5f61db64msh7f600f564ecb10fp19376bjsnba6d2cf62270"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "62be4e5f99msh607dbdc4ce45189p16ccf1jsnab0b5ef3aa43"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "51a303b628msh98b29edaf868e26p13cbc9jsn86fea8418ec4"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "083e73d7f1mshb9875a3ce952a51p1328cajsnfaf21b8be772"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "b1a97b7985msh9b1352e487120d5p1af67fjsn4e2b5a7c0620"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "89afd017famsh9d4103a2ab633aep18b214jsnff99ff585db1"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "e046888263msh82c3e4541a87e6ap15a14ajsn680b62f00464"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "eae3e0039fmshd491fc906fef37fp160630jsn32dde67a28fe"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "ccc0b8c37emsh6aff95bdf01d895p19c7bajsncc542b1fe00b"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "d77674738amsh264d40f255ccb9ep13ff6djsndcef3b0c48d9"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "b9664a9432mshc27f6a2758d392dp10f872jsn821e0f6bfaa3"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "3bef8ac175msh71645f0449bf057p1bcf92jsn54089ed01768"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "9f7a58057bmshf2d2870887b6234p1246d1jsncb1e388dc3be"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "bb886dc81cmsh552c95bc608c1a8p191182jsn5782ca1bae37"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "67f708c0dbmsh1d9262409bdb23fp1416fdjsn8690712ce39a"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "78cd074000mshe48fd8f89130c17p166183jsn52dd86c02528"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "f16eca3356mshbc481617c1987f3p1fdd3ejsn3a604da8b3a6"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "425524b776msh1e37fd1a7960543p116d96jsnb8857940d9ff"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "b09fbd3af9msh7e028a9a65aab91p129461jsn4f18a214cf86"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "b580d7cae0msh96af503f2ca4569p191799jsne3d4c1225e62"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "87bc26c082msh47c6b039c2102aap1fa447jsncb394a816e7f"
                },
                new ApiKey
                {
                    Funcion = "Trending",
                    EsValida = true,
                    ApiKeyValue = "94a52d823emshb61248ce258f006p18712djsn948392046631"
                }
            };

            context.ApiKeys.AddRange(apiKeys);
            context.SaveChanges();
        }


        public static void InsertLyricsKeys(IServiceProvider serviceProvider, TodoContext context)
        {
            if (context.ApiKeys.Any())
            {
                return;   // La base de datos ya tiene datos, no inserta nada
            }
            var lyricsKeys = new List<string>
            {
                "80f9461861mshc0e582b1dce56c7p17a9eajsn2e510d81e363",
                "a2891d6444mshf051420047419b7p134cf0jsn4da4efb44af8",
                "e337bdc97amsh96aa026340eb6c1p1b74ffjsna328a0f57664",
                "e6b3325a7amsh57f1d3a942fa6bcp1f0bb3jsnc16c8f8e55ad",
                "f467220ce9mshb87f4affe0fe75bp1d92d3jsnef8a059801eb",
                "accd065368msh44d9e1f58da3ac3p17cbcbjsn7ed51cc65cf5",
                "48a9c81c4dmsh7435c81d3b1920ep146a5ajsn9569988c8e30",
                "1763bd5976msh4ad294cb1e2f587p127454jsn3472d75f51d4",
                "72f831b276msh3ee9e228b95ea01p1a3806jsn31794d029dd3",
                "3df3367ademshb68e9e12217693ep11a616jsn2df850ca8efd",
                "2975ff274bmshf0826a5b1ceef3cp104080jsn007b63bbf7f0",
                "13315001f0msha48fd7135e48136p1c577cjsn506389eae63d",
                "0dec62608amshb6ee4084c66f28fp1b2e10jsn39c2560b7ffd",
                "13a133ec69msh7fbd77349184af0p1039c4jsne33a1ed775a3",
                "a5e561ef21msh0cf0c061b088bedp1f2985jsn7660201d8e24",
                "58b3fd3b1emshc5f8f60360b4df1p18a51cjsn5ccdc9955863",
                "fa3762a3cbmshbb63e47b4100eb6p1f7e3cjsn7fc71bde127a",
                "812c7ba73amsh19ad22d322219d3p149bccjsn4f3e9e3dd722",
                "7a6fd4e639msh872c557c7765546p102b83jsnd8af2ac6c197",
                "2d736bac49msh78466f9f6b34473p1a1152jsnfb098f83d9ef"
            };

            foreach (var key in lyricsKeys)
            {
                if (!context.ApiKeys.Any(k => k.ApiKeyValue == key))
                {
                    context.ApiKeys.Add(new ApiKey
                    {
                        Funcion = "Lyrics",
                        EsValida = true,
                        ApiKeyValue = key
                    });
                }
            }

            context.SaveChanges();
        }


        public static void InsertEscucharKeys(IServiceProvider serviceProvider, TodoContext context)
        {
            if (context.ApiKeys.Any())
            {
                return;   // La base de datos ya tiene datos, no inserta nada
            }
            var escucharKeys = new List<string>
            {
                "3985f53dc8msh9c15680f95d2864p1b408ajsnc61d1713b36a",
                "86a7bf4e34mshaf5f880211c2826p15185djsnd747916cda85",
                "d5839bbb1emshe750ab49434039cp1ceeddjsn691b5ec6ee90",
                "6c78710d80mshaab1639b4a2f43bp17a136jsn7506fbaaa118",
                "da5cb8f3admsh95ce57d749cec13p1967c6jsn85ba5ece5eba",
                "f6e6825361msheb1cfd8c3ac6b9cp19fe4ajsn300fd9c474ff",
                "0f084d9bfbmshfe369dc74c8e150p145b04jsn0c7b3b89574a",
                "0a8d08f0eemsh2b231cd38fc4804p119d8fjsn482b439163d1",
                "178fe5bafdmsh4f85734d804947bp17546bjsna676959250ae",
                "172e9bba04msh4e8835e94e71c83p17c541jsnae1dea977ac6",
                "d9141f2b07msh62d6719333fa2f6p163487jsn6e027dbc1436",
                "a648e802f7mshfab664717d5a822p124fb3jsn953b8750acee",
                "8fa7739482msh9a806517ef26c2ep1790d6jsnc0cf125f2ee9",
                "4c245b7f76msh3abf65f10935a86p1bb712jsn6cbce75f9b8a",
                "3a5c4273demsh13db258a9838e8dp13dc5fjsne59b4ab152aa",
                "386c5911fdmsh3538e647a8ca6c5p1d4041jsn0f4db79dbae5",
                "2265c4857emsh66cab1212c65ca5p1f6eeejsn24bc722c142c",
                "cd971d59dbmsh4aebfd1426fd7e4p10c405jsndee9ed130e16",
                "9b49a31b74msh27330860396329bp173f08jsn42c685e3bfe4",
                "f6832d3e7dmsh552f916c64d7be2p1d4e35jsn8986f4fc9242",
                "4a7dbcfbd0mshee5571db02742f2p1e2e27jsn9df0290cd663",
                "23819bd9famshb3b845a5bd90b3fp14ac61jsn3908c31c182c",
                "776be17c33msh3509756a9fb0c7cp1ac74cjsn9befdaa2f1e2",
                "e7c569125amshc79b1169a431e80p1530e3jsn915be63c3afa",
                "b708211c0dmsh54485bbbdfc99c9p1fa74ejsn1c730d45d8c6",
                "3b6165888cmsh5ef9d241fc3b30ep1a6ef8jsn8a0c0a71adac",
                "380413a58bmsh9dfd36b85af74e3p190776jsn3a6151d3425b",
                "4e6ad826aamsh3fe7f2ebf920f4cp15ace9jsn7edd16a0009e",
                "80e3fcb8b3msh5faaaa4501303e0p15bf6cjsn82bb0d20bc4a",
                "fe30ed2a86msh580427eb1643843p138486jsn8449b075e52e",
                "0509c9014fmsh998e84d2df3e3cdp150c9ejsn67f0ca3fa95f",
                "6ebb8cf621msh5963ccaa79ce4d6p1ed0bfjsne49a08752d7b",
                "9435a3b059mshbb9f993efc44a0ap14e9b1jsnf1e115f46ade",
                "a53a0826c0msh6ee0e614738a767p1df215jsn34c6a4f325a0",
                "90a3f20f7fmshbdefaac6480f498p1422ffjsn35772f7a8bc2",
                "2ecd6aa386msh3cc8a3977034efbp112dbfjsn6763bb291e79",
                "79e29fb911mshef0ff5492592e5dp18ba17jsnb2b47d3c0ec7",
                "c8afeec66dmshc46f77d388840c0p1c3742jsnd2ab3a9f69ef",
                "b772056fe4msh7baa4c5118a400cp162cc0jsn5f231edda761",
                "1de95a09e4mshc29cbd9f900af08p1e1ccejsn96981c2adb32",
                "95861a1f65mshcaa98cc7cd70719p153a54jsn0c41702940b9",
                "bad9b6beb3mshe1c5510a0db1250p155f63jsnd0e3f8ae19a5",
                "cba629d11dmsh7319bcdc0af54f6p1c431ajsn4fa353e998a9",
                "86348578cdmsh02f3f297e205ff3p14ae70jsn31c3c3dc421d",
                "a6adacfa49msh7a066f7e91aef59p1a7556jsn9ead181b8d34",
                "d41dab6610msh1d18999974bc920p1f82a6jsn7293e2062e07",
                "1d9e13826dmsh828871cd95f73d7p13a5a7jsnbc8ea252b537",
                "f1dd78fa7dmshcc55560e47dcf51p19b21djsndb76cf5d7ca1"
            };

            foreach (var key in escucharKeys)
            {
                if (!context.ApiKeys.Any(k => k.ApiKeyValue == key))
                {
                    context.ApiKeys.Add(new ApiKey
                    {
                        Funcion = "Escuchar",
                        EsValida = true,
                        ApiKeyValue = key
                    });
                }
            }

            context.SaveChanges();
        }


    }
}
