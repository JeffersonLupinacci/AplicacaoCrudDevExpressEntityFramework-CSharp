using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Net.Dominio.Poco
{
    public class CodificaSenha
    {
        public static bool Validar(String NovaSenha, String SenhaArmazenada)
        {
            if (NovaSenha == null || string.IsNullOrEmpty(SenhaArmazenada))
                throw new ArgumentException();
            String[] arr = SenhaArmazenada
                .Split(":".ToCharArray(), 2, StringSplitOptions.RemoveEmptyEntries);
            if (arr.Length == 2)
            {
                String cryptpass = arr[0];
                String salt = arr[1];
                return CreateMd5Hash(NovaSenha + salt).Equals(cryptpass);
            }
            else
            {
                String cryptpass = SenhaArmazenada;
                return CreateMd5Hash(NovaSenha).Equals(cryptpass);
            }
        }

        public static String Codificar(String NovaSenha)
        {
            var rnd = new Random();
            var saltBuf = new StringBuilder();
            const string seedList = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < 32; i++)
            {
                int rndIndex = rnd.Next(62);
                saltBuf.Append(seedList.Substring(rndIndex, 1));
            }

            String salt = saltBuf.ToString();
            return CreateMd5Hash(NovaSenha + salt) + ":" + salt;
        }
        
        private static String CreateMd5Hash(String data)
        {
            byte[] bdata = new byte[data.Length];
            byte[] hash;
            for (int i = 0; i < data.Length; i++)
            {
                bdata[i] = (byte)(data[i] & 0xff);
            }
            try
            {
                System.Security.Cryptography.MD5CryptoServiceProvider md5Provider = new System.Security.Cryptography.MD5CryptoServiceProvider();
                hash = md5Provider.ComputeHash(bdata);
            }
            catch (System.Security.SecurityException e)
            {
                throw new ApplicationException("A security encryption error occured.", e);
            }
            var result = new StringBuilder(32);
            foreach (byte t in hash)
            {
                String x = (t & 0xff).ToString("X").ToLowerInvariant();
                if (x.Length < 2)
                {
                    result.Append("0");
                }
                result.Append(x);
            }
            return result.ToString();
        }
    }
}
