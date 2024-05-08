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
            this.containerPanel1 = new System.Windows.Forms.Panel();
            this.btnReestablecer = new System.Windows.Forms.Button();
            this.buttonBuscarFiltro = new System.Windows.Forms.Button();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.criterioComboBox = new System.Windows.Forms.ComboBox();
            this.campoComboBox = new System.Windows.Forms.ComboBox();
            this.containerPanel2 = new System.Windows.Forms.Panel();
            this.siguienteImgButton = new System.Windows.Forms.PictureBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.articleImage = new System.Windows.Forms.PictureBox();
            this.modifyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.containerPanel1.SuspendLayout();
            this.containerPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siguienteImgButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
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
            this.addButton.Location = new System.Drawing.Point(1861, 854);
            this.addButton.Margin = new System.Windows.Forms.Padding(40, 6, 80, 6);
            this.addButton.Name = "addButton";
            this.addButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addButton.Size = new System.Drawing.Size(404, 63);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Agregar articulo nuevo";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // containerPanel1
            // 
            this.containerPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.containerPanel1.Controls.Add(this.btnReestablecer);
            this.containerPanel1.Controls.Add(this.buttonBuscarFiltro);
            this.containerPanel1.Controls.Add(this.textBoxFiltro);
            this.containerPanel1.Controls.Add(this.label5);
            this.containerPanel1.Controls.Add(this.label4);
            this.containerPanel1.Controls.Add(this.label2);
            this.containerPanel1.Controls.Add(this.label3);
            this.containerPanel1.Controls.Add(this.criterioComboBox);
            this.containerPanel1.Controls.Add(this.campoComboBox);
            this.containerPanel1.Location = new System.Drawing.Point(24, -15);
            this.containerPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 60, 6);
            this.containerPanel1.Name = "containerPanel1";
            this.containerPanel1.Size = new System.Drawing.Size(2262, 202);
            this.containerPanel1.TabIndex = 7;
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnReestablecer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(95)))));
            this.btnReestablecer.FlatAppearance.BorderSize = 2;
            this.btnReestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReestablecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnReestablecer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(95)))));
            this.btnReestablecer.Image = ((System.Drawing.Image)(resources.GetObject("btnReestablecer.Image")));
            this.btnReestablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReestablecer.Location = new System.Drawing.Point(1961, 121);
            this.btnReestablecer.Margin = new System.Windows.Forms.Padding(40, 6, 40, 6);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(263, 63);
            this.btnReestablecer.TabIndex = 12;
            this.btnReestablecer.Text = "Reestablecer";
            this.btnReestablecer.UseVisualStyleBackColor = false;
            this.btnReestablecer.Click += new System.EventHandler(this.btnReestablecer_Click);
            // 
            // buttonBuscarFiltro
            // 
            this.buttonBuscarFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.buttonBuscarFiltro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(95)))));
            this.buttonBuscarFiltro.FlatAppearance.BorderSize = 2;
            this.buttonBuscarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonBuscarFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(95)))));
            this.buttonBuscarFiltro.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarFiltro.Image")));
            this.buttonBuscarFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscarFiltro.Location = new System.Drawing.Point(1961, 46);
            this.buttonBuscarFiltro.Margin = new System.Windows.Forms.Padding(40, 6, 40, 6);
            this.buttonBuscarFiltro.Name = "buttonBuscarFiltro";
            this.buttonBuscarFiltro.Size = new System.Drawing.Size(263, 63);
            this.buttonBuscarFiltro.TabIndex = 11;
            this.buttonBuscarFiltro.Text = "Aplicar";
            this.buttonBuscarFiltro.UseVisualStyleBackColor = false;
            this.buttonBuscarFiltro.Click += new System.EventHandler(this.buttonBuscarFiltro_Click);
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBoxFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFiltro.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxFiltro.Location = new System.Drawing.Point(1404, 102);
            this.textBoxFiltro.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(491, 31);
            this.textBoxFiltro.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1422, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ingrese el filtro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1094, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Criterio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(526, 63);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filtros de Busqueda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(724, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Campo";
            // 
            // criterioComboBox
            // 
            this.criterioComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.criterioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.criterioComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.criterioComboBox.FormattingEnabled = true;
            this.criterioComboBox.Location = new System.Drawing.Point(1006, 100);
            this.criterioComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.criterioComboBox.Name = "criterioComboBox";
            this.criterioComboBox.Size = new System.Drawing.Size(296, 33);
            this.criterioComboBox.TabIndex = 2;
            // 
            // campoComboBox
            // 
            this.campoComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.campoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.campoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoComboBox.FormattingEnabled = true;
            this.campoComboBox.Location = new System.Drawing.Point(628, 100);
            this.campoComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.campoComboBox.Name = "campoComboBox";
            this.campoComboBox.Size = new System.Drawing.Size(296, 34);
            this.campoComboBox.TabIndex = 1;
            this.campoComboBox.SelectedIndexChanged += new System.EventHandler(this.CbxCampo_SelectedIndexChanged);
            // 
            // containerPanel2
            // 
            this.containerPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.containerPanel2.Controls.Add(this.siguienteImgButton);
            this.containerPanel2.Controls.Add(this.dgvArticulos);
            this.containerPanel2.Controls.Add(this.articleImage);
            this.containerPanel2.Location = new System.Drawing.Point(24, 225);
            this.containerPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.containerPanel2.Name = "containerPanel2";
            this.containerPanel2.Size = new System.Drawing.Size(2262, 594);
            this.containerPanel2.TabIndex = 9;
            // 
            // siguienteImgButton
            // 
            this.siguienteImgButton.BackColor = System.Drawing.Color.Transparent;
            this.siguienteImgButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("siguienteImgButton.BackgroundImage")));
            this.siguienteImgButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.siguienteImgButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siguienteImgButton.Location = new System.Drawing.Point(528, 510);
            this.siguienteImgButton.Margin = new System.Windows.Forms.Padding(6);
            this.siguienteImgButton.Name = "siguienteImgButton";
            this.siguienteImgButton.Size = new System.Drawing.Size(54, 54);
            this.siguienteImgButton.TabIndex = 12;
            this.siguienteImgButton.TabStop = false;
            this.siguienteImgButton.Click += new System.EventHandler(this.siguienteImgButton_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(628, 0);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(6);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 82;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(1634, 594);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // articleImage
            // 
            this.articleImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.articleImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("articleImage.ErrorImage")));
            this.articleImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("articleImage.InitialImage")));
            this.articleImage.Location = new System.Drawing.Point(10, 10);
            this.articleImage.Margin = new System.Windows.Forms.Padding(6);
            this.articleImage.Name = "articleImage";
            this.articleImage.Size = new System.Drawing.Size(594, 571);
            this.articleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.modifyButton.Location = new System.Drawing.Point(1290, 854);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(40, 6, 40, 6);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(480, 63);
            this.modifyButton.TabIndex = 10;
            this.modifyButton.Text = "Modificar articulo seleccionado";
            this.modifyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.deleteButton.Location = new System.Drawing.Point(122, 854);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(80, 6, 40, 6);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(430, 63);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Borrar articulo seleccionado";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(2316, 963);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.containerPanel2);
            this.Controls.Add(this.containerPanel1);
            this.Controls.Add(this.addButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmPrincipal";
            this.Text = "Ventana Princial";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.containerPanel1.ResumeLayout(false);
            this.containerPanel1.PerformLayout();
            this.containerPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siguienteImgButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel containerPanel1;
        private System.Windows.Forms.ComboBox criterioComboBox;
        private System.Windows.Forms.ComboBox campoComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel containerPanel2;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox articleImage;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonBuscarFiltro;
        private System.Windows.Forms.PictureBox siguienteImgButton;
        private System.Windows.Forms.Button btnReestablecer;
    }
}

