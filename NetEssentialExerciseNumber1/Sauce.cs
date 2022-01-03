using System;
using System.Collections.Generic;
using System.Text;

namespace NetEssentialExerciseNumber1
{
    enum SauceType
    {
        ketchup,
        mayonnaise
    }

    class Sauce : Ingredient
    {
        public SauceType Type { get; set; }

        public Sauce(string nameOfIngredient, bool isVeganIngredient, double price, SauceType type)
            : base(nameOfIngredient, isVeganIngredient, price)
        {
            this.Type = type;
        }
    }
}
