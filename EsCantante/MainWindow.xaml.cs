using System;
using System.Collections.Generic;
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

namespace EsCantante
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Brano> branos;
        CD album;
        public MainWindow()
        {
            InitializeComponent();
            branos = new List<Brano>();
            
        }
        public void Riempi()
        {
            foreach(Brano b in branos)
            {
                list_brani.Items.Add(b);
            }
        }

        private void crea_Click(object sender, RoutedEventArgs e)
        {
            Brano b = new Brano(titolo.Text, autore.Text, float.Parse(durata.Text));
            branos.Add(b);

            titolo.Text = ""; 
            autore.Text = ""; 
            durata.Text = "";
        }

        private void btnAlbum_Click(object sender, RoutedEventArgs e)
        {
            if(branos.Count>=1)
                album = new CD("eskere", "lil pump", branos);
            Riempi();
        }
    }
}
