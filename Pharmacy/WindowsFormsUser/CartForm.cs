using MyPharmacy.DAL.Repositories.Abstract;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsUser.CartForms
{
    public partial class CartForm : Form
    {
        IMedicineRepository medRepos;
        ICosmeticRepository cosRepos;
        ICartRepositoty cartRepos;
        public CartForm(ICartRepositoty cartRepos, IMedicineRepository medRepos, ICosmeticRepository cosRepos)
        {
            this.cartRepos = cartRepos;
            this.medRepos = medRepos;
            this.cosRepos = cosRepos;
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cartRepos.GetAll();
        }


        private void clear_cart_Click(object sender, EventArgs e)
        {
            foreach (var it in cartRepos.GetAll())
            {
                foreach (var medIt in medRepos.GetAll())
                {
                    if (it.Id == medIt.Id && it.name == medIt.name)
                    {
                        medIt.amount += it.amount;
                    }
                }
                foreach (var cosIt in cosRepos.GetAll())
                {
                    if (it.Id == cosIt.Id && it.name == cosIt.name)
                    {
                        cosIt.amount += it.amount;
                    }
                }
            }
            medRepos.Save();
            cosRepos.Save();
            cartRepos.DeleteAll();
        }

        private void cart_refresh_Click(object sender, EventArgs e)
        {
            var m = dataGridView1.GetType().GetMethod("OnDataSourceChanged", BindingFlags.NonPublic | BindingFlags.Instance);
            m.Invoke(dataGridView1, new object[] { EventArgs.Empty });
        }
    }
}
