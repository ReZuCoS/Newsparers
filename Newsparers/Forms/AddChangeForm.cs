using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newsparers.Model;

namespace Newsparers.Forms
{
    public partial class AddChangeForm : Form
    {
        public NewspapersModel Database { get; set; }
        public Agent Agent { get; set; } = null;

        private string _imageSource;

        public AddChangeForm()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            agentTypeBindingSource.DataSource = Database.AgentTypes.ToList();
            agentBindingSource.DataSource = Database.Agents.ToList();

            titleTextBox.Name = "Название";
            iNNTextBox.Name = "ИНН";
            priorityTextBox.Name = "Приоритет";

            if (Agent == null)
            {
                this.Text = "Добавление агента";
                this.pictureBox.Image = Properties.Resources.picture;
            }
            else
            {
                this.Text = "Изменение агента";

                titleTextBox.Text = Agent.Title;
                agentTypeIDComboBox.SelectedIndex = Agent.AgentTypeID - 1;
                addressTextBox.Text = Agent.Address;
                iNNTextBox.Text = Agent.INN;
                kPPTextBox.Text = Agent.KPP;
                directorNameTextBox.Text = Agent.DirectorName;
                maskedTextBoxPhone.Text = Agent.Phone;
                emailTextBox.Text = Agent.Email;
                priorityTextBox.Text = Agent.Priority.ToString();

                if (Agent.Logo == "null")
                {
                    pictureBox.Image = Properties.Resources.picture;
                }
                else
                {
                    labelImage.Text = "";

                    if(Agent.Logo.Length >= 100)
                    {
                        _imageSource = $"{Environment.CurrentDirectory}/{Agent.Logo}";
                    }
                    else
                    {
                        _imageSource = Agent.Logo;
                    }
                    pictureBox.Image = new Bitmap(_imageSource);
                }
            }
        }

        private void AddAgent()
        {
            Agent = new Agent
            {
                Title = titleTextBox.Text,
                AgentTypeID = agentTypeIDComboBox.SelectedIndex + 1,
                Address = addressTextBox.Text,
                INN = iNNTextBox.Text,
                KPP = kPPTextBox.Text,
                DirectorName = directorNameTextBox.Text,
                Email = emailTextBox.Text,
                Phone = maskedTextBoxPhone.Text,
                Priority = int.Parse(priorityTextBox.Text),
                Logo = _imageSource
            };

            try
            {
                Database.Agents.Add(Agent);
                Database.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ImageSelect(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                _imageSource = fileDialog.FileName;

                labelImage.Text = "";

                pictureBox.Image = new Bitmap(_imageSource);
            }
        }

        private void Save(object sender, EventArgs e)
        {
            if (WindowValidated() == false) return;

            if (Agent == null)
            {
                AddAgent();
                DialogResult = DialogResult.OK;
            }
            else
            {
                ChangeAgent();
                DialogResult = DialogResult.OK;
            }
        }

        private void ChangeAgent()
        {
            Agent.Title = titleTextBox.Text;
            Agent.AgentTypeID = agentTypeIDComboBox.SelectedIndex + 1;
            Agent.Address = addressTextBox.Text;
            Agent.INN = iNNTextBox.Text;
            Agent.KPP = kPPTextBox.Text;
            Agent.DirectorName = directorNameTextBox.Text;
            Agent.Email = emailTextBox.Text;
            Agent.Phone = maskedTextBoxPhone.Text;
            Agent.Priority = int.Parse(priorityTextBox.Text);
            Agent.Logo = _imageSource;

            try
            {
                Database.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool WindowValidated()
        {
            int errors = 0;

            var textBoxes = new List<TextBox>
            {
                titleTextBox,
                iNNTextBox,
                priorityTextBox
            };

            string message = "";

            foreach (TextBox tb in textBoxes)
            {
                if (tb.Text == "")
                {
                    message += $"{tb.Name}\n";
                    errors++;
                }
            }

            if (errors >= 1)
            {
                MessageBox.Show($"Поля должны быть заполнены: \n{message}", "Заполните поля", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (!maskedTextBoxPhone.MaskCompleted)
            {
                MessageBox.Show("Номер телефона должен быть заполнен!", "Заполните номер телефона", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(priorityTextBox.Text, out int i))
            {
                MessageBox.Show("Приоритет должен содержать только число", "Заполните приоритет", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
