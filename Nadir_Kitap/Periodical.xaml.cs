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
    public partial class Periodical : ContentPage
    {
        public Periodical()
        {
            InitializeComponent();
        }
        private async void Book_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Book());
        }

        private async void Periodical_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Periodical());
        }

        private async void ArtCollection_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ArtCollection());
        }

        private async void ProductCode_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ProductCode());
        }
    }
}