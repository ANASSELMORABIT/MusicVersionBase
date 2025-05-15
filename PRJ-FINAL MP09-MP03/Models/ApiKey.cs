using System.ComponentModel.DataAnnotations;

namespace PRJ_FINAL_MP09_MP03.Models
{
    public class ApiKey
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Funcion { get; set; }  // Describe el uso del API Key

        [Required]
        public bool EsValida { get; set; }  // True = válida, False = inválida

        [Required]
        public string ApiKeyValue { get; set; }  // Valor del API Key
    }
}
