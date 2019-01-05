using System;
using System.Collections.Generic;

namespace InertiaMage.SpellEditor.Core
{
    public static class Testing
    {   
        public static string Joke()
        {
            return "hahahahahah";
        }

        public static void Conditions2()
        {
            int a = 5;
            if (a  == 4)
            {
                Console.WriteLine("Will not execute");
            }
            else if (a == 5)
            {
                Console.WriteLine("Will execute");
            }
        }

        public static void SwitchTest()
        {
            int value = 0;
            switch (value)
            {
                case 0:
                    // Execute if
                    // value == 0
                    break;
                case 1:
                // Execute if
                // value == 1
                default:
                    // else
                    break;
            }
        }

        public static void DoWhileBreak()
        {
            bool condition = false;
            do
            {
                // Exits loop
                break;
                // Skipped
                SwitchTest();
            } while (condition);
            // Executed
            Conditions2();
        }

        public static void DoWhileReturn()
        {
            bool condition = false;
            do
            {
                // Exits function
                return;
                // Skipped
                SwitchTest();
            } while (condition);
            // Skipped
            Conditions2();
        }

        public static void ForeachTest()
        {
            List<string> viewers = new List<string>() {"ximvu", "cringean"};

            Console.WriteLine("Viewer:");
            foreach (var viewer in viewers)
            {
                Console.WriteLine(viewer);
            }
        }

    }
}
