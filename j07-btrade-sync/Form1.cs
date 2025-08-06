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
        private readonly KategoriSyncService _kategoriSyncService;
        private readonly WilayahSyncService _wilayahSyncService;

        private readonly BrgDal _brgDal;
        private readonly CustomerDal _customerDal;
        private readonly SalesPersonDal _salesPersonDal;
        private readonly KategoriDal _kategoriDal;
        private readonly WilayahDal _wilayahDal;

        public Form1()
        {
            InitializeComponent();

            _brgSyncService = new BrgSyncService();
            _customerSyncService = new CustomerSyncService();
            _salesPersonSyncService = new SalesPersonSyncService();
            _kategoriSyncService = new KategoriSyncService();
            _wilayahSyncService = new WilayahSyncService();

            _brgDal = new BrgDal();
            _customerDal = new CustomerDal();
            _salesPersonDal = new SalesPersonDal();
            _kategoriDal = new KategoriDal();
            _wilayahDal = new WilayahDal();

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
                    //MessageBox.Show("Sync successful!");
                }
                else
                {
                    MessageBox.Show($"Sync failed: {task.Result.Item2}");
                    return;
                }
            });

            var listKategori = _kategoriDal.ListData().ToList();
            var kategoriResult = _kategoriSyncService.SyncKategori(listKategori);
            kategoriResult.ContinueWith(task =>
            {
                if (task.Result.Item1)
                {
                    MessageBox.Show("Brg-Kategori sync successful!");
                }
                else
                {
                    MessageBox.Show($"Kategori sync failed: {task.Result.Item2}");
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
                    //MessageBox.Show("Sync successful!");
                }
                else
                {
                    MessageBox.Show($"Sync failed: {task.Result.Item2}");
                }
            });

            var listWilayah = _wilayahDal.ListData().ToList();
            var wilayahResult = _wilayahSyncService.SyncWilayah(listWilayah);
            wilayahResult.ContinueWith(task =>
            {
                if (task.Result.Item1)
                {
                    MessageBox.Show("SalesPerson-Wilayah sync successful!");
                }
                else
                {
                    MessageBox.Show($"Wilayah sync failed: {task.Result.Item2}");
                }
            });
        }

    }
}
