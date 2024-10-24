using System.IO;

namespace DzDoubleForm
{
    public partial class FrmRead : Form
    {
        public void setText(string text)
        {
            tbFileText.Text = text;
        }
        public FrmRead()
        {
            InitializeComponent();
            btnEdit.Enabled = false;
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            tbFileText.Clear();
            using (var dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string fileText = File.ReadAllText(dialog.FileName);
                    tbFileText.Text = fileText;
                    btnEdit.Enabled = true;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var frmEdit = new FrmEdit();
            frmEdit.text = tbFileText.Text;
            frmEdit.ptrFrmRead = this;
            frmEdit.Show();

        }
    }
}
