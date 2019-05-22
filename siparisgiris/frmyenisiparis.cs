using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siparisgiris
{
    public partial class frmyenisiparis : Form
    {
        public frmyenisiparis()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        private void btnolustur_Click(object sender, EventArgs e)
        {
            Orders order = new Orders();
            order.CustomerID = comboBoxcust.SelectedValue.ToString();
            order.ShipVia =Convert.ToInt32( comboBoxkargo.SelectedValue);
            order.EmployeeID = Convert.ToInt32(comboBoxemp.SelectedValue);
            order.OrderDate = dateTimePickerorder.Value;
            order.RequiredDate = dateTimePickerreq.Value;
            order.ShippedDate = dateTimePickership.Value;
            db.Orders.Add(order);
            db.SaveChanges();
            MessageBox.Show(order.OrderID+"siparis ana kayıt eklendi.");
            frmorder frm = new frmorder(order.OrderID);
            frm.Show();
        }
        
        private void frmyenisiparis_Load(object sender, EventArgs e)
        {
            frmorder frm = new frmorder();
            comboBoxemp = frm.empdoldur(comboBoxemp);
            comboBoxcust = frm.custdoldur(comboBoxcust);
            comboBoxkargo = frm.shipdoldur(comboBoxkargo);
            //frmorder frm = new frmorder();
            //frm.combodoldur(comboBoxemp,comboBoxcust,comboBoxkargo,null); parametre vererek combo dolduru çağırmak istediğimizde kullandığımız metot.
            //var mfrm = (frmorder)Application.OpenForms["frmorder"];
            //if (mfrm != null)
            //    mfrm.combodoldur();
            //((frmorder)Application.OpenForms["frmorder"]).combodoldur();


        }

        //private void combodoldur()
        //{

        //    var elist = db.Set<Employees>().Select(x => new
        //    {
        //        x.EmployeeID,
        //        fulname = x.FirstName + x.LastName

        //    }).ToList();

        //    comboBoxemp.DataSource = elist;
        //    comboBoxemp.DisplayMember = "fulname";
        //    comboBoxemp.ValueMember = "EmployeeID";


        //    var clist = db.Customers.Select(x => new
        //    {
        //        x.CompanyName,
        //        x.CustomerID

        //    }).ToList();

        //    comboBoxcust.DataSource = clist;
        //    comboBoxcust.DisplayMember = "CompanyName";
        //    comboBoxcust.ValueMember = "CustomerID";


        //    var klist = db.Shippers.Select(x => new
        //    {
        //        x.CompanyName,
        //        x.ShipperID

        //    }).ToList();

        //    comboBoxkargo.DataSource = klist;
        //    comboBoxkargo.DisplayMember = "CompanyName";
        //    comboBoxkargo.ValueMember = "ShipperID";


        //}

    }
}
