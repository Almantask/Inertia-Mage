using InertiaMage.SpellEditor.Core;
#pragma warning disable 219

namespace InertiaMage.SpellEditor.Presentation.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Whole numbers
            int lesson = 1;
            // Floating point numbers
            float height = (float)1.5500000000011111111111222222201;
            double height2 = 1.55;
            // Highest precision numbers.
            // Always for money, scientific calculations
            decimal balance = 600005000.000001101011654978m;
            // Text
            string person = "Tom";
            // Conditions: true or false
            bool isFirstLesson = true;

            

            string greeting1 = Greeter.Greet(person);
            Greeter.Print(person);
            System.Console.ReadLine();

            string prntspellatt = SpellAttributes.Magesfire();
            SpellAttributes.Print(prntspellatt);
            System.Console.ReadLine();
        }
    }
}
