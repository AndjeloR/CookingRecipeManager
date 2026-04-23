using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingRecipeManager
{
    public partial class Form1 : Form
    {

        List<Recipe> recipes = new List<Recipe>();
        string selectedImagePath = "";

        public Form1()
        {
            InitializeComponent();
            cmbSort.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Images|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    pbRecipeImage.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)) return;

            var newRecipe = new Recipe
            {
                Name = txtName.Text,
                Ingredients = txtIngredients.Text,
                Instructions = txtInstructions.Text,
                ImagePath = selectedImagePath
            };

            recipes.Add(newRecipe);
            ApplySorting();
            ClearInput();
        }

        private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem is Recipe selected)
            {
                txtName.Text = selected.Name;
                txtIngredients.Text = selected.Ingredients;
                txtInstructions.Text = selected.Instructions;

                if (!string.IsNullOrEmpty(selected.ImagePath))
                    pbRecipeImage.Image = Image.FromFile(selected.ImagePath);
                else
                    pbRecipeImage.Image = null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem is Recipe selected)
            {
                recipes.Remove(selected);
                RefreshList();
                ClearInput();
            }
        }

        private void RefreshList()
        {
            lstRecipes.DataSource = null;
            lstRecipes.DataSource = recipes;
        }

        private void ClearInput()
        {
            txtName.Clear();
            txtIngredients.Clear();
            txtInstructions.Clear();
            pbRecipeImage.Image = null;
            selectedImagePath = "";
        }

        private void ApplySorting()
        {
            if (cmbSort.SelectedItem == null) return;

            string sortOrder = cmbSort.SelectedItem.ToString();

            if (sortOrder == "A - Z")
            {
                recipes = recipes.OrderBy(r => r.Name).ToList();
            }
            else if (sortOrder == "Z - A")
            {
                recipes = recipes.OrderByDescending(r => r.Name).ToList();
            }

            RefreshList();
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplySorting();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
    }
}
