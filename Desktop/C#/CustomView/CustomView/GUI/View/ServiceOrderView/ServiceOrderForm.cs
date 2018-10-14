using Entity.Coolers;
using Entity.Coolers.Extra;
using GUI.CustomControls;
using Repository.Coolers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Util;

namespace GUI.View.ServiceOrderView
{
    public partial class ServiceOrderForm : BaseForm, ILoadData
    {
        private ServiceOrder _ServiceOrder;
        public ServiceOrder ServiceOrder
        {
            get
            {
                return _ServiceOrder;
            }
            set
            {
                _ServiceOrder = value;
                RefreshControls();
            }
        }

        private PaginableDataGrid<ServiceOrderDetailRow> PaginableDataGrid;
        private ServiceOrderRepository ServiceOrderRepository;
        private CoolerRepository CoolerRepository;
        private ServiceOrderDetailRepository ServiceOrderDetailRepository;
        private ButtonsContainer ButtonsContainer;

        private List<ServiceOrderDetail> serviceOrderDetails = new List<ServiceOrderDetail>();

        public ServiceOrderForm(ServiceOrderRepository ServiceOrderRepository)
        {
            this.ServiceOrderRepository = ServiceOrderRepository;
            CoolerRepository = new CoolerRepository(ServiceOrderRepository.ApplicationContext);
            ServiceOrderDetailRepository = new ServiceOrderDetailRepository(ServiceOrderRepository.ApplicationContext);
            StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();

            ButtonsContainer = new ButtonsContainer();
            ButtonsContainer.Dock = DockStyle.Fill;
            ButtonsContainer.SaveButton.Click += new EventHandler(SaveButton_Click);
            ButtonsContainer.CancelButton.Click += new EventHandler(CancelButton_Click);
            ButtonsPanel.Controls.Add(ButtonsContainer);

            CustomerComboBox.Init("Name", "Id", "Cliente", FillCustomerComboBox);

            InitializeGrid();
        }

        protected void InitializeGrid()
        {
            PaginableDataGrid = new PaginableDataGrid<ServiceOrderDetailRow>(this);
            PaginableDataGrid.Grid.ReadOnly = true;
            PaginableDataGrid.CastSourceQueryToList = true;
            PaginableDataGrid.AddToolStripButton.Visible = false;
            PaginableDataGrid.ReloadToolStripButton.Click += new EventHandler(BtnRefresh_Click);
            PaginableDataGrid.DeleteToolStripButton.Click += new EventHandler(BtnDelete_Click);
            PaginableDataGrid.ReactivateToolStripButton.Visible = false;
            PaginableDataGrid.EditToolStripButton.Visible = false;


            PaginableDataGrid.Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            PaginableDataGrid.HeaderTexts["Code"] = "Código";
            PaginableDataGrid.HeaderTexts["Barcode"] = "Código de Barras";
            PaginableDataGrid.HeaderTexts["Returned"] = "Devuelto";

            GridPanel.Controls.Add(PaginableDataGrid);
        }

        public void LoadData()
        {
            var res = ServiceOrderDetailRepository.FindAllRow(ServiceOrder, PaginableDataGrid.ShowActive, 0);
            PaginableDataGrid.SourceQuery = serviceOrderDetails.Concat(res.ToList()).AsQueryable().Select(sod => 
            new ServiceOrderDetailRow()
            {
                Id = sod.Id,
                Active = sod.Active,
                Code = sod.Cooler.Code,
                Barcode = sod.Cooler.Barcode,
                Returned = sod.Returned
            }); ;
        }

        protected void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            if (PaginableDataGrid.SelectedEntity == null)
            {
                MessageDialog(MessageUtil.GlobalSelectRow, MessageBoxIcon.Exclamation);
                return;
            }

