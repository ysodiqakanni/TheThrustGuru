﻿using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheThrustGuru.Database;
using TheThrustGuru.DataModels;
using TheThrustGuru.Logics;
using TheThrustGuru.Repository;
using TheThrustGuru.Utils;

namespace TheThrustGuru
{
    public partial class AddRecipes : Form
    {
        private string name = "Recipe name";
        private string desc = "Description";
        private string price = "Price";
        private string selectFood = "Select food items...";
        private bool isEdit = false;
        private IEnumerable<FoodItemsDataModel.FoodItemModel> data;
        private List<RecipeDataModel.RecipeData.items> recipeFoodItems = new List<RecipeDataModel.RecipeData.items>();
        public List<RecipeDataModel.RecipeData> recipeDataList = new List<RecipeDataModel.RecipeData>();

        public AddRecipes()
        {
            InitializeComponent();

            waterMarkOnTextBoxLeave(this.nameTextBox, name);
            waterMarkOnTextBoxLeave(this.descTextBox, desc);
            waterMarkOnTextBoxLeave(this.priceTextBox, price);
        }

        public AddRecipes(RecipeDataModel.RecipeData recipe)
        {
            InitializeComponent();

            this.nameTextBox.Text = recipe.recipeName;
            this.descTextBox.Text = recipe.recipeDesc;
            this.okButton.Text = "Edit";
            isEdit = true;

        }

        private void waterMarkOnTextBoxLeave(TextBox textbox, string placeHolder)
        {
            if (String.IsNullOrEmpty(textbox.Text) || textbox.Text == placeHolder)
            {
                textbox.ForeColor = Color.Gray;
                textbox.Text = placeHolder;
            }
            else
            {
                textbox.ForeColor = Color.Black;
            }
        }
        private void waterMarkOnTextBoxEnter(TextBox textbox, String placeholder)
        {
            if (textbox.Text == placeholder)
            {
                textbox.Text = String.Empty;
                textbox.ForeColor = Color.Black;
            }

        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            waterMarkOnTextBoxLeave(this.nameTextBox, name);
        }

        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            waterMarkOnTextBoxEnter(this.nameTextBox, name);
        }

        private void descTextBox_Leave(object sender, EventArgs e)
        {
            waterMarkOnTextBoxLeave(this.descTextBox, desc);
        }

        private void descTextBox_Enter(object sender, EventArgs e)
        {
            waterMarkOnTextBoxEnter(this.descTextBox, desc);
        }

        private void priceTextBox_Leave(object sender, EventArgs e)
        {
            waterMarkOnTextBoxLeave(this.priceTextBox, price);
        }

        private void priceTextBox_Enter(object sender, EventArgs e)
        {
            waterMarkOnTextBoxEnter(this.priceTextBox, price);
        }

        private void AddRecipes_Load(object sender, EventArgs e)
        {        
            data = DatabaseOperations.getData();
            foreach(var datum in data)
            {                
                this.foodItemsComboBox.Items.Add(datum.name);
               
            }

            if (!foodItemsComboBox.Items.Contains(selectFood))
                foodItemsComboBox.Items.Add(selectFood);
            foodItemsComboBox.Text = selectFood;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            validateControl();
        }

        private void validateData()
        {
            if (string.IsNullOrWhiteSpace(this.nameTextBox.Text) || this.nameTextBox.Text == name)
            {
                errorProvider.SetError(this.nameTextBox, "Please enter valid name for recipe");
                return;
            }
            else errorProvider.Clear();
            if (this.itemsDataGridView.RowCount < 1)
            {
                errorProvider.SetError(this.itemsDataGridView, "Please add valid foodItems to recipe");
                return;
            }
            else errorProvider.Clear();

            processData();
        }

