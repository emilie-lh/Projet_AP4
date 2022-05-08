models: Classe c#  //création classe

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


vueModels: Rencense les méthodes de binding ( exemple : bouton retour, page login) // création classe

Vue xaml: c'est ce qui est beau //création page de contenu

Vue xaml.cs: le code qui va avec ( clicked,etc), attention lien avec la vue modele correspondante
	pagevuemodele VueModele; // variable a utilisé pour utilisé des méthode du la vuemodele dans la vue
	//dans le constructeur
	bindingcontext = VueModele = new pagevuemodele();