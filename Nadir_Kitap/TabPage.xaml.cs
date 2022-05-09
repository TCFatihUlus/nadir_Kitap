
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public class ImageInformation
        {
            public ImageSource _Image { get; set; }
        }
        private ObservableCollection<ImageInformation> imageCollection;
        private ObservableCollection<ImageInformation> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value;
            OnPropertyChanged();
            }

        }
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

        public TabPage()
        {
            
            InitializeComponent();
            BindingContext = this;
            ImageCollection = new ObservableCollection<ImageInformation>
            {
                new ImageInformation{_Image="s91.jpg"},
                new ImageInformation{_Image="s92.jpg"},
                new ImageInformation{_Image="s93.jpg"},
                new ImageInformation{_Image="s94.jpg"},
                new ImageInformation{_Image="s95.jpg"},
                new ImageInformation{_Image="s96.jpg"},
                new ImageInformation{_Image="s97.jpg"},
                new ImageInformation{_Image="s98.jpg"},
            };

            

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

       
    }
   
}
