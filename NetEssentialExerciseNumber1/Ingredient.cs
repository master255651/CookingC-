using System;
using System.Collections.Generic;
using System.Text;

namespace NetEssentialExerciseNumber1
{
    abstract class Ingredient
    {
        public string NameOfIngredient { get; set; }
        public bool IsVeganIngredient { get; set; }
        public double Price { get; set; }

        public Ingredient(string nameOfIngredient, bool isVeganIngredient, double price)
        {
            this.NameOfIngredient = nameOfIngredient;
            this.IsVeganIngredient = isVeganIngredient;
            this.Price = price;
        }

        public string ShowInfoIngredient()
        {
            return this.NameOfIngredient + "\n";
        }
    }
}
