using System.Windows.Forms;
using System.Linq;
using Util;
using System.Collections.Generic;

namespace ProductStock.CustomControls
{
    public partial class ListForm : Form
    {
        public Dictionary<string, string> Titles { get; set; }
        public ListForm()
        {
            InitializeComponent();

            Titles = new Dictionary<string, string>();
        }

        public void HideAuditColumns()
        {
            string[] defaultColumnsToHide = new string[] { "Id", "active",
                "IdInsert", "IpInsert", "DateInsert",
                "IdUpdate", "IpUpdate", "DateUpdate",
                "IdDelete", "IpDelete", "DateDelete"};

            for (int i = 0; i < defaultColumnsToHide.Length; i++)
            {
                if (Grid.Columns.Contains(defaultColumnsToHide[i]))
                {
                    Grid.Columns[defaultColumnsToHide[i]].Visible = false;
                }
            }

            ChangeColumnTitle();
        }

        public void LoadStores(Repository.StoreRepository StoreRepository)
        {
            StoreComboBox.ComboBox.DisplayMember = "Name";
            StoreComboBox.ComboBox.ValueMember = "Id";
            StoreComboBox.ComboBox.FillComboBox(StoreRepository.GetStores("", 0).ToList());

            if(StoreComboBox.Items.Count > 0)
            {
                StoreComboBox.SelectedIndex = 0;
            }
        }

        private void ChangeColumnTitle()
        {
            foreach(string key in Titles.Keys)
            {
                if(Grid.Columns[key] != null)
                {
                    Grid.Columns[key].HeaderText = Titles[key];
                }
            }
        }
    }
}
