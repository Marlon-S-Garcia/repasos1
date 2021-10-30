using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace repasos1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String constrasena = txtContrasena.Text;

            String usuariou = "estudiante2021";
            String contrasenau = "uisrael2021";


            if (usuario != usuariou)
            {
                DisplayAlert("Mensaje de Alerta", "Usuario o Contraseña Incorrecta", "OK");
            }
            if (constrasena != contrasenau)
            {
                DisplayAlert("Mensaje de Alerta", "Usuario o Contraseña Incorrecta", "OK");
            }
            else if (usuario == usuariou && constrasena == contrasenau)
            {
                await Navigation.PushAsync(new Registro(usuario, constrasena));

            }


        }

    }
}
}
 