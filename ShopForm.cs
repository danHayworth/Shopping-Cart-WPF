using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2ShoppingCart
{
    public partial class frmShop : Form
    {
        public frmShop()
        {
            InitializeComponent();       
        }    

        Product product1 = new Product("Item 1", 24f);
        Product product2 = new Product("Item 2", 10f);
        Product product3 = new Product("Item 3", 24.5f);
        Product product4 = new Product("Item 4", 7.6f);
        Product product5 = new Product("Item 5", 2f);
        Product product6 = new Product("Item 6", 4.80f);
        Product product7 = new Product("Item 7", 25.75f);
        
        private void frmShop_Load(object sender, EventArgs e)
        {
            txtProd1.Text = product1.name;
            txtPrice1.Text = product1.price.ToString();
            txtProd2.Text = product2.name;
            txtPrice2.Text = product2.price.ToString();
            txtProd3.Text = product3.name;
            txtPrice3.Text = product3.price.ToString();
            txtProd4.Text = product4.name;
            txtPrice4.Text = product4.price.ToString();
            txtProd5.Text = product5.name;
            txtPrice5.Text = product5.price.ToString();
            txtProd6.Text = product6.name;
            txtPrice6.Text = product6.price.ToString();
            txtProd7.Text = product7.name;
            txtPrice7.Text = product7.price.ToString();
        }
       
        private void btnAdd1_Click(object sender, EventArgs e)
        {

            string a = txtPrice1.Text.ToString();
            string b = txtProd1.Text;
            string c = comboBox1.SelectedItem.ToString();
            BuyProduct prodAdd1 = new BuyProduct(b, float.Parse(a), int.Parse(c));
            frmCheckout.buyProducts.Add(prodAdd1);
            
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            string a = txtPrice2.Text.ToString();
            string b = txtProd2.Text;
            string c = comboBox2.SelectedItem.ToString();
            BuyProduct prodAdd2 = new BuyProduct(b, float.Parse(a), int.Parse(c));
            frmCheckout.buyProducts.Add(prodAdd2);  
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            string a = txtPrice3.Text.ToString();
            string b = txtProd3.Text;
            string c = comboBox3.SelectedItem.ToString();
            BuyProduct prodAdd3 = new BuyProduct(b, float.Parse(a), int.Parse(c));
            frmCheckout.buyProducts.Add(prodAdd3);
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            string a = txtPrice4.Text.ToString();
            string b = txtProd4.Text;
            string c = comboBox4.SelectedItem.ToString();
            BuyProduct prodAdd4 = new BuyProduct(b, float.Parse(a), int.Parse(c));
            frmCheckout.buyProducts.Add(prodAdd4);
        }

        private void btnAdd5_Click(object sender, EventArgs e)
        {
            string a = txtPrice5.Text.ToString();
            string b = txtProd5.Text;
            string c = comboBox5.SelectedItem.ToString();
            BuyProduct prodAdd5 = new BuyProduct(b, float.Parse(a), int.Parse(c));
            frmCheckout.buyProducts.Add(prodAdd5);
        }

        private void btnAdd6_Click(object sender, EventArgs e)
        {
            string a = txtPrice6.Text.ToString();
            string b = txtProd6.Text;
            string c = comboBox6.SelectedItem.ToString();
            BuyProduct prodAdd6 = new BuyProduct(b, float.Parse(a), int.Parse(c));
            frmCheckout.buyProducts.Add(prodAdd6);
        }

        private void btnAdd7_Click(object sender, EventArgs e)
        {
            string a = txtPrice7.Text.ToString();
            string b = txtProd7.Text;
            string c = comboBox7.SelectedItem.ToString();
            BuyProduct prodAdd7 = new BuyProduct(b, float.Parse(a), int.Parse(c));
            frmCheckout.buyProducts.Add(prodAdd7);
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            btnBack.Show();
            pCheckout.Visible = false;
            frmCheckout f = new frmCheckout() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            f.FormBorderStyle = FormBorderStyle.None;
            pCheckout.Controls.Add(f);
            pCheckout.Visible = true;
            mainPanel.Visible = false;
            f.Show();
            btnCheckout.Hide();
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            btnBack.Hide();
            mainPanel.Visible = true;
            pCheckout.Controls.Clear();
            btnCheckout.Show();
        }
    }
      
}
