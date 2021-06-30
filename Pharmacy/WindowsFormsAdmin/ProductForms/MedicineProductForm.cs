using MyPharmacy.DAL.Modules.Impl;
using MyPharmacy.DAL.Repositories.Abstract;
using System;
using System.Windows.Forms;


namespace WindowsFormsAdmin
{
    public partial class MedicineProductForm : Form
    {
        Medicine medProduct;
        IMedicineRepository medRepos;
        public MedicineProductForm(IMedicineRepository medRepos, Medicine product)
        {
            this.medRepos = medRepos;
            medProduct = product;
            InitializeComponent();
        }

        public Medicine GetProductBack()
        {
             return this.medProduct;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = medProduct.Id.ToString();
            textBox2.Text = medProduct.name;
            textBox3.Text = medProduct.expirationDate;
            textBox4.Text = medProduct.amount.ToString();
            textBox5.Text = medProduct.storageTemperature.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            medProduct.name = textBox2.Text;
            medRepos.Update(this.medProduct);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            medProduct.expirationDate = textBox3.Text;
            medRepos.Update(this.medProduct);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            medProduct.amount = int.Parse(textBox4.Text);
            medRepos.Update(this.medProduct);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            medProduct.storageTemperature = int.Parse(textBox5.Text);
            medRepos.Update(this.medProduct);
        }
    }
}