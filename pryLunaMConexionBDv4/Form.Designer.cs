namespace pryLunaMConexionBDv4
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRecargarAgregar = new System.Windows.Forms.Button();
            this.dgvAgregar = new System.Windows.Forms.DataGridView();
            this.lblCategoriaAgregar = new MaterialSkin.Controls.MaterialLabel();
            this.txtStockAgregar = new MaterialSkin.Controls.MaterialTextBox();
            this.lblStockAgregar = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrecioAgregar = new MaterialSkin.Controls.MaterialTextBox();
            this.lblPrecioAgregar = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescripcionAgregar = new MaterialSkin.Controls.MaterialTextBox();
            this.lblDescripcionAgregar = new MaterialSkin.Controls.MaterialLabel();
            this.cmbCategoriaAgregar = new MaterialSkin.Controls.MaterialComboBox();
            this.txtNombreAgregar = new MaterialSkin.Controls.MaterialTextBox();
            this.lblNombreAgregar = new MaterialSkin.Controls.MaterialLabel();
            this.btnAgregarProducto = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRecargarModificar = new System.Windows.Forms.Button();
            this.dgvModificar = new System.Windows.Forms.DataGridView();
            this.btnModificarProducto = new MaterialSkin.Controls.MaterialButton();
            this.lblCategoriaModificar = new MaterialSkin.Controls.MaterialLabel();
            this.txtStockModificar = new MaterialSkin.Controls.MaterialTextBox();
            this.lblStockModificar = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrecioModificar = new MaterialSkin.Controls.MaterialTextBox();
            this.lblPrecioModificar = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescripcionModificar = new MaterialSkin.Controls.MaterialTextBox();
            this.lblDescripcionModificar = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreModificar = new MaterialSkin.Controls.MaterialTextBox();
            this.lblNombreModificar = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdModificar = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbCategoriaModificar = new MaterialSkin.Controls.MaterialComboBox();
            this.btnBuscarIdModificar = new MaterialSkin.Controls.MaterialButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBuscarIdEliminar = new MaterialSkin.Controls.MaterialButton();
            this.cmbCategoriaEliminar = new MaterialSkin.Controls.MaterialComboBox();
            this.lblCategoriaEliminar = new MaterialSkin.Controls.MaterialLabel();
            this.txtStockEliminar = new MaterialSkin.Controls.MaterialTextBox();
            this.lblStockEliminar = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrecioEliminar = new MaterialSkin.Controls.MaterialTextBox();
            this.lblPrecioEliminar = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescripcionEliminar = new MaterialSkin.Controls.MaterialTextBox();
            this.lblDescripcionEliminar = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreEliminar = new MaterialSkin.Controls.MaterialTextBox();
            this.lblNombreEliminar = new MaterialSkin.Controls.MaterialLabel();
            this.btnRecargarEliminar = new System.Windows.Forms.Button();
            this.dgvEliminar = new System.Windows.Forms.DataGridView();
            this.txtIdEliminar = new MaterialSkin.Controls.MaterialTextBox();
            this.lblIdEliminar = new MaterialSkin.Controls.MaterialLabel();
            this.btnEliminarProductoPorID = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1181, 571);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnRecargarAgregar);
            this.tabPage1.Controls.Add(this.dgvAgregar);
            this.tabPage1.Controls.Add(this.lblCategoriaAgregar);
            this.tabPage1.Controls.Add(this.txtStockAgregar);
            this.tabPage1.Controls.Add(this.lblStockAgregar);
            this.tabPage1.Controls.Add(this.txtPrecioAgregar);
            this.tabPage1.Controls.Add(this.lblPrecioAgregar);
            this.tabPage1.Controls.Add(this.txtDescripcionAgregar);
            this.tabPage1.Controls.Add(this.lblDescripcionAgregar);
            this.tabPage1.Controls.Add(this.cmbCategoriaAgregar);
            this.tabPage1.Controls.Add(this.txtNombreAgregar);
            this.tabPage1.Controls.Add(this.lblNombreAgregar);
            this.tabPage1.Controls.Add(this.btnAgregarProducto);
            this.tabPage1.ImageKey = "duplicate_12108396.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1173, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Producto";
            // 
            // btnRecargarAgregar
            // 
            this.btnRecargarAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargarAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecargarAgregar.BackgroundImage")));
            this.btnRecargarAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecargarAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnRecargarAgregar.FlatAppearance.BorderSize = 0;
            this.btnRecargarAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargarAgregar.ImageKey = "sync_3287348.png";
            this.btnRecargarAgregar.Location = new System.Drawing.Point(1069, 454);
            this.btnRecargarAgregar.Name = "btnRecargarAgregar";
            this.btnRecargarAgregar.Size = new System.Drawing.Size(53, 45);
            this.btnRecargarAgregar.TabIndex = 11;
            this.btnRecargarAgregar.UseVisualStyleBackColor = false;
            this.btnRecargarAgregar.Click += new System.EventHandler(this.btnRecargarAgregar_Click);
            // 
            // dgvAgregar
            // 
            this.dgvAgregar.AllowUserToAddRows = false;
            this.dgvAgregar.AllowUserToDeleteRows = false;
            this.dgvAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregar.Location = new System.Drawing.Point(458, 25);
            this.dgvAgregar.MultiSelect = false;
            this.dgvAgregar.Name = "dgvAgregar";
            this.dgvAgregar.ReadOnly = true;
            this.dgvAgregar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgregar.Size = new System.Drawing.Size(664, 415);
            this.dgvAgregar.TabIndex = 6;
            // 
            // lblCategoriaAgregar
            // 
            this.lblCategoriaAgregar.AutoSize = true;
            this.lblCategoriaAgregar.Depth = 0;
            this.lblCategoriaAgregar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCategoriaAgregar.Location = new System.Drawing.Point(28, 374);
            this.lblCategoriaAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoriaAgregar.Name = "lblCategoriaAgregar";
            this.lblCategoriaAgregar.Size = new System.Drawing.Size(73, 19);
            this.lblCategoriaAgregar.TabIndex = 10;
            this.lblCategoriaAgregar.Text = "Categoria:";
            // 
            // txtStockAgregar
            // 
            this.txtStockAgregar.AnimateReadOnly = false;
            this.txtStockAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStockAgregar.Depth = 0;
            this.txtStockAgregar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStockAgregar.LeadingIcon = null;
            this.txtStockAgregar.Location = new System.Drawing.Point(154, 278);
            this.txtStockAgregar.MaxLength = 50;
            this.txtStockAgregar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtStockAgregar.Multiline = false;
            this.txtStockAgregar.Name = "txtStockAgregar";
            this.txtStockAgregar.Size = new System.Drawing.Size(275, 50);
            this.txtStockAgregar.TabIndex = 3;
            this.txtStockAgregar.Text = "";
            this.txtStockAgregar.TrailingIcon = null;
            // 
            // lblStockAgregar
            // 
            this.lblStockAgregar.AutoSize = true;
            this.lblStockAgregar.Depth = 0;
            this.lblStockAgregar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStockAgregar.Location = new System.Drawing.Point(28, 293);
            this.lblStockAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStockAgregar.Name = "lblStockAgregar";
            this.lblStockAgregar.Size = new System.Drawing.Size(45, 19);
            this.lblStockAgregar.TabIndex = 8;
            this.lblStockAgregar.Text = "Stock:";
            // 
            // txtPrecioAgregar
            // 
            this.txtPrecioAgregar.AnimateReadOnly = false;
            this.txtPrecioAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioAgregar.Depth = 0;
            this.txtPrecioAgregar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioAgregar.LeadingIcon = null;
            this.txtPrecioAgregar.Location = new System.Drawing.Point(154, 194);
            this.txtPrecioAgregar.MaxLength = 50;
            this.txtPrecioAgregar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioAgregar.Multiline = false;
            this.txtPrecioAgregar.Name = "txtPrecioAgregar";
            this.txtPrecioAgregar.Size = new System.Drawing.Size(275, 50);
            this.txtPrecioAgregar.TabIndex = 2;
            this.txtPrecioAgregar.Text = "";
            this.txtPrecioAgregar.TrailingIcon = null;
            // 
            // lblPrecioAgregar
            // 
            this.lblPrecioAgregar.AutoSize = true;
            this.lblPrecioAgregar.Depth = 0;
            this.lblPrecioAgregar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrecioAgregar.Location = new System.Drawing.Point(28, 209);
            this.lblPrecioAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecioAgregar.Name = "lblPrecioAgregar";
            this.lblPrecioAgregar.Size = new System.Drawing.Size(49, 19);
            this.lblPrecioAgregar.TabIndex = 6;
            this.lblPrecioAgregar.Text = "Precio:";
            // 
            // txtDescripcionAgregar
            // 
            this.txtDescripcionAgregar.AnimateReadOnly = false;
            this.txtDescripcionAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcionAgregar.Depth = 0;
            this.txtDescripcionAgregar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescripcionAgregar.LeadingIcon = null;
            this.txtDescripcionAgregar.Location = new System.Drawing.Point(154, 106);
            this.txtDescripcionAgregar.MaxLength = 50;
            this.txtDescripcionAgregar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescripcionAgregar.Multiline = false;
            this.txtDescripcionAgregar.Name = "txtDescripcionAgregar";
            this.txtDescripcionAgregar.Size = new System.Drawing.Size(275, 50);
            this.txtDescripcionAgregar.TabIndex = 1;
            this.txtDescripcionAgregar.Text = "";
            this.txtDescripcionAgregar.TrailingIcon = null;
            // 
            // lblDescripcionAgregar
            // 
            this.lblDescripcionAgregar.AutoSize = true;
            this.lblDescripcionAgregar.Depth = 0;
            this.lblDescripcionAgregar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescripcionAgregar.Location = new System.Drawing.Point(28, 121);
            this.lblDescripcionAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcionAgregar.Name = "lblDescripcionAgregar";
            this.lblDescripcionAgregar.Size = new System.Drawing.Size(88, 19);
            this.lblDescripcionAgregar.TabIndex = 4;
            this.lblDescripcionAgregar.Text = "Descripcion:";
            // 
            // cmbCategoriaAgregar
            // 
            this.cmbCategoriaAgregar.AutoResize = false;
            this.cmbCategoriaAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCategoriaAgregar.Depth = 0;
            this.cmbCategoriaAgregar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCategoriaAgregar.DropDownHeight = 174;
            this.cmbCategoriaAgregar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaAgregar.DropDownWidth = 121;
            this.cmbCategoriaAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCategoriaAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCategoriaAgregar.FormattingEnabled = true;
            this.cmbCategoriaAgregar.IntegralHeight = false;
            this.cmbCategoriaAgregar.ItemHeight = 43;
            this.cmbCategoriaAgregar.Location = new System.Drawing.Point(154, 356);
            this.cmbCategoriaAgregar.MaxDropDownItems = 4;
            this.cmbCategoriaAgregar.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCategoriaAgregar.Name = "cmbCategoriaAgregar";
            this.cmbCategoriaAgregar.Size = new System.Drawing.Size(275, 49);
            this.cmbCategoriaAgregar.StartIndex = 0;
            this.cmbCategoriaAgregar.TabIndex = 4;
            // 
            // txtNombreAgregar
            // 
            this.txtNombreAgregar.AnimateReadOnly = false;
            this.txtNombreAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreAgregar.Depth = 0;
            this.txtNombreAgregar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreAgregar.LeadingIcon = null;
            this.txtNombreAgregar.Location = new System.Drawing.Point(154, 25);
            this.txtNombreAgregar.MaxLength = 50;
            this.txtNombreAgregar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreAgregar.Multiline = false;
            this.txtNombreAgregar.Name = "txtNombreAgregar";
            this.txtNombreAgregar.Size = new System.Drawing.Size(275, 50);
            this.txtNombreAgregar.TabIndex = 0;
            this.txtNombreAgregar.Text = "";
            this.txtNombreAgregar.TrailingIcon = null;
            // 
            // lblNombreAgregar
            // 
            this.lblNombreAgregar.AutoSize = true;
            this.lblNombreAgregar.Depth = 0;
            this.lblNombreAgregar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombreAgregar.Location = new System.Drawing.Point(28, 40);
            this.lblNombreAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreAgregar.Name = "lblNombreAgregar";
            this.lblNombreAgregar.Size = new System.Drawing.Size(61, 19);
            this.lblNombreAgregar.TabIndex = 1;
            this.lblNombreAgregar.Text = "Nombre:";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarProducto.Depth = 0;
            this.btnAgregarProducto.HighEmphasis = true;
            this.btnAgregarProducto.Icon = null;
            this.btnAgregarProducto.Location = new System.Drawing.Point(109, 441);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarProducto.Size = new System.Drawing.Size(168, 36);
            this.btnAgregarProducto.TabIndex = 5;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarProducto.UseAccentColor = false;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRecargarModificar);
            this.tabPage2.Controls.Add(this.dgvModificar);
            this.tabPage2.Controls.Add(this.btnModificarProducto);
            this.tabPage2.Controls.Add(this.lblCategoriaModificar);
            this.tabPage2.Controls.Add(this.txtStockModificar);
            this.tabPage2.Controls.Add(this.lblStockModificar);
            this.tabPage2.Controls.Add(this.txtPrecioModificar);
            this.tabPage2.Controls.Add(this.lblPrecioModificar);
            this.tabPage2.Controls.Add(this.txtDescripcionModificar);
            this.tabPage2.Controls.Add(this.lblDescripcionModificar);
            this.tabPage2.Controls.Add(this.txtNombreModificar);
            this.tabPage2.Controls.Add(this.lblNombreModificar);
            this.tabPage2.Controls.Add(this.txtIdModificar);
            this.tabPage2.Controls.Add(this.materialLabel1);
            this.tabPage2.Controls.Add(this.cmbCategoriaModificar);
            this.tabPage2.Controls.Add(this.btnBuscarIdModificar);
            this.tabPage2.ImageKey = "engineering_18642986.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1173, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Producto";
            // 
            // btnRecargarModificar
            // 
            this.btnRecargarModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargarModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecargarModificar.BackgroundImage")));
            this.btnRecargarModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecargarModificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnRecargarModificar.FlatAppearance.BorderSize = 0;
            this.btnRecargarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargarModificar.ImageKey = "sync_3287348.png";
            this.btnRecargarModificar.Location = new System.Drawing.Point(1065, 454);
            this.btnRecargarModificar.Name = "btnRecargarModificar";
            this.btnRecargarModificar.Size = new System.Drawing.Size(53, 45);
            this.btnRecargarModificar.TabIndex = 13;
            this.btnRecargarModificar.UseVisualStyleBackColor = false;
            this.btnRecargarModificar.Click += new System.EventHandler(this.btnRecargarModificar_Click);
            // 
            // dgvModificar
            // 
            this.dgvModificar.AllowUserToAddRows = false;
            this.dgvModificar.AllowUserToDeleteRows = false;
            this.dgvModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificar.Location = new System.Drawing.Point(432, 31);
            this.dgvModificar.MultiSelect = false;
            this.dgvModificar.Name = "dgvModificar";
            this.dgvModificar.ReadOnly = true;
            this.dgvModificar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModificar.Size = new System.Drawing.Size(686, 397);
            this.dgvModificar.TabIndex = 8;
            this.dgvModificar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModificar_CellClick);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificarProducto.Depth = 0;
            this.btnModificarProducto.HighEmphasis = true;
            this.btnModificarProducto.Icon = null;
            this.btnModificarProducto.Location = new System.Drawing.Point(130, 448);
            this.btnModificarProducto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificarProducto.Size = new System.Drawing.Size(180, 36);
            this.btnModificarProducto.TabIndex = 7;
            this.btnModificarProducto.Text = "Modificar Producto";
            this.btnModificarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificarProducto.UseAccentColor = false;
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // lblCategoriaModificar
            // 
            this.lblCategoriaModificar.AutoSize = true;
            this.lblCategoriaModificar.Depth = 0;
            this.lblCategoriaModificar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCategoriaModificar.Location = new System.Drawing.Point(28, 394);
            this.lblCategoriaModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoriaModificar.Name = "lblCategoriaModificar";
            this.lblCategoriaModificar.Size = new System.Drawing.Size(73, 19);
            this.lblCategoriaModificar.TabIndex = 12;
            this.lblCategoriaModificar.Text = "Categoria:";
            // 
            // txtStockModificar
            // 
            this.txtStockModificar.AnimateReadOnly = false;
            this.txtStockModificar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStockModificar.Depth = 0;
            this.txtStockModificar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStockModificar.LeadingIcon = null;
            this.txtStockModificar.Location = new System.Drawing.Point(153, 310);
            this.txtStockModificar.MaxLength = 50;
            this.txtStockModificar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtStockModificar.Multiline = false;
            this.txtStockModificar.Name = "txtStockModificar";
            this.txtStockModificar.Size = new System.Drawing.Size(220, 50);
            this.txtStockModificar.TabIndex = 5;
            this.txtStockModificar.Text = "";
            this.txtStockModificar.TrailingIcon = null;
            // 
            // lblStockModificar
            // 
            this.lblStockModificar.AutoSize = true;
            this.lblStockModificar.Depth = 0;
            this.lblStockModificar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStockModificar.Location = new System.Drawing.Point(28, 325);
            this.lblStockModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStockModificar.Name = "lblStockModificar";
            this.lblStockModificar.Size = new System.Drawing.Size(45, 19);
            this.lblStockModificar.TabIndex = 10;
            this.lblStockModificar.Text = "Stock:";
            // 
            // txtPrecioModificar
            // 
            this.txtPrecioModificar.AnimateReadOnly = false;
            this.txtPrecioModificar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioModificar.Depth = 0;
            this.txtPrecioModificar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioModificar.LeadingIcon = null;
            this.txtPrecioModificar.Location = new System.Drawing.Point(153, 241);
            this.txtPrecioModificar.MaxLength = 50;
            this.txtPrecioModificar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioModificar.Multiline = false;
            this.txtPrecioModificar.Name = "txtPrecioModificar";
            this.txtPrecioModificar.Size = new System.Drawing.Size(220, 50);
            this.txtPrecioModificar.TabIndex = 4;
            this.txtPrecioModificar.Text = "";
            this.txtPrecioModificar.TrailingIcon = null;
            // 
            // lblPrecioModificar
            // 
            this.lblPrecioModificar.AutoSize = true;
            this.lblPrecioModificar.Depth = 0;
            this.lblPrecioModificar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrecioModificar.Location = new System.Drawing.Point(28, 256);
            this.lblPrecioModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecioModificar.Name = "lblPrecioModificar";
            this.lblPrecioModificar.Size = new System.Drawing.Size(49, 19);
            this.lblPrecioModificar.TabIndex = 8;
            this.lblPrecioModificar.Text = "Precio:";
            // 
            // txtDescripcionModificar
            // 
            this.txtDescripcionModificar.AnimateReadOnly = false;
            this.txtDescripcionModificar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcionModificar.Depth = 0;
            this.txtDescripcionModificar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescripcionModificar.LeadingIcon = null;
            this.txtDescripcionModificar.Location = new System.Drawing.Point(153, 176);
            this.txtDescripcionModificar.MaxLength = 50;
            this.txtDescripcionModificar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescripcionModificar.Multiline = false;
            this.txtDescripcionModificar.Name = "txtDescripcionModificar";
            this.txtDescripcionModificar.Size = new System.Drawing.Size(220, 50);
            this.txtDescripcionModificar.TabIndex = 3;
            this.txtDescripcionModificar.Text = "";
            this.txtDescripcionModificar.TrailingIcon = null;
            // 
            // lblDescripcionModificar
            // 
            this.lblDescripcionModificar.AutoSize = true;
            this.lblDescripcionModificar.Depth = 0;
            this.lblDescripcionModificar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescripcionModificar.Location = new System.Drawing.Point(28, 191);
            this.lblDescripcionModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcionModificar.Name = "lblDescripcionModificar";
            this.lblDescripcionModificar.Size = new System.Drawing.Size(88, 19);
            this.lblDescripcionModificar.TabIndex = 6;
            this.lblDescripcionModificar.Text = "Descripcion:";
            // 
            // txtNombreModificar
            // 
            this.txtNombreModificar.AnimateReadOnly = false;
            this.txtNombreModificar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreModificar.Depth = 0;
            this.txtNombreModificar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreModificar.LeadingIcon = null;
            this.txtNombreModificar.Location = new System.Drawing.Point(153, 109);
            this.txtNombreModificar.MaxLength = 50;
            this.txtNombreModificar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreModificar.Multiline = false;
            this.txtNombreModificar.Name = "txtNombreModificar";
            this.txtNombreModificar.Size = new System.Drawing.Size(220, 50);
            this.txtNombreModificar.TabIndex = 2;
            this.txtNombreModificar.Text = "";
            this.txtNombreModificar.TrailingIcon = null;
            // 
            // lblNombreModificar
            // 
            this.lblNombreModificar.AutoSize = true;
            this.lblNombreModificar.Depth = 0;
            this.lblNombreModificar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombreModificar.Location = new System.Drawing.Point(28, 124);
            this.lblNombreModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreModificar.Name = "lblNombreModificar";
            this.lblNombreModificar.Size = new System.Drawing.Size(61, 19);
            this.lblNombreModificar.TabIndex = 4;
            this.lblNombreModificar.Text = "Nombre:";
            // 
            // txtIdModificar
            // 
            this.txtIdModificar.AnimateReadOnly = false;
            this.txtIdModificar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdModificar.Depth = 0;
            this.txtIdModificar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdModificar.LeadingIcon = null;
            this.txtIdModificar.Location = new System.Drawing.Point(153, 31);
            this.txtIdModificar.MaxLength = 50;
            this.txtIdModificar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdModificar.Multiline = false;
            this.txtIdModificar.Name = "txtIdModificar";
            this.txtIdModificar.Size = new System.Drawing.Size(83, 50);
            this.txtIdModificar.TabIndex = 0;
            this.txtIdModificar.Text = "";
            this.txtIdModificar.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(28, 46);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(106, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Seleccionar ID:";
            // 
            // cmbCategoriaModificar
            // 
            this.cmbCategoriaModificar.AutoResize = false;
            this.cmbCategoriaModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCategoriaModificar.Depth = 0;
            this.cmbCategoriaModificar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCategoriaModificar.DropDownHeight = 174;
            this.cmbCategoriaModificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaModificar.DropDownWidth = 121;
            this.cmbCategoriaModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCategoriaModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCategoriaModificar.FormattingEnabled = true;
            this.cmbCategoriaModificar.IntegralHeight = false;
            this.cmbCategoriaModificar.ItemHeight = 43;
            this.cmbCategoriaModificar.Location = new System.Drawing.Point(153, 379);
            this.cmbCategoriaModificar.MaxDropDownItems = 4;
            this.cmbCategoriaModificar.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCategoriaModificar.Name = "cmbCategoriaModificar";
            this.cmbCategoriaModificar.Size = new System.Drawing.Size(220, 49);
            this.cmbCategoriaModificar.StartIndex = 0;
            this.cmbCategoriaModificar.TabIndex = 6;
            // 
            // btnBuscarIdModificar
            // 
            this.btnBuscarIdModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarIdModificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarIdModificar.Depth = 0;
            this.btnBuscarIdModificar.HighEmphasis = true;
            this.btnBuscarIdModificar.Icon = null;
            this.btnBuscarIdModificar.Location = new System.Drawing.Point(253, 36);
            this.btnBuscarIdModificar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarIdModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarIdModificar.Name = "btnBuscarIdModificar";
            this.btnBuscarIdModificar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarIdModificar.Size = new System.Drawing.Size(95, 36);
            this.btnBuscarIdModificar.TabIndex = 1;
            this.btnBuscarIdModificar.Text = "Buscar ID";
            this.btnBuscarIdModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarIdModificar.UseAccentColor = false;
            this.btnBuscarIdModificar.UseVisualStyleBackColor = true;
            this.btnBuscarIdModificar.Click += new System.EventHandler(this.btnBuscarIdModificar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnBuscarIdEliminar);
            this.tabPage3.Controls.Add(this.cmbCategoriaEliminar);
            this.tabPage3.Controls.Add(this.lblCategoriaEliminar);
            this.tabPage3.Controls.Add(this.txtStockEliminar);
            this.tabPage3.Controls.Add(this.lblStockEliminar);
            this.tabPage3.Controls.Add(this.txtPrecioEliminar);
            this.tabPage3.Controls.Add(this.lblPrecioEliminar);
            this.tabPage3.Controls.Add(this.txtDescripcionEliminar);
            this.tabPage3.Controls.Add(this.lblDescripcionEliminar);
            this.tabPage3.Controls.Add(this.txtNombreEliminar);
            this.tabPage3.Controls.Add(this.lblNombreEliminar);
            this.tabPage3.Controls.Add(this.btnRecargarEliminar);
            this.tabPage3.Controls.Add(this.dgvEliminar);
            this.tabPage3.Controls.Add(this.txtIdEliminar);
            this.tabPage3.Controls.Add(this.lblIdEliminar);
            this.tabPage3.Controls.Add(this.btnEliminarProductoPorID);
            this.tabPage3.ImageKey = "email_16513874.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1173, 528);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar Producto";
            // 
            // btnBuscarIdEliminar
            // 
            this.btnBuscarIdEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarIdEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarIdEliminar.Depth = 0;
            this.btnBuscarIdEliminar.HighEmphasis = true;
            this.btnBuscarIdEliminar.Icon = null;
            this.btnBuscarIdEliminar.Location = new System.Drawing.Point(283, 23);
            this.btnBuscarIdEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarIdEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarIdEliminar.Name = "btnBuscarIdEliminar";
            this.btnBuscarIdEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarIdEliminar.Size = new System.Drawing.Size(95, 36);
            this.btnBuscarIdEliminar.TabIndex = 24;
            this.btnBuscarIdEliminar.Text = "Buscar ID";
            this.btnBuscarIdEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarIdEliminar.UseAccentColor = false;
            this.btnBuscarIdEliminar.UseVisualStyleBackColor = true;
            this.btnBuscarIdEliminar.Click += new System.EventHandler(this.btnBuscarIdEliminar_Click);
            // 
            // cmbCategoriaEliminar
            // 
            this.cmbCategoriaEliminar.AutoResize = false;
            this.cmbCategoriaEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCategoriaEliminar.Depth = 0;
            this.cmbCategoriaEliminar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCategoriaEliminar.DropDownHeight = 174;
            this.cmbCategoriaEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaEliminar.DropDownWidth = 121;
            this.cmbCategoriaEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCategoriaEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCategoriaEliminar.FormattingEnabled = true;
            this.cmbCategoriaEliminar.IntegralHeight = false;
            this.cmbCategoriaEliminar.ItemHeight = 43;
            this.cmbCategoriaEliminar.Location = new System.Drawing.Point(172, 355);
            this.cmbCategoriaEliminar.MaxDropDownItems = 4;
            this.cmbCategoriaEliminar.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCategoriaEliminar.Name = "cmbCategoriaEliminar";
            this.cmbCategoriaEliminar.Size = new System.Drawing.Size(221, 49);
            this.cmbCategoriaEliminar.StartIndex = 0;
            this.cmbCategoriaEliminar.TabIndex = 22;
            // 
            // lblCategoriaEliminar
            // 
            this.lblCategoriaEliminar.AutoSize = true;
            this.lblCategoriaEliminar.Depth = 0;
            this.lblCategoriaEliminar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCategoriaEliminar.Location = new System.Drawing.Point(28, 371);
            this.lblCategoriaEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoriaEliminar.Name = "lblCategoriaEliminar";
            this.lblCategoriaEliminar.Size = new System.Drawing.Size(73, 19);
            this.lblCategoriaEliminar.TabIndex = 21;
            this.lblCategoriaEliminar.Text = "Categoria:";
            // 
            // txtStockEliminar
            // 
            this.txtStockEliminar.AnimateReadOnly = false;
            this.txtStockEliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStockEliminar.Depth = 0;
            this.txtStockEliminar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStockEliminar.LeadingIcon = null;
            this.txtStockEliminar.Location = new System.Drawing.Point(172, 284);
            this.txtStockEliminar.MaxLength = 50;
            this.txtStockEliminar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtStockEliminar.Multiline = false;
            this.txtStockEliminar.Name = "txtStockEliminar";
            this.txtStockEliminar.Size = new System.Drawing.Size(221, 50);
            this.txtStockEliminar.TabIndex = 19;
            this.txtStockEliminar.Text = "";
            this.txtStockEliminar.TrailingIcon = null;
            // 
            // lblStockEliminar
            // 
            this.lblStockEliminar.AutoSize = true;
            this.lblStockEliminar.Depth = 0;
            this.lblStockEliminar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStockEliminar.Location = new System.Drawing.Point(28, 300);
            this.lblStockEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStockEliminar.Name = "lblStockEliminar";
            this.lblStockEliminar.Size = new System.Drawing.Size(45, 19);
            this.lblStockEliminar.TabIndex = 20;
            this.lblStockEliminar.Text = "Stock:";
            // 
            // txtPrecioEliminar
            // 
            this.txtPrecioEliminar.AnimateReadOnly = false;
            this.txtPrecioEliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioEliminar.Depth = 0;
            this.txtPrecioEliminar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioEliminar.LeadingIcon = null;
            this.txtPrecioEliminar.Location = new System.Drawing.Point(172, 217);
            this.txtPrecioEliminar.MaxLength = 50;
            this.txtPrecioEliminar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioEliminar.Multiline = false;
            this.txtPrecioEliminar.Name = "txtPrecioEliminar";
            this.txtPrecioEliminar.Size = new System.Drawing.Size(221, 50);
            this.txtPrecioEliminar.TabIndex = 17;
            this.txtPrecioEliminar.Text = "";
            this.txtPrecioEliminar.TrailingIcon = null;
            // 
            // lblPrecioEliminar
            // 
            this.lblPrecioEliminar.AutoSize = true;
            this.lblPrecioEliminar.Depth = 0;
            this.lblPrecioEliminar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrecioEliminar.Location = new System.Drawing.Point(28, 233);
            this.lblPrecioEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecioEliminar.Name = "lblPrecioEliminar";
            this.lblPrecioEliminar.Size = new System.Drawing.Size(49, 19);
            this.lblPrecioEliminar.TabIndex = 18;
            this.lblPrecioEliminar.Text = "Precio:";
            // 
            // txtDescripcionEliminar
            // 
            this.txtDescripcionEliminar.AnimateReadOnly = false;
            this.txtDescripcionEliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcionEliminar.Depth = 0;
            this.txtDescripcionEliminar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescripcionEliminar.LeadingIcon = null;
            this.txtDescripcionEliminar.Location = new System.Drawing.Point(172, 151);
            this.txtDescripcionEliminar.MaxLength = 50;
            this.txtDescripcionEliminar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescripcionEliminar.Multiline = false;
            this.txtDescripcionEliminar.Name = "txtDescripcionEliminar";
            this.txtDescripcionEliminar.Size = new System.Drawing.Size(221, 50);
            this.txtDescripcionEliminar.TabIndex = 15;
            this.txtDescripcionEliminar.Text = "";
            this.txtDescripcionEliminar.TrailingIcon = null;
            // 
            // lblDescripcionEliminar
            // 
            this.lblDescripcionEliminar.AutoSize = true;
            this.lblDescripcionEliminar.Depth = 0;
            this.lblDescripcionEliminar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescripcionEliminar.Location = new System.Drawing.Point(28, 167);
            this.lblDescripcionEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcionEliminar.Name = "lblDescripcionEliminar";
            this.lblDescripcionEliminar.Size = new System.Drawing.Size(88, 19);
            this.lblDescripcionEliminar.TabIndex = 16;
            this.lblDescripcionEliminar.Text = "Descripcion:";
            // 
            // txtNombreEliminar
            // 
            this.txtNombreEliminar.AnimateReadOnly = false;
            this.txtNombreEliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreEliminar.Depth = 0;
            this.txtNombreEliminar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEliminar.LeadingIcon = null;
            this.txtNombreEliminar.Location = new System.Drawing.Point(172, 83);
            this.txtNombreEliminar.MaxLength = 50;
            this.txtNombreEliminar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreEliminar.Multiline = false;
            this.txtNombreEliminar.Name = "txtNombreEliminar";
            this.txtNombreEliminar.Size = new System.Drawing.Size(221, 50);
            this.txtNombreEliminar.TabIndex = 13;
            this.txtNombreEliminar.Text = "";
            this.txtNombreEliminar.TrailingIcon = null;
            // 
            // lblNombreEliminar
            // 
            this.lblNombreEliminar.AutoSize = true;
            this.lblNombreEliminar.Depth = 0;
            this.lblNombreEliminar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombreEliminar.Location = new System.Drawing.Point(28, 99);
            this.lblNombreEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreEliminar.Name = "lblNombreEliminar";
            this.lblNombreEliminar.Size = new System.Drawing.Size(61, 19);
            this.lblNombreEliminar.TabIndex = 14;
            this.lblNombreEliminar.Text = "Nombre:";
            // 
            // btnRecargarEliminar
            // 
            this.btnRecargarEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargarEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecargarEliminar.BackgroundImage")));
            this.btnRecargarEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecargarEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnRecargarEliminar.FlatAppearance.BorderSize = 0;
            this.btnRecargarEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargarEliminar.ImageKey = "sync_3287348.png";
            this.btnRecargarEliminar.Location = new System.Drawing.Point(1069, 454);
            this.btnRecargarEliminar.Name = "btnRecargarEliminar";
            this.btnRecargarEliminar.Size = new System.Drawing.Size(53, 45);
            this.btnRecargarEliminar.TabIndex = 12;
            this.btnRecargarEliminar.UseVisualStyleBackColor = false;
            this.btnRecargarEliminar.Click += new System.EventHandler(this.btnRecargarEliminar_Click);
            // 
            // dgvEliminar
            // 
            this.dgvEliminar.AllowUserToAddRows = false;
            this.dgvEliminar.AllowUserToDeleteRows = false;
            this.dgvEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminar.Location = new System.Drawing.Point(423, 33);
            this.dgvEliminar.MultiSelect = false;
            this.dgvEliminar.Name = "dgvEliminar";
            this.dgvEliminar.ReadOnly = true;
            this.dgvEliminar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEliminar.Size = new System.Drawing.Size(682, 346);
            this.dgvEliminar.TabIndex = 2;
            this.dgvEliminar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEliminar_CellClick);
            // 
            // txtIdEliminar
            // 
            this.txtIdEliminar.AnimateReadOnly = false;
            this.txtIdEliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdEliminar.Depth = 0;
            this.txtIdEliminar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdEliminar.LeadingIcon = null;
            this.txtIdEliminar.Location = new System.Drawing.Point(172, 17);
            this.txtIdEliminar.MaxLength = 50;
            this.txtIdEliminar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdEliminar.Multiline = false;
            this.txtIdEliminar.Name = "txtIdEliminar";
            this.txtIdEliminar.Size = new System.Drawing.Size(104, 50);
            this.txtIdEliminar.TabIndex = 0;
            this.txtIdEliminar.Text = "";
            this.txtIdEliminar.TrailingIcon = null;
            this.txtIdEliminar.TextChanged += new System.EventHandler(this.txtIdEliminar_TextChanged);
            // 
            // lblIdEliminar
            // 
            this.lblIdEliminar.AutoSize = true;
            this.lblIdEliminar.Depth = 0;
            this.lblIdEliminar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIdEliminar.Location = new System.Drawing.Point(28, 33);
            this.lblIdEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdEliminar.Name = "lblIdEliminar";
            this.lblIdEliminar.Size = new System.Drawing.Size(106, 19);
            this.lblIdEliminar.TabIndex = 1;
            this.lblIdEliminar.Text = "Seleccionar ID:";
            // 
            // btnEliminarProductoPorID
            // 
            this.btnEliminarProductoPorID.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarProductoPorID.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarProductoPorID.Depth = 0;
            this.btnEliminarProductoPorID.HighEmphasis = true;
            this.btnEliminarProductoPorID.Icon = null;
            this.btnEliminarProductoPorID.Location = new System.Drawing.Point(150, 429);
            this.btnEliminarProductoPorID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarProductoPorID.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarProductoPorID.Name = "btnEliminarProductoPorID";
            this.btnEliminarProductoPorID.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarProductoPorID.Size = new System.Drawing.Size(169, 36);
            this.btnEliminarProductoPorID.TabIndex = 1;
            this.btnEliminarProductoPorID.Text = "Eliminar Producto";
            this.btnEliminarProductoPorID.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarProductoPorID.UseAccentColor = false;
            this.btnEliminarProductoPorID.UseVisualStyleBackColor = true;
            this.btnEliminarProductoPorID.Click += new System.EventHandler(this.btnEliminarProductoPorID_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1_fseafaww1.jpg");
            this.imageList1.Images.SetKeyName(1, "11_aswasdas1.jpg");
            this.imageList1.Images.SetKeyName(2, "abstract-view-modern-architecture.jpg");
            this.imageList1.Images.SetKeyName(3, "add_8532597.png");
            this.imageList1.Images.SetKeyName(4, "add-button_10703134.png");
            this.imageList1.Images.SetKeyName(5, "creativity_7407522.png");
            this.imageList1.Images.SetKeyName(6, "delete_6861362.png");
            this.imageList1.Images.SetKeyName(7, "duplicate_12108396.png");
            this.imageList1.Images.SetKeyName(8, "edit_8273154.png");
            this.imageList1.Images.SetKeyName(9, "email_16513874.png");
            this.imageList1.Images.SetKeyName(10, "engineering_18642986.png");
            this.imageList1.Images.SetKeyName(11, "freepik__upload__41513.png");
            this.imageList1.Images.SetKeyName(12, "geometria-3d_3840x2160_xtrafondos.com.jpg");
            this.imageList1.Images.SetKeyName(13, "Icono de luna 1.ico");
            this.imageList1.Images.SetKeyName(14, "Icono de luna 2.ico");
            this.imageList1.Images.SetKeyName(15, "luca-bravo-g_LG9LGyTk8-unsplash.jpg");
            this.imageList1.Images.SetKeyName(16, "ondas-azules_5120x2880_xtrafondos.com.jpg");
            this.imageList1.Images.SetKeyName(17, "pencil_10296476.png");
            this.imageList1.Images.SetKeyName(18, "refresh 1.png");
            this.imageList1.Images.SetKeyName(19, "Reprecentacion de una Cola.jpg");
            this.imageList1.Images.SetKeyName(20, "Reprecentacion de una Pila.jpg");
            this.imageList1.Images.SetKeyName(21, "Representacion de Listas Simples Entrelazadas.jpg");
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 638);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRecargarAgregar;
        private System.Windows.Forms.DataGridView dgvAgregar;
        private MaterialSkin.Controls.MaterialLabel lblCategoriaAgregar;
        private MaterialSkin.Controls.MaterialTextBox txtStockAgregar;
        private MaterialSkin.Controls.MaterialLabel lblStockAgregar;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioAgregar;
        private MaterialSkin.Controls.MaterialLabel lblPrecioAgregar;
        private MaterialSkin.Controls.MaterialTextBox txtDescripcionAgregar;
        private MaterialSkin.Controls.MaterialLabel lblDescripcionAgregar;
        private MaterialSkin.Controls.MaterialComboBox cmbCategoriaAgregar;
        private MaterialSkin.Controls.MaterialTextBox txtNombreAgregar;
        private MaterialSkin.Controls.MaterialLabel lblNombreAgregar;
        private MaterialSkin.Controls.MaterialButton btnAgregarProducto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRecargarModificar;
        private System.Windows.Forms.DataGridView dgvModificar;
        private MaterialSkin.Controls.MaterialButton btnModificarProducto;
        private MaterialSkin.Controls.MaterialLabel lblCategoriaModificar;
        private MaterialSkin.Controls.MaterialTextBox txtStockModificar;
        private MaterialSkin.Controls.MaterialLabel lblStockModificar;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioModificar;
        private MaterialSkin.Controls.MaterialLabel lblPrecioModificar;
        private MaterialSkin.Controls.MaterialTextBox txtDescripcionModificar;
        private MaterialSkin.Controls.MaterialLabel lblDescripcionModificar;
        private MaterialSkin.Controls.MaterialTextBox txtNombreModificar;
        private MaterialSkin.Controls.MaterialLabel lblNombreModificar;
        private MaterialSkin.Controls.MaterialTextBox txtIdModificar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cmbCategoriaModificar;
        private MaterialSkin.Controls.MaterialButton btnBuscarIdModificar;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialComboBox cmbCategoriaEliminar;
        private MaterialSkin.Controls.MaterialLabel lblCategoriaEliminar;
        private MaterialSkin.Controls.MaterialTextBox txtStockEliminar;
        private MaterialSkin.Controls.MaterialLabel lblStockEliminar;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioEliminar;
        private MaterialSkin.Controls.MaterialLabel lblPrecioEliminar;
        private MaterialSkin.Controls.MaterialTextBox txtDescripcionEliminar;
        private MaterialSkin.Controls.MaterialLabel lblDescripcionEliminar;
        private MaterialSkin.Controls.MaterialTextBox txtNombreEliminar;
        private MaterialSkin.Controls.MaterialLabel lblNombreEliminar;
        private System.Windows.Forms.Button btnRecargarEliminar;
        private System.Windows.Forms.DataGridView dgvEliminar;
        private MaterialSkin.Controls.MaterialTextBox txtIdEliminar;
        private MaterialSkin.Controls.MaterialLabel lblIdEliminar;
        private MaterialSkin.Controls.MaterialButton btnEliminarProductoPorID;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton btnBuscarIdEliminar;
    }
}

