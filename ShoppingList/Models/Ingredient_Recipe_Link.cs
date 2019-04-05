using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ShoppingList.Enums;

namespace ShoppingList.Models
{
    public class Ingredient_Recipe_Link
    {
        [Key]
        public int LinkId { get; set; }
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }

        public Unit Unit { get; set; }

        public int Amount { get; set; }

    }
}