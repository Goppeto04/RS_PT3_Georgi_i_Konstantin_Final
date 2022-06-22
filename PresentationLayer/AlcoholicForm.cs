using BusinessLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class AlcoholicForm : Form
    {
        private DbManager<Alcoholic, int> dbManager;
        private DbManager<Alcohol, int> alcoholDbManager;
        private Alcoholic selectedAlcoholic;
        private Alcohol selectedDrink;
        public AlcoholicForm()
        {
            dbManager = new DbManager<Alcoholic, int>(DbContextManager.CreateAlcoholicContext(DbContextManager.CreateContext()));          
            alcoholDbManager = new DbManager<Alcohol, int>(DbContextManager.CreateAlcoholContext(DbContextManager.GetContext()));
            InitializeComponent();

            LoadAlcoholics();
            
            LoadAlcohols();
        }     

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedAlcoholic != null)
                {
                    MessageBox.Show("You can't duplicated this alcoholic!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ValidateData())
                {
                    List<Alcohol> favouriteDrinks = new List<Alcohol>();
                    Alcoholic alcoholic = new Alcoholic(NameBox.Text, FamilyBox.Text, Decimal.ToByte(AgeNumeric.Value),DrunkNameBox.Text/*, null, favouriteDrinks, null*/);
                    dbManager.Create(alcoholic);
                    MessageBox.Show("Alcoholic created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadAlcoholics();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Something is missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (ValidateData() && selectedAlcoholic != null)
            {
                Alcoholic alcoholic = new Alcoholic(selectedAlcoholic.ID,NameBox.Text, FamilyBox.Text, Decimal.ToByte(AgeNumeric.Value), DrunkNameBox.Text);
                dbManager.Update(alcoholic);
                MessageBox.Show("Alcoholic updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAlcoholics();

                ClearData();
            }
            else
            {
                MessageBox.Show("Something is missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedAlcoholic != null)
            {
                dbManager.Delete(selectedAlcoholic.ID);

                MessageBox.Show("Alcoholic deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAlcoholics();

                ClearData();
            }
            else
            {
                MessageBox.Show("You must select a party!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddingDrinksButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedAlcoholic != null && selectedDrink != null)
                {
                    if (!((HashSet<Alcohol>)selectedAlcoholic.FavouriteDrinks).Contains(selectedDrink))
                    {
                        ((HashSet<Alcohol>)selectedAlcoholic.FavouriteDrinks).Add(selectedDrink);

                        dbManager.Update(selectedAlcoholic);

                        MessageBox.Show(string.Format("{0} added successfully!", selectedDrink.Title),
                            "dobur wkus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("This drink is already added to ur favourites!", "shte ti spra pieneto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("You must choose piqnica and piene!", ":|", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            LoadAlcoholics();

            ClearData();
        }

        private void DrinksListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (DrinksListBox.SelectedValue != null)
            {
                selectedDrink = DrinksListBox.SelectedItem as Alcohol;
            }   
        }

        #region hwlping methods

        private void LoadAlcoholics()
        {
            AlcoholicGridView.DataSource = dbManager.ReadAll(true);
        }

        private void LoadAlcohols()
        {
            DrinksListBox.DataSource = alcoholDbManager.ReadAll(true);

            DrinksListBox.DisplayMember = "Title";
            DrinksListBox.ValueMember = "ID";
        }
        

        private bool ValidateData()
        {
            if (NameBox.Text != string.Empty && FamilyBox.Text != string.Empty && DrunkNameBox.Text != string.Empty && AgeNumeric.Value >= 18)
            {
                return true;
            }

            return false;
        }

        private void ClearData()
        {
            NameBox.Text = string.Empty;
            FamilyBox.Text = string.Empty;
            DrunkNameBox.Text = string.Empty;
            AgeNumeric.Value = 18;

            selectedAlcoholic = null;
            selectedDrink = null;
        }

        private void AlcoholicGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = AlcoholicGridView.Rows[e.RowIndex];

            selectedAlcoholic = row.DataBoundItem as Alcoholic;

            NameBox.Text = selectedAlcoholic.Name;
            FamilyBox.Text = selectedAlcoholic.FamilyName;
            DrunkNameBox.Text = selectedAlcoholic.DrunkName;
            AgeNumeric.Value = selectedAlcoholic.Age;
        }
        #endregion

        
    }
}
