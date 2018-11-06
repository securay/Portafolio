using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PhotoSelector
{
    public partial class MainForm : Form
    {
        private LinkedList<string> SourceFiles;
        private LinkedList<string> LastFiles;
        private string[] Formats = new string[] { "png", "jpeg", "jpg", "bmp" };
        private bool JustCopy = false;
        public MainForm()
        {
            InitializeComponent();
            SourceFiles = new LinkedList<string>();
            LastFiles = new LinkedList<string>();
            AddKeyDownSupport();
        }

        private void AddKeyDownSupport()
        {
            foreach (Control control in MainLayoutPanel.Controls)
            {
                control.KeyDown += MainForm_KeyDown;
            }
        }

        private bool ShowFolderDialog(TextBox TargetTextBox)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                TargetTextBox.Text = FolderBrowserDialog.SelectedPath;
                return true;
            }
            return false;
        }

        private void SourceButton_Click(object sender, EventArgs e)
        {
            SourceFiles = new LinkedList<string>();
            LastFiles = new LinkedList<string>();
            if (ShowFolderDialog(SourceTextBox))
            {
                foreach(string file in Directory.GetFiles(SourceTextBox.Text))
                {
                    if (Formats.Any(f => file.EndsWith(f)))
                    {
                        SourceFiles.AddLast(file);
                    }
                }
                if(SourceFiles.Count > 0)
                {
                    MainPictureBox.Image = Image.FromFile(SourceFiles.First.Value);
                    StatusLabel.Text = String.Format("Imagenes encontradas: {0}", SourceFiles.Count);
                }
                else
                {
                    StatusLabel.Text = "No se encontraron imagenes";
                }
            }
            SourceTextBox.Focus();
        }

        private void TargetButton_Click(object sender, EventArgs e)
        {
            ShowFolderDialog(TargetTextBox);
            TargetTextBox.Focus();
        }

        private void MoveBack()
        {
            if(LastFiles.Count > 0)
            {
                SourceFiles.AddFirst(LastFiles.First.Value);
                Image image = MainPictureBox.Image;
                MainPictureBox.Image = Image.FromFile(LastFiles.First.Value);
                if (image != null)
                {
                    image.Dispose();
                }
                LastFiles.RemoveFirst();
            }
            StatusLabel.Text = String.Format("{0} imagenes en cola.", SourceFiles.Count);
        }

        private void MoveNext()
        {
            LastFiles.AddFirst(SourceFiles.First.Value);
            SourceFiles.RemoveFirst();
            if (SourceFiles.Count > 0)
            {
                Image image = MainPictureBox.Image;
                MainPictureBox.Image = Image.FromFile(SourceFiles.First.Value);
                if (image != null)
                {
                    image.Dispose();
                }
            }
            else
            {
                CleanPictureBox();
            }
            StatusLabel.Text = String.Format("{0} imagenes en cola.", SourceFiles.Count);
        }

        private void MoveImage()
        {
            string target = String.Format(@"{0}\{1}", TargetTextBox.Text, Path.GetFileName(SourceFiles.First.Value));
            if (File.Exists(target))
            {
                if(MessageBox.Show("Ya existe una imagen con el mismo nombre en la carpeta de destino." +
                    "\n¿Desea renombrarlo?",
                    "PhotoSelector", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string tmpTarget = target.Substring(0, target.LastIndexOf('.') - 1);
                    string targetExtension = target.Substring(target.LastIndexOf('.'));
                    int count = 1;
                    target = String.Format("{0} ({1}){2}", tmpTarget, count, targetExtension);
                    while (File.Exists(target))
                    {
                        count++;
                        target = String.Format("{0} ({1}){2}", tmpTarget, count, targetExtension);
                    }
                }
                else return;
            }

            try
            {
                CleanPictureBox();
                if (JustCopy)
                {
                    File.Copy(SourceFiles.First.Value, target);
                }
                else
                {
                    File.Move(SourceFiles.First.Value, target);
                }
                MoveNext();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CleanPictureBox()
        {
            var image = MainPictureBox.Image;
            MainPictureBox.Image = null;
            if (image != null)
            {
                image.Dispose();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (SourceTextBox.TextLength == 0)
            {
                MessageBox.Show("Debe seleccionar un directorio de origen.", "PhotoSelector",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (SourceFiles.Count == 0)
            {
                MessageBox.Show("No hay más archivos.", "PhotoSelector",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(TargetTextBox.TextLength == 0)
            {
                MessageBox.Show("Debe seleccionar un directorio de destino.", "PhotoSelector", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (e.KeyCode)
            {
                case Keys.Right: MoveNext(); break;
                case Keys.Up: MoveImage(); break;
                case Keys.Left: MoveBack(); break;
                default: break;
            }
            e.Handled = true;
        }

        private void HelpLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PhotoSelector\n" +
                "• Seleccione como origen el directorio que contiene las imagenes que quiere clasificar.\n" +
                "• Seleccione como destino el directorio que contendrá las imagenes seleccionadas.\n" +
                "• Para mover la imagen actual al directorio de destino presione flecha arriba.\n" +
                "• Para avanzar a la siguiente imagen presione flecha a la derecha.\n" +
                "• Si ya existe una imagen con el mismo nombre en el destino se consultará para renombrarla automaticamente.", 
                "PhotoSelector", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SplitLabel_Click(object sender, EventArgs e)
        {
            JustCopy = !JustCopy;
            SplitLabel.Image = JustCopy ? CheckedLabel.Image : UncheckedLabel.Image;
        }
    }
}
