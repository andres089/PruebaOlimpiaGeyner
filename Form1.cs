//PRUEBA OLIMPIA
//La función de la aplicación actual es calcular el saldo final de las cuentas de un "banco", para esto se consume un servicio que devuelve 
//las transacciones realizas a la cuentas.

//Paso 1: Hacer funcionar la aplicación. Debido al aumento de transacciones y al  colocar al servicio con SSL la aplicación actual esta fallando.
//Paso 2: Estructurar mejor el codigo. Uso de patrones, buenas practicas, etc.
//Paso 3: Optimizar el codigo, como se menciono en el paso 1 el aumento de transacciones ha causado que el calculo de los saldos se demore demasiado.
//Paso 4: Adicionar una barra de progreso al formulario. Actualizar la barra con el progreso del proceso, evitando bloqueos del GUI.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsLiderEntrega.Clases;

namespace WindowsLiderEntrega
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {            

            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();

            ServicioPrueba.ServiceClient client = new ServicioPrueba.ServiceClient();
            ConsumoServicio consumoServicio = new ConsumoServicio(client);
            
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            //ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback((snder, cert, chain, error) => true);
            //var respuesta = client.GetData(Constantes.Usuario, Constantes.Password);


            ServicioPrueba.Transaccion[] respuesta = consumoServicio.ObtenerTransacciones();

            //Variable donse se almacenan los saldos finales
            List<ServicioPrueba.Saldo> saldos = new List<ServicioPrueba.Saldo>();
            pgb_Progreso.Minimum = 0;
            pgb_Progreso.Maximum = respuesta.Count();
            lbl_TotalAplicaciones.Text = respuesta.Count().ToString();
            int intContador = 0;

            foreach (ServicioPrueba.Transaccion transaccion in respuesta)
            {
                intContador += 1;
                Application.DoEvents();
                pgb_Progreso.Value = intContador;
                lbl_Contador.Text = intContador.ToString();

                long cuentaActual = transaccion.CuentaOrigen;
                string claveCifrado = consumoServicio.ObtenerClaveCifradoCuenta(cuentaActual);
                string movimientoActual = Utilidades.Desencripta(claveCifrado, transaccion.TipoTransaccion);

                double saldoActual = -1;

                //Obtenemos el saldo actual de la cuenta
                foreach (var saldo  in saldos.Where(x => x.CuentaOrigen == cuentaActual))
                {                    
                    saldoActual = saldo.SaldoCuenta;

                    double comision = Utilidades.CalcularComision(Convert.ToInt64(transaccion.ValorTransaccion));

                    if (movimientoActual == Constantes.MovimientoDebito)
                    {
                        saldo.SaldoCuenta -= transaccion.ValorTransaccion;
                    }
                    else
                    {
                        saldo.SaldoCuenta += transaccion.ValorTransaccion - comision;
                    }                    
                }

                //Si no encuentra lo inserta
                if(saldoActual == -1)
                {
                    ServicioPrueba.Saldo saldo = new ServicioPrueba.Saldo();


                    double comision = Utilidades.CalcularComision(Convert.ToInt64(transaccion.ValorTransaccion));

                    saldo.CuentaOrigen = cuentaActual;                   
                    if (movimientoActual == Constantes.MovimientoDebito)
                    {
                        saldo.SaldoCuenta -= transaccion.ValorTransaccion;
                    }
                    else
                    {
                        saldo.SaldoCuenta += transaccion.ValorTransaccion - comision; 
                    }

                    saldos.Add(saldo);
                } 
            }


            sw.Stop();
            lblTiempoTotal.Text = sw.ElapsedMilliseconds.ToString();

            //Enviamos los saldos finales
            consumoServicio.Guardar(saldos);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
