using System.Windows.Forms;
using System.Linq;
using Util;

namespace ProductStock.CustomControls
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
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
    }
}
