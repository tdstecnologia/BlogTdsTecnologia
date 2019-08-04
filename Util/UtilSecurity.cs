using System.Security.Cryptography;
using System.Text;

namespace BlogTdsTecnologia.Util
{
    public class UtilSecurity
    {

        public static string ConvertMD5(string texto)
        {
            byte[] data = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(texto));
            StringBuilder sb = new StringBuilder();
            foreach (byte b in data) {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
