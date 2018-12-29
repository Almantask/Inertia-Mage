using System.Windows;
using InertiaMage.SpellEditor.Core;

namespace InertiaMage.SpellEditor.Presentation.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string person = "Tom";
            string greeting1 = Greeter.Greet(person);
        }
    }
}
