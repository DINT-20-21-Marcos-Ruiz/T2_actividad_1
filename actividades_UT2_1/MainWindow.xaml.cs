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

namespace actividades_UT2_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random aleatorio = new Random();
        int numAleatorio = aleatorio.Next(0, 100);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComprobarButton_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(numeroTextBox.Text) > numAleatorio) mensajeResultado.Text = "Te has pasado"; 
            else if (Convert.ToInt32(numeroTextBox.Text) < numAleatorio) mensajeResultado.Text = "Te has quedado corto";
            else mensajeResultado.Text = "¡Acertaste!";
        }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numAleatorio = aleatorio.Next(0,100);
            numeroTextBox.Clear();
            mensajeResultado.Text = "";
            
        }
    }
}
