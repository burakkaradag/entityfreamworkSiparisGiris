using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siparisgiris
{
    public partial class frmorder : Form
    {
        private int siparisno;
        NorthwindEntities db = new NorthwindEntities();
        Orders gelenorder;
        Order_Details secorderdet;
        public frmorder()
        {
            InitializeComponent();
        }

        public frmorder(int siparisno)
        {
            InitializeComponent();
            this.siparisno = siparisno;


        }

        private void sipdoldur()
        {
            textBoxorderno.Text = siparisno.ToString();
            dateTimePickerorder.Value = (DateTime)gelenorder.OrderDate;
            dateTimePickerreq.Value = (DateTime)gelenorder.RequiredDate;
            dateTimePickership.Value = (DateTime)gelenorder.ShippedDate;
        }

        public void combodoldur(ComboBox c1e, ComboBox c2c, ComboBox c3s, ComboBox c4p)
        {
            comboBoxemp = empdoldur(comboBoxemp);
            comboBoxcust = custdoldur(comboBoxcust);
            comboBoxkargo = shipdoldur(comboBoxkargo);

            var elist = db.Set<Employees>().Select(x => new
            {
                x.EmployeeID,
                fulname = x.FirstName + x.LastName

            }).ToList();

            c1e.DataSource = elist;
            c1e.DisplayMember = "fulname";
            c1e.ValueMember = "EmployeeID";
            try
            {
                c1e.SelectedValue = gelenorder.EmployeeID;
            }
            catch (Exception)
            {

               
            }
            

            var clist = db.Customers.Select(x => new
            {
                x.CompanyName,
                x.CustomerID

            }).ToList();

            c2c.DataSource = clist;
            c2c.DisplayMember = "CompanyName";
            c2c.ValueMember = "CustomerID";
            try
            {
                c2c.SelectedValue = gelenorder.CustomerID;
            }
            catch (Exception)
            {

                
            }
            

            var klist = db.Shippers.Select(x => new
            {
                x.CompanyName,
                x.ShipperID

            }).ToList();

            c3s.DataSource = klist;
            c3s.DisplayMember = "CompanyName";
            c3s.ValueMember = "ShipperID";
            try
            {
                c3s.SelectedValue = gelenorder.ShipVia;
            }
            catch (Exception)
            {
                
            }
           
            var prolist = db.Products.Select(x => new
            {
                x.ProductID,
                x.ProductName
            }).ToList();

            c4p.DataSource = prolist;
            c4p.DisplayMember = "ProductName";
            c4p.ValueMember = "ProductID";
            
        }

        public ComboBox shipdoldur(ComboBox comboBoxkargo)
        {
            var klist = db.Shippers.Select(x => new
            {
                x.CompanyName,
                x.ShipperID

            }).ToList();

            comboBoxkargo.DataSource = klist;
            comboBoxkargo.DisplayMember = "CompanyName";
            comboBoxkargo.ValueMember = "ShipperID";
            return comboBoxkargo;
        }

        public ComboBox custdoldur(ComboBox comboBoxcust)
        {
            var clist = db.Customers.Select(x => new
            {
                x.CompanyName,
                x.CustomerID

            }).ToList();

            comboBoxcust.DataSource = clist;
            comboBoxcust.DisplayMember = "CompanyName";
            comboBoxcust.ValueMember = "CustomerID";
            return comboBoxcust;
        }

        public ComboBox empdoldur(ComboBox comboBoxemp)
        {
            var elist = db.Set<Employees>().Select(x => new
            {
                x.EmployeeID,
                fulname = x.FirstName + x.LastName

            }).ToList();

            comboBoxemp.DataSource = elist;
            comboBoxemp.DisplayMember = "fulname";
            comboBoxemp.ValueMember = "EmployeeID";
            return comboBoxemp;
        }

        private void frmorder_Load(object sender, EventArgs e)
        {
            gelenorder = db.Orders.Find(siparisno);
            sipdoldur();
            combodoldur(comboBoxemp,comboBoxcust,comboBoxkargo,cmbboxproduct);
            sipdetaydoldur();
        }

        private void sipdetaydoldur()
        {
            var orderdetaillist = db.Order_Details.Select(x => new
            {
                x.ProductID,
                x.Products.ProductName,
                x.Quantity,
                x.UnitPrice,
                x.OrderID,
                linetotal = x.Quantity * x.UnitPrice

            }).Where(x => x.OrderID == siparisno).OrderBy(x => x.OrderID).ToList();

            dataGridView1.DataSource = orderdetaillist;

            int toplam = orderdetaillist.Count();
            decimal siptoplam = orderdetaillist.Sum(x => x.linetotal);
            txtboxsatır.Text = toplam.ToString();
            txtboxsiptoplam.Text = siptoplam.ToString();



        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            gelenorder.CustomerID = comboBoxcust.SelectedValue.ToString();
            gelenorder.EmployeeID = Convert.ToInt32(comboBoxemp.SelectedValue);
            gelenorder.ShipVia = Convert.ToInt32(comboBoxkargo.SelectedValue);
            gelenorder.OrderDate = dateTimePickerorder.Value;
            gelenorder.RequiredDate = dateTimePickerreq.Value;
            gelenorder.ShippedDate = dateTimePickership.Value;
            db.SaveChanges();


        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                db.Orders.Remove(gelenorder);
                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("öncelikle siparis detayları silmeliniz gerekir.");

            }
        }

        private void btnekledetay_Click(object sender, EventArgs e)
        {
            DbContextTransaction tran = db.Database.BeginTransaction();
            try
            {
                Order_Details od = new Order_Details();
                od.OrderID = siparisno;
                od.ProductID = Convert.ToInt32(cmbboxproduct.SelectedValue);
                od.Quantity = Convert.ToInt16(txtboxmiktar.Text);
                Products secproduct = db.Products.Find(od.ProductID);
                od.UnitPrice = (decimal)secproduct.UnitPrice;
                //  od.Discount =Convert.ToInt32( txtboxiskonto.Text);
                db.Order_Details.Add(od);

                db.SaveChanges();

                tran.Commit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tran.Rollback();

            }

            sipdetaydoldur();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilenproductıd = (int)dataGridView1.CurrentRow.Cells[0].Value;
            secorderdet = db.Order_Details.Find(siparisno, secilenproductıd);
            txtboxmiktar.Text = secorderdet.Quantity.ToString();
            cmbboxproduct.SelectedValue = secorderdet.ProductID;



        }

        private void btnsildetay_Click(object sender, EventArgs e)
        {
            db.Order_Details.Remove(secorderdet);
            db.SaveChanges();
            sipdetaydoldur();
        }

        private void btngünceldetay_Click(object sender, EventArgs e)
        {
            //DbContextTransaction tran = db.Database.BeginTransaction();
            //try
            //{
            //    secorderdet.Quantity = Convert.ToInt16(txtboxmiktar.Text);

            //    db.SaveChanges();
            //    tran.Commit();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    tran.Rollback();

            //}


            //sipdetaydoldur();

        }
    }
}
