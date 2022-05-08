
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nadir_Kitap
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabPage : TabbedPage
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

        public TabPage()
        {
            
            InitializeComponent();

            if (true)
            {
                someImage = "11096.png";
            }
            else
            {
                someImage = "11096.png";
            }
            BindingContext = this;
            
        }
        
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TabPage());  
        }
        private async void Login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TabPageLogin());
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

        public String someImage;
        public String SomeImage
        {
            set
            {
                if (someImage != value)
                {
                    someImage = value;
                }
            }
            get
            {
                return someImage;
            }
        }
    }
   
}
