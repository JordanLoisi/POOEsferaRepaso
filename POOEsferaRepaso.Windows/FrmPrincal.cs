using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POOEsferaRepaso.Datos;
using POOEsferaRepaso.Entidades;

namespace POOEsferaRepaso.Windows
{
    public partial class FrmPrincal : Form
    {
        public FrmPrincal()
        {
            InitializeComponent();
        }
        private RepositorioDeEsferas repo = new RepositorioDeEsferas();
        private List<Esfera> lista;
        private int cantidad;

        private void SalirtoolStripButton7_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea salir del programa?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            
            if (dr == DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

        private void NuevotoolStripButton1_Click(object sender, EventArgs e)
        {
            FrmNuevaEsfera frm = new FrmNuevaEsfera();
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            Esfera esfera = frm.GetEsfera();
            DataGridViewRow r = ConstruirFila();
            SetearFila(r, esfera);
            AgregarFila(r);
            cantidad = repo.GatCantidad();
            MostrarTotal();

        }

        private void MostrarTotal()
        {

            cantidadlabel.Text = cantidad.ToString();

        }

        private void MostrarLista()
        {
            EsferadataGridView2.Rows.Clear();
            foreach (var esfera in lista)
            {
                var r = ConstruirFila();
                SetearFila(r, esfera);
                AgregarFila(r);

            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            EsferadataGridView2.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Esfera esfera)
        {
            r.Cells[ColumnArea.Index].Value = esfera.GetArea().ToString();
            r.Cells[ColumnColor.Index].Value = esfera.color;
            r.Cells[ColumnRadio.Index].Value = esfera.Radio.ToString();
            r.Cells[ColumnTrazos.Index].Value = esfera.trazos;
            r.Cells[ColumnVolumen.Index].Value = esfera.GetVolumen().ToString();

            r.Tag = esfera;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(EsferadataGridView2);
            return r;
        }

        private void EditartoolStripButton2_Click(object sender, EventArgs e)
        {
            if (EsferadataGridView2.Rows.Count ==0)
            {
                return;
            }
            var r = EsferadataGridView2.SelectedRows[0];
            Esfera esfera = r.Tag as Esfera;
            FrmNuevaEsfera frm = new FrmNuevaEsfera() { Text = "Editar datos" };
            frm.setEsfera(esfera);

            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }
            esfera = frm.GetEsfera();
            SetearFila(r, esfera);
            MessageBox.Show("se agrego la fila ");
        }

        private void BorrartoolStripButton3_Click(object sender, EventArgs e)
        {
            if (EsferadataGridView2.Rows.Count==0)
            {
                return;
            }
            var r = EsferadataGridView2.SelectedRows[0];
            Esfera esfera = r.Tag as Esfera;
            
            DialogResult dr = MessageBox.Show("¿Desea eliminar la fila?", "Confirmar selección", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                MessageBox.Show("el usuario se arrepintio ");
                return;
            }
            if (repo.Borrar(esfera))
            {
                repo.Borrar(esfera);
                lista.Remove(esfera);
                EsferadataGridView2.Rows.Remove(r);
                cantidad = repo.GetCantidad();

            }
        }

        private void RestaurartoolStripButton5_Click(object sender, EventArgs e)
        {
            lista = repo.GetLista();
            MostrarLista();
            cantidad = repo.GetCantidad();
            MostrarTotal();

        }

        private void FrmPrincal_Load(object sender, EventArgs e)
        {
            repo = new RepositorioDeEsferas();
            lista = repo.GetLista();
            if (cantidad<0)
            {
                MostrarLista();
            }
            else
            {
                MessageBox.Show("El Repositorio esta vacío", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            MostrarTotal();
        }

        private void GuardartoolStripButton6_Click(object sender, EventArgs e)
        {
            ManejadorDeArchivosSecuenciales.GuardarArchivoSecuenciales(repo.GetLista());
            MessageBox.Show("Archivo guardado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void FiltrartoolStripButton4_Click(object sender, EventArgs e)
        {
            
        }

        

        private void acendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var orden = Ordenar.Acendente;
            lista = repo.Ordena(orden);
            MostrarLista();
        }

        private void decenteRiberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var orden = Ordenar.Decendente;
            lista = repo.Ordena(orden);
            MostrarLista();
        }
    }
}
