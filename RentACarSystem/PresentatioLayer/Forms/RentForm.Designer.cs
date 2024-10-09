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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentForm));
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
            rentsDataGridView = new DataGridView();
            titlePrincipalFormPanel = new Panel();
            tittleLabel = new Label();
            newRentGroupBox = new GroupBox();
            returnTimeDTP = new DateTimePicker();
            rentTimeDTP = new DateTimePicker();
            returnTimeLabel = new Label();
            rentTimeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)rentsDataGridView).BeginInit();
            titlePrincipalFormPanel.SuspendLayout();
            newRentGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // clientsButton
            // 
            clientsButton.BackColor = SystemColors.ActiveCaption;
            clientsButton.Location = new Point(108, 15);
            clientsButton.Margin = new Padding(0);
            clientsButton.Name = "clientsButton";
            clientsButton.Size = new Size(163, 25);
            clientsButton.TabIndex = 0;
            clientsButton.Text = "agregar nuevo cliente";
            clientsButton.UseVisualStyleBackColor = false;
            clientsButton.Click += clientsButton_Click;
            // 
            // carsButton
            // 
            carsButton.BackColor = SystemColors.ActiveCaption;
            carsButton.Location = new Point(108, 90);
            carsButton.Margin = new Padding(3, 2, 3, 2);
            carsButton.Name = "carsButton";
            carsButton.Size = new Size(163, 26);
            carsButton.TabIndex = 1;
            carsButton.Text = "agregar nuevo carro";
            carsButton.UseVisualStyleBackColor = false;
            carsButton.Click += carsButton_Click;
            // 
            // clientsLabel
            // 
            clientsLabel.AutoSize = true;
            clientsLabel.BackColor = SystemColors.ActiveCaption;
            clientsLabel.Font = new Font("Algerian", 10F);
            clientsLabel.Location = new Point(18, 48);
            clientsLabel.Name = "clientsLabel";
            clientsLabel.Size = new Size(189, 19);
            clientsLabel.TabIndex = 2;
            clientsLabel.Text = "seleccionar cliente";
            // 
            // CarLabel
            // 
            CarLabel.AutoSize = true;
            CarLabel.BackColor = SystemColors.ActiveCaption;
            CarLabel.Font = new Font("Algerian", 10F);
            CarLabel.Location = new Point(35, 126);
            CarLabel.Name = "CarLabel";
            CarLabel.Size = new Size(179, 19);
            CarLabel.TabIndex = 3;
            CarLabel.Text = "seleccionar carro";
            // 
            // rentDateLabel
            // 
            rentDateLabel.AutoSize = true;
            rentDateLabel.BackColor = SystemColors.ActiveCaption;
            rentDateLabel.Font = new Font("Algerian", 10F);
            rentDateLabel.Location = new Point(507, 19);
            rentDateLabel.Name = "rentDateLabel";
            rentDateLabel.Size = new Size(151, 19);
            rentDateLabel.TabIndex = 4;
            rentDateLabel.Text = "fecha de retiro";
            // 
            // rentReturnLabel
            // 
            rentReturnLabel.AutoSize = true;
            rentReturnLabel.BackColor = SystemColors.ActiveCaption;
            rentReturnLabel.Font = new Font("Algerian", 10F);
            rentReturnLabel.Location = new Point(496, 76);
            rentReturnLabel.Name = "rentReturnLabel";
            rentReturnLabel.Size = new Size(190, 19);
            rentReturnLabel.TabIndex = 5;
            rentReturnLabel.Text = "fecha de devolucion";
            // 
            // saveRentButton
            // 
            saveRentButton.BackColor = SystemColors.ActiveCaption;
            saveRentButton.ForeColor = Color.Black;
            saveRentButton.Location = new Point(473, 263);
            saveRentButton.Margin = new Padding(3, 2, 3, 2);
            saveRentButton.Name = "saveRentButton";
            saveRentButton.Size = new Size(144, 41);
            saveRentButton.TabIndex = 6;
            saveRentButton.Text = "guardar";
            saveRentButton.UseVisualStyleBackColor = false;
            saveRentButton.Click += saveRentButton_Click;
            // 
            // editRentButton
            // 
            editRentButton.BackColor = SystemColors.ActiveCaption;
            editRentButton.Location = new Point(123, 263);
            editRentButton.Margin = new Padding(3, 2, 3, 2);
            editRentButton.Name = "editRentButton";
            editRentButton.Size = new Size(121, 41);
            editRentButton.TabIndex = 7;
            editRentButton.Text = "editar";
            editRentButton.UseVisualStyleBackColor = false;
            // 
            // deleteRentButton
            // 
            deleteRentButton.BackColor = SystemColors.ActiveCaption;
            deleteRentButton.Location = new Point(803, 263);
            deleteRentButton.Margin = new Padding(3, 2, 3, 2);
            deleteRentButton.Name = "deleteRentButton";
            deleteRentButton.Size = new Size(110, 41);
            deleteRentButton.TabIndex = 8;
            deleteRentButton.Text = "eliminar";
            deleteRentButton.UseVisualStyleBackColor = false;
            // 
            // ClientscomboBox
            // 
            ClientscomboBox.BackColor = SystemColors.InactiveCaption;
            ClientscomboBox.FormattingEnabled = true;
            ClientscomboBox.Location = new Point(180, 45);
            ClientscomboBox.Margin = new Padding(3, 2, 3, 2);
            ClientscomboBox.Name = "ClientscomboBox";
            ClientscomboBox.Size = new Size(133, 24);
            ClientscomboBox.TabIndex = 9;
            // 
            // CarscomboBox
            // 
            CarscomboBox.BackColor = SystemColors.InactiveCaption;
            CarscomboBox.ForeColor = SystemColors.InactiveBorder;
            CarscomboBox.FormattingEnabled = true;
            CarscomboBox.Location = new Point(192, 122);
            CarscomboBox.Margin = new Padding(3, 2, 3, 2);
            CarscomboBox.Name = "CarscomboBox";
            CarscomboBox.Size = new Size(133, 24);
            CarscomboBox.TabIndex = 10;
            // 
            // rentDateDTP
            // 
            rentDateDTP.CustomFormat = "";
            rentDateDTP.Location = new Point(673, 86);
            rentDateDTP.Margin = new Padding(3, 2, 3, 2);
            rentDateDTP.Name = "rentDateDTP";
            rentDateDTP.Size = new Size(240, 27);
            rentDateDTP.TabIndex = 11;
            rentDateDTP.Value = new DateTime(2024, 10, 9, 11, 41, 40, 0);
            // 
            // rentReturnDTP
            // 
            rentReturnDTP.Location = new Point(711, 68);
            rentReturnDTP.Margin = new Padding(3, 2, 3, 2);
            rentReturnDTP.Name = "rentReturnDTP";
            rentReturnDTP.Size = new Size(240, 27);
            rentReturnDTP.TabIndex = 12;
            // 
            // rentsDataGridView
            // 
            rentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            rentsDataGridView.BackgroundColor = SystemColors.GradientActiveCaption;
            rentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rentsDataGridView.Location = new Point(27, 331);
            rentsDataGridView.Margin = new Padding(3, 2, 3, 2);
            rentsDataGridView.Name = "rentsDataGridView";
            rentsDataGridView.RowHeadersWidth = 51;
            rentsDataGridView.Size = new Size(996, 190);
            rentsDataGridView.TabIndex = 13;
            // 
            // titlePrincipalFormPanel
            // 
            titlePrincipalFormPanel.BackColor = SystemColors.ActiveCaption;
            titlePrincipalFormPanel.Controls.Add(tittleLabel);
            titlePrincipalFormPanel.Location = new Point(50, 11);
            titlePrincipalFormPanel.Margin = new Padding(3, 2, 3, 2);
            titlePrincipalFormPanel.Name = "titlePrincipalFormPanel";
            titlePrincipalFormPanel.Size = new Size(969, 45);
            titlePrincipalFormPanel.TabIndex = 15;
            // 
            // tittleLabel
            // 
            tittleLabel.AutoSize = true;
            tittleLabel.Font = new Font("Algerian", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tittleLabel.Location = new Point(332, 9);
            tittleLabel.Name = "tittleLabel";
            tittleLabel.Size = new Size(496, 41);
            tittleLabel.TabIndex = 0;
            tittleLabel.Text = "The Brothers Rent A Car";
            // 
            // newRentGroupBox
            // 
            newRentGroupBox.BackColor = SystemColors.ControlDark;
            newRentGroupBox.Controls.Add(returnTimeDTP);
            newRentGroupBox.Controls.Add(rentTimeDTP);
            newRentGroupBox.Controls.Add(returnTimeLabel);
            newRentGroupBox.Controls.Add(rentReturnDTP);
            newRentGroupBox.Controls.Add(rentTimeLabel);
            newRentGroupBox.Controls.Add(CarscomboBox);
            newRentGroupBox.Controls.Add(ClientscomboBox);
            newRentGroupBox.Controls.Add(rentReturnLabel);
            newRentGroupBox.Controls.Add(rentDateLabel);
            newRentGroupBox.Controls.Add(CarLabel);
            newRentGroupBox.Controls.Add(clientsLabel);
            newRentGroupBox.Controls.Add(carsButton);
            newRentGroupBox.Controls.Add(clientsButton);
            newRentGroupBox.Location = new Point(27, 72);
            newRentGroupBox.Name = "newRentGroupBox";
            newRentGroupBox.Size = new Size(992, 177);
            newRentGroupBox.TabIndex = 16;
            newRentGroupBox.TabStop = false;
            newRentGroupBox.Text = "Renta de Vehiculo";
            // 
            // returnTimeDTP
            // 
            returnTimeDTP.Format = DateTimePickerFormat.Time;
            returnTimeDTP.Location = new Point(662, 140);
            returnTimeDTP.Name = "returnTimeDTP";
            returnTimeDTP.ShowUpDown = true;
            returnTimeDTP.Size = new Size(250, 27);
            returnTimeDTP.TabIndex = 14;
            // 
            // rentTimeDTP
            // 
            rentTimeDTP.Format = DateTimePickerFormat.Time;
            rentTimeDTP.Location = new Point(662, 107);
            rentTimeDTP.Name = "rentTimeDTP";
            rentTimeDTP.ShowUpDown = true;
            rentTimeDTP.Size = new Size(250, 27);
            rentTimeDTP.TabIndex = 13;
            // 
            // returnTimeLabel
            // 
            returnTimeLabel.AutoSize = true;
            returnTimeLabel.Location = new Point(496, 143);
            returnTimeLabel.Name = "returnTimeLabel";
            returnTimeLabel.Size = new Size(130, 16);
            returnTimeLabel.TabIndex = 12;
            returnTimeLabel.Text = "hora de entrga";
            // 
            // rentTimeLabel
            // 
            rentTimeLabel.AutoSize = true;
            rentTimeLabel.Location = new Point(497, 107);
            rentTimeLabel.Name = "rentTimeLabel";
            rentTimeLabel.Size = new Size(124, 16);
            rentTimeLabel.TabIndex = 11;
            rentTimeLabel.Text = "hora de retiro";
            // 
            // RentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1153, 642);
            Controls.Add(titlePrincipalFormPanel);
            Controls.Add(saveRentButton);
            Controls.Add(rentsDataGridView);
            Controls.Add(rentDateDTP);
            Controls.Add(deleteRentButton);
            Controls.Add(editRentButton);
            Controls.Add(newRentGroupBox);
            Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RentForm";
            Text = "RentForm";
            FormClosing += RentForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)rentsDataGridView).EndInit();
            titlePrincipalFormPanel.ResumeLayout(false);
            titlePrincipalFormPanel.PerformLayout();
            newRentGroupBox.ResumeLayout(false);
            newRentGroupBox.PerformLayout();
            ResumeLayout(false);
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
        private DataGridView rentsDataGridView;
        private Panel titlePrincipalFormPanel;
        private Label tittleLabel;
        private GroupBox newRentGroupBox;
        private DateTimePicker returnTimeDTP;
        private DateTimePicker rentTimeDTP;
        private Label returnTimeLabel;
        private Label rentTimeLabel;
    }
}