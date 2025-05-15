using System.ComponentModel.DataAnnotations;

namespace PRJ_FINAL_MP09_MP03.Models
{
    public class ForgetPasswordViewModel
    {
        [Required(ErrorMessage = "El campo de correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo de contraseña es obligatorio.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "El campo de confirmación de contraseña es obligatorio.")]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        // Nuevo campo para el código de verificación
        [Required(ErrorMessage = "El campo de código de verificación es obligatorio.")]
        public string VerificationCode { get; set; }
    }
}
