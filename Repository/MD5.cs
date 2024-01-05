using XSystem.Security.Cryptography;

namespace API.CSDL.BaoChi.Repository
{
    public static class MD5
    {
        public static string toMD5(this string input)
        {
            string str_md5 = "";
            try
            {
                byte[] mang = System.Text.Encoding.UTF8.GetBytes(input);

                MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
                mang = my_md5.ComputeHash(mang);

                foreach (byte b in mang)
                {
                    str_md5 += b.ToString("x2");//Nếu là "X2" thì kết quả sẽ tự chuyển sang ký tự in Hoa
                }
            }
            catch
            {
                str_md5 = "";
            }

            return str_md5;
        }
    }
}