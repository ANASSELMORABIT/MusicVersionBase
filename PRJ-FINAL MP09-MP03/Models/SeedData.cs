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
    }
}
