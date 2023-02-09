using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace morelli.giovanni._4h.ReadCSV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Utente u = new();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            List<Utente> utenti = new List<Utente>();
            int x = 0;

            try
            {

                StreamReader fin = new StreamReader("Utenti.csv");
                while (!fin.EndOfStream)
                {

                    string str = fin.ReadLine();
                    string[] colonne = str.Split(";");
                    Utente u = new Utente { Nome = colonne[0], Cognome = colonne[1], Email = colonne[2] };
                    utenti.Add(u);
                    x++;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            dgDati.ItemsSource = utenti;
        }

       
       private void dgDati_LoadingRow(object sender, RoutedEventArgs e) 
        { 

        } 


    }
}
