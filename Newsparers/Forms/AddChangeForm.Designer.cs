
namespace Newsparers.Forms
{
    partial class AddChangeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label agentTypeIDLabel;
            System.Windows.Forms.Label directorNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label iNNLabel;
            System.Windows.Forms.Label kPPLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label titleLabel;
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.agentTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.agentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.iNNTextBox = new System.Windows.Forms.TextBox();
            this.kPPTextBox = new System.Windows.Forms.TextBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelImage = new System.Windows.Forms.Label();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            addressLabel = new System.Windows.Forms.Label();
            agentTypeIDLabel = new System.Windows.Forms.Label();
            directorNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            kPPLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(13, 255);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(51, 16);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Адрес:";
            // 
            // agentTypeIDLabel
            // 
            agentTypeIDLabel.AutoSize = true;
            agentTypeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            agentTypeIDLabel.Location = new System.Drawing.Point(13, 225);
            agentTypeIDLabel.Name = "agentTypeIDLabel";
            agentTypeIDLabel.Size = new System.Drawing.Size(84, 16);
            agentTypeIDLabel.TabIndex = 3;
            agentTypeIDLabel.Text = "Тип агента:";
            // 
            // directorNameLabel
            // 
            directorNameLabel.AutoSize = true;
            directorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            directorNameLabel.Location = new System.Drawing.Point(13, 339);
            directorNameLabel.Name = "directorNameLabel";
            directorNameLabel.Size = new System.Drawing.Size(110, 16);
            directorNameLabel.TabIndex = 5;
            directorNameLabel.Text = "Имя директора:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(13, 395);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(49, 16);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "E-mail:";
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iNNLabel.Location = new System.Drawing.Point(13, 283);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(41, 16);
            iNNLabel.TabIndex = 11;
            iNNLabel.Text = "ИНН:";
            // 
            // kPPLabel
            // 
            kPPLabel.AutoSize = true;
            kPPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kPPLabel.Location = new System.Drawing.Point(13, 311);
            kPPLabel.Name = "kPPLabel";
            kPPLabel.Size = new System.Drawing.Size(39, 16);
            kPPLabel.TabIndex = 13;
            kPPLabel.Text = "КПП:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(13, 367);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(71, 16);
            phoneLabel.TabIndex = 17;
            phoneLabel.Text = "Телефон:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priorityLabel.Location = new System.Drawing.Point(13, 423);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(83, 16);
            priorityLabel.TabIndex = 19;
            priorityLabel.Text = "Приоритет:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.Location = new System.Drawing.Point(13, 197);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(77, 16);
            titleLabel.TabIndex = 21;
            titleLabel.Text = "Название:";
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataSource = typeof(Newsparers.Model.Agent);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(130, 252);
            this.addressTextBox.MaxLength = 300;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(180, 22);
            this.addressTextBox.TabIndex = 3;
            // 
            // agentTypeIDComboBox
            // 
            this.agentTypeIDComboBox.DataSource = this.agentTypeBindingSource;
            this.agentTypeIDComboBox.DisplayMember = "Title";
            this.agentTypeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agentTypeIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentTypeIDComboBox.FormattingEnabled = true;
            this.agentTypeIDComboBox.Location = new System.Drawing.Point(130, 222);
            this.agentTypeIDComboBox.Name = "agentTypeIDComboBox";
            this.agentTypeIDComboBox.Size = new System.Drawing.Size(180, 24);
            this.agentTypeIDComboBox.TabIndex = 2;
            this.agentTypeIDComboBox.ValueMember = "ID";
            // 
            // agentTypeBindingSource
            // 
            this.agentTypeBindingSource.DataSource = typeof(Newsparers.Model.AgentType);
            // 
            // directorNameTextBox
            // 
            this.directorNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorNameTextBox.Location = new System.Drawing.Point(130, 336);
            this.directorNameTextBox.MaxLength = 100;
            this.directorNameTextBox.Name = "directorNameTextBox";
            this.directorNameTextBox.Size = new System.Drawing.Size(180, 22);
            this.directorNameTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(130, 392);
            this.emailTextBox.MaxLength = 255;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(180, 22);
            this.emailTextBox.TabIndex = 8;
            // 
            // iNNTextBox
            // 
            this.iNNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iNNTextBox.Location = new System.Drawing.Point(130, 280);
            this.iNNTextBox.MaxLength = 12;
            this.iNNTextBox.Name = "iNNTextBox";
            this.iNNTextBox.Size = new System.Drawing.Size(180, 22);
            this.iNNTextBox.TabIndex = 4;
            // 
            // kPPTextBox
            // 
            this.kPPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kPPTextBox.Location = new System.Drawing.Point(130, 308);
            this.kPPTextBox.MaxLength = 9;
            this.kPPTextBox.Name = "kPPTextBox";
            this.kPPTextBox.Size = new System.Drawing.Size(180, 22);
            this.kPPTextBox.TabIndex = 5;
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityTextBox.Location = new System.Drawing.Point(130, 420);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(180, 22);
            this.priorityTextBox.TabIndex = 9;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(130, 194);
            this.titleTextBox.MaxLength = 150;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(180, 22);
            this.titleTextBox.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(298, 176);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 23;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.ImageSelect);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbort.Location = new System.Drawing.Point(196, 448);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(114, 31);
            this.buttonAbort.TabIndex = 11;
            this.buttonAbort.Text = "Отменить";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.CloseForm);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(12, 448);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(114, 31);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.Save);
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelImage.Enabled = false;
            this.labelImage.Location = new System.Drawing.Point(92, 95);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(128, 13);
            this.labelImage.TabIndex = 0;
            this.labelImage.Text = "Выберите изображение";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(130, 364);
            this.maskedTextBoxPhone.Mask = "+7 (999)000-00-00";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(180, 22);
            this.maskedTextBoxPhone.TabIndex = 24;
            this.maskedTextBoxPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // AddChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 491);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(agentTypeIDLabel);
            this.Controls.Add(this.agentTypeIDComboBox);
            this.Controls.Add(directorNameLabel);
            this.Controls.Add(this.directorNameTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(iNNLabel);
            this.Controls.Add(this.iNNTextBox);
            this.Controls.Add(kPPLabel);
            this.Controls.Add(this.kPPTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(priorityLabel);
            this.Controls.Add(this.priorityTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.MaximumSize = new System.Drawing.Size(338, 530);
            this.MinimumSize = new System.Drawing.Size(338, 530);
            this.Name = "AddChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddChangeForm";
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource agentBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.ComboBox agentTypeIDComboBox;
        private System.Windows.Forms.TextBox directorNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox iNNTextBox;
        private System.Windows.Forms.TextBox kPPTextBox;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.BindingSource agentTypeBindingSource;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
    }
}