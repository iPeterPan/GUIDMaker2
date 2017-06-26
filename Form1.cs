using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIDMaker2
{
    public partial class frmGUIDMaker : Form
    {
        string strGUID = Guid.NewGuid().ToString().ToLower();

        public frmGUIDMaker()
        {
            InitializeComponent();

            txtGUID.Text = strGUID;
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            object guid = Guid.NewGuid();
            strGUID = guid.ToString();

            string strResult = ReturnGUIDStringValue();

            txtGUID.Text = strResult;
            Clipboard.SetText(strResult);
        }


        private void Option_Clicked(object sender, EventArgs e)
        {
            string strResult = ReturnGUIDStringValue();

            txtGUID.Text = strResult;
            Clipboard.SetText(strResult);
        }


        private string ReturnGUIDStringValue()
        {
            string strResult = string.Empty;

            if (rdoUpper.Checked)
            {
                strResult = strGUID.ToUpper();
            }
            else
            {
                strResult = strGUID.ToLower();
            }

            string strFormat = string.Empty;
            if (!rdoNone.Checked)
            {
                if (rdo1.Checked) strFormat = "<{0}>";
                if (rdo2.Checked) strFormat = "{{{0}}}";
                if (rdo3.Checked) strFormat = "[{0}]";
                strResult = string.Format(strFormat, strResult);
            }

            return strResult;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
