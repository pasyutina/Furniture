namespace Furniture
{
    partial class Zakaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zakaz));
            this.comboBoxAgent = new System.Windows.Forms.ComboBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewZakaz = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Agent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Products = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxAgents = new System.Windows.Forms.TextBox();
            this.textBoxMagaz = new System.Windows.Forms.TextBox();
            this.labelAgents = new System.Windows.Forms.Label();
            this.labelMagaz = new System.Windows.Forms.Label();
            this.Agents = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Magazins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAgent
            // 
            this.comboBoxAgent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAgent.FormattingEnabled = true;
            this.comboBoxAgent.Location = new System.Drawing.Point(14, 150);
            this.comboBoxAgent.Name = "comboBoxAgent";
            this.comboBoxAgent.Size = new System.Drawing.Size(176, 29);
            this.comboBoxAgent.TabIndex = 82;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Items.AddRange(new object[] {
            "Диван",
            "Шкаф",
            "Кровать"});
            this.comboBoxClient.Location = new System.Drawing.Point(14, 91);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(176, 29);
            this.comboBoxClient.TabIndex = 81;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Items.AddRange(new object[] {
            "Диван",
            "Шкаф",
            "Кровать"});
            this.comboBoxProduct.Location = new System.Drawing.Point(14, 36);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(176, 29);
            this.comboBoxProduct.TabIndex = 80;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Furniture.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(5, 297);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
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
            this.buttonDel.Location = new System.Drawing.Point(651, 297);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(174, 37);
            this.buttonDel.TabIndex = 78;
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
            this.buttonEdit.Location = new System.Drawing.Point(471, 297);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(174, 37);
            this.buttonEdit.TabIndex = 77;
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
            this.buttonAdd.Location = new System.Drawing.Point(291, 297);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(174, 37);
            this.buttonAdd.TabIndex = 76;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewZakaz
            // 
            this.listViewZakaz.BackColor = System.Drawing.SystemColors.Window;
            this.listViewZakaz.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Client,
            this.Agent,
            this.Products,
            this.Price,
            this.Agents,
            this.Magazins});
            this.listViewZakaz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewZakaz.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listViewZakaz.FullRowSelect = true;
            this.listViewZakaz.GridLines = true;
            this.listViewZakaz.HideSelection = false;
            this.listViewZakaz.Location = new System.Drawing.Point(196, 12);
            this.listViewZakaz.MultiSelect = false;
            this.listViewZakaz.Name = "listViewZakaz";
            this.listViewZakaz.Size = new System.Drawing.Size(629, 279);
            this.listViewZakaz.TabIndex = 75;
            this.listViewZakaz.UseCompatibleStateImageBehavior = false;
            this.listViewZakaz.View = System.Windows.Forms.View.Details;
            this.listViewZakaz.SelectedIndexChanged += new System.EventHandler(this.listViewAgent_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 33;
            // 
            // Client
            // 
            this.Client.Text = "Клиент";
            // 
            // Agent
            // 
            this.Agent.Text = "Менеджер";
            this.Agent.Width = 89;
            // 
            // Products
            // 
            this.Products.Text = "Вид товара";
            this.Products.Width = 90;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.Location = new System.Drawing.Point(9, 126);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(87, 21);
            this.labelMiddleName.TabIndex = 74;
            this.labelMiddleName.Text = "Менеджер";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(9, 67);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(60, 21);
            this.labelLastName.TabIndex = 73;
            this.labelLastName.Text = "Клиент";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(10, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 21);
            this.labelName.TabIndex = 71;
            this.labelName.Text = "Товар";
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            this.Price.Width = 72;
            // 
            // textBoxAgents
            // 
            this.textBoxAgents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAgents.Location = new System.Drawing.Point(14, 206);
            this.textBoxAgents.Name = "textBoxAgents";
            this.textBoxAgents.Size = new System.Drawing.Size(176, 29);
            this.textBoxAgents.TabIndex = 83;
            this.textBoxAgents.TextChanged += new System.EventHandler(this.textBoxAgents_TextChanged);
            // 
            // textBoxMagaz
            // 
            this.textBoxMagaz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMagaz.Location = new System.Drawing.Point(13, 262);
            this.textBoxMagaz.Name = "textBoxMagaz";
            this.textBoxMagaz.Size = new System.Drawing.Size(176, 29);
            this.textBoxMagaz.TabIndex = 84;
            this.textBoxMagaz.TextChanged += new System.EventHandler(this.textBoxMagaz_TextChanged);
            // 
            // labelAgents
            // 
            this.labelAgents.AutoSize = true;
            this.labelAgents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAgents.Location = new System.Drawing.Point(10, 182);
            this.labelAgents.Name = "labelAgents";
            this.labelAgents.Size = new System.Drawing.Size(182, 21);
            this.labelAgents.TabIndex = 85;
            this.labelAgents.Text = "Отчисления менеджеру";
            // 
            // labelMagaz
            // 
            this.labelMagaz.AutoSize = true;
            this.labelMagaz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMagaz.Location = new System.Drawing.Point(10, 238);
            this.labelMagaz.Name = "labelMagaz";
            this.labelMagaz.Size = new System.Drawing.Size(166, 21);
            this.labelMagaz.TabIndex = 86;
            this.labelMagaz.Text = "Отчисления магазину";
            // 
            // Agents
            // 
            this.Agents.Text = "Отчисления менеджеру";
            this.Agents.Width = 131;
            // 
            // Magazins
            // 
            this.Magazins.Text = "Отчисления магазину";
            this.Magazins.Width = 146;
            // 
            // Zakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(833, 342);
            this.Controls.Add(this.labelMagaz);
            this.Controls.Add(this.labelAgents);
            this.Controls.Add(this.textBoxMagaz);
            this.Controls.Add(this.textBoxAgents);
            this.Controls.Add(this.comboBoxAgent);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewZakaz);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zakaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxAgent;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewZakaz;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Client;
        private System.Windows.Forms.ColumnHeader Agent;
        private System.Windows.Forms.ColumnHeader Products;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Agents;
        private System.Windows.Forms.ColumnHeader Magazins;
        private System.Windows.Forms.TextBox textBoxAgents;
        private System.Windows.Forms.TextBox textBoxMagaz;
        private System.Windows.Forms.Label labelAgents;
        private System.Windows.Forms.Label labelMagaz;
    }
}