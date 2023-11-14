namespace zoologico.Formulários
{
    partial class fmrCadAnimais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label classeLabel;
            System.Windows.Forms.Label pesoLabel;
            System.Windows.Forms.Label data_nascimentoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrCadAnimais));
            this.db_230577DataSet = new zoologico.db_230577DataSet();
            this.tb_animaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_animaisTableAdapter = new zoologico.db_230577DataSetTableAdapters.tb_animaisTableAdapter();
            this.tableAdapterManager = new zoologico.db_230577DataSetTableAdapters.TableAdapterManager();
            this.tb_animaisBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_animaisBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataSet_Zoologico = new zoologico.Dados.DataSet_Zoologico();
            this.animaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animaisTableAdapter = new zoologico.Dados.DataSet_ZoologicoTableAdapters.AnimaisTableAdapter();
            this.tableAdapterManager1 = new zoologico.Dados.DataSet_ZoologicoTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.classeTextBox = new System.Windows.Forms.TextBox();
            this.pesoTextBox = new System.Windows.Forms.TextBox();
            this.data_nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.animaisDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            classeLabel = new System.Windows.Forms.Label();
            pesoLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_230577DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_animaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_animaisBindingNavigator)).BeginInit();
            this.tb_animaisBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Zoologico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(272, 111);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(25, 20);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(272, 151);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(53, 20);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "nome:";
            // 
            // classeLabel
            // 
            classeLabel.AutoSize = true;
            classeLabel.Location = new System.Drawing.Point(272, 191);
            classeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            classeLabel.Name = "classeLabel";
            classeLabel.Size = new System.Drawing.Size(58, 20);
            classeLabel.TabIndex = 5;
            classeLabel.Text = "classe:";
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.Location = new System.Drawing.Point(272, 231);
            pesoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new System.Drawing.Size(48, 20);
            pesoLabel.TabIndex = 7;
            pesoLabel.Text = "peso:";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.Location = new System.Drawing.Point(272, 272);
            data_nascimentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(131, 20);
            data_nascimentoLabel.TabIndex = 9;
            data_nascimentoLabel.Text = "data nascimento:";
            // 
            // db_230577DataSet
            // 
            this.db_230577DataSet.DataSetName = "db_230577DataSet";
            this.db_230577DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_animaisBindingSource
            // 
            this.tb_animaisBindingSource.DataMember = "tb_animais";
            this.tb_animaisBindingSource.DataSource = this.db_230577DataSet;
            // 
            // tb_animaisTableAdapter
            // 
            this.tb_animaisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_animaisTableAdapter = this.tb_animaisTableAdapter;
            this.tableAdapterManager.UpdateOrder = zoologico.db_230577DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_animaisBindingNavigator
            // 
            this.tb_animaisBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_animaisBindingNavigator.BindingSource = this.tb_animaisBindingSource;
            this.tb_animaisBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_animaisBindingNavigator.DeleteItem = null;
            this.tb_animaisBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tb_animaisBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tb_animaisBindingNavigatorSaveItem});
            this.tb_animaisBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_animaisBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_animaisBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_animaisBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_animaisBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_animaisBindingNavigator.Name = "tb_animaisBindingNavigator";
            this.tb_animaisBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tb_animaisBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_animaisBindingNavigator.Size = new System.Drawing.Size(862, 33);
            this.tb_animaisBindingNavigator.TabIndex = 0;
            this.tb_animaisBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // tb_animaisBindingNavigatorSaveItem
            // 
            this.tb_animaisBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_animaisBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_animaisBindingNavigatorSaveItem.Image")));
            this.tb_animaisBindingNavigatorSaveItem.Name = "tb_animaisBindingNavigatorSaveItem";
            this.tb_animaisBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.tb_animaisBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tb_animaisBindingNavigatorSaveItem.Click += new System.EventHandler(this.Tb_animaisBindingNavigatorSaveItem_Click);
            // 
            // dataSet_Zoologico
            // 
            this.dataSet_Zoologico.DataSetName = "DataSet_Zoologico";
            this.dataSet_Zoologico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animaisBindingSource
            // 
            this.animaisBindingSource.DataMember = "Animais";
            this.animaisBindingSource.DataSource = this.dataSet_Zoologico;
            // 
            // animaisTableAdapter
            // 
            this.animaisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AnimaisTableAdapter = this.animaisTableAdapter;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = zoologico.Dados.DataSet_ZoologicoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(412, 106);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(46, 26);
            this.idTextBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(412, 146);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(175, 26);
            this.nomeTextBox.TabIndex = 4;
            // 
            // classeTextBox
            // 
            this.classeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource, "classe", true));
            this.classeTextBox.Location = new System.Drawing.Point(412, 186);
            this.classeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.classeTextBox.Name = "classeTextBox";
            this.classeTextBox.Size = new System.Drawing.Size(175, 26);
            this.classeTextBox.TabIndex = 6;
            // 
            // pesoTextBox
            // 
            this.pesoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource, "peso", true));
            this.pesoTextBox.Location = new System.Drawing.Point(412, 226);
            this.pesoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pesoTextBox.Name = "pesoTextBox";
            this.pesoTextBox.Size = new System.Drawing.Size(175, 26);
            this.pesoTextBox.TabIndex = 8;
            // 
            // data_nascimentoDateTimePicker
            // 
            this.data_nascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.animaisBindingSource, "data_nascimento", true));
            this.data_nascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_nascimentoDateTimePicker.Location = new System.Drawing.Point(412, 266);
            this.data_nascimentoDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.data_nascimentoDateTimePicker.Name = "data_nascimentoDateTimePicker";
            this.data_nascimentoDateTimePicker.Size = new System.Drawing.Size(175, 26);
            this.data_nascimentoDateTimePicker.TabIndex = 10;
            // 
            // animaisDataGridView
            // 
            this.animaisDataGridView.AutoGenerateColumns = false;
            this.animaisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animaisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.animaisDataGridView.DataSource = this.animaisBindingSource;
            this.animaisDataGridView.Location = new System.Drawing.Point(18, 338);
            this.animaisDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.animaisDataGridView.Name = "animaisDataGridView";
            this.animaisDataGridView.RowHeadersWidth = 62;
            this.animaisDataGridView.Size = new System.Drawing.Size(828, 358);
            this.animaisDataGridView.TabIndex = 11;
            this.animaisDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnimaisDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "classe";
            this.dataGridViewTextBoxColumn3.HeaderText = "classe";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "peso";
            this.dataGridViewTextBoxColumn4.HeaderText = "peso";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "data_nascimento";
            this.dataGridViewTextBoxColumn5.HeaderText = "data_nascimento";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // fmrCadAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 715);
            this.Controls.Add(this.animaisDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(classeLabel);
            this.Controls.Add(this.classeTextBox);
            this.Controls.Add(pesoLabel);
            this.Controls.Add(this.pesoTextBox);
            this.Controls.Add(data_nascimentoLabel);
            this.Controls.Add(this.data_nascimentoDateTimePicker);
            this.Controls.Add(this.tb_animaisBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fmrCadAnimais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Animais";
            this.Load += new System.EventHandler(this.FmrCadAnimais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_230577DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_animaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_animaisBindingNavigator)).EndInit();
            this.tb_animaisBindingNavigator.ResumeLayout(false);
            this.tb_animaisBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Zoologico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_230577DataSet db_230577DataSet;
        private System.Windows.Forms.BindingSource tb_animaisBindingSource;
        private db_230577DataSetTableAdapters.tb_animaisTableAdapter tb_animaisTableAdapter;
        private db_230577DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_animaisBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tb_animaisBindingNavigatorSaveItem;
        private Dados.DataSet_Zoologico dataSet_Zoologico;
        private System.Windows.Forms.BindingSource animaisBindingSource;
        private Dados.DataSet_ZoologicoTableAdapters.AnimaisTableAdapter animaisTableAdapter;
        private Dados.DataSet_ZoologicoTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox classeTextBox;
        private System.Windows.Forms.TextBox pesoTextBox;
        private System.Windows.Forms.DateTimePicker data_nascimentoDateTimePicker;
        private System.Windows.Forms.DataGridView animaisDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}