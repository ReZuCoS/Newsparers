using System.Windows.Forms;
using Newsparers.Model;
using Newsparers.Forms;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Newsparers.Forms
{
    public partial class TableAgentsForm : Form
    {
        private readonly NewspapersModel _database = new NewspapersModel();

        private List<Agent> TempAgents { get; set; }

        public TableAgentsForm()
        {
            InitializeComponent();
            agentTypeBindingSource.DataSource = _database.AgentTypes.ToList();

            foreach (AgentType type in _database.AgentTypes)
            {
                comboBoxFiltering.Items.Add(type.Title);
            }

            TempAgents = _database.Agents.ToList();

            comboBoxSort.SelectedIndex = 0;
            comboBoxFiltering.SelectedIndex = 0;
        }

        private void OnSelectionChanging(object sender, EventArgs e)
        {
            int selectedRowsCount = dataGridView.SelectedRows.Count;

            if (selectedRowsCount >= 2)
            {
                buttonChange.Enabled = false;
                buttonRemove.Text = $"Удалить ({selectedRowsCount})";
            }
            else
            {
                buttonChange.Enabled = true;
                buttonRemove.Text = "Удалить";
            }
        }

        private void RemoveSelectedRecords(object sender, EventArgs e)
        {
            List<Agent> agents = new List<Agent>();
            string message = "";

            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                Agent agent = row.DataBoundItem as Agent;
                agents.Add(agent);
                message += $"\n{agent.Title}";
            }

            DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите удалить:{message}?\nОтменить данное действие будет невозможно!",
                "Удаление агента", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No) return;

            try
            {
                _database.Agents.RemoveRange(agents);
                _database.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            TempAgents = _database.Agents.ToList();

            agentBindingSource.DataSource = TempAgents;
            comboBoxFiltering.SelectedIndex = 0;
            comboBoxSort.SelectedIndex = 0;
            checkBoxSort.Checked = false;
        }

        private void TableFiltering(object sender, EventArgs e)
        {
            comboBoxSort.SelectedIndex = 0;
            checkBoxSort.Checked = false;

            if(comboBoxFiltering.SelectedIndex == 0)
            {
                TempAgents = _database.Agents.ToList();
                agentBindingSource.DataSource = TempAgents;
                return;
            }
            else
            {
                TempAgents.Clear();

                TempAgents = _database.Agents.Where(x => x.AgentTypeID == comboBoxFiltering.SelectedIndex).ToList();

                agentBindingSource.DataSource = TempAgents;
                return;
            }
        }

        private void TableSort(object sender, EventArgs e)
        {
            int index = comboBoxSort.SelectedIndex;
            IOrderedEnumerable<Agent> sortedAgents;

            if (checkBoxSort.Checked)
            {
                index *= 10;
            }

            switch (index)
            {
                case 0:
                    agentBindingSource.DataSource = TempAgents;
                    break;

                case 1:
                    sortedAgents = from ag in TempAgents orderby ag.AgentTypeID ascending select ag;

                    agentBindingSource.DataSource = sortedAgents;
                    break;

                case 2:
                    sortedAgents = from ag in TempAgents orderby ag.Priority ascending select ag;

                    agentBindingSource.DataSource = sortedAgents;
                    break;

                case 10:
                    sortedAgents = from ag in TempAgents orderby ag.AgentTypeID descending select ag;

                    agentBindingSource.DataSource = sortedAgents;
                    break;

                case 20:
                    sortedAgents = from ag in TempAgents orderby ag.Priority descending select ag;

                    agentBindingSource.DataSource = sortedAgents;
                    break;
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAgent(object sender, EventArgs e)
        {
            AddChangeForm form = new AddChangeForm
            {
                Database = _database
            };

            DialogResult dialog = form.ShowDialog();
            if(dialog == DialogResult.OK)
            {
                agentBindingSource.DataSource = _database.Agents.ToList();
            }
        }

        private void ChangeAgent(object sender, EventArgs e)
        {
            AddChangeForm form = new AddChangeForm
            {
                Database = _database,
                Agent = (Agent)agentBindingSource.Current
            };

            DialogResult dialog = form.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                agentBindingSource.DataSource = _database.Agents.ToList();
            }
        }
    }
}
