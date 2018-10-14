using Entity.Coolers;
using GUI.CustomControls;
using Repository.Coolers;
using System;
using System.Drawing;
using System.Windows.Forms;
using Util;

namespace GUI.View.CustomerView
{
    public partial class CustomerForm : BaseForm
    {
        private Customer _Customer;
        public Customer Customer
        {
            get
            {
                return _Customer;
            }
            set
            {
                _Customer = value;
                RefreshControls();
            }
        }

        private CustomerRepository CustomerRepository;
        private ButtonsContainer ButtonsContainer;

        public CustomerForm(CustomerRepository CustomerRepository)
        {
            this.CustomerRepository = CustomerRepository;

            StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();

            ButtonsContainer = new ButtonsContainer();
            ButtonsContainer.Dock = DockStyle.Fill;
            ButtonsContainer.SaveButton.Click += new EventHandler(SaveButton_Click);
            ButtonsContainer.CancelButton.Click += new EventHandler(CancelButton_Click);

            ButtonsPanel.Controls.Add(ButtonsContainer);
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
            Customer = new Customer();
        }

        public void Edit(Customer Customer)
        {
            this.Customer = Customer;
        }

        protected void RefreshForm()
        {
            Customer.RUC = RUCTextBox.Text.Trim();
            Customer.Name = NameTextBox.Text.Trim();
            Customer.Description = DescriptionTextBox.Text;
        }

        protected void RefreshControls()
        {
            RUCTextBox.Text = Customer.RUC;
            NameTextBox.Text = Customer.Name;
            DescriptionTextBox.Text = Customer.Description;
        }

        protected bool ValidateEntity()
        {
            return ValidateForm(
                ValidateAssertNotZeroString(RUCTextBox, "Ingrese el RUC", RUCTextBox.Text.Trim()) &&
                ValidateAssertNotZeroString(NameTextBox, "Ingrese la Razón Social", NameTextBox.Text.Trim()) &&
                ValidateAssertNotZeroString(DescriptionTextBox, "Ingrese la descrpción", DescriptionTextBox.Text.Trim())
            );
        }

        protected bool Save()
        {
            if (ValidateEntity())
            {
                RefreshForm();
                Entity.Exceptions.DuplicatedExceptionResult<Customer> Duplicated = CustomerRepository.findDuplicate(Customer);
                if(Duplicated.Reason == Entity.Exceptions.Reason.None)
                {
                    if (Customer.Id == Guid.Empty)
                    {
                        CustomerRepository.SaveAndFlush(Customer);
                    }
                    else
                    {
                        CustomerRepository.Update(Customer);
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
    }
}
