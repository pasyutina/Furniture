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
    public partial class Zakaz : Form
    {
        public Zakaz()
        {
            InitializeComponent();
            ShowAgent();
            ShowClient();
            ShowProduct();
            ShowZakaz();
        }

        void ShowClient()
        {
            comboBoxClient.Items.Clear();
            foreach (ClientsSet clientsSet in Program.furn.ClientsSet)
            {
                string[] item = { clientsSet.FirstName.ToString(), clientsSet.MiddleName.ToString(), clientsSet.LastName.ToString(),};
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }

        
        void ShowAgent()
        {
            comboBoxClient.Items.Clear();
            foreach (AgentSet agentSet in Program.furn.AgentSet)
            {
                string[] item = { agentSet.FirstName.ToString(), agentSet.MiddleName.ToString(), agentSet.LastName.ToString(), };
                comboBoxAgent.Items.Add(string.Join(" ", item));
            }
        }

        void ShowProduct()
        {
            comboBoxProduct.Items.Clear();
            foreach (ProductSet product in Program.furn.ProductSet)
            {

                string[] item = { product.Type.ToString(), product.Material.ToString(), product.Height.ToString(), product.Length.ToString(), product.Width.ToString(), };
                comboBoxProduct.Items.Add(string.Join(" ", item));
            }
        }
        void ShowZakaz()
        {
            listViewZakaz.Items.Clear();
            foreach (DealSet zakaz in Program.furn.DealSet)
            { 
                ListViewItem item = new ListViewItem(new string[]
                {
                    zakaz.Id.ToString(),
                    zakaz.ClientsSet.LastName + " " + zakaz.ClientsSet.FirstName.Remove(1) + "." + zakaz.ClientsSet.MiddleName.Remove(1) + ".",
                    zakaz.AgentSet.LastName+" "+ zakaz.AgentSet.FirstName.Remove(1)+"."+zakaz.AgentSet.MiddleName.Remove(1) + ".",
                    zakaz.ProductSet.Type+ ", " + zakaz.ProductSet.Material+ ", " + zakaz.ProductSet.Height.ToString()+ "м., "+
                    zakaz.ProductSet.Width.ToString() + "м., "+zakaz.ProductSet.Length.ToString()+ "м.", 
                    zakaz.ProductSet.Price.ToString(),
                });
                item.Tag = zakaz;
                listViewZakaz.Items.Add(item);
            }
        }
        void Deductions()
        {
            if (comboBoxAgent.SelectedItem != null && comboBoxProduct.SelectedItem != null)
            {
                AgentSet agent = Program.furn.AgentSet.Find(Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]));
                ProductSet product = Program.furn.ProductSet.Find(Convert.ToInt32(comboBoxProduct.SelectedItem.ToString().Split('.')[0]));
                double magaz = product.Price * 0.05;
                textBoxMagaz.Text = magaz.ToString("0.00");
                if(agent.DealShare != null)
                {
                    double agents = product.Price * Convert.ToDouble(agent.DealShare) / 100.00;
                    textBoxAgents.Text = agents.ToString("0.00");
                }
                else
                {
                    double agents = product.Price * 0.03;
                    textBoxAgents.Text = agents.ToString("0.00");
                }
            }
            else
            {
                textBoxAgents.Text = "";
                textBoxMagaz.Text = "";
            }
        }
        private void listViewAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewZakaz.SelectedItems.Count == 1)
            {
                DealSet zakaz = listViewZakaz.SelectedItems[0].Tag as DealSet;
                comboBoxAgent.SelectedIndex = comboBoxAgent.FindString(zakaz.IdAgent.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(zakaz.IdClient.ToString());
                comboBoxProduct.SelectedIndex = comboBoxProduct.FindString(zakaz.IdProduct.ToString());
            }
            else
            {
                comboBoxAgent.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                comboBoxProduct.SelectedItem = null;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAgent.SelectedItem != null && comboBoxClient.SelectedItem != null && comboBoxProduct.SelectedItem != null)
            {
                DealSet zakaz = new DealSet();
                zakaz.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                zakaz.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                zakaz.IdProduct = Convert.ToInt32(comboBoxProduct.SelectedItem.ToString().Split('.')[0]);
                Program.furn.DealSet.Add(zakaz);
                Program.furn.SaveChanges();
                ShowZakaz();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewZakaz.SelectedItems.Count == 1)
            {
                DealSet zakaz = listViewZakaz.SelectedItems[0].Tag as DealSet;
                zakaz.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                zakaz.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                zakaz.IdProduct = Convert.ToInt32(comboBoxProduct.SelectedItem.ToString().Split('.')[0]);

                Program.furn.SaveChanges();
                ShowZakaz();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewZakaz.SelectedItems.Count == 1)
                {
                    DealSet zakaz = listViewZakaz.SelectedItems[0].Tag as DealSet;
                    Program.furn.DealSet.Remove(zakaz);
                    Program.furn.SaveChanges();
                    ShowZakaz();
                }
                comboBoxAgent.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                comboBoxProduct.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxAgent_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxAgents_TextChanged(object sender, EventArgs e)
        {
            Deductions();
        }

        private void textBoxMagaz_TextChanged(object sender, EventArgs e)
        {
            Deductions();
        }
    }
}
