using DGVPrinterHelper;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WFGoodFood.DataModel;

namespace WFGoodFood.GUI
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                orderBindingSource.DataSource = db.OrderList.ToList();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Execution Order List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
            printer.SubTitleFormatFlags =StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "GoodFood";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridViewDeliv);
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Close();
            Hide();
        }

        private void lbClose_MouseEnter(object sender, EventArgs e)
        {
            lbClose.ForeColor = Color.Red;
        }

        private void lbClose_MouseLeave(object sender, EventArgs e)
        {
            lbClose.ForeColor = Color.Black;
        }
    }
}
