using System.Windows.Forms;

namespace OP_13
{
    partial class Calculation
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1_reporting_period = new System.Windows.Forms.Label();
            this.label2_reporting_period = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dGV_Calculation = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOKPO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOKDP = new System.Windows.Forms.TextBox();
            this.textBoxNumberDoc = new System.Windows.Forms.TextBox();
            this.comboBoxOrganization = new System.Windows.Forms.ComboBox();
            this.comboBoxStructSubdivision = new System.Windows.Forms.ComboBox();
            this.dGV_Spravka = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabelSignatures = new System.Windows.Forms.LinkLabel();
            this.textBoxTYPEoPERATION = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.result = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.resultSpravka = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_ = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance_receipt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberDishes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Calculation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Spravka)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.result)).BeginInit();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultSpravka)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_reporting_period
            // 
            this.label1_reporting_period.AutoSize = true;
            this.label1_reporting_period.Location = new System.Drawing.Point(41, 178);
            this.label1_reporting_period.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_reporting_period.Name = "label1_reporting_period";
            this.label1_reporting_period.Size = new System.Drawing.Size(77, 17);
            this.label1_reporting_period.TabIndex = 2;
            this.label1_reporting_period.Text = "За период";
            // 
            // label2_reporting_period
            // 
            this.label2_reporting_period.AutoSize = true;
            this.label2_reporting_period.Location = new System.Drawing.Point(361, 178);
            this.label2_reporting_period.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2_reporting_period.Name = "label2_reporting_period";
            this.label2_reporting_period.Size = new System.Drawing.Size(17, 17);
            this.label2_reporting_period.TabIndex = 3;
            this.label2_reporting_period.Text = " -";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(726, 21);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dGV_Calculation
            // 
            this.dGV_Calculation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Calculation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_Calculation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Calculation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Calculation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Calculation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_,
            this.Code,
            this.balance_start,
            this.balance_receipt,
            this.balance_end,
            this.cost});
            this.dGV_Calculation.GridColor = System.Drawing.SystemColors.Control;
            this.dGV_Calculation.Location = new System.Drawing.Point(-4, 0);
            this.dGV_Calculation.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_Calculation.Name = "dGV_Calculation";
            this.dGV_Calculation.RowHeadersWidth = 30;
            this.dGV_Calculation.ShowRowErrors = false;
            this.dGV_Calculation.Size = new System.Drawing.Size(1003, 258);
            this.dGV_Calculation.TabIndex = 7;
            this.dGV_Calculation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Calculation_CellContentClick);
            this.dGV_Calculation.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.summ);
            this.dGV_Calculation.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dGV_Calculation_EditingControlShowing);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(162, 178);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(392, 178);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(213, 22);
            this.dateTimePicker3.TabIndex = 3;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(932, 604);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(115, 28);
            this.button_cancel.TabIndex = 15;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(809, 604);
            this.button_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(115, 28);
            this.button_save.TabIndex = 14;
            this.button_save.Text = "Экспорт";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(685, 606);
            this.calculate.Margin = new System.Windows.Forms.Padding(4);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(116, 26);
            this.calculate.TabIndex = 12;
            this.calculate.Text = "Рассчитать";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Организация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Подразделение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Форма по ОКПО";
            // 
            // textBoxOKPO
            // 
            this.textBoxOKPO.Location = new System.Drawing.Point(797, 104);
            this.textBoxOKPO.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOKPO.Name = "textBoxOKPO";
            this.textBoxOKPO.Size = new System.Drawing.Size(254, 22);
            this.textBoxOKPO.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Вид деятельности ";
            // 
            // textBoxOKDP
            // 
            this.textBoxOKDP.Location = new System.Drawing.Point(797, 175);
            this.textBoxOKDP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOKDP.Name = "textBoxOKDP";
            this.textBoxOKDP.Size = new System.Drawing.Size(254, 22);
            this.textBoxOKDP.TabIndex = 71;
            // 
            // textBoxNumberDoc
            // 
            this.textBoxNumberDoc.Location = new System.Drawing.Point(519, 21);
            this.textBoxNumberDoc.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumberDoc.Name = "textBoxNumberDoc";
            this.textBoxNumberDoc.Size = new System.Drawing.Size(86, 22);
            this.textBoxNumberDoc.TabIndex = 1;
            // 
            // comboBoxOrganization
            // 
            this.comboBoxOrganization.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxOrganization.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxOrganization.FormattingEnabled = true;
            this.comboBoxOrganization.Items.AddRange(new object[] {
            "Организация 1",
            "Организация 2",
            "Организация 3",
            "РосГранТрон"});
            this.comboBoxOrganization.Location = new System.Drawing.Point(162, 106);
            this.comboBoxOrganization.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOrganization.Name = "comboBoxOrganization";
            this.comboBoxOrganization.Size = new System.Drawing.Size(443, 24);
            this.comboBoxOrganization.TabIndex = 1;
            this.comboBoxOrganization.DropDownClosed += new System.EventHandler(this.numb_org);
            this.comboBoxOrganization.TextChanged += new System.EventHandler(this.numb_org);
            // 
            // comboBoxStructSubdivision
            // 
            this.comboBoxStructSubdivision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxStructSubdivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxStructSubdivision.FormattingEnabled = true;
            this.comboBoxStructSubdivision.Items.AddRange(new object[] {
            "Подразделение 1",
            "Подразделение 2",
            "Подразделение 3"});
            this.comboBoxStructSubdivision.Location = new System.Drawing.Point(162, 141);
            this.comboBoxStructSubdivision.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStructSubdivision.Name = "comboBoxStructSubdivision";
            this.comboBoxStructSubdivision.Size = new System.Drawing.Size(443, 24);
            this.comboBoxStructSubdivision.TabIndex = 6;
            this.comboBoxStructSubdivision.DropDownClosed += new System.EventHandler(this.numb_org1);
            // 
            // dGV_Spravka
            // 
            this.dGV_Spravka.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Spravka.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_Spravka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Spravka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.NumberDishes,
            this.Summa});
            this.dGV_Spravka.Location = new System.Drawing.Point(0, 7);
            this.dGV_Spravka.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_Spravka.Name = "dGV_Spravka";
            this.dGV_Spravka.RowHeadersWidth = 51;
            this.dGV_Spravka.Size = new System.Drawing.Size(999, 224);
            this.dGV_Spravka.TabIndex = 12;
            this.dGV_Spravka.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.summ_spravka);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(657, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "Дата";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(209, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 25);
            this.label9.TabIndex = 47;
            this.label9.Text = "Контрольный расчет №";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(209, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 25);
            this.label10.TabIndex = 48;
            this.label10.Text = "расхода специй и соли";
            // 
            // linkLabelSignatures
            // 
            this.linkLabelSignatures.AutoSize = true;
            this.linkLabelSignatures.Location = new System.Drawing.Point(45, 604);
            this.linkLabelSignatures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelSignatures.Name = "linkLabelSignatures";
            this.linkLabelSignatures.Size = new System.Drawing.Size(160, 17);
            this.linkLabelSignatures.TabIndex = 13;
            this.linkLabelSignatures.TabStop = true;
            this.linkLabelSignatures.Text = "Расшифрока подписей";
            this.linkLabelSignatures.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignatures_LinkClicked);
            // 
            // textBoxTYPEoPERATION
            // 
            this.textBoxTYPEoPERATION.Location = new System.Drawing.Point(797, 141);
            this.textBoxTYPEoPERATION.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTYPEoPERATION.Name = "textBoxTYPEoPERATION";
            this.textBoxTYPEoPERATION.Size = new System.Drawing.Size(254, 22);
            this.textBoxTYPEoPERATION.TabIndex = 103;
            this.textBoxTYPEoPERATION.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(656, 144);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 17);
            this.label15.TabIndex = 102;
            this.label15.Text = "Вид операции";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Location = new System.Drawing.Point(44, 225);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1007, 372);
            this.tabControl1.TabIndex = 104;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.result);
            this.tab1.Controls.Add(this.dGV_Calculation);
            this.tab1.Location = new System.Drawing.Point(4, 25);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(999, 343);
            this.tab1.TabIndex = 1;
            this.tab1.Text = "Расчет";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.AllowUserToAddRows = false;
            this.result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.result.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.result.GridColor = System.Drawing.SystemColors.Control;
            this.result.Location = new System.Drawing.Point(-4, 252);
            this.result.Margin = new System.Windows.Forms.Padding(4);
            this.result.Name = "result";
            this.result.RowHeadersVisible = false;
            this.result.RowHeadersWidth = 51;
            this.result.Size = new System.Drawing.Size(1007, 91);
            this.result.TabIndex = 8;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Остаток на начало отчётного периода (сумма), руб.";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Поступило за отчётный период (сумма), руб.";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Остаток на конец отчётного периода (сумма), руб.";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Израсходовано за отчётный период (сумма), руб.";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.resultSpravka);
            this.tab2.Controls.Add(this.dGV_Spravka);
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(999, 343);
            this.tab2.TabIndex = 0;
            this.tab2.Text = "Справка";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // resultSpravka
            // 
            this.resultSpravka.AllowUserToAddRows = false;
            this.resultSpravka.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultSpravka.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.resultSpravka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultSpravka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.resultSpravka.Location = new System.Drawing.Point(0, 224);
            this.resultSpravka.Margin = new System.Windows.Forms.Padding(4);
            this.resultSpravka.Name = "resultSpravka";
            this.resultSpravka.ReadOnly = true;
            this.resultSpravka.RowHeadersWidth = 51;
            this.resultSpravka.Size = new System.Drawing.Size(999, 113);
            this.resultSpravka.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.HeaderText = "Сумма (руб.)";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Name_
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Name_.DefaultCellStyle = dataGridViewCellStyle2;
            this.Name_.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Name_.HeaderText = "Наименование";
            this.Name_.Items.AddRange(new object[] {
            "Горчица",
            "Соль",
            "Специи"});
            this.Name_.MinimumWidth = 6;
            this.Name_.Name = "Name_";
            this.Name_.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Name_.Sorted = true;
            this.Name_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Code
            // 
            this.Code.HeaderText = "Код";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // balance_start
            // 
            this.balance_start.HeaderText = "Остаток на начало отчётного периода (сумма), руб.";
            this.balance_start.MinimumWidth = 6;
            this.balance_start.Name = "balance_start";
            // 
            // balance_receipt
            // 
            this.balance_receipt.HeaderText = "Поступило за отчётный период (сумма), руб.";
            this.balance_receipt.MinimumWidth = 6;
            this.balance_receipt.Name = "balance_receipt";
            // 
            // balance_end
            // 
            this.balance_end.HeaderText = "Остаток на конец отчётного периода (сумма), руб.";
            this.balance_end.MinimumWidth = 6;
            this.balance_end.Name = "balance_end";
            // 
            // cost
            // 
            this.cost.HeaderText = "Израсходовано за отчётный период (сумма), руб.";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Column1.HeaderText = "Наименование (код)";
            this.Column1.Items.AddRange(new object[] {
            "Горчица",
            "Соль",
            "Специи"});
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Sorted = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 157;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Стоимость на блюда";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // NumberDishes
            // 
            this.NumberDishes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumberDishes.HeaderText = "Количество блюд";
            this.NumberDishes.MinimumWidth = 6;
            this.NumberDishes.Name = "NumberDishes";
            // 
            // Summa
            // 
            this.Summa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Summa.HeaderText = "Сумма (руб.)";
            this.Summa.MinimumWidth = 6;
            this.Summa.Name = "Summa";
            this.Summa.ReadOnly = true;
            // 
            // Calculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 641);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBoxTYPEoPERATION);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.linkLabelSignatures);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxStructSubdivision);
            this.Controls.Add(this.comboBoxOrganization);
            this.Controls.Add(this.textBoxNumberDoc);
            this.Controls.Add(this.textBoxOKDP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOKPO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2_reporting_period);
            this.Controls.Add(this.label1_reporting_period);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Calculation";
            this.Text = "ОП-13";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Calculation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Spravka)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.result)).EndInit();
            this.tab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultSpravka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        #endregion
        private System.Windows.Forms.Label label1_reporting_period;
        private System.Windows.Forms.Label label2_reporting_period;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dGV_Calculation;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Label label4;
        private TextBox textBoxOKPO;
        private Label label5;
        private TextBox textBoxOKDP;
        private TextBox textBoxNumberDoc;
        private ComboBox comboBoxOrganization;
        private ComboBox comboBoxStructSubdivision;
        private DataGridView dGV_Spravka;
        private Label label8;
        private Label label9;
        private Label label10;
        private LinkLabel linkLabelSignatures;
        private TextBox textBoxTYPEoPERATION;
        private Label label15;
        private TabControl tabControl1;
        private TabPage tab2;
        private TabPage tab1;
        private DataGridView result;
        private DataGridView resultSpravka;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewComboBoxColumn Name_;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn balance_start;
        private DataGridViewTextBoxColumn balance_receipt;
        private DataGridViewTextBoxColumn balance_end;
        private DataGridViewTextBoxColumn cost;
        private DataGridViewComboBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn NumberDishes;
        private DataGridViewTextBoxColumn Summa;
    }
}

