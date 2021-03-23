using System;

namespace csharp_menu_selection
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSelectionWithSwitchStatement();
            MenuSelectionWithSwitchExpression();
        }

        private static void MenuSelectionWithSwitchStatement()
        {
            Console.WriteLine("Your menu options using switch statement are: ");
            Console.WriteLine("1. Chicken burger");
            Console.WriteLine("2. Hamburger");
            Console.WriteLine("3. Fish and chips");
            Console.WriteLine("4. Potato Salad");
            Console.WriteLine("Please make your selection: ");

            // no try parse or error handling yet, that is to come in later lessons
            int selection = Convert.ToInt32(Console.ReadLine());

            string selectedOption;

            switch (selection)
            {
                case 1:
                    selectedOption = "Chicken burger";
                    break;
                case 2:
                    selectedOption = "Hamburger";
                    break;
                case 3:
                    selectedOption = "Fish and chips";
                    break;
                case 4:
                    selectedOption = "Potato salad";
                    break;

                default:
                    selectedOption = "an invalid option";
                    break;
            }

            Console.WriteLine($"You selected '{selectedOption}' - have a great day");
        }
        
        private static void MenuSelectionWithSwitchExpression()
        {
            Console.WriteLine("Your menu options using switch expression are: ");
            Console.WriteLine("1. Chicken burger");
            Console.WriteLine("2. Hamburger");
            Console.WriteLine("3. Fish and chips");
            Console.WriteLine("4. Potato Salad");
            Console.WriteLine("Please make your selection: ");

            // no try parse or error handling yet, that is to come in later lessons
            int selection = Convert.ToInt32(Console.ReadLine());

            string selectedOption = selection switch
            {
                1 => "Chicken burger",
                2 => "Hamburger",
                3 => "Fish and chips",
                4 => "Potato salad",
                _ => "an invalid option"
            };

            Console.WriteLine($"You selected '{selectedOption}' - have a great day");
            Console.WriteLine();
        }
    }
}
