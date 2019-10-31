using System;
using System.Collections.Generic;
using System.Text;


namespace SMS.BusinessLogic
{
    public class Sandwich
    {
        public string NameEnglish { get; set; }
        public string NameFrench { get; set; }
        public string NameDutch { get; set; }

        public Fournisseur Fournisseur { get; set; }
        public List<Ingredient> Ingredient { get; set; }//List

        public string GetIngredientList(Language lang)
        {
            List<string> ingredientArrays = new List<string>();

            foreach (var item in Ingredient)
            {
                //var ingredient = GetIngredientName(item, lang);
                var ingredient =  GetIngredientName(item, lang);
                ingredientArrays.Add(ingredient);
            }

            return string.Join(", ", ingredientArrays);
        }
        
        public string GetIngredientName(Ingredient item, Language lang)
        {
            var name = lang == Language.English ? item.NameEnglish : (lang == Language.French ? item.NameFrench : item.NameDutch);
            return name + (item.Allergene ? "*" : "");
        }
    }
}
