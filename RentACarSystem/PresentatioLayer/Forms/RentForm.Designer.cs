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
            SuspendLayout();
            // 
            // clientsButton
            // 
            clientsButton.Location = new Point(12, 12);
            clientsButton.Name = "clientsButton";
            clientsButton.Size = new Size(175, 29);
            clientsButton.TabIndex = 0;
            clientsButton.Text = "agregar nuevo cliente";
            clientsButton.UseVisualStyleBackColor = true;
            clientsButton.Click += clientsButton_Click;
            // 
            // carsButton
            // 
            carsButton.Location = new Point(807, 12);
            carsButton.Name = "carsButton";
            carsButton.Size = new Size(171, 29);
            carsButton.TabIndex = 1;
            carsButton.Text = "agregar nuevo carro";
            carsButton.UseVisualStyleBackColor = true;
            carsButton.Click += carsButton_Click;
            // 
            // RentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 593);
            Controls.Add(carsButton);
            Controls.Add(clientsButton);
            Name = "RentForm";
            Text = "RentForm";
            FormClosing += RentForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button clientsButton;
        private Button carsButton;
    }
}