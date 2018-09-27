using Entity.Coolers;
using GUI.CustomControls;
using Repository.Coolers;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Util;

namespace GUI.View.CoolerView
{
    public partial class CoolerForm : BaseForm
    {
        private Cooler _Cooler;
        public Cooler Cooler
        {
            get
            {
                return _Cooler;
            }
            set
            {
                _Cooler = value;
                RefreshControls();
            }
        }

        private CoolerRepository CoolerRepository;
        private ButtonsContainer ButtonsContainer;

        public CoolerForm(CoolerRepository CoolerRepository)
        {
            this.CoolerRepository = CoolerRepository;

            StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
            Text = "Cooler";

            ButtonsContainer = new ButtonsContainer();
            ButtonsContainer.Dock = DockStyle.Fill;
            ButtonsContainer.SaveButton.Click += new EventHandler(SaveButton_Click);
            ButtonsContainer.CancelButton.Click += new EventHandler(CancelButton_Click);

            ButtonsPanel.Controls.Add(ButtonsContainer);

            CapacityTextBox.KeyPress += Util.OnlyDecimalNumbers.OnlyDecimalNumbers_KeyPress;
        }

        public void SaveButton_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                MessageDialog(MessageUtil.GlobalRecordSaved, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Hide();
            }
            else
            {
                ButtonsContainer.SaveButton.Enabled = true;
                ButtonsContainer.CancelButton.Enabled = true;
            }
        }

        public void CancelButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void Create()
        {
            Cooler = new Cooler();
        }

        public void Edit(Cooler Cooler)
        {
            this.Cooler = Cooler;
        }

        protected void RefreshForm()
        {
            Cooler.Code = CodeTextBox.Text.Trim();
            Cooler.Barcode = BarcodeTextBox.Text.Trim();
            Cooler.Capacity = CapacityTextBox.TextLength == 0 ? 0 : decimal.Parse(CapacityTextBox.Text);
            Cooler.Color = ColorTextBox.BackColor.ToArgb();
            Cooler.MeasureUnitId = (MeasureUnitComboBox.SelectedItem as MeasureUnit).Id;
        }

        protected void RefreshControls()
        {
            CodeTextBox.Text = Cooler.Code;
            BarcodeTextBox.Text = Cooler.Barcode;
            CapacityTextBox.Text = Cooler.Capacity == 0 ? "" : Cooler.Capacity.ToString("#0.00");
            ColorTextBox.BackColor = Color.FromArgb(Cooler.Color);
            if(Cooler.MeasureUnit != null)
            {
                MeasureUnitComboBox.Text = Cooler.MeasureUnit.Name;
                MeasureUnitComboBox.SelectedItem = Cooler.MeasureUnit;
            }
        }

        protected bool ValidateEntity()
        {
            return ValidateForm(
                ValidateAssertNotZeroString(CodeTextBox, "Ingrese el código", CodeTextBox.Text.Trim()) &&
                ValidateAssertNotZeroString(BarcodeTextBox, "Ingrese el código de barras", BarcodeTextBox.Text.Trim()) &&
                ValidateAssertNotZeroString(BarcodeTextBox, "Ingrese la capacidad", CapacityTextBox.Text.Trim()) &&
                ValidateAssertNotNull(MeasureUnitComboBox, "Seleccione la unidad de medida", MeasureUnitComboBox.SelectedItem)
            );
        }

        protected bool Save()
        {
            if (ValidateEntity())
            {
                RefreshForm();
                Entity.Exceptions.DuplicatedExceptionResult<Cooler> Duplicated = CoolerRepository.findDuplicate(Cooler);
                if(Duplicated.Reason == Entity.Exceptions.Reason.None)
                {
                    if (Cooler.Id == Guid.Empty)
                    {
                        CoolerRepository.SaveAndFlush(Cooler);
                    }
                    else
                    {
                        CoolerRepository.Update(Cooler);
                    }
                    return true;
                }
                else
                {
                    if (Duplicated.Reason == Entity.Exceptions.Reason.Duplicated)
                    {
                        MessageDialog(Duplicated.Message, MessageBoxIcon.Exclamation);
                    }
                    else if(Duplicated.Reason == Entity.Exceptions.Reason.DuplicatedAndDeleted)
                    {
                        MessageDialog(Duplicated.Message, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageDialog(Duplicated.Message, MessageBoxIcon.Information);
                    }
                }
            }
            return false;
        }

        private void FillMeasureUnitComboBox()
        {
            using (MeasureUnitRepository MeasureUnitRepository = new MeasureUnitRepository())
            {
                MeasureUnitComboBox.DisplayMember = "Name";
                MeasureUnitComboBox.ValueMember = "Id";
                IQueryable<MeasureUnit> ProductCategories = MeasureUnitRepository.FindAll(MeasureUnitComboBox.Text, true, 20);
                MeasureUnitComboBox.FillComboBox<MeasureUnit>(ProductCategories);
            }
        }

        private void MeasureUnitComboBox_TextChanged(object sender, EventArgs e)
        {
            if (MeasureUnitComboBox.SelectedItem == null)
            {
                FillMeasureUnitComboBox();
                MeasureUnitComboBox.SelectionStart = MeasureUnitComboBox.Text.Length;
            }
        }

        private void ColorTextBox_Click(object sender, EventArgs e)
        {
            if(ColorDialog.ShowDialog() == DialogResult.OK)
            {
                ColorTextBox.BackColor = ColorDialog.Color;
            }
        }
    }
}
