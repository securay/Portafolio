using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GUI.CustomControls
{
    public partial class ExportForm <T> : BaseForm
    {
        protected IQueryable<T> SourceQuery;
        protected Dictionary<string, string> ColumnNames;
        protected int PageNumber, PageSize, MaxPage;
        public List<string> HiddenColumns;

        public ExportForm(IQueryable<T> SourceQuery, int PageSize, int MaxPage, Dictionary<string, string> ColumnNames, params string[] HiddenColumns)
        {
            this.SourceQuery = SourceQuery;
            this.ColumnNames = ColumnNames;
            this.HiddenColumns = HiddenColumns.ToList();
            this.PageSize = PageSize;
            this.MaxPage = MaxPage;
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            byte[] excel = null;
            if (AllCheckBox.Checked)
            {
                excel = Util.ExcelExportUtil.ExportExcel<T>(
                    SourceQuery.ToList(), ColumnNames, "",
                    HiddenColumns.ToArray());
            }
            else
            {
                if (StartPageTextBox.Text.Length > 0 && EndPageTextBox.Text.Length > 0)
                {
                    excel = Util.ExcelExportUtil.ExportExcel<T>(
                        SourceQuery.Skip((int.Parse(StartPageTextBox.Text) - 1) * PageSize).
                                Take((int.Parse(EndPageTextBox.Text) - 1) * PageSize).ToList(), ColumnNames, "",
                        HiddenColumns.ToArray());
                }
                else
                {
                    MessageDialog("Error al exportar", MessageBoxIcon.Exclamation);
                }
            }

            if (excel != null)
            {
                if (SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (SaveFileDialog.FileName != null)
                    {
                        File.WriteAllBytes(SaveFileDialog.FileName, excel);
                        MessageDialog("Se exportaron los datos con exito", MessageBoxIcon.Information);
                        Hide();
                    }
                }
            }
        }
    }
}
