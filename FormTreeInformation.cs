using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSUTreeAdmin
{
    public partial class FormTreeInformation : Form
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public FormTreeInformation()
        {
            InitializeComponent();
            cmbTreeType.SelectedIndex = 0;
        }

        // set tree information into dialog.
        public void setXY(double x, double y)
        {
            txtX.Text = String.Format("{0}", x);
            txtY.Text = String.Format("{0}", y);
        }

        public void setTreeType(int selectindex)
        {
            cmbTreeType.SelectedIndex = selectindex;
        }

        public void setTreeDiameter(double diameter)
        {
            txtDiameter.Text = string.Format("{0}", diameter);
        }

        public void setTreeAge(double age)
        {
            numAge.Value = (decimal)age;
        }


        // get tree information from dialog.
        public int getTreeType()
        {
            return (int)cmbTreeType.SelectedIndex;
        }

        public double getTreeDiameter()
        {
            return double.Parse(txtDiameter.Text);
        }

        public double getTreeAge()
        {
            return (double)numAge.Value;
        }
    }
}
