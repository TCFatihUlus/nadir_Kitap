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
    public partial class TabPageLogin : TabbedPage
    {
        
        public TabPageLogin()
        {
            InitializeComponent();
            List<Settings> settings = new List<Settings>();
            settings.Add(new Settings { Name = "Mesajlarım" });
            settings.Add(new Settings { Name = "Siparişlerim" });
            settings.Add(new Settings { Name = "Sepetim" });
            settings.Add(new Settings { Name = "İzlediklerim" });
            settings.Add(new Settings { Name = "Hesabım" });
            settings.Add(new Settings { Name = "Favorilerim" });
            settings.Add(new Settings { Name = "Çıkış" });
            listView.ItemsSource = settings;
            listView.ItemSelected += Clicked_Settings;
            
            
        }
        async void Clicked_Settings(object sender, SelectedItemChangedEventArgs e)
        {
            var clickedname = ((Settings)listView.SelectedItem).Name;
            if (clickedname == "Çıkış")
            {
                await Navigation.PushModalAsync(new TabPage());
            }
            else if (clickedname == "Sepetim")
            {
                await Navigation.PushModalAsync(new ShoppingCartPage());
            }
            else if (clickedname == "Favorilerim")
            {
                await Navigation.PushModalAsync(new Favorites());
            }
            else if (clickedname == "Mesajlarım")
            {
                await Navigation.PushModalAsync(new MessagesPage());
            }
            else if (clickedname == "İzlediklerim")
            {
                await Navigation.PushModalAsync(new Following());
            }
            else if (clickedname == "Hesabım")
            {
                await Navigation.PushModalAsync(new AccountPage());
            }
            else if (clickedname == "Siparişlerim")
            {
                await Navigation.PushModalAsync(new Orders());
            }

        }
    }
}