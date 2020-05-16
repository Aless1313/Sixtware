using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SixtwareApp.Clases
{
    public class UserManager
    {
        //Cambiar este link por el generado en Ngrok desde localhost usando xampp
        const String URL = "http://533f9165.ngrok.io/";

        private HttpClient getClient()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Connection", "close");

            return client;
        }

        public async Task<IEnumerable<user>> userlogin(string correo, string password, string tipo)
        {
            HttpClient client = getClient();

            var result = await client.GetAsync(URL + "login.php?Correo=" + correo + "&Contrasena=" + password + "&Tipo="+tipo);

            if (result.IsSuccessStatusCode)
            {
                string content = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<user>>(content);
            }
            else
            {
                return Enumerable.Empty<user>();
            }
        }

        public async void corporativo(string ja, string pl, string vas, string cu, string se, string bo, string ca, string ve, string pa, string car, string ade)
        {
            HttpClient client = getClient();
            var result = await client.GetAsync(URL + "corporativo.php?JABON=" + ja + "&PLATOS=" + pl + "&VASOS=" + vas + "&CUCHARAS=" + cu + "&SERVILLETAS=" + se + "&BOLSAS=" + bo + "&CAJA_HAMBURGUESA=" + ca + "&VERDURAS=" + ve + "&PAN=" + pa + "&CARNE=" + car + "&ADEREZOS=" + ade);
        }

        public async void sucursal(string suc, string ja, string pl, string vas, string cu, string se, string bo, string ca, string ve, string pa, string car, string ade)
        {
            HttpClient client = getClient();
            var result = await client.GetAsync(URL + "sucursal.php?DIRECCION_SUCURSAL="+suc+"&JABON=" + ja + "&PLATOS=" + pl + "&VASOS=" + vas + "&CUCHARAS=" + cu + "&SERVILLETAS=" + se + "&BOLSAS=" + bo + "&CAJA_HAMBURGUESA=" + ca + "&VERDURAS=" + ve + "&PAN=" + pa + "&CARNE=" + car + "&ADEREZOS=" + ade);
        }
    }
}
