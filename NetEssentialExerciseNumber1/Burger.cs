using System;
using System.Collections.Generic;
using System.Text;

namespace NetEssentialExerciseNumber1
{
    class Burger
    {
        public string NameOfBurger { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public double PriceOfBurger { get; }
        public bool IsVeganBurger { get; }

        public Burger(string nameOfBurger, List<Ingredient> ingredients)
        {
            double priceOfIngredients = 0;
            bool isVeganBurger = true;

            foreach (Ingredient ingredient in ingredients)
            {
                priceOfIngredients += ingredient.Price;

                if (!ingredient.IsVeganIngredient)
                {
                    isVeganBurger = false;
                }                    
            }

            this.NameOfBurger = nameOfBurger;
            this.Ingredients = ingredients;
            this.PriceOfBurger = priceOfIngredients;
            this.IsVeganBurger = isVeganBurger;
        }

        public void PrintInfoBurger()
        {
            StringBuilder stringBuilder = new StringBuilder($"\n\nPosition name = {this.NameOfBurger}\nPrice = {Math.Round(this.PriceOfBurger, 2)}\n");
            stringBuilder.Append(this.IsVeganBurger ? "Is vegetarian\n" : "Is not vegetarian\n");
            stringBuilder.Append("Ingredients:\n");

            int counter = 1;
            foreach (Ingredient ingredient in this.Ingredients)
            {
                stringBuilder.Append($"\t{counter++})");
                stringBuilder.Append(ingredient.ShowInfoIngredient());
            }

            Console.Write(stringBuilder);
        }
    }
}
