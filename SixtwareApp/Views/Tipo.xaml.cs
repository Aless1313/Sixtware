using SixtwareApp.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SixtwareApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tipo : ContentPage
    {
        public Tipo(string correo, string contra, string tipo)
        {
            InitializeComponent();
            string g = Convert.ToString(correo);
            string f = Convert.ToString(contra);
            string h = Convert.ToString(tipo);
            variabledeprueba.Text = g;
            variabledeprueba2.Text = f;
            variabledeprueba3.Text = h;
            iniciar();
            if (tipo == "Sucursal")
            {
                corp.IsEnabled = false;
                suc.IsEnabled = true;
            }
            else
            {
                if (tipo == "Corporativo")
                {
                    suc.IsEnabled = false;
                    corp.IsEnabled = true;
                }
                else
                {
                    suc.IsEnabled = false;
                    corp.IsEnabled = false;
                }

            }


        }

        private async void suc_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sucursal());
        }

        private async void corp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Corporativo());
        }


        public async void iniciar()
        {
            //string mtr = "alessandro.uanl@gmail.com";
            try
            {
                UserManager manager = new UserManager();
                var result = await manager.userlogin(variabledeprueba.Text.ToString(), variabledeprueba2.Text.ToString(), variabledeprueba3.Text.ToString());

                if (result.Count() > 0)
                {
                    informacion.ItemsSource = result;
                }
                else
                {
                    await DisplayAlert("Error", "Usuario, contraseña o Modo incorrecto", "Aceptar");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Aceptar");
            }
        }
    }
}