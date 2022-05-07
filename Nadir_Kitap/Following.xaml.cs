using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nadir_Kitap
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Following : ContentPage
    {
        public Following()
        {
            InitializeComponent();
        }
        private async void Back2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TabPageLogin());
        }
    }
}