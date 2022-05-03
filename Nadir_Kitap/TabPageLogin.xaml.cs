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
            this.BindingContext = new[] { "Mesajlarım", "Siparişlerim", "Sepetim", "İzlediklerim", "Hesabım", "Favorilerim", "Çıkış" };
        }
    }
}