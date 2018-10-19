using GUI.CustomControls;
using Util;
using System;
using System.Linq;
using System.Windows.Forms;
using Entity.Auth;
using Repository.Auth;

namespace GUI.Auth.EmployeeView
{
    public partial class EmployeeForm : BaseForm
    {
        protected Employee Employee_;
        private EmployeeRepository EmployeeRepository { get; set; }

        public Employee Employee
        {
            get
            {
                return Employee_;
            }
            set
            {
                Employee_ = value;
                if(Employee_ != null)
                {
                    RefreshControls();
                }
            }
        }

        public EmployeeForm(EmployeeRepository EmployeeRepository)
        {
            this.EmployeeRepository = EmployeeRepository;
            InitializeComponent();
            ButtonsContainer panelButtons = new ButtonsContainer();
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.SaveButton.Click += new EventHandler(this.BtnOk_click);
            panelButtons.CancelButton.Click += new EventHandler(this.BtnCancel_Click);
            ButtonsPanel.Controls.Add(panelButtons);
            StartPosition = FormStartPosition.CenterScreen;

            DependencyComboBox.Init("Name", "Id", "Área", FillDependencyComboBox);
            DocumentTypeComboBox.Init("Name", "Id", "Tipo de Documento", FillDocumentTypeComboBox);
            PositionComboBox.Init("Name", "Id", "Puesto", FillPositionComboBox);
        }

        public void BtnOk_click(object sender, EventArgs e)
        {
            if (Save())
            {
                MessageDialog(MessageUtil.GlobalRecordSaved, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Hide();
            }
        }

        public void BtnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void Create()
        {
            FillDocumentTypeComboBox();
            FillDependencyComboBox();
            FillPositionComboBox();
            Employee = new Employee();
        }

        public void Edit(Guid id)
        {
            FillDocumentTypeComboBox();
            FillDependencyComboBox();
            FillPositionComboBox();
            Employee idt = EmployeeRepository.findById(id);
            Employee = idt;
            RefreshControls();
        }

        protected void RefreshForm()
        {
            Employee.Address = AddressTextBox.Text;
            Employee.Email = EmailTextBox.Text;
            Employee.Phone = PhoneTextBox.Text;
            Employee.DocumentType = DocumentTypeComboBox.SelectedItem as DocumentType;
            Employee.DocumentNumber = DocumentNumberComboBox.Text;
            Employee.PaternalSurname = PaternalSurnameTextBox.Text;
            Employee.MaternalSurname = MaternalSurnameTextBox.Text;
            Employee.PersonName = PersonNameTextBox.Text;
            Employee.Dependency = DependencyComboBox.SelectedItem as Dependency;
            Employee.Position = PositionComboBox.SelectedItem as Position;
        }

        protected void RefreshControls()
        {
            if (Employee.DocumentType != null)
            {
                DocumentTypeComboBox.QueryText = Employee.DocumentType.Name;
                DocumentTypeComboBox.FillComboBox();
                DocumentTypeComboBox.SelectedItem = Employee.DocumentType;
            }
            DocumentNumberComboBox.Text = Employee.DocumentNumber;
            PaternalSurnameTextBox.Text = Employee.PaternalSurname;
            MaternalSurnameTextBox.Text = Employee.MaternalSurname;
            PersonNameTextBox.Text = Employee.PersonName;
            PhoneTextBox.Text = Employee.Phone;
            EmailTextBox.Text = Employee.Email;
            AddressTextBox.Text = Employee.Address;
            if (Employee.Dependency != null)
            {
                DependencyComboBox.QueryText = Employee.Dependency.Name;
                DependencyComboBox.FillComboBox();
                DependencyComboBox.SelectedItem = Employee.Dependency;
            }
            if (Employee.Position != null)
            {
                PositionComboBox.QueryText = Employee.Position.Name;
                PositionComboBox.FillComboBox();
                PositionComboBox.SelectedItem = Employee.Position;
            }
            DocumentNumberComboBox.Text = Employee.DocumentNumber; 
        }

        protected bool ValidateEntity()
        {
            return ValidateForm(
                ValidateAssertNotNull(DocumentTypeComboBox, "Seleccione un tipo de documento", DocumentTypeComboBox.SelectedItem) &&
                ValidateAssertNotZeroString(DocumentNumberComboBox, "Ingrese el número de documento", DocumentNumberComboBox.Text.Trim()) &&
                ValidateAssertNotZeroString(PaternalSurnameTextBox, "Ingrese el apellido paterno", PaternalSurnameTextBox.Text.Trim()) &&
                ValidateAssertNotZeroString(MaternalSurnameTextBox, "Ingrese el apellido materno", MaternalSurnameTextBox.Text.Trim()) &&
                ValidateAssertNotZeroString(PersonNameTextBox, "Ingrese el nombre", PersonNameTextBox.Text.Trim()) &&
                ValidateAssertNotZeroString(EmailTextBox, "Ingrese el correo electrónico", EmailTextBox.Text.Trim()) &&
                ValidateAssertNotNull(DependencyComboBox, "Ingrese el área", DependencyComboBox.SelectedItem) &&
                ValidateAssertNotNull(PositionComboBox, "Ingrese el puesto", PositionComboBox.SelectedItem)
            );
        }

        protected bool Save()
        {
            if (ValidateEntity())
            {
                RefreshForm();
                Entity.Exceptions.DuplicatedExceptionResult<Employee> Duplicated = EmployeeRepository.findDuplicate(Employee);
                if (Duplicated.Reason == Entity.Exceptions.Reason.None)
                {
                    if (Employee.Id == Guid.Empty)
                    {
                        EmployeeRepository.SaveAndFlush(Employee);
                    }
                    else
                    {
                        EmployeeRepository.Update(Employee);
                    }
                    return true;
                }
                else
                {
                    if (Duplicated.Reason == Entity.Exceptions.Reason.Duplicated)
                    {
                        MessageDialog(Duplicated.Message, MessageBoxIcon.Exclamation);
                    }
                    else if (Duplicated.Reason == Entity.Exceptions.Reason.DuplicatedAndDeleted)
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

        protected void FillDocumentTypeComboBox()
        {
            using (DocumentTypeRepository DocumentTypeRepository = new DocumentTypeRepository())
            {
                IQueryable<DocumentType> DocumentTypes = DocumentTypeRepository.FindForComboBox(DocumentTypeComboBox.QueryText, true, 20);
                DocumentTypeComboBox.FillComboBox<DocumentType>(DocumentTypes);
            }
        }

        protected void FillDependencyComboBox()
        {
            using (DependencyRepository DependencyRepository = new DependencyRepository())
            {
                IQueryable<Dependency> Dependencies = DependencyRepository.FindForComboBox(DependencyComboBox.QueryText, true, 20);
                DependencyComboBox.FillComboBox<Dependency>(Dependencies);
            }
        }

        protected void FillPositionComboBox()
        {
            using (PositionRepository PositionRepository = new PositionRepository())
            {
                IQueryable<Position> Positions = PositionRepository.FindForComboBox(DependencyComboBox.QueryText, true, 20);
                PositionComboBox.FillComboBox<Position>(Positions);
            }
        }
    }
}
