using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixtwareApp.Clases;
using Syncfusion.SfNumericUpDown.XForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace SixtwareApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Corporativo : ContentPage
    {
        public Corporativo()
        {
            InitializeComponent();
        }

        public async void agcorporativo()
        {
            string j = jabon.Value.ToString();
            string p = platos.Value.ToString();
            string v = vasos.Value.ToString();
            string c = cucharas.Value.ToString();
            string s = servilletas.Value.ToString();
            string b = bolsas.Value.ToString();
            string ca = cajahamburguesa.Value.ToString();
            string ve = verduras.Value.ToString();
            string pa = pan.Value.ToString();
            string car = carne.Value.ToString();
            string ade = aderezos.Value.ToString();

            try
            {
                UserManager manager = new UserManager();
                manager.corporativo(j,p,v,c,s,b,ca,ve,pa,car,ade);
                await DisplayAlert("Exito", "Inventario actualizado", "Aceptar");
                jabon.Value = 0;
                platos.Value = 0;
                vasos.Value = 0;
                cucharas.Value = 0;
                servilletas.Value = 0;
                bolsas.Value = 0;
                cajahamburguesa.Value = 0;
                verduras.Value = 0;
                pan.Value = 0;
                carne.Value = 0;
                aderezos.Value = 0;
            }
            catch(Exception e)
            {
                await DisplayAlert("Error", e.Message, "Aceptar");
            }
        }

        private void ag_Clicked(object sender, EventArgs e)
        {
            agcorporativo();
        }

        private void escanear_Clicked(object sender, EventArgs e)
        {
            escaner();
        }

        public async void escaner()
        {
            var scannerPage = new ZXingScannerPage();

            scannerPage.Title = "Escaneando...";
            scannerPage.OnScanResult += (result) =>
            {
                scannerPage.IsScanning = true;
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                    escaneo(result.Text.ToString());
                });
            };
            await Navigation.PushAsync(scannerPage);
        }

        public void escaneo(string recibido)
        {
            switch (recibido)
            {
                //Jabon
                case "5jabon":
                    int a = Convert.ToInt32(jabon.Value);
                    jabon.Value = a + 5;
                    break;

                case "10jabon":
                    int a1 = Convert.ToInt32(jabon.Value);
                    jabon.Value = a1 + 10;
                    break;

                case "15jabon":
                    int a2 = Convert.ToInt32(jabon.Value);
                    jabon.Value = a2 + 15;
                    break;

                //Platos
                case "5platos":
                    int b = Convert.ToInt32(platos.Value);
                    platos.Value = b + 5;
                    break;

                case "10platos":
                    int b1 = Convert.ToInt32(platos.Value);
                    platos.Value = b1 + 10;
                    break;

                case "15platos":
                    int b2 = Convert.ToInt32(platos.Value);
                    platos.Value = b2 + 15;
                    break;

                //Vasos
                case "5vasos":
                    int c = Convert.ToInt32(vasos.Value);
                    vasos.Value = c + 5;
                    break;

                case "10vasos":
                    int c1 = Convert.ToInt32(vasos.Value);
                    vasos.Value = c1 + 10;
                    break;

                case "15vasos":
                    int c2 = Convert.ToInt32(vasos.Value);
                    vasos.Value = c2 + 15;
                    break;

                //Cucharas
                case "5cucharas":
                    int d = Convert.ToInt32(cucharas.Value);
                    cucharas.Value = d + 5;
                    break;

                case "10cucharas":
                    int d1 = Convert.ToInt32(cucharas.Value);
                    cucharas.Value = d1 + 10;
                    break;

                case "15cucharas":
                    int d2 = Convert.ToInt32(cucharas.Value);
                    cucharas.Value = d2 + 15;
                    break;

                //Bolsas
                case "5bolsas":
                    int e = Convert.ToInt32(bolsas.Value);
                    bolsas.Value = e + 5;
                    break;

                case "10bolsas":
                    int e1 = Convert.ToInt32(bolsas.Value);
                    bolsas.Value = e1 + 10;
                    break;

                case "15bolsas":
                    int e2 = Convert.ToInt32(bolsas.Value);
                    bolsas.Value = e2 + 15;
                    break;

                //Caja_hamburguesa
                case "5hamburguesas":
                    int f = Convert.ToInt32(cajahamburguesa.Value);
                    cajahamburguesa.Value = f + 5;
                    break;

                case "10hamburguesas":
                    int f1 = Convert.ToInt32(cajahamburguesa.Value);
                    cajahamburguesa.Value = f1 + 10;
                    break;

                case "15hamburguesas":
                    int f2 = Convert.ToInt32(cajahamburguesa.Value);
                    cajahamburguesa.Value = f2 + 15;
                    break;

                //Verduras
                case "5verduras":
                    int g = Convert.ToInt32(verduras.Value);
                    verduras.Value = g + 5;
                    break;

                case "10verduras":
                    int g1 = Convert.ToInt32(verduras.Value);
                    verduras.Value = g1 + 10;
                    break;

                case "15verduras":
                    int g2 = Convert.ToInt32(verduras.Value);
                    verduras.Value = g2 + 15;
                    break;

                //Pan
                case "5pan":
                    int h = Convert.ToInt32(pan.Value);
                    pan.Value = h + 5;
                    break;

                case "10pan":
                    int h1 = Convert.ToInt32(pan.Value);
                    pan.Value = h1 + 10;
                    break;

                case "15pan":
                    int h2 = Convert.ToInt32(pan.Value);
                    pan.Value = h2 + 15;
                    break;

                //Carne
                case "5carne":
                    int i = Convert.ToInt32(carne.Value);
                    carne.Value = i + 5;
                    break;

                case "10carne":
                    int i1 = Convert.ToInt32(carne.Value);
                    carne.Value = i1 + 10;
                    break;

                case "15carne":
                    int i2 = Convert.ToInt32(carne.Value);
                    carne.Value = i2 + 15;
                    break;

                //Aderezos
                case "5aderezos":
                    int j = Convert.ToInt32(aderezos.Value);
                    aderezos.Value = j + 5;
                    break;

                case "10aderezos":
                    int j1 = Convert.ToInt32(aderezos.Value);
                    aderezos.Value = j1 + 10;
                    break;

                case "15aderezos":
                    int j2 = Convert.ToInt32(aderezos.Value);
                    aderezos.Value = j2 + 15;
                    break;
            }
        }
    }
}