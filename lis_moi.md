models: Classe c#  //cr�ation classe

.Code de base  dans les Classe :
using System;
using System.Collections.Generic;
using System.Text;

namespace appli22112021.Models
{
    class Humain
    {
        #region Attribut
public static List<ClasseCourante> CollClasse = new List<ClasseCourante>();

        #endregion

        #region Constructeurs
public classeCourante()
        {
            ClasseCourante.CollClasse.Add(this);
        }
        #endregion

        #region Getters/Setters
		
        #endregion

        #region Methodes
        #endregion

    }
}


vueModels: Rencense les m�thodes de binding ( exemple : bouton retour, page login) // cr�ation classe

Vue xaml: c'est ce qui est beau //cr�ation page de contenu

Vue xaml.cs: le code qui va avec ( clicked,etc), attention lien avec la vue modele correspondante
	pagevuemodele VueModele; // variable a utilis� pour utilis� des m�thode du la vuemodele dans la vue
	//dans le constructeur
	bindingcontext = VueModele = new pagevuemodele();