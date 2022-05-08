using Encheres.Modeles;
using Encheres.Services;
using Encheres.Vues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Encheres.VuesModeles
{
    class RegisterVueModeles : BaseVueModele
    {

        #region Constructeurs

        public RegisterVueModeles(INavigation navigation)
        {
            ButtonRetour = new Command(Retout);
            //new Command(() => Gotoco());
        }


        #endregion

        #region Getters/Setters

        public ICommand ButtonRetour { get; }

        #endregion

        #region Methodes

        public async void Retout()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new AccueilVisiteurPage());
        }

        #endregion
    }
}
