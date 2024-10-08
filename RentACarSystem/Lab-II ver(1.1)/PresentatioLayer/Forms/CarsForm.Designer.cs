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
            ((System.ComponentModel.ISupportInitialize)CarsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // CarsDataGridView
            // 
            CarsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarsDataGridView.Location = new Point(88, 150);
            CarsDataGridView.Name = "CarsDataGridView";
            CarsDataGridView.RowHeadersWidth = 51;
            CarsDataGridView.Size = new Size(629, 188);
            CarsDataGridView.TabIndex = 0;
            // 
            // CarsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CarsDataGridView);
            Name = "CarsForm";
            Text = "CarsForm";
            ((System.ComponentModel.ISupportInitialize)CarsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CarsDataGridView;
    }
}