﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Contracts;
using DataAccessLayer.Repositories;
using DomainModel.Models;

namespace CookBook.UI
{
    public partial class IngredientsForm : Form
    {
        private readonly IIngredientsRepository _ingredientsRepository; 
        public IngredientsForm(IIngredientsRepository ingredientsRepository)
        {
            InitializeComponent();
            _ingredientsRepository = ingredientsRepository;
        }

        private void AddToFridgeBtn_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = new Ingredient(NameTxt.Text, TypeTxt.Text, WeightNum.Value,
                KcalPer100gNum.Value, PricePer100gNum.Value);


            
            _ingredientsRepository.AddIngredient(ingredient);

            ClearAllFields();
            RefreshGridData();

        }

        private void ClearAllFields()
        {
            NameTxt.Text = string.Empty;
            TypeTxt.Text = string.Empty;
            WeightNum.Value = 1;
            KcalPer100gNum.Value = 0;
            PricePer100gNum.Value = 0;
        }

        private void IngredientsForm_Load(object sender, EventArgs e)
        {
            RefreshGridData();
            CustomizeGridAppearance();
        }


        private void RefreshGridData()
        {
            IngredientsGrid.DataSource = _ingredientsRepository.GetIngredients();
        }

        private void CustomizeGridAppearance()
        {
            IngredientsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            IngredientsGrid.AutoGenerateColumns = false;

            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[6];
            dataGridViewColumns[0] = new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Id",
                Visible = false
            };

            dataGridViewColumns[1] = new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Name",
                HeaderText = "Name"
            };

            dataGridViewColumns[2] = new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Type",
                HeaderText = "Type"
            };

            dataGridViewColumns[3] = new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Weight",
                HeaderText = "Weight"
            };

            dataGridViewColumns[4] = new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "PricePer100g",
                HeaderText = "Price (100g)"
            };

            dataGridViewColumns[5] = new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "KcalPer100g",
                HeaderText = "Kcal (100g)"
            };

            IngredientsGrid.Columns.Clear();
            IngredientsGrid.Columns.AddRange(dataGridViewColumns);

        }
    }
}



