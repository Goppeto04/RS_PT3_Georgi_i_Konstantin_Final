using BusinessLayer;
using Microsoft.Data.SqlClient;
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
    public partial class AlcoholForm : Form
    {
        
        private DbManager<Alcohol, int> dbManager;
        private Alcohol selectedAlcohol;
        public AlcoholForm()
        {
            InitializeComponent();
            dbManager = new DbManager<Alcohol, int>(DbContextManager.CreateAlcoholContext(DbContextManager.CreateContext()));

            LoadAlcohol();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedAlcohol != null)
                {
                    MessageBox.Show("You can't duplicated this alcohol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ValidateData())
                {
                    Alcohol alcohol = new Alcohol(TitleBox.Text, IngredientBox.Text, CountryBox.Text, Double.Parse(BushidoBox.Text), Double.Parse(OnyxBox.Text), Double.Parse(SecretsBox.Text));
                    dbManager.Create(alcohol);
                    MessageBox.Show("Alcohol created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadAlcohol();

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
            if (ValidateData() && selectedAlcohol != null)
            {
                Alcohol alcohol = new Alcohol(selectedAlcohol.ID, TitleBox.Text, IngredientBox.Text, CountryBox.Text, Double.Parse(BushidoBox.Text), Double.Parse(OnyxBox.Text), Double.Parse(SecretsBox.Text));
                dbManager.Update(alcohol);
                MessageBox.Show("Alcohol updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAlcohol();

                ClearData();
            }
            else
            {
                MessageBox.Show("Something is missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedAlcohol != null)
            {
                dbManager.Delete(selectedAlcohol.ID);

                MessageBox.Show("Alcohol deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAlcohol();

                ClearData();
            }
            else
            {
                MessageBox.Show("You must select an alcohol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadAlcohol()
        {
            AlcoholDataGridView.DataSource = dbManager.ReadAll(true);
        }

        private bool ValidateData()
        {
            if (TitleBox.Text != string.Empty && IngredientBox.Text != string.Empty && CountryBox.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void ClearData()
        {
            TitleBox.Text = string.Empty;
            IngredientBox.Text = string.Empty;
            CountryBox.Text = string.Empty;
            BushidoBox.Text = string.Empty;
            OnyxBox.Text = string.Empty;
            SecretsBox.Text = string.Empty;

            selectedAlcohol = null;
        }

        private void AlcoholDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = AlcoholDataGridView.Rows[e.RowIndex];

            selectedAlcohol = row.DataBoundItem as Alcohol;

            TitleBox.Text = selectedAlcohol.Title;
            IngredientBox.Text = selectedAlcohol.MainIngrediant;
            CountryBox.Text = selectedAlcohol.Countries;
            BushidoBox.Text = selectedAlcohol.PriceInBushido.ToString();
            OnyxBox.Text = selectedAlcohol.PriceInOnyx.ToString();
            SecretsBox.Text = selectedAlcohol.PriceInSecrets.ToString();

        }

    }
}
