using BeeDone.Models;
using Microsoft.UI.Xaml;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BeeDone
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        ObservableCollection<Tache> Taches  = new ObservableCollection<Tache>();

        public MainWindow()
        {
            InitializeComponent();

            Taches.Add(new Tache("Faire l'épicerie"));
            Taches.Add(new Tache("Réviser WinUI"));

            lvTaches.ItemsSource = Taches;
        }


        private void btnAjouterTache_Click(object sender, RoutedEventArgs e)
        {
            // Créer un objet Tâche à partir du nom de la tâche

            if (!string.IsNullOrEmpty(txtNouvelleTache.Text))
            {

                Tache nouvelleTache = new Tache(txtNouvelleTache.Text);

                // Ajouter à la liste des tâches
                Taches.Add(nouvelleTache);
                txtNouvelleTache.Text = string.Empty;


            } else
            {
                // Afficher un message d'erreur dans dialogue
            }

        }

        //private void btnValider_Click(object sender, RoutedEventArgs e)
        //{
        //    string nom = txtNom.Text;
        //    txtMessage.Text = $"Bonjour {nom}";

        //}



    }
}
