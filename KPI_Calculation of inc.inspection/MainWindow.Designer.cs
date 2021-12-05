namespace KPI_Calculation_of_inc.inspection
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tb_Choose_File = new System.Windows.Forms.TextBox();
            this.dgv_DataFromExcel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_calc_totalQty_of_inspections = new System.Windows.Forms.Button();
            this.cb_forTabPageMonth = new System.Windows.Forms.ComboBox();
            this.btn_Load_Excel = new System.Windows.Forms.Button();
            this.gb_Results = new System.Windows.Forms.GroupBox();
            this.dgv_results = new System.Windows.Forms.DataGridView();
            this.User_results = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalChecks_results = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyOf_overDue_inspections = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_ChooseFile = new System.Windows.Forms.GroupBox();
            this.cb_spreedSheets = new System.Windows.Forms.ComboBox();
            this.btn_Choose_File = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gb_nokResults = new System.Windows.Forms.GroupBox();
            this.dgv_nokInspections = new System.Windows.Forms.DataGridView();
            this.Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LengthOfCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_chooseMonth = new System.Windows.Forms.GroupBox();
            this.tc_forTabPageMonth = new System.Windows.Forms.TabControl();
            this.TabPageForMonth = new System.Windows.Forms.TabPage();
            this.dtp_forTabPageMonth = new System.Windows.Forms.DateTimePicker();
            this.TabPageForPeriod = new System.Windows.Forms.TabPage();
            this.lbl_till = new System.Windows.Forms.Label();
            this.lbl_from = new System.Windows.Forms.Label();
            this.dtp_forTabPagePeriodTILL = new System.Windows.Forms.DateTimePicker();
            this.dtp_forTabPagePeriodFROM = new System.Windows.Forms.DateTimePicker();
            this.gb_holidays = new System.Windows.Forms.GroupBox();
            this.btn_deleteHoliday = new System.Windows.Forms.Button();
            this.lb_holidays = new System.Windows.Forms.ListBox();
            this.btn_chooseHoliday = new System.Windows.Forms.Button();
            this.dtp_holidays = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.якКористуватисяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інфоПроПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_CurrentGoal = new System.Windows.Forms.Label();
            this.lbl_ChangeGoal = new System.Windows.Forms.Label();
            this.nud_minGoal = new System.Windows.Forms.NumericUpDown();
            this.lb_checkers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_UnSelectSelectedUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataFromExcel)).BeginInit();
            this.gb_Results.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_results)).BeginInit();
            this.gb_ChooseFile.SuspendLayout();
            this.gb_nokResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nokInspections)).BeginInit();
            this.gb_chooseMonth.SuspendLayout();
            this.tc_forTabPageMonth.SuspendLayout();
            this.TabPageForMonth.SuspendLayout();
            this.TabPageForPeriod.SuspendLayout();
            this.gb_holidays.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minGoal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Choose_File
            // 
            this.tb_Choose_File.Location = new System.Drawing.Point(116, 20);
            this.tb_Choose_File.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Choose_File.Name = "tb_Choose_File";
            this.tb_Choose_File.Size = new System.Drawing.Size(279, 22);
            this.tb_Choose_File.TabIndex = 0;
            // 
            // dgv_DataFromExcel
            // 
            this.dgv_DataFromExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DataFromExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_DataFromExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DataFromExcel.Location = new System.Drawing.Point(547, 33);
            this.dgv_DataFromExcel.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DataFromExcel.Name = "dgv_DataFromExcel";
            this.dgv_DataFromExcel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_DataFromExcel.RowHeadersWidth = 51;
            this.dgv_DataFromExcel.Size = new System.Drawing.Size(1123, 178);
            this.dgv_DataFromExcel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Назва аркуша в Excel";
            // 
            // btn_calc_totalQty_of_inspections
            // 
            this.btn_calc_totalQty_of_inspections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calc_totalQty_of_inspections.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_calc_totalQty_of_inspections.Location = new System.Drawing.Point(15, 454);
            this.btn_calc_totalQty_of_inspections.Margin = new System.Windows.Forms.Padding(4);
            this.btn_calc_totalQty_of_inspections.Name = "btn_calc_totalQty_of_inspections";
            this.btn_calc_totalQty_of_inspections.Size = new System.Drawing.Size(523, 52);
            this.btn_calc_totalQty_of_inspections.TabIndex = 6;
            this.btn_calc_totalQty_of_inspections.Text = "Розрахувати";
            this.btn_calc_totalQty_of_inspections.UseVisualStyleBackColor = true;
            this.btn_calc_totalQty_of_inspections.Click += new System.EventHandler(this.btn_calc_totalQty_of_inspections_Click);
            // 
            // cb_forTabPageMonth
            // 
            this.cb_forTabPageMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_forTabPageMonth.FormattingEnabled = true;
            this.cb_forTabPageMonth.Location = new System.Drawing.Point(4, 6);
            this.cb_forTabPageMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cb_forTabPageMonth.Name = "cb_forTabPageMonth";
            this.cb_forTabPageMonth.Size = new System.Drawing.Size(285, 33);
            this.cb_forTabPageMonth.TabIndex = 11;
            // 
            // btn_Load_Excel
            // 
            this.btn_Load_Excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Load_Excel.Location = new System.Drawing.Point(404, 20);
            this.btn_Load_Excel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Load_Excel.Name = "btn_Load_Excel";
            this.btn_Load_Excel.Size = new System.Drawing.Size(112, 58);
            this.btn_Load_Excel.TabIndex = 3;
            this.btn_Load_Excel.Text = "Завантажити Excel";
            this.btn_Load_Excel.UseVisualStyleBackColor = true;
            this.btn_Load_Excel.Click += new System.EventHandler(this.btn_Load_Excel_Click);
            // 
            // gb_Results
            // 
            this.gb_Results.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Results.Controls.Add(this.dgv_results);
            this.gb_Results.Location = new System.Drawing.Point(547, 219);
            this.gb_Results.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Results.Name = "gb_Results";
            this.gb_Results.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Results.Size = new System.Drawing.Size(1123, 210);
            this.gb_Results.TabIndex = 16;
            this.gb_Results.TabStop = false;
            this.gb_Results.Text = "Результати";
            // 
            // dgv_results
            // 
            this.dgv_results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_results,
            this.TotalChecks_results,
            this.QtyOf_overDue_inspections,
            this.Percentage});
            this.dgv_results.Location = new System.Drawing.Point(4, 20);
            this.dgv_results.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_results.Name = "dgv_results";
            this.dgv_results.RowHeadersWidth = 51;
            this.dgv_results.Size = new System.Drawing.Size(1085, 183);
            this.dgv_results.TabIndex = 0;
            // 
            // User_results
            // 
            this.User_results.HeaderText = "Користувач";
            this.User_results.MinimumWidth = 6;
            this.User_results.Name = "User_results";
            this.User_results.Width = 114;
            // 
            // TotalChecks_results
            // 
            this.TotalChecks_results.HeaderText = "Загальна к-сть перевірок";
            this.TotalChecks_results.MinimumWidth = 6;
            this.TotalChecks_results.Name = "TotalChecks_results";
            this.TotalChecks_results.Width = 186;
            // 
            // QtyOf_overDue_inspections
            // 
            this.QtyOf_overDue_inspections.HeaderText = "К-сть протермінованих перевірок";
            this.QtyOf_overDue_inspections.MinimumWidth = 6;
            this.QtyOf_overDue_inspections.Name = "QtyOf_overDue_inspections";
            this.QtyOf_overDue_inspections.Width = 234;
            // 
            // Percentage
            // 
            this.Percentage.HeaderText = "Відсоток вчасних перевірок";
            this.Percentage.MinimumWidth = 6;
            this.Percentage.Name = "Percentage";
            this.Percentage.Width = 199;
            // 
            // gb_ChooseFile
            // 
            this.gb_ChooseFile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gb_ChooseFile.Controls.Add(this.cb_spreedSheets);
            this.gb_ChooseFile.Controls.Add(this.btn_Load_Excel);
            this.gb_ChooseFile.Controls.Add(this.label1);
            this.gb_ChooseFile.Controls.Add(this.tb_Choose_File);
            this.gb_ChooseFile.Controls.Add(this.btn_Choose_File);
            this.gb_ChooseFile.Location = new System.Drawing.Point(16, 32);
            this.gb_ChooseFile.Margin = new System.Windows.Forms.Padding(4);
            this.gb_ChooseFile.Name = "gb_ChooseFile";
            this.gb_ChooseFile.Padding = new System.Windows.Forms.Padding(4);
            this.gb_ChooseFile.Size = new System.Drawing.Size(523, 84);
            this.gb_ChooseFile.TabIndex = 17;
            this.gb_ChooseFile.TabStop = false;
            this.gb_ChooseFile.Text = "КРОК1 - Вибір excel-файлу";
            // 
            // cb_spreedSheets
            // 
            this.cb_spreedSheets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_spreedSheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_spreedSheets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_spreedSheets.FormattingEnabled = true;
            this.cb_spreedSheets.Location = new System.Drawing.Point(159, 52);
            this.cb_spreedSheets.Margin = new System.Windows.Forms.Padding(4);
            this.cb_spreedSheets.Name = "cb_spreedSheets";
            this.cb_spreedSheets.Size = new System.Drawing.Size(236, 24);
            this.cb_spreedSheets.TabIndex = 6;
            // 
            // btn_Choose_File
            // 
            this.btn_Choose_File.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Choose_File.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Choose_File.Location = new System.Drawing.Point(8, 20);
            this.btn_Choose_File.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Choose_File.Name = "btn_Choose_File";
            this.btn_Choose_File.Size = new System.Drawing.Size(92, 25);
            this.btn_Choose_File.TabIndex = 2;
            this.btn_Choose_File.Text = "Огляд";
            this.btn_Choose_File.UseVisualStyleBackColor = true;
            this.btn_Choose_File.Click += new System.EventHandler(this.btn_Choose_File_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 513);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(523, 28);
            this.progressBar1.TabIndex = 19;
            // 
            // gb_nokResults
            // 
            this.gb_nokResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_nokResults.Controls.Add(this.dgv_nokInspections);
            this.gb_nokResults.Location = new System.Drawing.Point(551, 437);
            this.gb_nokResults.Margin = new System.Windows.Forms.Padding(4);
            this.gb_nokResults.Name = "gb_nokResults";
            this.gb_nokResults.Padding = new System.Windows.Forms.Padding(4);
            this.gb_nokResults.Size = new System.Drawing.Size(1119, 362);
            this.gb_nokResults.TabIndex = 20;
            this.gb_nokResults.TabStop = false;
            this.gb_nokResults.Text = "Протерміновані перевірки";
            // 
            // dgv_nokInspections
            // 
            this.dgv_nokInspections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_nokInspections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_nokInspections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nokInspections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Article,
            this.Quantity,
            this.MaterialDescription,
            this.Batch,
            this.DateOfIN,
            this.Worker,
            this.DateOfCH,
            this.LengthOfCheck});
            this.dgv_nokInspections.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_nokInspections.Location = new System.Drawing.Point(0, 39);
            this.dgv_nokInspections.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_nokInspections.Name = "dgv_nokInspections";
            this.dgv_nokInspections.RowHeadersWidth = 51;
            this.dgv_nokInspections.Size = new System.Drawing.Size(1103, 331);
            this.dgv_nokInspections.TabIndex = 0;
            // 
            // Article
            // 
            this.Article.HeaderText = "Артикль";
            this.Article.MinimumWidth = 6;
            this.Article.Name = "Article";
            this.Article.Width = 91;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "К-сть шт.";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 91;
            // 
            // MaterialDescription
            // 
            this.MaterialDescription.HeaderText = "Назва матеріалу";
            this.MaterialDescription.MinimumWidth = 6;
            this.MaterialDescription.Name = "MaterialDescription";
            this.MaterialDescription.Width = 135;
            // 
            // Batch
            // 
            this.Batch.HeaderText = "Бетч";
            this.Batch.MinimumWidth = 6;
            this.Batch.Name = "Batch";
            this.Batch.Width = 69;
            // 
            // DateOfIN
            // 
            this.DateOfIN.HeaderText = "Коли оприбуткували";
            this.DateOfIN.MinimumWidth = 6;
            this.DateOfIN.Name = "DateOfIN";
            this.DateOfIN.Width = 158;
            // 
            // Worker
            // 
            this.Worker.HeaderText = "Опрацював";
            this.Worker.MinimumWidth = 6;
            this.Worker.Name = "Worker";
            this.Worker.Width = 112;
            // 
            // DateOfCH
            // 
            this.DateOfCH.HeaderText = "Коли опрацювали";
            this.DateOfCH.MinimumWidth = 6;
            this.DateOfCH.Name = "DateOfCH";
            this.DateOfCH.Width = 142;
            // 
            // LengthOfCheck
            // 
            this.LengthOfCheck.HeaderText = "Тривалість перевірки";
            this.LengthOfCheck.MinimumWidth = 6;
            this.LengthOfCheck.Name = "LengthOfCheck";
            this.LengthOfCheck.Width = 163;
            // 
            // gb_chooseMonth
            // 
            this.gb_chooseMonth.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gb_chooseMonth.Controls.Add(this.tc_forTabPageMonth);
            this.gb_chooseMonth.Location = new System.Drawing.Point(16, 219);
            this.gb_chooseMonth.Margin = new System.Windows.Forms.Padding(4);
            this.gb_chooseMonth.Name = "gb_chooseMonth";
            this.gb_chooseMonth.Padding = new System.Windows.Forms.Padding(4);
            this.gb_chooseMonth.Size = new System.Drawing.Size(523, 97);
            this.gb_chooseMonth.TabIndex = 21;
            this.gb_chooseMonth.TabStop = false;
            this.gb_chooseMonth.Text = "КРОК 3 - Оберіть звітний період";
            // 
            // tc_forTabPageMonth
            // 
            this.tc_forTabPageMonth.Controls.Add(this.TabPageForMonth);
            this.tc_forTabPageMonth.Controls.Add(this.TabPageForPeriod);
            this.tc_forTabPageMonth.Location = new System.Drawing.Point(9, 21);
            this.tc_forTabPageMonth.Margin = new System.Windows.Forms.Padding(4);
            this.tc_forTabPageMonth.Name = "tc_forTabPageMonth";
            this.tc_forTabPageMonth.SelectedIndex = 0;
            this.tc_forTabPageMonth.Size = new System.Drawing.Size(493, 76);
            this.tc_forTabPageMonth.TabIndex = 0;
            // 
            // TabPageForMonth
            // 
            this.TabPageForMonth.Controls.Add(this.dtp_forTabPageMonth);
            this.TabPageForMonth.Controls.Add(this.cb_forTabPageMonth);
            this.TabPageForMonth.Location = new System.Drawing.Point(4, 25);
            this.TabPageForMonth.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageForMonth.Name = "TabPageForMonth";
            this.TabPageForMonth.Padding = new System.Windows.Forms.Padding(4);
            this.TabPageForMonth.Size = new System.Drawing.Size(485, 47);
            this.TabPageForMonth.TabIndex = 0;
            this.TabPageForMonth.Text = "За місяць";
            this.TabPageForMonth.UseVisualStyleBackColor = true;
            // 
            // dtp_forTabPageMonth
            // 
            this.dtp_forTabPageMonth.CustomFormat = "yyyy";
            this.dtp_forTabPageMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_forTabPageMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_forTabPageMonth.Location = new System.Drawing.Point(299, 7);
            this.dtp_forTabPageMonth.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_forTabPageMonth.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtp_forTabPageMonth.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_forTabPageMonth.Name = "dtp_forTabPageMonth";
            this.dtp_forTabPageMonth.ShowUpDown = true;
            this.dtp_forTabPageMonth.Size = new System.Drawing.Size(81, 30);
            this.dtp_forTabPageMonth.TabIndex = 12;
            // 
            // TabPageForPeriod
            // 
            this.TabPageForPeriod.Controls.Add(this.lbl_till);
            this.TabPageForPeriod.Controls.Add(this.lbl_from);
            this.TabPageForPeriod.Controls.Add(this.dtp_forTabPagePeriodTILL);
            this.TabPageForPeriod.Controls.Add(this.dtp_forTabPagePeriodFROM);
            this.TabPageForPeriod.Location = new System.Drawing.Point(4, 25);
            this.TabPageForPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageForPeriod.Name = "TabPageForPeriod";
            this.TabPageForPeriod.Padding = new System.Windows.Forms.Padding(4);
            this.TabPageForPeriod.Size = new System.Drawing.Size(485, 47);
            this.TabPageForPeriod.TabIndex = 1;
            this.TabPageForPeriod.Text = "За період";
            this.TabPageForPeriod.UseVisualStyleBackColor = true;
            // 
            // lbl_till
            // 
            this.lbl_till.AutoSize = true;
            this.lbl_till.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_till.Location = new System.Drawing.Point(252, 10);
            this.lbl_till.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_till.Name = "lbl_till";
            this.lbl_till.Size = new System.Drawing.Size(50, 31);
            this.lbl_till.TabIndex = 13;
            this.lbl_till.Text = "До";
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_from.Location = new System.Drawing.Point(4, 6);
            this.lbl_from.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(54, 31);
            this.lbl_from.TabIndex = 13;
            this.lbl_from.Text = "Від";
            // 
            // dtp_forTabPagePeriodTILL
            // 
            this.dtp_forTabPagePeriodTILL.CustomFormat = "";
            this.dtp_forTabPagePeriodTILL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_forTabPagePeriodTILL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_forTabPagePeriodTILL.Location = new System.Drawing.Point(312, 5);
            this.dtp_forTabPagePeriodTILL.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_forTabPagePeriodTILL.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtp_forTabPagePeriodTILL.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_forTabPagePeriodTILL.Name = "dtp_forTabPagePeriodTILL";
            this.dtp_forTabPagePeriodTILL.Size = new System.Drawing.Size(169, 37);
            this.dtp_forTabPagePeriodTILL.TabIndex = 12;
            // 
            // dtp_forTabPagePeriodFROM
            // 
            this.dtp_forTabPagePeriodFROM.CustomFormat = "";
            this.dtp_forTabPagePeriodFROM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_forTabPagePeriodFROM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_forTabPagePeriodFROM.Location = new System.Drawing.Point(69, 5);
            this.dtp_forTabPagePeriodFROM.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_forTabPagePeriodFROM.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtp_forTabPagePeriodFROM.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_forTabPagePeriodFROM.Name = "dtp_forTabPagePeriodFROM";
            this.dtp_forTabPagePeriodFROM.Size = new System.Drawing.Size(173, 37);
            this.dtp_forTabPagePeriodFROM.TabIndex = 12;
            // 
            // gb_holidays
            // 
            this.gb_holidays.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gb_holidays.Controls.Add(this.btn_deleteHoliday);
            this.gb_holidays.Controls.Add(this.lb_holidays);
            this.gb_holidays.Controls.Add(this.btn_chooseHoliday);
            this.gb_holidays.Controls.Add(this.dtp_holidays);
            this.gb_holidays.Location = new System.Drawing.Point(16, 324);
            this.gb_holidays.Margin = new System.Windows.Forms.Padding(4);
            this.gb_holidays.Name = "gb_holidays";
            this.gb_holidays.Padding = new System.Windows.Forms.Padding(4);
            this.gb_holidays.Size = new System.Drawing.Size(521, 123);
            this.gb_holidays.TabIndex = 22;
            this.gb_holidays.TabStop = false;
            this.gb_holidays.Text = "КРОК 4 - Вкажіть святкові дня";
            // 
            // btn_deleteHoliday
            // 
            this.btn_deleteHoliday.BackgroundImage = global::KPI_Calculation_of_inc.inspection.Properties.Resources.minus;
            this.btn_deleteHoliday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_deleteHoliday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteHoliday.FlatAppearance.BorderSize = 0;
            this.btn_deleteHoliday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteHoliday.Location = new System.Drawing.Point(89, 57);
            this.btn_deleteHoliday.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deleteHoliday.Name = "btn_deleteHoliday";
            this.btn_deleteHoliday.Size = new System.Drawing.Size(61, 57);
            this.btn_deleteHoliday.TabIndex = 3;
            this.btn_deleteHoliday.UseVisualStyleBackColor = true;
            this.btn_deleteHoliday.Click += new System.EventHandler(this.btn_deleteHoliday_Click);
            // 
            // lb_holidays
            // 
            this.lb_holidays.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_holidays.FormattingEnabled = true;
            this.lb_holidays.Location = new System.Drawing.Point(159, 22);
            this.lb_holidays.Margin = new System.Windows.Forms.Padding(4);
            this.lb_holidays.MultiColumn = true;
            this.lb_holidays.Name = "lb_holidays";
            this.lb_holidays.Size = new System.Drawing.Size(351, 82);
            this.lb_holidays.TabIndex = 2;
            // 
            // btn_chooseHoliday
            // 
            this.btn_chooseHoliday.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_chooseHoliday.BackgroundImage = global::KPI_Calculation_of_inc.inspection.Properties.Resources.plus;
            this.btn_chooseHoliday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_chooseHoliday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_chooseHoliday.FlatAppearance.BorderSize = 0;
            this.btn_chooseHoliday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chooseHoliday.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_chooseHoliday.Location = new System.Drawing.Point(11, 57);
            this.btn_chooseHoliday.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chooseHoliday.Name = "btn_chooseHoliday";
            this.btn_chooseHoliday.Size = new System.Drawing.Size(61, 57);
            this.btn_chooseHoliday.TabIndex = 1;
            this.btn_chooseHoliday.UseVisualStyleBackColor = false;
            this.btn_chooseHoliday.Click += new System.EventHandler(this.btn_chooseHoliday_Click);
            // 
            // dtp_holidays
            // 
            this.dtp_holidays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_holidays.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_holidays.Location = new System.Drawing.Point(9, 21);
            this.dtp_holidays.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_holidays.Name = "dtp_holidays";
            this.dtp_holidays.Size = new System.Drawing.Size(140, 26);
            this.dtp_holidays.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.проПрограмуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1685, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.якКористуватисяToolStripMenuItem,
            this.інфоПроПрограмуToolStripMenuItem});
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            // 
            // якКористуватисяToolStripMenuItem
            // 
            this.якКористуватисяToolStripMenuItem.Name = "якКористуватисяToolStripMenuItem";
            this.якКористуватисяToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.якКористуватисяToolStripMenuItem.Text = "Як користуватися?";
            // 
            // інфоПроПрограмуToolStripMenuItem
            // 
            this.інфоПроПрограмуToolStripMenuItem.Name = "інфоПроПрограмуToolStripMenuItem";
            this.інфоПроПрограмуToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.інфоПроПрограмуToolStripMenuItem.Text = "Інфо про програму";
            this.інфоПроПрограмуToolStripMenuItem.Click += new System.EventHandler(this.інфоПроПрограмуToolStripMenuItem_Click);
            // 
            // lbl_CurrentGoal
            // 
            this.lbl_CurrentGoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_CurrentGoal.AutoSize = true;
            this.lbl_CurrentGoal.Location = new System.Drawing.Point(21, 756);
            this.lbl_CurrentGoal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CurrentGoal.Name = "lbl_CurrentGoal";
            this.lbl_CurrentGoal.Size = new System.Drawing.Size(216, 17);
            this.lbl_CurrentGoal.TabIndex = 24;
            this.lbl_CurrentGoal.Text = "На початок 2019 року ціль 90%";
            // 
            // lbl_ChangeGoal
            // 
            this.lbl_ChangeGoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ChangeGoal.AutoSize = true;
            this.lbl_ChangeGoal.Location = new System.Drawing.Point(20, 780);
            this.lbl_ChangeGoal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ChangeGoal.Name = "lbl_ChangeGoal";
            this.lbl_ChangeGoal.Size = new System.Drawing.Size(296, 17);
            this.lbl_ChangeGoal.TabIndex = 25;
            this.lbl_ChangeGoal.Text = "Для зміни рівня показника, змініть відсоток";
            // 
            // nud_minGoal
            // 
            this.nud_minGoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nud_minGoal.Location = new System.Drawing.Point(329, 778);
            this.nud_minGoal.Margin = new System.Windows.Forms.Padding(4);
            this.nud_minGoal.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_minGoal.Name = "nud_minGoal";
            this.nud_minGoal.Size = new System.Drawing.Size(47, 22);
            this.nud_minGoal.TabIndex = 26;
            this.nud_minGoal.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // lb_checkers
            // 
            this.lb_checkers.ColumnWidth = 75;
            this.lb_checkers.FormattingEnabled = true;
            this.lb_checkers.ItemHeight = 16;
            this.lb_checkers.Location = new System.Drawing.Point(4, 23);
            this.lb_checkers.Margin = new System.Windows.Forms.Padding(4);
            this.lb_checkers.MultiColumn = true;
            this.lb_checkers.Name = "lb_checkers";
            this.lb_checkers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_checkers.Size = new System.Drawing.Size(441, 52);
            this.lb_checkers.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btn_UnSelectSelectedUsers);
            this.groupBox1.Controls.Add(this.lb_checkers);
            this.groupBox1.Location = new System.Drawing.Point(16, 123);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(523, 89);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "КРОК2 - Оберіть для кого розрахувати результат";
            // 
            // btn_UnSelectSelectedUsers
            // 
            this.btn_UnSelectSelectedUsers.BackgroundImage = global::KPI_Calculation_of_inc.inspection.Properties.Resources.clear;
            this.btn_UnSelectSelectedUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_UnSelectSelectedUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UnSelectSelectedUsers.FlatAppearance.BorderSize = 0;
            this.btn_UnSelectSelectedUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UnSelectSelectedUsers.Location = new System.Drawing.Point(455, 23);
            this.btn_UnSelectSelectedUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btn_UnSelectSelectedUsers.Name = "btn_UnSelectSelectedUsers";
            this.btn_UnSelectSelectedUsers.Size = new System.Drawing.Size(61, 57);
            this.btn_UnSelectSelectedUsers.TabIndex = 29;
            this.btn_UnSelectSelectedUsers.UseVisualStyleBackColor = true;
            this.btn_UnSelectSelectedUsers.Click += new System.EventHandler(this.btn_UnSelectSelectedUsers_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1685, 814);
            this.Controls.Add(this.nud_minGoal);
            this.Controls.Add(this.lbl_ChangeGoal);
            this.Controls.Add(this.lbl_CurrentGoal);
            this.Controls.Add(this.gb_holidays);
            this.Controls.Add(this.gb_chooseMonth);
            this.Controls.Add(this.gb_nokResults);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gb_ChooseFile);
            this.Controls.Add(this.gb_Results);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_calc_totalQty_of_inspections);
            this.Controls.Add(this.dgv_DataFromExcel);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1461, 605);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результати вхідного контролю";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataFromExcel)).EndInit();
            this.gb_Results.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_results)).EndInit();
            this.gb_ChooseFile.ResumeLayout(false);
            this.gb_ChooseFile.PerformLayout();
            this.gb_nokResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nokInspections)).EndInit();
            this.gb_chooseMonth.ResumeLayout(false);
            this.tc_forTabPageMonth.ResumeLayout(false);
            this.TabPageForMonth.ResumeLayout(false);
            this.TabPageForPeriod.ResumeLayout(false);
            this.TabPageForPeriod.PerformLayout();
            this.gb_holidays.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minGoal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Choose_File;
        private System.Windows.Forms.Button btn_Choose_File;
        private System.Windows.Forms.DataGridView dgv_DataFromExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_calc_totalQty_of_inspections;
        private System.Windows.Forms.ComboBox cb_forTabPageMonth;
        private System.Windows.Forms.Button btn_Load_Excel;
        private System.Windows.Forms.GroupBox gb_Results;
        private System.Windows.Forms.GroupBox gb_ChooseFile;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox gb_nokResults;
        private System.Windows.Forms.DataGridView dgv_nokInspections;
        private System.Windows.Forms.GroupBox gb_chooseMonth;
        private System.Windows.Forms.GroupBox gb_holidays;
        private System.Windows.Forms.ListBox lb_holidays;
        private System.Windows.Forms.Button btn_chooseHoliday;
        private System.Windows.Forms.DateTimePicker dtp_holidays;
        private System.Windows.Forms.Button btn_deleteHoliday;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem якКористуватисяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інфоПроПрограмуToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LengthOfCheck;
        private System.Windows.Forms.TabControl tc_forTabPageMonth;
        private System.Windows.Forms.TabPage TabPageForMonth;
        private System.Windows.Forms.TabPage TabPageForPeriod;
        private System.Windows.Forms.DateTimePicker dtp_forTabPageMonth;
        private System.Windows.Forms.DateTimePicker dtp_forTabPagePeriodTILL;
        private System.Windows.Forms.DateTimePicker dtp_forTabPagePeriodFROM;
        private System.Windows.Forms.Label lbl_till;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_CurrentGoal;
        private System.Windows.Forms.Label lbl_ChangeGoal;
        private System.Windows.Forms.NumericUpDown nud_minGoal;
        private System.Windows.Forms.ListBox lb_checkers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_UnSelectSelectedUsers;
        private System.Windows.Forms.DataGridView dgv_results;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_results;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalChecks_results;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyOf_overDue_inspections;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percentage;
        private System.Windows.Forms.ComboBox cb_spreedSheets;
    }
}

