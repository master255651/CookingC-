using System;
using System.Collections.Generic;
using System.Text;

namespace NetEssentialExerciseNumber1
{
    enum CutletType
    {
        beef,
        pork,
        chicken,
        potato
    }

    class Cutlet : Ingredient
    {
        public CutletType Type { get; set; }

        public Cutlet(string nameOfIngredient, bool isVeganIngredient, double price, CutletType type)
            : base(nameOfIngredient, isVeganIngredient, price)
        {
            this.Type = type;
        }
    }
}
