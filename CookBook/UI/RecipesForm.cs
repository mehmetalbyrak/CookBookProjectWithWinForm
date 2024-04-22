﻿using DataAccessLayer.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.UI
{
    public partial class RecipesForm : Form
    {
        private readonly IRecipeTypesRepository _recipeTypesRepository;
        private readonly IServiceProvider _serviceProvider;
        public RecipesForm(IRecipeTypesRepository recipeTypesRepository, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _recipeTypesRepository = recipeTypesRepository;
            _serviceProvider = serviceProvider;
        }

        private async void RefreshRecipeTypes()
        {
            RecipeTypesCbx.DataSource = await _recipeTypesRepository.GetRecipeTypes();
            RecipeTypesCbx.DisplayMember = "Name";
        }

        private void RecipesForm_Load(object sender, EventArgs e)
        {
            RefreshRecipeTypes();
        }

        private void AddRecipeTypeBtn_Click(object sender, EventArgs e)
        {
            RecipeTypesFrom form = _serviceProvider.GetRequiredService<RecipeTypesFrom>();
            form.FormClosed += (sender, e) => RefreshRecipeTypes();
            form.ShowDialog();
        }
    }
}
