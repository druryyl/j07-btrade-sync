using j07_btrade_sync.Repository;
using j07_btrade_sync.Service;
using System;
using System.Linq;
using System.Windows.Forms;

namespace j07_btrade_sync
{
    public partial class Form1 : Form
    {
        private readonly BrgSyncService _brgSyncService;
        private readonly CustomerSyncService _customerSyncService;
        private readonly SalesPersonSyncService _salesPersonSyncService;

        private readonly BrgDal _brgDal;
        private readonly CustomerDal _customerDal;
        private readonly SalesPersonDal _salesPersonDal;

        public Form1()
        {
            InitializeComponent();

            _brgSyncService = new BrgSyncService();
            _customerSyncService = new CustomerSyncService();
            _salesPersonSyncService = new SalesPersonSyncService();

            _brgDal = new BrgDal();
            _customerDal = new CustomerDal();
            _salesPersonDal = new SalesPersonDal();

            SyncBrgButton.Click += SyncBrgButton_Click;
            SyncCustomerButton.Click += SyncCustomerButton_Click;
            SyncSalesPersonBotton.Click += SyncSalesPersonButton_Click;
        }

        private void SyncCustomerButton_Click(object sender, EventArgs e)
        {
            var listCustomer = _customerDal.ListData().ToList();
            var result = _customerSyncService.SyncCustomer(listCustomer);
            result.ContinueWith(task =>
            {
                if (task.Result.Item1)
                {
                    MessageBox.Show("Sync successful!");
                }
                else
                {
                    MessageBox.Show($"Sync failed: {task.Result.Item2}");
                }
            });
        }

        private void SyncBrgButton_Click(object sender, EventArgs e)
        {
            var listBrg = _brgDal.ListData().ToList();
            var result = _brgSyncService.SyncBrg(listBrg);
            result.ContinueWith(task =>
            {
                if (task.Result.Item1)
                {
                    MessageBox.Show("Sync successful!");
                }
                else
                {
                    MessageBox.Show($"Sync failed: {task.Result.Item2}");
                }
            });
        }
        private void SyncSalesPersonButton_Click(object sender, EventArgs e)
        {
            var listSalesPerson = _salesPersonDal.ListData().ToList();
            var result = _salesPersonSyncService.SyncSalesPerson(listSalesPerson);
            result.ContinueWith(task =>
            {
                if (task.Result.Item1)
                {
                    MessageBox.Show("Sync successful!");
                }
                else
                {
                    MessageBox.Show($"Sync failed: {task.Result.Item2}");
                }
            });
        }

    }
}