        private async void processData()
        {
                        
            RecipeDataModel.RecipeData recipeData = new RecipeDataModel.RecipeData();
            recipeData.recipeName = this.nameTextBox.Text;
            recipeData.itemsData = recipeFoodItems;
            string nDesc = this.descTextBox.Text;
            if (string.IsNullOrWhiteSpace(nDesc))
                nDesc = " ";
            recipeData.recipeDesc = nDesc;         
          

            //Send recipe to server
            AppRepo repo = new AppRepo();
            DialogForm dialogForm = new DialogForm("Creating Recipe...");
            dialogForm.Show(this);
            this.Enabled = false;
           
            try
            {
                RecipeResultDataModel recipeResult = await repo.createRecipe(DatabaseOperations.getToken().token, recipeData);
                this.Enabled = true;
                dialogForm.Close();

                if (recipeResult != null && !recipeResult.success)
                {
                    MessageBox.Show(recipeResult.message, "Error Creating Recipe");
                } else if(recipeResult != null && recipeResult.success)
                {
                    recipeData.id = recipeResult.id;
                    recipeDataList.Add(recipeData);
                    DatabaseOperations.addRecipe(recipeData);
                    MessageBox.Show("Recipe Created successfully");
                    clearControls();

                    //TODO clear data in controls for user to create new recipe
                }
            }
            catch (ApiException ex)
            {
                MessageBox.Show(ex.Message, "Error Creating Recipe");
                this.Enabled = true;
                dialogForm.Close();
            }                                      

            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void validateControl()
        {
            if (notValidQuantity(this.quantityTextBox))
            {
                errorProvider.SetError(this.quantityTextBox, "Please provide a valid quantity");
                return;
            }
            else errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(this.foodItemsComboBox.Text) || foodItemsComboBox.Text == selectFood)
            {
                errorProvider.SetError(this.foodItemsComboBox, "Please select an item");
                return;
            }
            else errorProvider.Clear();

            addSelectedItem();
        }
        private bool notValidQuantity(TextBox textbox)
        {
            if (String.IsNullOrEmpty(textbox.Text) || String.IsNullOrWhiteSpace(textbox.Text))
                return true;
            else
                try
                {
                    int quantity = int.Parse(textbox.Text);
                    return false;
                }
                catch (Exception ex)
                {
                    return true;
                }

        }

        private void addSelectedItem()
        {
            int index = this.foodItemsComboBox.SelectedIndex;
            int quantity = int.Parse(this.quantityTextBox.Text);

            //use index to find the fooditem
            var item = data.ElementAt(index);
            decimal totalPrice = item.price * quantity;           

            new UpdateDataGridView().updateAddRecipeDataGrid(new RecipeItems {itemName = item.name,itemId = index,
            quantity = quantity, totalPrice = totalPrice},this.itemsDataGridView);

            //add the item to new list of foods
            RecipeDataModel.RecipeData.items R_items = new RecipeDataModel.RecipeData.items();
            R_items.quantity = quantity;
            R_items.foodItems = item;
            recipeFoodItems.Add(R_items);
        }

        private void clearControls()
        {
            this.nameTextBox.Clear();
            this.descTextBox.Clear();
            new UpdateDataGridView().clearDataInDataGridView(this.itemsDataGridView);
            this.quantityTextBox.Clear();
            this.priceTextBox.Clear();

            waterMarkOnTextBoxLeave(this.nameTextBox, name);
            waterMarkOnTextBoxLeave(this.descTextBox, desc);
            waterMarkOnTextBoxLeave(this.priceTextBox, price);

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            validateData();            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void foodItemsComboBox_DropDown(object sender, EventArgs e)
        {
            if (foodItemsComboBox.Items.Contains(selectFood))
                foodItemsComboBox.Items.Remove(selectFood);
        }

        private void foodItemsComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if(foodItemsComboBox.SelectedIndex == -1)
            {
                if (!foodItemsComboBox.Items.Contains(selectFood))
                    foodItemsComboBox.Items.Add(selectFood);
                foodItemsComboBox.Text = selectFood;
            }
        }
    }
}