            int index = -1;
            for (int i = 0; i < serviceOrderDetails.Count; i++)
            {
                if(serviceOrderDetails[i].Cooler.Code == PaginableDataGrid.SelectedEntity.Code)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                if (MessageDialog(String.Format(Util.MessageUtil.GlobalDeleteConfirm,
                    PaginableDataGrid.SelectedEntity.Code), MessageBoxIcon.Question, MessageBoxButtons.YesNo)
                    == DialogResult.No)
                    return;
                serviceOrderDetails.RemoveAt(index);
                LoadData();
            }
            else
            {
                MessageDialog("Solo se pueden eliminar items no guardados", MessageBoxIcon.Exclamation);
            }
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
            ServiceOrder = new ServiceOrder();
        }

        public void Edit(ServiceOrder ServiceOrder)
        {
            this.ServiceOrder = ServiceOrder;
            LoadData();
        }

        protected void RefreshForm()
        {
            ServiceOrder.Code = CodeTextBox.Text.Trim();
            ServiceOrder.CustomerId = (CustomerComboBox.SelectedItem as Customer).Id;
        }

        protected void RefreshControls()
        {
            CodeTextBox.Text = ServiceOrder.Code;
            if (ServiceOrder.Customer != null)
            {
                CustomerComboBox.Text = ServiceOrder.Customer.Name;
                CustomerComboBox.SelectedItem = ServiceOrder.Customer;
            }
        }

        protected bool ValidateEntity()
        {
            return ValidateForm(
                ValidateAssertNotZeroString(CodeTextBox, "Ingrese el código", CodeTextBox.Text.Trim()) &&
                ValidateAssertNotNull(CustomerComboBox, "Seleccione el cliente", CustomerComboBox.SelectedItem) &&
                ValidateAssertNotEqual(PaginableDataGrid.Grid, "Debe ingresar almenos un cooler", PaginableDataGrid.Grid.Rows.Count, 0)
            );
        }

        protected bool Save()
        {
            if (ValidateEntity())
            {
                RefreshForm();
                Entity.Exceptions.DuplicatedExceptionResult<ServiceOrder> Duplicated = ServiceOrderRepository.findDuplicate(ServiceOrder);
                if(Duplicated.Reason == Entity.Exceptions.Reason.None)
                {
                    if (ServiceOrder.Id == Guid.Empty)
                    {
                        ServiceOrderRepository.SaveAndFlush(ServiceOrder);
                    }
                    else
                    {
                        ServiceOrderRepository.Update(ServiceOrder);
                    }
                    foreach(var sod in serviceOrderDetails)
                    {
                        sod.ServiceOrder = ServiceOrder;
                        ServiceOrderDetailRepository.SaveAndFlush(sod);
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

        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            if(CoolerTextBox.TextLength > 0)
            {
                Cooler cooler = CoolerRepository.FindByBarcode(CoolerTextBox.Text);
                if(cooler != null)
                {
                    if(!ServiceOrderDetailRepository.IsUsed(cooler))
                    {
                        serviceOrderDetails.Add(new ServiceOrderDetail()
                        {
                            Active = true,
                            Cooler = cooler,
                            ServiceOrder = ServiceOrder
                        });
                        CoolerTextBox.Text = "";
                        CoolerTextBox.Focus();
                        LoadData();
                    }
                    else
                    {
                        MessageDialog("El cooler ingresado está en uso",
                            MessageBoxIcon.Exclamation, MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageDialog("No existe ningún cooler con el código ingresado", 
                        MessageBoxIcon.Exclamation, MessageBoxButtons.OK);
                }
            }
        }

        private void FillCustomerComboBox()
        {
            using (CustomerRepository CustomerRepository = new CustomerRepository())
            {
                IQueryable<Customer> Customers = CustomerRepository.FindForComboBox(CustomerComboBox.QueryText, true, 20);
                CustomerComboBox.FillComboBox<Customer>(Customers);
            }
        }

        private void CoolerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                AddPictureBox_Click(sender, null);
            }
        }
    }
}
