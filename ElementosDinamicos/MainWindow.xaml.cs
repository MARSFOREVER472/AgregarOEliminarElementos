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
            // 1.- Este es un evento que verificará si se hizo clic en un rectángulo o dentro del Canvas.
            // 2.- Si hacemos clic en un rectángulo entonces hará lo siguiente:

            if (e.OriginalSource is Rectangle)
            {
                // Si el clic original es un rectángulo entonces se creará un nuevo rectángulo.
                // Se enlaza hacia este rectángulo para enviarlo al evento de cliqueo.

                Rectangle activarRectangulo = (Rectangle)e.OriginalSource;

                MyCanvas.Children.Remove(activarRectangulo); // Busca a este rectángulo y lo elimina en este Canvas.
            }

            // Si se hizo clic dentro del Canvas entonces se hará lo siguiente:

            else
            {
                // Se genera un color aleatorio y lo guarda dentro de la variable "PincelPersonalizado".

                PincelPersonalizado = new SolidColorBrush(Color.FromRgb((byte)aleatorio.Next(1, 255),
                    (byte)aleatorio.Next(1, 255), (byte)aleatorio.Next(1, 233)));

                // 1.- Se crea un rectángulo con sus atributos respectivos.
                // 2.- El ancho y la altura serán de 50 pixeles.
                // 3.- El grosor del borde es de 3 pixeles, mientras que el relleno del cuadrado será coloreado dentro de ella.
                // 4.- El color del borde será negro.

                Rectangle nuevoCuadro = new Rectangle
                {
                    Width = 50,
                    Height = 50,
                    StrokeThickness = 3,
                    Fill = PincelPersonalizado,
                    Stroke = Brushes.Black
                };

                // 1.- Una vez ya creado el rectángulo necesitamos pedir una posición X e Y para el nuevo objeto.
                // 2.- Luego, calcularemos la ubicación del clic del mouse y la agregaremos allí.

                Canvas.SetLeft(nuevoCuadro, Mouse.GetPosition(MyCanvas).X); // Se establece una posición horizontal del rectángulo para el mouse en X.
                Canvas.SetTop(nuevoCuadro, Mouse.GetPosition(MyCanvas).Y); // Se establece una posición vertical del rectángulo para el mouse en Y.

                MyCanvas.Children.Add(nuevoCuadro); // Por último, se añade un nuevo rectángulo dentro del Canvas.
            }
        }
    }
}
