using SixtwareApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SixtwareApp.Clases
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            
        }

        private void entrar_Clicked(object sender, EventArgs e)
        {
            verificar();
        }

        public async void iniciar()
        {
            //string mtr = "alessandro.uanl@gmail.com";
            string a = Convert.ToString(name.Text);
            string b = Convert.ToString(pass.Text);
            string c = tipo.SelectedItem.ToString();
            try
            {
                UserManager manager = new UserManager();
                var result = await manager.userlogin(name.Text.ToString(), pass.Text.ToString(), c);

                if (result.Count() > 0)
                {
                    aa.ItemsSource = result;
                  
                    //Inicio de sesión
                    await Navigation.PushAsync(new Tipo(a,b,c));
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

        public async void verificar()
        {
            if (String.IsNullOrWhiteSpace(name.Text))
            {
                await DisplayAlert("Error", "Campo nombre requerido", "Aceptar");
            }
            else
            {
                if (String.IsNullOrWhiteSpace(pass.Text))
                {
                    await DisplayAlert("Error", "Campo contraseñan requerido", "Aceptar");
                }
                else
                {
                    if (tipo.SelectedIndex == -1)
                    {
                        await DisplayAlert("Error", "Campo modo requerido", "Aceptar");
                    }
                    else
                    {
                        iniciar();
                    }
                }
            }
        }
    }
}