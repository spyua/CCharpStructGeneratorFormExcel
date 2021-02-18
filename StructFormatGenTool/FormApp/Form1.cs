using Core.Help;
using System;
using System.Windows.Forms;

namespace FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_select_path_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog()
            {
                Title = "Select Excel File",
                Filter = "xlsx files (*.xlsx)|*.xlsx;",     //  CloseXML only use .xlsx
                RestoreDirectory = true,
                Multiselect = true
            };

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            if (FileOpHelper.Instance.IsFileLocked(dlg.FileName))
            {
                MessageBox.Show(dlg.FileName + "Excel opening....");
                return;
            }
        }

        private void btn_save_path_Click(object sender, EventArgs e)
        {

        }

        private void btn_export_Click(object sender, EventArgs e)
        {

        }
    }
}
