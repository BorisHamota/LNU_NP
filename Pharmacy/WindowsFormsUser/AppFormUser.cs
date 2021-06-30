using MyPharmacy.DAL.Factories.Impl;
using MyPharmacy.DAL.Modules.Impl;
using MyPharmacy.DAL.Repositories;
using MyPharmacy.DAL.Repositories.Abstract;
using System;
using System.Windows.Forms;
using WindowsFormsUser.CartForms;

namespace WindowsFormsUser
{
    public partial class AppFormUser : Form
    {
        IMedicineRepository medRepos;
        ICosmeticRepository cosRepos;
        ICartRepositoty cartRepos;
        FactoryProvider prov;
        FlyweightFactory factory;
        public AppFormUser()
        {
            factory = new FlyweightFactory();
            prov = new FactoryProvider();
            medRepos = prov.GetFactory().GetMedicineRepository();
            cosRepos = prov.GetFactory().GetCosmeticRepository();
            cartRepos = prov.GetFactory().GetCartRepository();
            InitializeComponent();
            //
            Load_Med_Columns();
            Load_Cos_Columns();
        }
        private void Clear_Table(DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            medRepos = prov.GetFactory().GetMedicineRepository();
            cosRepos = prov.GetFactory().GetCosmeticRepository();
        }
        private void Load_Med_Table(DataGridView dataGridView)
        {
            foreach (var it in medRepos.GetAll())
            {
                dataGridView.Rows.Add(it.Id, it.name, it.expirationDate, it.amount, it.storageTemperature);
            }
        }
        private void Load_Cos_Table(DataGridView dataGridView)
        {
            foreach (var it in cosRepos.GetAll())
            {
                dataGridView.Rows.Add(it.Id, it.name, it.expirationDate, it.amount, it.capacity, it.storageTemperature);
            }
        }
        private void Load_Med_Columns()
        {
            dataGridView1.Columns.Add("", "Id");
            dataGridView1.Columns.Add("", "Name");
            dataGridView1.Columns.Add("", "Expir. Date");
            dataGridView1.Columns.Add("", "Amount");
            dataGridView1.Columns.Add("", "Temperature");
        }
        private void Load_Cos_Columns()
        {
            dataGridView2.Columns.Add("", "Id");
            dataGridView2.Columns.Add("", "Name");
            dataGridView2.Columns.Add("", "Expir. Date");
            dataGridView2.Columns.Add("", "Amount");
            dataGridView2.Columns.Add("", "Capacity");
            dataGridView2.Columns.Add("", "Temperature");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Clear_Table(this.dataGridView1);
            Load_Med_Table(this.dataGridView1);
            ////////////////
            Clear_Table(this.dataGridView2);
            Load_Cos_Table(this.dataGridView2);
        }

        private void med_refresh_Click(object sender, EventArgs e)
        {
            Clear_Table(this.dataGridView1);
            //medRepos = prov.GetFactory().GetMedicineRepository();
            Load_Med_Table(this.dataGridView1);
        }

        private void med_open_cart_Click(object sender, EventArgs e)
        {
            CartForm cart = new CartForm(cartRepos, medRepos, cosRepos);
            cart.Show();
        }

        private void med_add_to_cart_Click(object sender, EventArgs e)
        {
            //take amount from
            CartEntity p = new CartEntity();
            foreach (var it in medRepos.GetAll())
            {
                if (it.Id == (int)dataGridView1.CurrentCell.Value)//id in row
                {
                    p.Id = it.Id;
                    p.name = it.name;
                    it.amount = it.amount - int.Parse(med_amount.Text);//amount in text
                }
            }
            //add amount to cart
            medRepos.Save();
            cartRepos.Save();//
            if (cartRepos .IsProductExist(factory.GetCartFlyweight(p, int.Parse(med_amount.Text))))///////////////////////////////////
            {
                factory.GetCartFlyweight(p, int.Parse(med_amount.Text)).amount += int.Parse(med_amount.Text);/////
                cartRepos.Update(factory.GetCartFlyweight(p, int.Parse(med_amount.Text)));
            }
            else if ((factory.GetCartFlyweight(p, int.Parse(med_amount.Text))).amount == 0)
            {
                factory.GetCartFlyweight(p, int.Parse(med_amount.Text)).amount += int.Parse(med_amount.Text);
                cartRepos.Create(factory.GetCartFlyweight(p, int.Parse(med_amount.Text)));
            }
            else
            {
                cartRepos.Create(factory.GetCartFlyweight(p, int.Parse(med_amount.Text)));
            }
        }

        private void cos_add_to_cart_Click(object sender, EventArgs e)
        {
            //take amount from
            CartEntity p = new CartEntity();
            foreach (var it in cosRepos.GetAll())
            {
                if (it.Id == (int)dataGridView2.CurrentCell.Value)//id in row
                {
                    p.Id = it.Id;
                    p.name = it.name;
                    it.amount = it.amount - int.Parse(cos_amount.Text);//amount in text
                }
            }
            //add amount to cart
            cosRepos.Save();
            cartRepos.Save();//
            if (cartRepos.IsProductExist(factory.GetCartFlyweight(p, int.Parse(cos_amount.Text))))///////////////////////////////////
            {
                factory.GetCartFlyweight(p, int.Parse(cos_amount.Text)).amount += int.Parse(cos_amount.Text);/////
                cartRepos.Update(factory.GetCartFlyweight(p, int.Parse(med_amount.Text)));
            }
            else if ((factory.GetCartFlyweight(p, int.Parse(cos_amount.Text))).amount == 0)
            {
                factory.GetCartFlyweight(p, int.Parse(cos_amount.Text)).amount += int.Parse(cos_amount.Text);
                cartRepos.Create(factory.GetCartFlyweight(p, int.Parse(cos_amount.Text)));
            }
            else
            {
                cartRepos.Create(factory.GetCartFlyweight(p, int.Parse(cos_amount.Text)));
            }
        }

        private void cos_open_cart_Click(object sender, EventArgs e)
        {
            CartForm cart = new CartForm(cartRepos, medRepos, cosRepos);
            cart.Show();
        }

        private void cos_refresh_Click(object sender, EventArgs e)
        {
            Clear_Table(this.dataGridView2);
            //cosRepos = prov.GetFactory().GetCosmeticRepository();
            Load_Cos_Table(this.dataGridView2);
        }
    }
}
