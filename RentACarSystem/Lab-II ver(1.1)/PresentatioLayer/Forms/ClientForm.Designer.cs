namespace PresentatioLayer.Forms
{
    partial class ClientForm
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
            tittleLabel = new Label();
            nameLabel = new Label();
            emailLabel = new Label();
            phoneLabel = new Label();
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            phoneTextBox = new TextBox();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            clientDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)clientDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tittleLabel
            // 
            tittleLabel.AutoSize = true;
            tittleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tittleLabel.Location = new Point(363, 9);
            tittleLabel.Name = "tittleLabel";
            tittleLabel.Size = new Size(58, 21);
            tittleLabel.TabIndex = 0;
            tittleLabel.Text = "Cliente";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(63, 57);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(54, 15);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Nombre:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(63, 128);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(42, 15);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email: ";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(60, 213);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(55, 15);
            phoneLabel.TabIndex = 3;
            phoneLabel.Text = "Telefono:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(63, 84);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(289, 23);
            nameTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(63, 162);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(286, 23);
            emailTextBox.TabIndex = 5;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(64, 240);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(286, 23);
            phoneTextBox.TabIndex = 6;
            // 
            // addButton
            // 
            addButton.Location = new Point(60, 305);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 7;
            addButton.Text = "Agregar";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(167, 305);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 8;
            editButton.Text = "Editar";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(274, 305);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Eliminar";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // clientDataGridView
            // 
            clientDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientDataGridView.Location = new Point(416, 84);
            clientDataGridView.Name = "clientDataGridView";
            clientDataGridView.Size = new Size(334, 244);
            clientDataGridView.TabIndex = 10;
            clientDataGridView.SelectionChanged += clientDataGridView_SelectionChanged;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clientDataGridView);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(phoneTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(emailLabel);
            Controls.Add(nameLabel);
            Controls.Add(tittleLabel);
            Name = "ClientForm";
            Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)clientDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tittleLabel;
        private Label nameLabel;
        private Label emailLabel;
        private Label phoneLabel;
        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private TextBox phoneTextBox;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private DataGridView clientDataGridView;
    }
}