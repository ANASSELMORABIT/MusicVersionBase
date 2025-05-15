using Microsoft.AspNetCore.Identity;

namespace PRJ_FINAL_MP09_MP03.Helpers
{
    public static class PasswordHelper
    {
        private static PasswordHasher<object> _hasher = new PasswordHasher<object>();

        public static string HashPassword(string password)
        {
            return _hasher.HashPassword(null, password);
        }

        public static bool VerifyPassword(string hashedPassword, string providedPassword)
        {
            var result = _hasher.VerifyHashedPassword(null, hashedPassword, providedPassword);
            return result == PasswordVerificationResult.Success;
        }
    }
}
