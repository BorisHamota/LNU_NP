using MyPharmacy.DAL.Factories.Impl;
using MyPharmacy.DAL.Modules.Impl;
using MyPharmacy.DAL.Repositories.Abstract;
using System;
using System.Windows.Forms;

namespace WindowsFormsAdmin
{
    public partial class AppFormAdmin : Form
    {
        IMedicineRepository medRepos;
        ICosmeticRepository cosRepos;
        FactoryProvider prov;
        MedicineProductForm medSecondForm;
        CosmeticProductFrom cosSecondForm;
        public AppFormAdmin()
        {
            prov = new FactoryProvider();
            medRepos = prov.GetFactory().GetMedicineRepository();
            cosRepos = prov.GetFactory().GetCosmeticRepository();

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
        private void Form_Load(object sender, EventArgs e)
        {
            //
            Clear_Table(this.dataGridView1);
            Load_Med_Table(this.dataGridView1);
            //
            Clear_Table(this.dataGridView2);
            Load_Cos_Table(this.dataGridView2);
        }

        private void Med_Create_Click(object sender, EventArgs e)
        {
            try
            {
                medRepos.Create(new Medicine()
                {
                    Id = int.Parse(med_Id.Text),
                    name = med_name.Text ?? "",
                    expirationDate = med_expirationDate.Text,
                    amount = int.Parse(med_amount.Text),
                    storageTemperature = int.Parse(med_storageTemperature.Text)
                });
                MessageBox.Show("Created successfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Table(this.dataGridView1);
                Load_Med_Table(this.dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("exception!", ex.Message, MessageBoxButtons.OK);
            }
        }

        private void Med_Delete_Product_Click(object sender, EventArgs e)
        {
            medRepos.Delete((int)dataGridView1.CurrentCell.Value);
            Clear_Table(this.dataGridView1);
            Load_Med_Table(this.dataGridView1);
        }

        private void Med_Product_Details_Click(object sender, EventArgs e)
        {
            medSecondForm = new MedicineProductForm(medRepos, medRepos.GetById((int)dataGridView1.CurrentCell.Value));
            medSecondForm.Show();
        }

        private void Med_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Table(this.dataGridView1);
            //this.medRepos.Update(medSecondForm.GetProductBack());
            Load_Med_Table(this.dataGridView1);
        }

        private void Cos_Create_Click(object sender, EventArgs e)
        {
            try
            {
                cosRepos.Create(new Cosmetic()
                {
                    Id = int.Parse(cos_Id.Text),
                    name = cos_name.Text ?? "",
                    expirationDate = cos_expirationDate.Text,
                    amount = int.Parse(cos_amount.Text),
                    capacity = int.Parse(cos_capacity.Text),
                    storageTemperature = int.Parse(cos_storageTemperature.Text)
                });
                MessageBox.Show("Created successfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Table(this.dataGridView2);
                Load_Cos_Table(this.dataGridView2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("exception!", ex.Message, MessageBoxButtons.OK);
            }
        }

        private void Cos_Delete_Product_Click(object sender, EventArgs e)
        {
            cosRepos.Delete((int)dataGridView2.CurrentCell.Value);
            Clear_Table(this.dataGridView2);
            Load_Cos_Table(this.dataGridView2);
        }

        private void Cos_Product_Details_Click(object sender, EventArgs e)
        {
            cosSecondForm = new CosmeticProductFrom(cosRepos, cosRepos.GetById((int)dataGridView2.CurrentCell.Value));
            cosSecondForm.Show();
        }

        private void Cos_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Table(this.dataGridView2);
            //this.cosRepos.Update(cosSecondForm.GetProductBack());
            Load_Cos_Table(this.dataGridView2);
        }
    }
}
