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

namespace ElementosDinamicos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush PincelPersonalizado; // Nueva instancia de esta clase para generar colores aleatorios para los cuadros.
        Random aleatorio = new Random(); // Variable aleatoria.

        public MainWindow()
        {
            InitializeComponent();
        }

        private void agregarYEliminarElementos(object sender, MouseButtonEventArgs e)
        {
            // EN INSTANTES...
        }
    }
}
