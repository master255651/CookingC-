using System;
using System.Collections.Generic;
using System.Text;

namespace NetEssentialExerciseNumber1
{
    enum VegetableType
    {
        cabbage,
        tomato,
        cucumber,
        onion
    }

    class Vegetable : Ingredient
    {
        public VegetableType Type { get; set; }

        public Vegetable(string nameOfIngredient, bool isVeganIngredient, double price, VegetableType type)
            : base(nameOfIngredient, isVeganIngredient, price)
        {
            this.Type = type;
        }
    }
}
