
using System.Windows;
using System.Windows.Input;

namespace DesktoPet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

    private void Window_MouseLeftButtonDown (object sender,MouseButtonEventArgs e) //Metodo para con el mause mover la figura
        {
            DragMove();
        }
    }
}