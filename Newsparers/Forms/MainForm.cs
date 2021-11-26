using System.Windows.Forms;
using Newsparers.Model;
using Newsparers.Forms;
using System.Linq;
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace Newsparers.Forms
{
    public partial class MainForm : Form
    {
        private readonly NewspapersModel _database = new NewspapersModel();

        public MainForm()
        {
            InitializeComponent();
            agentTypeBindingSource.DataSource = _database.AgentTypes.ToList();
            agentBindingSource.DataSource = _database.Agents.ToList();

            foreach (AgentType type in _database.AgentTypes)
            {
                comboBoxFiltering.Items.Add(type.Title);
            }

            comboBoxSort.SelectedIndex = 0;
        }

        private void OnSelectionChanging(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count >= 2)
            {
                buttonChange.Enabled = false;
                buttonRemove.Text = $"Удалить ({dataGridView.SelectedRows.Count})";
            }
            else
            {
                buttonChange.Enabled = true;
                buttonRemove.Text = "Удалить";
            }
        }

        private void RemoveSelectedRecords(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView.SelectedRows)
            {
                Agent agent = row.DataBoundItem as Agent;
                _database.Agents.Remove(agent);
            }

            try
            {
                _database.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            agentBindingSource.DataSource = _database.Agents.ToList();
        }

        private void SortChanged(object sender, EventArgs e)
        {
            
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
