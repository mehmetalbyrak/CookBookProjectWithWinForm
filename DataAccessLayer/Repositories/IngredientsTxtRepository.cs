using DataAccessLayer.Contracts;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class IngredientsTxtRepository : IIngredientsRepository
    {
        string _filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            "IngredientsStorage.txt");

        public void AddIngredient(Ingredient ingredient)
        {
            int id = Math.Abs(Guid.NewGuid().GetHashCode());

            using (StreamWriter streamWriter = File.AppendText(_filePath))
            {
                streamWriter.WriteLine($"{id} | {ingredient.Name} | {ingredient.Weight} |" +
                    $"{ingredient.KcalPer100g} | {ingredient.PricePer100g} | {ingredient.Type}");

            }
        }

        public List<Ingredient> GetIngredients()
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            using (StreamReader streamReader = File.OpenText(_filePath))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    string[] values = line.Split('|');

                    Ingredient ingredient = new Ingredient();
                    ingredient.Id = int.Parse(values[0]);
                    ingredient.Name = values[1];
                    ingredient.Weight = decimal.Parse(values[2]);
                    ingredient.KcalPer100g = decimal.Parse(values[3]);
                    ingredient.PricePer100g = decimal.Parse(values[4]);
                    ingredient.Type = values[5];

                    ingredients.Add(ingredient);
                }
            }
            return ingredients;
        }
    }
}
