using System;
using System.Collections.Generic;
using System.Text;

namespace NetEssentialExerciseNumber1
{
    class DataManager
    {
        public static List<string> NameOfBurgers = new List<string>() { "Chicken Burger", "Vegan Burger", "Pork Burger" };
        private static List<Ingredient> _ingredientsForChickenBurger;
        private static List<Ingredient> _ingredientsForVeganBurger;
        private static List<Ingredient> _ingredientsForPorkBurger;

        public static void DefineIngredients()
        {
            ForChickenBurger();
            ForVeganBurger();
            ForPorkBurger();
        }

        private static void ForChickenBurger()
        {
            Bun whiteBun = new Bun("White Bun", true, 25.5, BunType.white);
            Cutlet chickenCutlet = new Cutlet("Chicken Cutlet", false, 78, CutletType.chicken);
            Vegetable cabbage = new Vegetable("Cabbage", true, 32.5, VegetableType.cabbage);
            Vegetable onion = new Vegetable("Onion", true, 12, VegetableType.onion);
            Sauce mayonnaise = new Sauce("Mayonnaise", false, 17.2, SauceType.mayonnaise);

            _ingredientsForChickenBurger = new List<Ingredient>() { whiteBun, chickenCutlet, cabbage, onion, mayonnaise };
        }

        private static void ForVeganBurger()
        {
            Bun brownBun = new Bun("Brown Bun", true, 31.5, BunType.brown);
            Cutlet potatoCutlet = new Cutlet("Potato Cutlet", true, 54.3, CutletType.potato);
            Vegetable onion = new Vegetable("Onion", true, 12, VegetableType.onion);
            Sauce ketchup = new Sauce("Ketchup", true, 17.2, SauceType.ketchup);

            _ingredientsForVeganBurger = new List<Ingredient>() { brownBun, potatoCutlet, onion, ketchup };
        }

        private static void ForPorkBurger()
        {
            Bun brownBun = new Bun("Brown Bun", true, 31.5, BunType.brown);
            Cutlet porkCutlet = new Cutlet("Pork Cutlet", false, 112.7, CutletType.pork);
            Vegetable onion = new Vegetable("Onion", true, 12, VegetableType.onion);
            Sauce ketchup = new Sauce("Ketchup", true, 17.2, SauceType.ketchup);
            Sauce mayonnaise = new Sauce("Mayonnaise", false, 17.2, SauceType.mayonnaise);
            Vegetable cabbage = new Vegetable("Cabbage", true, 32.5, VegetableType.cabbage);
            Cheese cheese = new Cheese("Cheese", false, 56.7);

            _ingredientsForPorkBurger = new List<Ingredient>() { brownBun, porkCutlet, onion, ketchup, mayonnaise, cabbage, cheese };
        }

        public static List<Ingredient> GetIngredients(TypeBurger typeBurger)
        {
            switch (typeBurger)
            {
                case TypeBurger.ChickenBurger:
                    {
                        return _ingredientsForChickenBurger;
                    }
                case TypeBurger.VeganBurger:
                    {
                        return _ingredientsForVeganBurger;
                    }
                case TypeBurger.PorkBurger:
                    {
                        return _ingredientsForPorkBurger;
                    }
            }
            return new List<Ingredient>();
        }
    }
}
