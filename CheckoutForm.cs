using System;
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
    public partial class frmCheckout : Form
    {
        public frmCheckout()
        {
            InitializeComponent();
            AddToList();
            AddTotal();
          
        }
        public static List<BuyProduct> buyProducts = new List<BuyProduct>();

        public void AddToList()
        {
            foreach (BuyProduct p in buyProducts)
            {
                float addedPrice = p.price * p.quantity;
                dataGridView.Rows.Add(p.name.ToString(), p.quantity, addedPrice.ToString());
            }
        }
        void AddTotal()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView.Rows[i].Cells[2].Value);
            }
            txtTotal.Text += sum.ToString();
        }
    }
}
