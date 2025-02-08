using System.Linq;

namespace PasswordStrengthMeter
{
    public class PassWordStrength
    {
        public static int GetPasswordStrength(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return 0;
            }
            int result = 0;
            if (password.Length > 8)
            {
                result = result + 1;
            }
            if (password.Any(char.IsUpper))
            {
                result = result + 1;
            }

            if (password.Any(char.IsLower))
            {
                result = result + 1;
            }
            string specialchars = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specarray = specialchars.ToCharArray();
            foreach (char c in specarray)
            {
                if (password.Contains(c))
                {
                    result = result + 1;
                }
            }
            if (password.Any(char.IsDigit))
            {
                result = result + 1;
            }

            return result;


        }
    }
}
