
using System.Windows;
using System.Windows.Input;

namespace DesktoPet
{
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