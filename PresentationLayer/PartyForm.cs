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
    public partial class PartyForm : Form
    {
        //TO DO: uprawi addwaneto na pitieta i hora
        private DbManager<Party, int> dbManager;
        private DbManager<Alcohol, int> alcoholDbManager;
        private DbManager<Alcoholic, int> alcoholicDbManager;
        private Party selectedParty;
        private Alcohol selectedDrink;
        private Alcoholic selectedAlcoholic;
        public PartyForm()
        {
            InitializeComponent();
            dbManager = new DbManager<Party, int>(DbContextManager.CreatePartyContext(DbContextManager.CreateContext()));
            alcoholDbManager = new DbManager<Alcohol, int>(DbContextManager.CreateAlcoholContext(DbContextManager.GetContext()));
            alcoholicDbManager = new DbManager<Alcoholic, int>(DbContextManager.CreateAlcoholicContext(DbContextManager.GetContext()));

            LoadParty();
            LoadAlcohol();
            LoadAlcoholics();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedParty != null)
                {
                    MessageBox.Show("You can't duplicated this party!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ValidateData())
                {
                    Party party = new Party(TitleBox.Text, LocationBox.Text, DescriptionBox.Text);
                    dbManager.Create(party);
                    MessageBox.Show("Party created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadParty();
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
            if (ValidateData() && selectedParty != null)
            {
                Party party = new Party(selectedParty.ID, TitleBox.Text, LocationBox.Text, DescriptionBox.Text);
                dbManager.Update(party);
                MessageBox.Show("Party updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadParty();

                ClearData();
            }
            else
            {
                MessageBox.Show("Something is missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedParty != null)
            {
                dbManager.Delete(selectedParty.ID);

                MessageBox.Show("Party deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadParty();

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

        private void AddDrinksButton_Click(object sender, EventArgs e)
        {
            if (selectedParty != null && selectedDrink != null)
            {
                if (!((HashSet<Alcohol>)selectedParty.Drinks).Contains(selectedDrink))
                {
                    ((HashSet<Alcohol>)selectedParty.Drinks).Add(selectedDrink);

                    dbManager.Update(selectedParty);

                    MessageBox.Show(string.Format("{0} added successfully!", selectedDrink.Title),
                    "mnogo nice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This drink is already added to the list, me bruda!", "da ne stane mnogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (selectedParty == null)
                {
                    MessageBox.Show("You must choose a party!", "not cool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    MessageBox.Show("You must choose a drink!", "not cool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadParty();
            ClearData();
        }
        private void DrinkListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (DrinksListBox.SelectedValue != null)
            {
                selectedDrink = DrinksListBox.SelectedItem as Alcohol;
            }
        }

        private void AddMembersButton_Click(object sender, EventArgs e)
        {
            if (selectedParty != null && selectedAlcoholic != null)
            {
                if (!((HashSet<Alcoholic>)selectedParty.PartyMembers).Contains(selectedAlcoholic))
                {
                    ((HashSet<Alcoholic>)selectedParty.PartyMembers).Add(selectedAlcoholic);

                    dbManager.Update(selectedParty);

                    MessageBox.Show(string.Format("{0} added successfully!", selectedAlcoholic.Name),
                    "mnogo nice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This pich is already added to the list, me bruda!", "da ne stane mnogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (selectedParty == null)
                {
                    MessageBox.Show("You must choose a party!", "not cool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("You must choose a person!", "not cool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadParty();
            ClearData();
        }

        private void MembersListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (MembersListBox.SelectedValue != null)
            {
                selectedAlcoholic = MembersListBox.SelectedItem as Alcoholic;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedParty = row.DataBoundItem as Party;

                TitleBox.Text = selectedParty.PartyTitle;
                LocationBox.Text = selectedParty.Location;
                DescriptionBox.Text = selectedParty.Description;
        }

        private void LoadParty()
        {
            dataGridView1.DataSource = dbManager.ReadAll(true);
        }

        private void LoadAlcohol()
        {
            DrinksListBox.DataSource = alcoholDbManager.ReadAll(true);

            DrinksListBox.DisplayMember = "Title";
            DrinksListBox.ValueMember = "ID";
        }

        private void LoadAlcoholics()
        {
            MembersListBox.DataSource = alcoholicDbManager.ReadAll(true);

            MembersListBox.DisplayMember = "Name";
            MembersListBox.ValueMember = "ID";
        }

        private bool ValidateData()
        {
            if (TitleBox.Text != string.Empty && LocationBox.Text != string.Empty && DescriptionBox.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void ClearData()
        {
            TitleBox.Text = string.Empty;
            LocationBox.Text = string.Empty;
            DescriptionBox.Text = string.Empty;

            selectedParty = null;
            selectedDrink = null;
        }

        
    }
}
