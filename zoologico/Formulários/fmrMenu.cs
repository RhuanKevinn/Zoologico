using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zoologico.Formulários;

namespace zoologico
{
    public partial class fmrMenu : Form
    {
        public fmrMenu()
        {
            InitializeComponent();
        }

        private void Tb_animaisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_animaisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_230577DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_230577DataSet.tb_animais'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_animaisTableAdapter.Fill(this.db_230577DataSet.tb_animais);

        }

        private void AnimaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrCadAnimais objCadAnimais = new fmrCadAnimais();
            objCadAnimais.MdiParent = this;
            objCadAnimais.Show();
        }

  


        private void animaisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmrConsultaAnimais objConsultaAnimais = new fmrConsultaAnimais();
            objConsultaAnimais.MdiParent = this;
            objConsultaAnimais.Show();
        }

        private void relatórioAnimaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizaListaAnimais objVisualiza = new frmVisualizaListaAnimais();
            objVisualiza.MdiParent = this;
            objVisualiza.Show();

        }
    }
}
