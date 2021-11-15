using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsLiderEntrega.Clases
{
    class ConsumoServicio
    {
        private readonly ServicioPrueba.ServiceClient _client;

        public ConsumoServicio(ServicioPrueba.ServiceClient client)
        {
            _client = client;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback((snder, cert, chain, error) => true);
        }
        
        public ServicioPrueba.Transaccion[] ObtenerTransacciones()
        {
            try
            {
                return _client.GetData(Constantes.Usuario, Constantes.Password);
            }
            catch (Exception ex)
            {
                Utilidades.RegistrarError(ex, "ConsumoServicio_ObtenerTrancaciones");
                throw;
            }            

        }

        public string ObtenerClaveCifradoCuenta(long cuentaActual)
        {
            try
            {
                return _client.GetClaveCifradoCuenta(Constantes.Usuario, Constantes.Password, cuentaActual);
            }
            catch (Exception ex)
            {
                Utilidades.RegistrarError(ex, "ConsumoServicio_ObtenerClaveCifradoCuenta");
                throw;
            }

        }

        public void Guardar(List<ServicioPrueba.Saldo> saldos)
        {
            try
            {
                _client.SaveData(Constantes.Usuario, Constantes.Password, saldos.ToArray());
                
            }
            catch (Exception ex)
            {
                Utilidades.RegistrarError(ex, "ConsumoServicio_Guardar");
                throw;
            }


        }



        

    }
}
