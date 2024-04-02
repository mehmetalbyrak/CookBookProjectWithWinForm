﻿using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contracts
{
    public interface IIngredientsRepository
    {
        public void AddIngredient(Ingredient ingredient);

        public List<Ingredient> GetIngredients();
    }
}
