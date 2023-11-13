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
    public partial class fmrCadAnimais : Form
    {
        public fmrCadAnimais()
        {
            InitializeComponent();
        }

        private void Tb_animaisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_animaisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_230577DataSet);

        }

        private void FmrCadAnimais_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Zoologico.Animais'. Você pode movê-la ou removê-la conforme necessário.
            this.animaisTableAdapter.Fill(this.dataSet_Zoologico.Animais);
            // TODO: esta linha de código carrega dados na tabela 'db_230577DataSet.tb_animais'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_animaisTableAdapter.Fill(this.db_230577DataSet.tb_animais);

        }

        private void AnimaisDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
