namespace tpWinformGroup9
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.addButton = new System.Windows.Forms.Button();
            this.articleListComboBox = new System.Windows.Forms.ComboBox();
            this.containerPanel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.containerPanel2 = new System.Windows.Forms.Panel();
            this.articleDataGrid = new System.Windows.Forms.DataGridView();
            this.articleImage = new System.Windows.Forms.PictureBox();
            this.modifyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.containerPanel1.SuspendLayout();
            this.containerPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articleDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(95)))));
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(95)))));
            this.addButton.FlatAppearance.BorderSize = 2;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.Location = new System.Drawing.Point(1546, 835);
            this.addButton.Margin = new System.Windows.Forms.Padding(40, 6, 80, 6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(244, 63);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // articleListComboBox
            // 
            this.articleListComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.articleListComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.articleListComboBox.FormattingEnabled = true;
            this.articleListComboBox.Location = new System.Drawing.Point(78, 121);
            this.articleListComboBox.Margin = new System.Windows.Forms.Padding(60, 6, 6, 6);
            this.articleListComboBox.Name = "articleListComboBox";
            this.articleListComboBox.Size = new System.Drawing.Size(878, 33);
            this.articleListComboBox.TabIndex = 5;
            // 
            // containerPanel1
            // 
            this.containerPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.containerPanel1.Controls.Add(this.label4);
            this.containerPanel1.Controls.Add(this.label3);
            this.containerPanel1.Controls.Add(this.categoryComboBox);
            this.containerPanel1.Controls.Add(this.brandComboBox);
            this.containerPanel1.Controls.Add(this.label1);
            this.containerPanel1.Location = new System.Drawing.Point(1034, -25);
            this.containerPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 60, 6);
            this.containerPanel1.Name = "containerPanel1";
            this.containerPanel1.Size = new System.Drawing.Size(776, 187);
            this.containerPanel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.categoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(426, 121);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(296, 33);
            this.categoryComboBox.TabIndex = 2;
            // 
            // brandComboBox
            // 
            this.brandComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.brandComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brandComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(44, 121);
            this.brandComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(296, 34);
            this.brandComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtros de Busqueda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 63);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lista de Articulos";
            // 
            // containerPanel2
            // 
            this.containerPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.containerPanel2.Controls.Add(this.articleDataGrid);
            this.containerPanel2.Controls.Add(this.articleImage);
            this.containerPanel2.Location = new System.Drawing.Point(24, 196);
            this.containerPanel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.containerPanel2.Name = "containerPanel2";
            this.containerPanel2.Size = new System.Drawing.Size(1840, 594);
            this.containerPanel2.TabIndex = 9;
            // 
            // articleDataGrid
            // 
            this.articleDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.articleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articleDataGrid.Location = new System.Drawing.Point(628, 0);
            this.articleDataGrid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.articleDataGrid.Name = "articleDataGrid";
            this.articleDataGrid.RowHeadersWidth = 82;
            this.articleDataGrid.Size = new System.Drawing.Size(1212, 594);
            this.articleDataGrid.TabIndex = 1;
            // 
            // articleImage
            // 
            this.articleImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("articleImage.ErrorImage")));
            this.articleImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("articleImage.InitialImage")));
            this.articleImage.Location = new System.Drawing.Point(10, 10);
            this.articleImage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.articleImage.Name = "articleImage";
            this.articleImage.Size = new System.Drawing.Size(598, 575);
            this.articleImage.TabIndex = 0;
            this.articleImage.TabStop = false;
            // 
            // modifyButton
            // 
            this.modifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.modifyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(95)))));
            this.modifyButton.FlatAppearance.BorderSize = 2;
            this.modifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.modifyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(95)))));
            this.modifyButton.Image = ((System.Drawing.Image)(resources.GetObject("modifyButton.Image")));
            this.modifyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modifyButton.Location = new System.Drawing.Point(1222, 835);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(40, 6, 40, 6);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(244, 63);
            this.modifyButton.TabIndex = 10;
            this.modifyButton.Text = "Modificar";
            this.modifyButton.UseVisualStyleBackColor = false;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(108)))), ((int)(((byte)(85)))));
            this.deleteButton.FlatAppearance.BorderSize = 2;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(108)))), ((int)(((byte)(85)))));
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.Location = new System.Drawing.Point(98, 835);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(80, 6, 40, 6);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(244, 63);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Borrar";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1888, 963);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.containerPanel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.containerPanel1);
            this.Controls.Add(this.articleListComboBox);
            this.Controls.Add(this.addButton);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmPrincipal";
            this.Text = "Ventana Princial";
            this.containerPanel1.ResumeLayout(false);
            this.containerPanel1.PerformLayout();
            this.containerPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.articleDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox articleListComboBox;
        private System.Windows.Forms.Panel containerPanel1;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel containerPanel2;
        private System.Windows.Forms.DataGridView articleDataGrid;
        private System.Windows.Forms.PictureBox articleImage;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

