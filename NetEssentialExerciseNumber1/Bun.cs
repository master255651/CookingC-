using System;
using System.Collections.Generic;
using System.Text;

namespace NetEssentialExerciseNumber1
{
    enum BunType
    {
        white,
        brown
    }

    class Bun : Ingredient
    {
        public BunType Type { get; set; }

        public Bun(string nameOfIngredient, bool isVeganIngredient, double price, BunType type)
            : base(nameOfIngredient, isVeganIngredient, price)
        {
            this.Type = type;
        }
    }
}
