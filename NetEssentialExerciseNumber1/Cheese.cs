using System;
using System.Collections.Generic;
using System.Text;

namespace NetEssentialExerciseNumber1
{
    class Cheese : Ingredient
    {
        public Cheese(string nameOfIngredient, bool isVeganIngredient, double price)
            : base(nameOfIngredient, isVeganIngredient, price)
        {

        }
    }
}
