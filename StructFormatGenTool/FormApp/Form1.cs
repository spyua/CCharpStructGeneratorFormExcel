using Core.Help;
using Generator;
using StructGenerator;
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
            edit_star_sheet.Text = "1";
            edit_star_raw.Text = "3";
            edit_star_column.Text = "3";
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
            if (!InvalidSettingPara())
                return;

            var outType = (OutFormat.Type)cbx_export_format.SelectedIndex;
            var excelFile = new ExcelFile()
            {
                SourcePath = tb_select_path.Text,
                ExportPath = tb_save_path.Text,
                OutFileName = "Demo",

                StarSheet = Int32.Parse(edit_star_sheet.Text),
                StarReadRaw = Int32.Parse(edit_star_raw.Text),
                StarReadCloumn = Int32.Parse(edit_star_column.Text),
            };

            var file = FormatFactory.Create(outType, excelFile);
            file.Decode();
            file.GenFile();
        }

        private void ValidtionText()
        {
            AssertText(tb_select_path.Text, "Pls set the source file path");
            AssertText(tb_save_path.Text, "Pls set the save file path");

            AssertText(edit_star_sheet.Text, "Pls set the read star sheet");
            AssertText(edit_star_raw.Text, "Pls set the read star raw");
            AssertText(edit_star_column.Text, "Pls set the read star column");
        }

        private bool InvalidSettingPara()
        {
            try
            {
                ValidtionText();
                return true;

            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
    
        private void AssertText(string text, string errorMessage)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException(errorMessage);
            }
        }


        //private bool InvaildText(string text)
        //    => InvaildSetting((txt) => {
        //        if (string.IsNullOrEmpty(text))
        //        {
        //            return false;
        //        }
                    
        //        return true;
        //    }, text);

        //private bool InvaildSetting(Func<string, bool> func, string text)
        //{
        //    return func.Invoke(text);
        //}

        //private void ShowMessage(string msg)
        //{
        //    MessageBox.Show(msg);
        //}

    }
}
