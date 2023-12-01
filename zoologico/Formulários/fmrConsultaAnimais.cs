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
    public partial class fmrConsultaAnimais : Form
    {
        public fmrConsultaAnimais()
        {
            InitializeComponent();
        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void animaisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animaisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_Zoologico);

        }

        private void fmrConsultaAnimais_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Zoologico.Animais'. Você pode movê-la ou removê-la conforme necessário.
            this.animaisTableAdapter.Fill(this.dataSet_Zoologico.Animais);

        }

        private void Filtrar_Click(object sender, EventArgs e)
        {

            string vColuna, vProcurar, vTexto, vFiltro;

            vColuna = cmbColuna.Text;
            vProcurar = cmbProcurar.Text;
            vTexto = txtPesquisa.Text;

            vFiltro = vColuna;

            if (vProcurar == "Que começa com") // %' apenas depois
            {
                vFiltro += " like '" + vTexto + "%'";
            }
            else if (vProcurar == "Que contém") // % antes e depois
            {
                vFiltro += " like '%" + vTexto + "%'";
            }
            else if (vProcurar == "Que termina com") // % apenas antes
            {
                vFiltro += " like '%" + vTexto + "'";
            }
            else if (vProcurar == "Igual a") // usa-se o igual sem % nem antes nem depois
            {
                vFiltro += " = " + vTexto + "'";
            }
            else //Todos
            {
                vFiltro = "";
            }

            animaisBindingSource.Filter = vFiltro;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
