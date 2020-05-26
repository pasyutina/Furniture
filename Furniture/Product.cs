using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            ShowProduct();
        }

        void ShowProduct()
        {
            listViewKrovat.Items.Clear();

            foreach (ProductSet product in Program.furn.ProductSet)
            {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        product.Type, product.Material,product.Length.ToString(),product.Width.ToString(), 
                        product.Height.ToString(), product.Price.ToString()
                    });
                    item.Tag = product;
                    listViewKrovat.Items.Add(item);
            }
            listViewKrovat.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ProductSet product = new ProductSet();

            product.Type = textBoxType.Text;
            product.Material = textBoxMaterial.Text;
            if (textBoxLength.Text != "")
            {
                product.Length = Convert.ToDouble(textBoxLength.Text);
            }
            if (textBoxWidth.Text != "")
            {
                product.Width = Convert.ToDouble(textBoxWidth.Text);
            }
            if (textBoxHeight.Text != "")
            {
                product.Height = Convert.ToDouble(textBoxHeight.Text);
            }
            if (textBoxPrice.Text != "")
            {
                product.Price = Convert.ToInt64(textBoxPrice.Text);
            }
            Program.furn.ProductSet.Add(product);
            Program.furn.SaveChanges();
            ShowProduct();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
                if (listViewKrovat.SelectedItems.Count == 1)
                {
                    ProductSet product = listViewKrovat.SelectedItems[0].Tag as ProductSet;
                    product.Type = textBoxType.Text;
                    product.Material = textBoxMaterial.Text;

                    if (textBoxLength.Text != "")
                    {
                        product.Length = Convert.ToDouble(textBoxLength.Text);
                    }
                    if (textBoxWidth.Text != "")
                    {
                        product.Width = Convert.ToDouble(textBoxWidth.Text);
                    }
                    if (textBoxHeight.Text != "")
                    {
                        product.Height = Convert.ToDouble(textBoxHeight.Text);
                    }
                    if (textBoxPrice.Text != "")
                    {
                        product.Price = Convert.ToInt64(textBoxPrice.Text);
                    }

                    Program.furn.SaveChanges();
                    ShowProduct();
                }
        }

        private void listViewKrovat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewKrovat.SelectedItems.Count == 1)
            {
                ProductSet product = listViewKrovat.SelectedItems[0].Tag as ProductSet;

                textBoxType.Text = product.Type;
                textBoxMaterial.Text = product.Material;
                textBoxHeight.Text = product.Height.ToString();
                textBoxWidth.Text = product.Width.ToString();
                textBoxLength.Text = product.Length.ToString();
                textBoxPrice.Text = product.Price.ToString();
            }
            else
            {
                textBoxType.Text = "";
                textBoxMaterial.Text = "";
                textBoxLength.Text = "";
                textBoxWidth.Text = "";
                textBoxHeight.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void listViewDivan_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                
                    if (listViewKrovat.SelectedItems.Count == 1)
                    {
                        ProductSet product = listViewKrovat.SelectedItems[0].Tag as ProductSet;
                        Program.furn.ProductSet.Remove(product);
                        Program.furn.SaveChanges();
                        ShowProduct();
                    }

                    textBoxType.Text = "";
                    textBoxMaterial.Text = "";
                    textBoxLength.Text = "";
                    textBoxWidth.Text = "";
                    textBoxHeight.Text = "";
                    textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
