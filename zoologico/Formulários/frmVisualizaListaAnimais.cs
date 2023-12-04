using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zoologico.Formulários
{
    public partial class frmVisualizaListaAnimais : Form
    {
        public frmVisualizaListaAnimais()
        {
            InitializeComponent();
        }

        private void FormfrmVisualizaListaAnimais_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Zoologico.Animais'. Você pode movê-la ou removê-la conforme necessário.
            this.animaisTableAdapter.Fill(this.dataSet_Zoologico.Animais);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
