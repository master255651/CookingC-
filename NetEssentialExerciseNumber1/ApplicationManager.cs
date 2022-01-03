using System;
using System.Collections.Generic;
using System.Text;

namespace NetEssentialExerciseNumber1
{
    enum TypeBurger
    {
        ChickenBurger,
        VeganBurger,
        PorkBurger
    }

    class ApplicationManager
    {
        public static void OnStart()
        {
            DataManager.DefineIngredients();
            Console.Write("What burger do you want information about?\n1)ChickenBurger\n2)VeganBurger\n3)PorkBurger\nYour choise: ");
            var userChoice = Console.ReadKey();

            int idBurger = Converting.StringToInt(userChoice.KeyChar.ToString());
            idBurger--; //Starts with 0

            switch (userChoice.KeyChar)
            {
                case '1':
                    {
                        ShowInfoAboutBurger(idBurger);
                    }
                    break;
                case '2':
                    {
                        ShowInfoAboutBurger(idBurger);
                    }
                    break;
                case '3':
                    {
                        ShowInfoAboutBurger(idBurger);
                    }
                    break;
            }
                   
        }

        private static void ShowInfoAboutBurger(int typeBurger)
        {
            List<Ingredient> ingredientsForSelectedBurger = DataManager.GetIngredients((TypeBurger)typeBurger);
            Burger newBurger = new Burger(DataManager.NameOfBurgers[typeBurger], ingredientsForSelectedBurger);
            newBurger.PrintInfoBurger();
        }

    }
}
