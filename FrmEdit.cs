using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DzDoubleForm
{
    public partial class FrmEdit : Form
    {
        public string text;
        public FrmRead ptrFrmRead = null;
        public FrmEdit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            text = tbEdit.Text;
            ptrFrmRead.setText(text);
            Close();
        }

        private void FrmEdit_Shown(object sender, EventArgs e)
        {
            tbEdit.Text = text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbEdit.Clear();
            Close();
        }
    }
}
