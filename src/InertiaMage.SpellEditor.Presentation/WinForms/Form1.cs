using System.Windows.Forms;
using InertiaMage.SpellEditor.Core;

namespace InertiaMage.SpellEditor.Presentation.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string person = "Tom";
            string greeting1 = Greeter.Greet(person);
            label1.Text = greeting1;
        }
    }
}
