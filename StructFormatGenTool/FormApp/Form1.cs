using Core.Help;
using Generator;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string name in Enum.GetNames(typeof(OutFormat.Type)))
                cbx_export_format.Items.Add(name);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            cbx_export_format.SelectedIndex = 0;
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

            tb_select_path.Text = dlg.FileName;
  
        }

        private void btn_save_path_Click(object sender, EventArgs e)
        {
            var savePath = new FolderBrowserDialog();
            savePath.ShowDialog();
            tb_save_path.Text = savePath.SelectedPath;
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            if (!InvaildSettingPara())
                return;
        }

        private bool InvaildSettingPara()
        {

            

            if (string.IsNullOrEmpty(tb_select_path.Text))
            {
                ShowMessage("Pls set the source file path");
                return false;
            }

            if (string.IsNullOrEmpty(tb_save_path.Text))
            {
                ShowMessage("Pls set the save file path");
                return false;
            }

            if (string.IsNullOrEmpty(edit_star_sheet.Text))
            {
                ShowMessage("Pls set the read star sheet");
                return false;
            }

            if (string.IsNullOrEmpty(edit_star_raw.Text))
            {
                ShowMessage("Pls set the read star raw");
                return false;
            }

            if (string.IsNullOrEmpty(edit_star_column.Text))
            {
                ShowMessage("Pls set the read star column");
                return false;
            }

            return true;
        }

        private bool InvaildText(string text)
            => InvaildSetting((txt) => {
                if (string.IsNullOrEmpty(text))
                {
                    return false;
                }
                    
                return true;
            }, text);

        private bool InvaildSetting(Func<string, bool> func, string text)
        {
            return func.Invoke(text);
        }

        private void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }

    }
}
