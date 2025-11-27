using IFSPStore.App.Base;
using IFSPStore.App.ViewModels;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
using MySqlX.XDevAPI;
using System.Data;
using System.Globalization;

namespace IFSPStore.App.Register
{
    public partial class SaleForm : BaseForm
    {
        private readonly IBaseService<Sale> _saleService;
        private readonly IBaseService<User> _userService;
        private readonly IBaseService<Customer> _customerService;
        private readonly IBaseService<Product> _productService;
        private List<SaleItemModel> _saleItems;
        private List<SaleModel>? sales;

        public SaleForm(IBaseService<Sale> saleService, IBaseService<User> userService, IBaseService<Customer> customerService, IBaseService<Product> productService)
        {
            _saleService = saleService;
            _userService = userService;
            _customerService = customerService;
            _productService = productService;
            _saleItems = [];
            InitializeComponent();
            LoadComboBox();
            LoadGridSaleItem();
            New();
        }

        private void LoadComboBox()
        {
            mcbSalesman.ValueMember = "Id";
            mcbSalesman.DisplayMember = "Name";
            mcbSalesman.DataSource = _userService.Get<User>().ToList();

            mcbCustomer.ValueMember = "Id";
            mcbCustomer.DisplayMember = "Name";
            mcbCustomer.DataSource = _customerService.Get<Customer>().ToList();

            mcbProduct.ValueMember = "Id";
            mcbProduct.DisplayMember = "Name";
            mcbProduct.DataSource = _productService.Get<Product>().ToList();
        }

        private void FormToObject(Sale sale)
        {
            var saleDate = DateTime.ParseExact(
                mtbSaleDate.Text,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture
            ).ToUniversalTime();

            sale.Date = saleDate;

            if (int.TryParse(mcbSalesman.SelectedValue.ToString(), out var userId))
            {
                var salesMan = _userService.GetById<User>(userId);
                sale.Salesman = salesMan;
            }

            if (int.TryParse(mcbCustomer.SelectedValue.ToString(), out var customerId))
            {
                var customer = _customerService.GetById<Customer>(customerId);
                sale.Customer = customer;
            }

            sale.TotalValue = _saleItems.Sum(x => x.TotalValue);

            foreach (var item in _saleItems)
            {
                var saleItem = new SaleItem
                {
                    Sale = sale,
                    Product = _productService.GetById<Product>(item.ProductId),
                    UnitaryValue = item.UnitaryValue,
                    Quantity = item.Quantity,
                    TotalValue = item.TotalValue
                };

                sale.Items.Add(saleItem);
            }

        }

        protected override void New()
        {
            base.New();
            _saleItems.Clear();
            LoadGridSaleItem();
            mtbSaleDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected override void Save()
        {
            try
            {
                if (isEditMode)
                {
                    if (int.TryParse(mtbId.Text, out var id))
                    {
                        var sale = _saleService.GetById<Sale>(id);
                        FormToObject(sale);
                        sale = _saleService.Update<Sale, Sale, SaleValidator>(sale);
                    }
                }
                else
                {
                    var sale = new Sale();
                    FormToObject(sale);

                    _customerService.AttachObject(sale.Customer);
                    sale.Items.ForEach(p => _productService.AttachObject(p));

                    sale = _saleService.Add<Sale, Sale, SaleValidator>(sale);
                }

                tabControlRegister.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _saleService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void PopulateGrid()
        {
            sales = _saleService.Get<SaleModel>(["Customer", "Salesman"]).ToList();
            dataGridViewList.DataSource = sales;
            dataGridViewList.Columns["SalesmanId"]!.Visible = false;
            dataGridViewList.Columns["CustomerId"]!.Visible = false;
            //dataGridViewList.Columns["ValorTotal"].DefaultCellStyle.Format = "C2";
            //dataGridViewList.Columns["ValorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            try
            {
                int.TryParse(record?.Cells["Id"].Value.ToString(), out var id);
                mtbId.Text = record?.Cells["Id"].Value.ToString();
                mcbSalesman.SelectedValue = record?.Cells["SalesmanId"].Value;
                mcbCustomer.SelectedValue = record?.Cells["CustomerId"].Value;
                mtbSaleDate.Text = DateTime.TryParse(record?.Cells["Date"].Value.ToString(), out var date)
                   ? date.ToString("g")
                   : "";

                var venda = _saleService.GetById<Sale>(id, ["Customer", "Salesman", "Items", "Items.Product"]);
                _saleItems = new List<SaleItemModel>();
                foreach (var item in venda.Items)
                {
                    var saleItem = new SaleItemModel
                    (
                        item.Id,
                        item.Product!.Name,
                        item.Product!.Id,
                        item.Quantity,
                        item.UnitaryValue,
                        item.TotalValue
                    );
                    _saleItems.Add(saleItem);
                }
                LoadGridSaleItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGridSaleItem()
        {
            var source = new BindingSource();
            source.DataSource = _saleItems.ToArray();
            dataGridViewItens.DataSource = source;
            dataGridViewItens.Columns["Id"]!.Visible = false;
            //dataGridViewItens.Columns["ProductId"]!.HeaderText = @"Id.Product";
            //dataGridViewItens.Columns["UnitaryValue"]!.DefaultCellStyle.Format = "C2";
            //dataGridViewItens.Columns["ValorUnitario"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridViewItens.Columns["ValorTotal"]!.DefaultCellStyle.Format = "C2";
            //dataGridViewItens.Columns["ValorTotal"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridViewItens.Columns["Quantidade"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            SaleItemModel saleItem;

            if (int.TryParse(mcbProduct.SelectedValue.ToString(), out var idProduto) &&
                decimal.TryParse(mtbUnitaryValue.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out var unitaryValue) &&
                int.TryParse(mtbQuantity.Text, out var quantity))
            {
                var product = _productService.GetById<Product>(idProduto);

                saleItem = new SaleItemModel(
                    0,
                    product.Name,
                    product.Id,
                    quantity,
                    unitaryValue,
                    quantity * unitaryValue
                    );

                _saleItems.Add(saleItem);
                CalculaTotalVenda();
                LoadGridSaleItem();
            }
        }

        private void txtVlUnitario_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(mtbUnitaryValue.Text, out double value))
                mtbUnitaryValue.Text = string.Format(CultureInfo.CurrentCulture, @"{0:C2}", value);
            else
                mtbUnitaryValue.Text = string.Empty;

            CalculaTotalItem();
        }

        private void CalculaTotalItem()
        {
            var convVlr = float.TryParse(mtbUnitaryValue.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out float vlUnitario);
            var convQtd = int.TryParse(mtbQuantity.Text, out int quantidade);
            if (convVlr && convQtd)
            {
                var valorTotal = quantidade * vlUnitario;
                mtbTotalValue.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", valorTotal);
            }
        }

        private void CalculaTotalVenda()
        {
            lblValue.Text = $@"Valor Total: {string.Format(CultureInfo.CurrentCulture, "{0:C2}", _saleItems.Sum(x => x.TotalValue))}";
            lblQtdItens.Text = $@"Qtd. Produtos: {_saleItems.Sum(x => x.Quantity)}";
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            CalculaTotalItem();
        }
    }
}
