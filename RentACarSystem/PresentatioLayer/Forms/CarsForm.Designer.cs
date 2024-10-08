namespace PresentatioLayer.Forms
{
    partial class CarsForm
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
            CarsDataGridView = new DataGridView();
            Tittlelabel = new Label();
            brandLabel = new Label();
            modelLabel = new Label();
            yearLabel = new Label();
            label5 = new Label();
            tittlePanel = new Panel();
            brandTextBox = new TextBox();
            modelTextBox = new TextBox();
            yearTextBox = new TextBox();
            saveCarButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            availabilityCheckBox = new CheckBox();
            availabilityLabel = new Label();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)CarsDataGridView).BeginInit();
            tittlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // CarsDataGridView
            // 
            CarsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarsDataGridView.Location = new Point(74, 417);
            CarsDataGridView.Name = "CarsDataGridView";
            CarsDataGridView.RowHeadersWidth = 51;
            CarsDataGridView.Size = new Size(1115, 265);
            CarsDataGridView.TabIndex = 0;
            // 
            // Tittlelabel
            // 
            Tittlelabel.AutoSize = true;
            Tittlelabel.Font = new Font("Segoe UI", 15F);
            Tittlelabel.Location = new Point(502, 20);
            Tittlelabel.Name = "Tittlelabel";
            Tittlelabel.Size = new Size(230, 35);
            Tittlelabel.TabIndex = 1;
            Tittlelabel.Text = "registros de  carros";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new Point(184, 112);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(57, 20);
            brandLabel.TabIndex = 2;
            brandLabel.Text = "marca :";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(184, 208);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(68, 20);
            modelLabel.TabIndex = 3;
            modelLabel.Text = "modelo :";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(184, 289);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(41, 20);
            yearLabel.TabIndex = 4;
            yearLabel.Text = "año :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 289);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 5;
            // 
            // tittlePanel
            // 
            tittlePanel.BackColor = Color.White;
            tittlePanel.Controls.Add(Tittlelabel);
            tittlePanel.Location = new Point(2, 1);
            tittlePanel.Name = "tittlePanel";
            tittlePanel.Size = new Size(1236, 81);
            tittlePanel.TabIndex = 6;
            // 
            // brandTextBox
            // 
            brandTextBox.Location = new Point(288, 112);
            brandTextBox.Name = "brandTextBox";
            brandTextBox.Size = new Size(376, 27);
            brandTextBox.TabIndex = 7;
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(288, 201);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(376, 27);
            modelTextBox.TabIndex = 8;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(288, 282);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(117, 27);
            yearTextBox.TabIndex = 9;
            // 
            // saveCarButton
            // 
            saveCarButton.Location = new Point(681, 345);
            saveCarButton.Name = "saveCarButton";
            saveCarButton.Size = new Size(94, 29);
            saveCarButton.TabIndex = 10;
            saveCarButton.Text = "guardar";
            saveCarButton.UseVisualStyleBackColor = true;
            saveCarButton.Click += saveCarButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(879, 345);
            editButton.Name = "editButton";
            editButton.Size = new Size(94, 29);
            editButton.TabIndex = 11;
            editButton.Text = "editar";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(1043, 345);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "eliminar";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // availabilityCheckBox
            // 
            availabilityCheckBox.AutoSize = true;
            availabilityCheckBox.Location = new Point(332, 345);
            availabilityCheckBox.Name = "availabilityCheckBox";
            availabilityCheckBox.Size = new Size(101, 24);
            availabilityCheckBox.TabIndex = 13;
            availabilityCheckBox.Text = "disponible";
            availabilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // availabilityLabel
            // 
            availabilityLabel.AutoSize = true;
            availabilityLabel.Location = new Point(187, 354);
            availabilityLabel.Name = "availabilityLabel";
            availabilityLabel.Size = new Size(54, 20);
            availabilityLabel.TabIndex = 14;
            availabilityLabel.Text = "estado";
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 112);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 15;
            backButton.Text = "regresar";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // CarsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 713);
            Controls.Add(backButton);
            Controls.Add(availabilityLabel);
            Controls.Add(availabilityCheckBox);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(saveCarButton);
            Controls.Add(yearTextBox);
            Controls.Add(modelTextBox);
            Controls.Add(brandTextBox);
            Controls.Add(tittlePanel);
            Controls.Add(label5);
            Controls.Add(yearLabel);
            Controls.Add(modelLabel);
            Controls.Add(brandLabel);
            Controls.Add(CarsDataGridView);
            Name = "CarsForm";
            Text = "CarsForm";
            ((System.ComponentModel.ISupportInitialize)CarsDataGridView).EndInit();
            tittlePanel.ResumeLayout(false);
            tittlePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CarsDataGridView;
        private Label Tittlelabel;
        private Label brandLabel;
        private Label modelLabel;
        private Label yearLabel;
        private Label label5;
        private Panel tittlePanel;
        private TextBox brandTextBox;
        private TextBox modelTextBox;
        private TextBox yearTextBox;
        private Button saveCarButton;
        private Button editButton;
        private Button deleteButton;
        private CheckBox availabilityCheckBox;
        private Label availabilityLabel;
        private Button backButton;
    }
}