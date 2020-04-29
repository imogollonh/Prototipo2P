using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Diseño.Mantenimientos;

namespace Capa_Diseño
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        bool ventanaVendedores = false;
        MantenimientoVendedores vendedor = new MantenimientoVendedores();
        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is MantenimientoVendedores);
            if (ventanaVendedores == false || frmC == null)
            {
                if (frmC == null)
                {
                    vendedor = new MantenimientoVendedores();
                }

                vendedor.MdiParent = this;
                vendedor.Show();
                Application.DoEvents();
                ventanaVendedores = true;
            }
            else
            {
                vendedor.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaLinea = false;
        MantenimientoLineas linea = new MantenimientoLineas();
        private void lineasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is MantenimientoLineas);
            if (ventanaLinea == false || frmC == null)
            {
                if (frmC == null)
                {
                    linea = new MantenimientoLineas();
                }

                linea.MdiParent = this;
                linea.Show();
                Application.DoEvents();
                ventanaLinea = true;
            }
            else
            {
                linea.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaMarca = false;
        MantenimientoMarcas marca = new MantenimientoMarcas();

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is MantenimientoMarcas);
            if (ventanaMarca == false || frmC == null)
            {
                if (frmC == null)
                {
                    marca = new MantenimientoMarcas();
                }

                marca.MdiParent = this;
                marca.Show();
                Application.DoEvents();
                ventanaMarca = true;
            }
            else
            {
                marca.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
    }
}
