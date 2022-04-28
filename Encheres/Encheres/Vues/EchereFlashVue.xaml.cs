using Encheres.Modeles;
using Encheres.VuesModeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Encheres.Vues
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EchereFlashVue : ContentPage
    {
        EncherirVueModele vueModele;
        public EchereFlashVue(Enchere param)
        {
            InitializeComponent();
            BindingContext = vueModele = new EncherirVueModele(param);
        }
    }
}