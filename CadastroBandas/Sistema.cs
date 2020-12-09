using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CadastroBandas
{
    public partial class Sistema : Form
    {
        

        public Sistema()
        {
            InitializeComponent();
            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            marcador.Height = btnCadastra.Height;
            marcador.Top = btnCadastra.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[0];
            

        }

        

        private void btnBusca_Click(object sender, EventArgs e)
        {
            marcador.Height = btnBusca.Height;
            marcador.Top = btnBusca.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }

        

   


        private void btnConfirmaRemocao_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {

        }

        void limpaForm()
        {
           
        }

        void listaBandas()
        {
            ConectaBanco con = new ConectaBanco();
            dgBandas.DataSource = con.lista();
            dgBandas.Columns["idbandas"].Visible = false;
        }


        private void Sistema_Load(object sender, EventArgs e)
        {
            listaBandas();
        }

        private void txtnomeBusca_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
