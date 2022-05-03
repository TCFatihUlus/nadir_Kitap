
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
    }
   
}
