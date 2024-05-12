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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.marcaCategoriaButton = new System.Windows.Forms.Button();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.marcaComboBox = new System.Windows.Forms.ComboBox();
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
            this.addImgButton = new System.Windows.Forms.Button();
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
            this.addButton.Location = new System.Drawing.Point(930, 444);
            this.addButton.Margin = new System.Windows.Forms.Padding(20, 3, 40, 3);
            this.addButton.Name = "addButton";
            this.addButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addButton.Size = new System.Drawing.Size(202, 33);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Agregar articulo nuevo";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // containerPanel1
            // 
            this.containerPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.containerPanel1.Controls.Add(this.label6);
            this.containerPanel1.Controls.Add(this.label1);
            this.containerPanel1.Controls.Add(this.marcaCategoriaButton);
            this.containerPanel1.Controls.Add(this.categoriaComboBox);
            this.containerPanel1.Controls.Add(this.marcaComboBox);
            this.containerPanel1.Controls.Add(this.btnReestablecer);
            this.containerPanel1.Controls.Add(this.buttonBuscarFiltro);
            this.containerPanel1.Controls.Add(this.textBoxFiltro);
            this.containerPanel1.Controls.Add(this.label5);
            this.containerPanel1.Controls.Add(this.label4);
            this.containerPanel1.Controls.Add(this.label2);
            this.containerPanel1.Controls.Add(this.label3);
            this.containerPanel1.Controls.Add(this.criterioComboBox);
            this.containerPanel1.Controls.Add(this.campoComboBox);
            this.containerPanel1.Location = new System.Drawing.Point(12, -8);
            this.containerPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.containerPanel1.Name = "containerPanel1";
            this.containerPanel1.Size = new System.Drawing.Size(1131, 105);
            this.containerPanel1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(489, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Marca";
            // 
            // marcaCategoriaButton
            // 
            this.marcaCategoriaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.marcaCategoriaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(95)))));
            this.marcaCategoriaButton.FlatAppearance.BorderSize = 2;
            this.marcaCategoriaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.marcaCategoriaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.marcaCategoriaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(95)))));
            this.marcaCategoriaButton.Image = ((System.Drawing.Image)(resources.GetObject("marcaCategoriaButton.Image")));
            this.marcaCategoriaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.marcaCategoriaButton.Location = new System.Drawing.Point(314, 59);
            this.marcaCategoriaButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.marcaCategoriaButton.Name = "marcaCategoriaButton";
            this.marcaCategoriaButton.Size = new System.Drawing.Size(247, 33);
            this.marcaCategoriaButton.TabIndex = 12;
            this.marcaCategoriaButton.Text = "Modificar filtros Marca/Categoria";
            this.marcaCategoriaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.marcaCategoriaButton.UseVisualStyleBackColor = false;
            this.marcaCategoriaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(445, 28);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(150, 21);
            this.categoriaComboBox.TabIndex = 14;
            this.categoriaComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // marcaComboBox
            // 
            this.marcaComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.marcaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marcaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.marcaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaComboBox.FormattingEnabled = true;
            this.marcaComboBox.Location = new System.Drawing.Point(277, 28);
            this.marcaComboBox.Name = "marcaComboBox";
            this.marcaComboBox.Size = new System.Drawing.Size(150, 21);
            this.marcaComboBox.TabIndex = 13;
            this.marcaComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.btnReestablecer.Location = new System.Drawing.Point(980, 63);
            this.btnReestablecer.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(132, 33);
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
            this.buttonBuscarFiltro.Location = new System.Drawing.Point(980, 24);
            this.buttonBuscarFiltro.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.buttonBuscarFiltro.Name = "buttonBuscarFiltro";
            this.buttonBuscarFiltro.Size = new System.Drawing.Size(132, 33);
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
            this.textBoxFiltro.Location = new System.Drawing.Point(672, 72);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(246, 20);
            this.textBoxFiltro.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(681, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ingrese palabra clave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(854, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Criterio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filtros de Busqueda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(669, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Campo";
            // 
            // criterioComboBox
            // 
            this.criterioComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.criterioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.criterioComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.criterioComboBox.FormattingEnabled = true;
            this.criterioComboBox.Location = new System.Drawing.Point(810, 28);
            this.criterioComboBox.Name = "criterioComboBox";
            this.criterioComboBox.Size = new System.Drawing.Size(150, 21);
            this.criterioComboBox.TabIndex = 2;
            // 
            // campoComboBox
            // 
            this.campoComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.campoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.campoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoComboBox.FormattingEnabled = true;
            this.campoComboBox.Location = new System.Drawing.Point(621, 28);
            this.campoComboBox.Name = "campoComboBox";
            this.campoComboBox.Size = new System.Drawing.Size(150, 21);
            this.campoComboBox.TabIndex = 1;
            this.campoComboBox.SelectedIndexChanged += new System.EventHandler(this.CbxCampo_SelectedIndexChanged);
            // 
            // containerPanel2
            // 
            this.containerPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.containerPanel2.Controls.Add(this.addImgButton);
            this.containerPanel2.Controls.Add(this.siguienteImgButton);
            this.containerPanel2.Controls.Add(this.dgvArticulos);
            this.containerPanel2.Controls.Add(this.articleImage);
            this.containerPanel2.Location = new System.Drawing.Point(12, 117);
            this.containerPanel2.Name = "containerPanel2";
            this.containerPanel2.Size = new System.Drawing.Size(1131, 309);
            this.containerPanel2.TabIndex = 9;
            // 
            // addImgButton
            // 
            this.addImgButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(95)))));
            this.addImgButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(95)))));
            this.addImgButton.FlatAppearance.BorderSize = 2;
            this.addImgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addImgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addImgButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.addImgButton.Image = ((System.Drawing.Image)(resources.GetObject("addImgButton.Image")));
            this.addImgButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addImgButton.Location = new System.Drawing.Point(20, 260);
            this.addImgButton.Margin = new System.Windows.Forms.Padding(20, 3, 40, 3);
            this.addImgButton.Name = "addImgButton";
            this.addImgButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addImgButton.Size = new System.Drawing.Size(195, 33);
            this.addImgButton.TabIndex = 12;
            this.addImgButton.Text = "Añadir imagen nueva";
            this.addImgButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addImgButton.UseVisualStyleBackColor = false;
            this.addImgButton.Click += new System.EventHandler(this.addImgButton_Click);
            // 
            // siguienteImgButton
            // 
            this.siguienteImgButton.BackColor = System.Drawing.Color.Transparent;
            this.siguienteImgButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("siguienteImgButton.BackgroundImage")));
            this.siguienteImgButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.siguienteImgButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siguienteImgButton.Location = new System.Drawing.Point(258, 260);
            this.siguienteImgButton.Name = "siguienteImgButton";
            this.siguienteImgButton.Size = new System.Drawing.Size(33, 33);
            this.siguienteImgButton.TabIndex = 12;
            this.siguienteImgButton.TabStop = false;
            this.siguienteImgButton.Click += new System.EventHandler(this.siguienteImgButton_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(314, 0);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 82;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(817, 309);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // articleImage
            // 
            this.articleImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.articleImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("articleImage.ErrorImage")));
            this.articleImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("articleImage.InitialImage")));
            this.articleImage.Location = new System.Drawing.Point(5, 5);
            this.articleImage.Name = "articleImage";
            this.articleImage.Size = new System.Drawing.Size(299, 299);
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
            this.modifyButton.Location = new System.Drawing.Point(645, 444);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(240, 33);
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
            this.deleteButton.Location = new System.Drawing.Point(61, 444);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(40, 3, 20, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(215, 33);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Borrar articulo seleccionado";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1158, 501);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.containerPanel2);
            this.Controls.Add(this.containerPanel1);
            this.Controls.Add(this.addButton);
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
        private System.Windows.Forms.Button addImgButton;
        private System.Windows.Forms.Button marcaCategoriaButton;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.ComboBox marcaComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}

