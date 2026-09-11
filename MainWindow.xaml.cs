
using System.Windows;
using System.Windows.Input;

namespace DesktoPet
{
    public partial class MainWindow : Window

    {
        private double pet_scale = 1;
        public MainWindow() //Constructor
        {
            InitializeComponent();
            Focus(); //Establece el foco en la ventana para que pueda recibir eventos de teclado
        }

        private void Window_MouseLeftButtonDown (object sender,MouseButtonEventArgs e) //Metodo para con el mause mover la figura
        {
            DragMove();
        }

        private void Increase_Size() //Aumenta el tamaño de la mascota
        {
            pet_scale += 0.1;

            if (pet_scale > 2)
                pet_scale = 2;

            DesktopPetScale.ScaleX = pet_scale;
            DesktopPetScale.ScaleY = pet_scale;

        }

        private void Decrease_Size() //Disminuye el tamaño de la mascota
        {
            pet_scale -= 0.1;

            if (pet_scale < 0.5)
            {
                pet_scale = 0.5;
            }

            DesktopPetScale.ScaleX = pet_scale;
            DesktopPetScale.ScaleY = pet_scale;

        }

        private void Window_KeyDown(object sender, KeyEventArgs e) //Metodo para aumentar o disminuir el tamaño de la mascota con el teclado
        {
            if (e.Key == Key.Up)
            {
                Increase_Size();
            }
            else if (e.Key == Key.Down)
            {
                Decrease_Size();
            }
        }

    }
}