using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POOEsferaRepaso.Entidades;

namespace POOEsferaRepaso.Windows
{
    public partial class FrmNuevaEsfera : Form
    {
        private Esfera esfera;
        public FrmNuevaEsfera()
        {
            InitializeComponent();
        }
        private void FrmNuevaEsfera_Load(object sender, EventArgs e)
        {
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LlenarComboBox();
            if (esfera != null)

                RadiotextBox1.Text = esfera.Radio.ToString();
        }
        

        private void LlenarComboBox()
        {
            ColorcomboBox1.DataSource = Enum.GetValues(typeof(ColorRelleno));
            ColorcomboBox1.SelectedItem = 0;
            TrazosComboBox2.DataSource = Enum.GetValues(typeof(Trazos));
            TrazosComboBox2.SelectedItem = 0;

        }
        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
       

        private void Okbutton2_Click(object sender, EventArgs e)
        {
            if (validardatos())
            {


                esfera = new Esfera()
                {
                    Radio = double.Parse(RadiotextBox1.Text),
                    color = (ColorRelleno)ColorcomboBox1.SelectedItem,
                    trazos = (Trazos)TrazosComboBox2.SelectedItem
                };
                
               
                DialogResult = DialogResult.OK;
            }
        }

        internal Esfera GetEsfera()
        {
            return esfera;
        }

        private bool validardatos()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (!double.TryParse(RadiotextBox1.Text, out double radio))
            {
                errorProvider1.SetError(RadiotextBox1, " el radio tiene que ser un numero ");
                valido = false;

            }
            else if (radio < 0)
            {
                errorProvider1.SetError(RadiotextBox1, "el radio tiene q ser mayor a 0 ");
                return false;
            }
            return valido;
        }

        internal void setEsfera(Esfera esfer)
        {
            esfera = esfer;
        }
    }

    
}
