namespace Furniture
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.listViewKrovat = new System.Windows.Forms.ListView();
            this.Material = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Height = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Width = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonDel.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.buttonDel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonDel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Rounds Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonDel.Location = new System.Drawing.Point(530, 359);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(174, 37);
            this.buttonDel.TabIndex = 57;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Rounds Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonEdit.Location = new System.Drawing.Point(350, 359);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(174, 37);
            this.buttonEdit.TabIndex = 56;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Rounds Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonAdd.Location = new System.Drawing.Point(170, 359);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(174, 37);
            this.buttonAdd.TabIndex = 55;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(9, 300);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(47, 21);
            this.labelPrice.TabIndex = 51;
            this.labelPrice.Text = "Цена";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProduct.Location = new System.Drawing.Point(8, 19);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(52, 21);
            this.labelProduct.TabIndex = 49;
            this.labelProduct.Text = "Товар";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPrice.Location = new System.Drawing.Point(13, 324);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(151, 29);
            this.textBoxPrice.TabIndex = 45;
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaterial.Location = new System.Drawing.Point(9, 75);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(81, 21);
            this.labelMaterial.TabIndex = 63;
            this.labelMaterial.Text = "Материал";
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaterial.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxMaterial.Location = new System.Drawing.Point(13, 99);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(151, 29);
            this.textBoxMaterial.TabIndex = 62;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLength.Location = new System.Drawing.Point(9, 132);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(55, 21);
            this.labelLength.TabIndex = 65;
            this.labelLength.Text = "Длина";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLength.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxLength.Location = new System.Drawing.Point(13, 156);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(151, 29);
            this.textBoxLength.TabIndex = 64;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWidth.Location = new System.Drawing.Point(9, 188);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(69, 21);
            this.labelWidth.TabIndex = 67;
            this.labelWidth.Text = "Ширина";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWidth.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxWidth.Location = new System.Drawing.Point(13, 212);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(151, 29);
            this.textBoxWidth.TabIndex = 66;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeight.Location = new System.Drawing.Point(9, 244);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(61, 21);
            this.labelHeight.TabIndex = 69;
            this.labelHeight.Text = "Высота";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHeight.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxHeight.Location = new System.Drawing.Point(13, 268);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(151, 29);
            this.textBoxHeight.TabIndex = 68;
            // 
            // listViewKrovat
            // 
            this.listViewKrovat.BackColor = System.Drawing.SystemColors.Window;
            this.listViewKrovat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.type,
            this.Material,
            this.Length,
            this.Width,
            this.Height,
            this.Price});
            this.listViewKrovat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewKrovat.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listViewKrovat.FullRowSelect = true;
            this.listViewKrovat.GridLines = true;
            this.listViewKrovat.HideSelection = false;
            this.listViewKrovat.Location = new System.Drawing.Point(181, 19);
            this.listViewKrovat.MultiSelect = false;
            this.listViewKrovat.Name = "listViewKrovat";
            this.listViewKrovat.Size = new System.Drawing.Size(534, 334);
            this.listViewKrovat.TabIndex = 71;
            this.listViewKrovat.UseCompatibleStateImageBehavior = false;
            this.listViewKrovat.View = System.Windows.Forms.View.Details;
            this.listViewKrovat.SelectedIndexChanged += new System.EventHandler(this.listViewKrovat_SelectedIndexChanged);
            // 
            // Material
            // 
            this.Material.Text = "Материал";
            this.Material.Width = 85;
            // 
            // Height
            // 
            this.Height.Text = "Высота";
            this.Height.Width = 72;
            // 
            // Width
            // 
            this.Width.Text = "Ширина";
            this.Width.Width = 98;
            // 
            // Length
            // 
            this.Length.Text = "Длина";
            this.Length.Width = 71;
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            this.Price.Width = 77;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Furniture.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 359);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // type
            // 
            this.type.Text = "Вид товара";
            this.type.Width = 122;
            // 
            // textBoxType
            // 
            this.textBoxType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxType.Location = new System.Drawing.Point(13, 43);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(151, 29);
            this.textBoxType.TabIndex = 72;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(727, 404);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.listViewKrovat);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.textBoxMaterial);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.textBoxPrice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.TextBox textBoxMaterial;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.ListView listViewKrovat;
        private System.Windows.Forms.ColumnHeader Material;
        private System.Windows.Forms.ColumnHeader Height;
        private System.Windows.Forms.ColumnHeader Width;
        private System.Windows.Forms.ColumnHeader Length;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.TextBox textBoxType;
    }
}