using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace WindowsLiderEntrega.Clases
{
    class Utilidades
    {

        public static string Desencripta(string ClaveCifrado, string Cadena)
        {
            //Este metodo no se requiere estructurar / optimizar
            byte[] Clave = Encoding.ASCII.GetBytes(ClaveCifrado);
            byte[] IV = Encoding.ASCII.GetBytes("1234567812345678");


            byte[] inputBytes = Convert.FromBase64String(Cadena);
            byte[] resultBytes = new byte[inputBytes.Length];
            string textoLimpio = String.Empty;
            RijndaelManaged cripto = new RijndaelManaged();
            using (MemoryStream ms = new MemoryStream(inputBytes))
            {
                using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateDecryptor(Clave, IV), CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(objCryptoStream, true))
                    {
                        textoLimpio = sr.ReadToEnd();
                    }
                }
            }
            return textoLimpio;
        }

        public static long CalcularComision(long valorTransaccion)
        {
            return valorTransaccion >= 0 ?  2 : -1;            
        }

        public static void RegistrarError(Exception ex, string strMetodo)
        {

            string strRutaLog = Path.Combine(Application.StartupPath, string.Concat("LogError", DateTime.Now.ToString("ddMMyyyy"), ".txt"));
            using (StreamWriter sw = new StreamWriter(strRutaLog, true))
            {
                sw.WriteLine("*************");
                sw.WriteLine(string.Concat("Fecha Hora: ", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")));
                sw.WriteLine(ex.Message);
                sw.WriteLine(strMetodo);
                sw.WriteLine("*************");
            }
        }

    }
}
