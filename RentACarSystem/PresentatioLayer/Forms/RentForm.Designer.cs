namespace PresentatioLayer.Forms
{
    partial class RentForm
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
            clientsButton = new Button();
            carsButton = new Button();
            clientsLabel = new Label();
            CarLabel = new Label();
            rentDateLabel = new Label();
            rentReturnLabel = new Label();
            saveRentButton = new Button();
            editRentButton = new Button();
            deleteRentButton = new Button();
            ClientscomboBox = new ComboBox();
            CarscomboBox = new ComboBox();
            rentDateDTP = new DateTimePicker();
            rentReturnDTP = new DateTimePicker();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            tittleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // clientsButton
            // 
            clientsButton.Location = new Point(47, 102);
            clientsButton.Name = "clientsButton";
            clientsButton.Size = new Size(175, 29);
            clientsButton.TabIndex = 0;
            clientsButton.Text = "agregar nuevo cliente";
            clientsButton.UseVisualStyleBackColor = true;
            clientsButton.Click += clientsButton_Click;
            // 
            // carsButton
            // 
            carsButton.Location = new Point(47, 203);
            carsButton.Name = "carsButton";
            carsButton.Size = new Size(171, 29);
            carsButton.TabIndex = 1;
            carsButton.Text = "agregar nuevo carro";
            carsButton.UseVisualStyleBackColor = true;
            carsButton.Click += carsButton_Click;
            // 
            // clientsLabel
            // 
            clientsLabel.AutoSize = true;
            clientsLabel.Location = new Point(47, 151);
            clientsLabel.Name = "clientsLabel";
            clientsLabel.Size = new Size(131, 20);
            clientsLabel.TabIndex = 2;
            clientsLabel.Text = "seleccionar cliente";
            // 
            // CarLabel
            // 
            CarLabel.AutoSize = true;
            CarLabel.Location = new Point(57, 253);
            CarLabel.Name = "CarLabel";
            CarLabel.Size = new Size(121, 20);
            CarLabel.TabIndex = 3;
            CarLabel.Text = "seleccionar carro";
            // 
            // rentDateLabel
            // 
            rentDateLabel.AutoSize = true;
            rentDateLabel.Location = new Point(596, 102);
            rentDateLabel.Name = "rentDateLabel";
            rentDateLabel.Size = new Size(106, 20);
            rentDateLabel.TabIndex = 4;
            rentDateLabel.Text = "fecha de retiro";
            // 
            // rentReturnLabel
            // 
            rentReturnLabel.AutoSize = true;
            rentReturnLabel.Location = new Point(596, 187);
            rentReturnLabel.Name = "rentReturnLabel";
            rentReturnLabel.Size = new Size(143, 20);
            rentReturnLabel.TabIndex = 5;
            rentReturnLabel.Text = "fecha de devolucion";
            // 
            // saveRentButton
            // 
            saveRentButton.Location = new Point(535, 312);
            saveRentButton.Name = "saveRentButton";
            saveRentButton.Size = new Size(94, 29);
            saveRentButton.TabIndex = 6;
            saveRentButton.Text = "guardar";
            saveRentButton.UseVisualStyleBackColor = true;
            // 
            // editRentButton
            // 
            editRentButton.Location = new Point(757, 312);
            editRentButton.Name = "editRentButton";
            editRentButton.Size = new Size(94, 29);
            editRentButton.TabIndex = 7;
            editRentButton.Text = "editar";
            editRentButton.UseVisualStyleBackColor = true;
            // 
            // deleteRentButton
            // 
            deleteRentButton.Location = new Point(925, 312);
            deleteRentButton.Name = "deleteRentButton";
            deleteRentButton.Size = new Size(94, 29);
            deleteRentButton.TabIndex = 8;
            deleteRentButton.Text = "eliminar";
            deleteRentButton.UseVisualStyleBackColor = true;
            // 
            // ClientscomboBox
            // 
            ClientscomboBox.FormattingEnabled = true;
            ClientscomboBox.Location = new Point(223, 148);
            ClientscomboBox.Name = "ClientscomboBox";
            ClientscomboBox.Size = new Size(151, 28);
            ClientscomboBox.TabIndex = 9;
            // 
            // CarscomboBox
            // 
            CarscomboBox.FormattingEnabled = true;
            CarscomboBox.Location = new Point(223, 245);
            CarscomboBox.Name = "CarscomboBox";
            CarscomboBox.Size = new Size(151, 28);
            CarscomboBox.TabIndex = 10;
            // 
            // rentDateDTP
            // 
            rentDateDTP.Location = new Point(769, 104);
            rentDateDTP.Name = "rentDateDTP";
            rentDateDTP.Size = new Size(250, 27);
            rentDateDTP.TabIndex = 11;
            // 
            // rentReturnDTP
            // 
            rentReturnDTP.Location = new Point(769, 187);
            rentReturnDTP.Name = "rentReturnDTP";
            rentReturnDTP.Size = new Size(250, 27);
            rentReturnDTP.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 378);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1159, 319);
            dataGridView1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Controls.Add(tittleLabel);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1216, 68);
            panel2.TabIndex = 15;
            // 
            // tittleLabel
            // 
            tittleLabel.AutoSize = true;
            tittleLabel.Font = new Font("Segoe UI", 15F);
            tittleLabel.Location = new Point(412, 14);
            tittleLabel.Name = "tittleLabel";
            tittleLabel.Size = new Size(362, 35);
            tittleLabel.TabIndex = 0;
            tittleLabel.Text = "Alquiler de carros El migueleño";
            // 
            // RentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 689);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(rentReturnDTP);
            Controls.Add(rentDateDTP);
            Controls.Add(CarscomboBox);
            Controls.Add(ClientscomboBox);
            Controls.Add(deleteRentButton);
            Controls.Add(editRentButton);
            Controls.Add(saveRentButton);
            Controls.Add(rentReturnLabel);
            Controls.Add(rentDateLabel);
            Controls.Add(CarLabel);
            Controls.Add(clientsLabel);
            Controls.Add(carsButton);
            Controls.Add(clientsButton);
            Name = "RentForm";
            Text = "RentForm";
            FormClosing += RentForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clientsButton;
        private Button carsButton;
        private Label clientsLabel;
        private Label CarLabel;
        private Label rentDateLabel;
        private Label rentReturnLabel;
        private Button saveRentButton;
        private Button editRentButton;
        private Button deleteRentButton;
        private ComboBox ClientscomboBox;
        private ComboBox CarscomboBox;
        private DateTimePicker rentDateDTP;
        private DateTimePicker rentReturnDTP;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label tittleLabel;
    }
}