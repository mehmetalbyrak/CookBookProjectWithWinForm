using DataAccessLayer.Contracts;
using DomainModel.Models;
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
    public partial class RecipeTypesFrom : Form
    {
        private readonly IRecipeTypesRepository _recipeTypesRepository;
        public RecipeTypesFrom(IRecipeTypesRepository recipeTypesRepository)
        {
            InitializeComponent();
            _recipeTypesRepository = recipeTypesRepository;
           _recipeTypesRepository.OnError += (message)=> MessageBox.Show(message);
        }

        

        private void RecipeTypesFrom_Load(object sender, EventArgs e)
        {
            RefreshRecipeTypesList();
        }

        private async void RefreshRecipeTypesList()
        {
            RecipeTypesLbx.DataSource = await _recipeTypesRepository.GetRecipeTypes();
            RecipeTypesLbx.DisplayMember = "Name";
        }

        private async void AddRecipeTypeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NewTypeTxt.Text))
            
                return;

            RecipeType recipeType = new RecipeType(NewTypeTxt.Text);

            await _recipeTypesRepository.AddRecipeType(recipeType);
            RefreshRecipeTypesList();
            NewTypeTxt.Text = "";
           
        }
    }
}
