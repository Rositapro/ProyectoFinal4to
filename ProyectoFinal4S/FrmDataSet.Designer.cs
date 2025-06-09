namespace ProyectoFinal4S
{
    partial class FrmDataSet
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
            btnOpen = new Button();
            dgvData = new DataGridView();
            cmbDeleteType = new ComboBox();
            btnDelete = new Button();
            btnClearData = new Button();
            cmbExportFormat = new ComboBox();
            btnExport = new Button();
            cmbClassFilter = new ComboBox();
            btnFilterClass = new Button();
            groupBox1 = new GroupBox();
            btnGoBack = new Button();
            groupBox2 = new GroupBox();
            btnsqlDate = new Button();
            btnGraphics = new Button();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            btnScatterPlot = new Button();
            btnExportPDF = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            rbClose = new RadioButton();
            rbDistant = new RadioButton();
            btnRedshift = new Button();
            groupBox4 = new GroupBox();
            lblView = new Label();
            cmbViewOption = new ComboBox();
            groupBox3 = new GroupBox();
            btnSaveSqlChanges = new Button();
            lblData = new Label();
            treeView = new TreeView();
            txtPlainText = new TextBox();
            groupBox5 = new GroupBox();
            btnEnviarArchivo = new Button();
            pgb = new ProgressBar();
            lblProgress = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.BlueViolet;
            btnOpen.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpen.Location = new Point(13, 34);
            btnOpen.Margin = new Padding(4, 5, 4, 5);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(110, 50);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // dgvData
            // 
            dgvData.BackgroundColor = SystemColors.ControlLight;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(309, 151);
            dgvData.Margin = new Padding(4, 5, 4, 5);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.Size = new Size(663, 393);
            dgvData.TabIndex = 5;
            // 
            // cmbDeleteType
            // 
            cmbDeleteType.BackColor = SystemColors.ScrollBar;
            cmbDeleteType.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDeleteType.FormattingEnabled = true;
            cmbDeleteType.Location = new Point(13, 25);
            cmbDeleteType.Name = "cmbDeleteType";
            cmbDeleteType.Size = new Size(164, 39);
            cmbDeleteType.TabIndex = 12;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.BlueViolet;
            btnDelete.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(13, 75);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 50);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClearData
            // 
            btnClearData.BackColor = Color.BlueViolet;
            btnClearData.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearData.Location = new Point(129, 75);
            btnClearData.Name = "btnClearData";
            btnClearData.Size = new Size(110, 50);
            btnClearData.TabIndex = 14;
            btnClearData.Text = "Clear data";
            btnClearData.UseVisualStyleBackColor = false;
            btnClearData.Click += btnClearData_Click;
            // 
            // cmbExportFormat
            // 
            cmbExportFormat.BackColor = SystemColors.ScrollBar;
            cmbExportFormat.Font = new Font("Yu Gothic UI", 11.25F);
            cmbExportFormat.FormattingEnabled = true;
            cmbExportFormat.Location = new Point(8, 32);
            cmbExportFormat.Name = "cmbExportFormat";
            cmbExportFormat.Size = new Size(129, 39);
            cmbExportFormat.TabIndex = 16;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.BlueViolet;
            btnExport.Font = new Font("Yu Gothic UI", 11.25F);
            btnExport.Location = new Point(143, 32);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(110, 50);
            btnExport.TabIndex = 17;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // cmbClassFilter
            // 
            cmbClassFilter.BackColor = SystemColors.ScrollBar;
            cmbClassFilter.Font = new Font("Yu Gothic UI", 11.25F);
            cmbClassFilter.FormattingEnabled = true;
            cmbClassFilter.Location = new Point(1122, 41);
            cmbClassFilter.Name = "cmbClassFilter";
            cmbClassFilter.Size = new Size(183, 39);
            cmbClassFilter.TabIndex = 18;
            // 
            // btnFilterClass
            // 
            btnFilterClass.BackColor = Color.BlueViolet;
            btnFilterClass.Font = new Font("Yu Gothic UI", 11.25F);
            btnFilterClass.Location = new Point(1313, 32);
            btnFilterClass.Name = "btnFilterClass";
            btnFilterClass.Size = new Size(110, 50);
            btnFilterClass.TabIndex = 19;
            btnFilterClass.Text = "Filter";
            btnFilterClass.UseVisualStyleBackColor = false;
            btnFilterClass.Click += btnFilterClass_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MediumPurple;
            groupBox1.Controls.Add(cmbDeleteType);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnClearData);
            groupBox1.Location = new Point(8, 504);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(258, 138);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // btnGoBack
            // 
            btnGoBack.BackColor = Color.BlueViolet;
            btnGoBack.Font = new Font("Yu Gothic UI", 12F);
            btnGoBack.Location = new Point(15, 41);
            btnGoBack.Margin = new Padding(4, 5, 4, 5);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(110, 50);
            btnGoBack.TabIndex = 21;
            btnGoBack.Text = "Go back";
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.MediumPurple;
            groupBox2.Controls.Add(btnOpen);
            groupBox2.Controls.Add(btnsqlDate);
            groupBox2.Location = new Point(11, 131);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(260, 106);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // btnsqlDate
            // 
            btnsqlDate.BackColor = Color.BlueViolet;
            btnsqlDate.Font = new Font("Yu Gothic UI", 11.25F);
            btnsqlDate.Location = new Point(131, 36);
            btnsqlDate.Margin = new Padding(4, 5, 4, 5);
            btnsqlDate.Name = "btnsqlDate";
            btnsqlDate.Size = new Size(110, 50);
            btnsqlDate.TabIndex = 40;
            btnsqlDate.Text = "Sql";
            btnsqlDate.UseVisualStyleBackColor = false;
            btnsqlDate.Click += btnsqlDate_Click;
            // 
            // btnGraphics
            // 
            btnGraphics.BackColor = Color.BlueViolet;
            btnGraphics.Font = new Font("Yu Gothic UI", 11.25F);
            btnGraphics.Location = new Point(17, 32);
            btnGraphics.Name = "btnGraphics";
            btnGraphics.Size = new Size(110, 50);
            btnGraphics.TabIndex = 23;
            btnGraphics.Text = "Pie ";
            btnGraphics.UseVisualStyleBackColor = false;
            btnGraphics.Click += btnGraphics_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.BackColor = Color.MediumPurple;
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(13, 648);
            formsPlot1.Margin = new Padding(4, 5, 4, 5);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(511, 403);
            formsPlot1.TabIndex = 24;
            // 
            // formsPlot2
            // 
            formsPlot2.BackColor = Color.MediumPurple;
            formsPlot2.DisplayScale = 1F;
            formsPlot2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formsPlot2.Location = new Point(729, 648);
            formsPlot2.Margin = new Padding(4, 5, 4, 5);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(1069, 403);
            formsPlot2.TabIndex = 25;
            // 
            // btnScatterPlot
            // 
            btnScatterPlot.BackColor = Color.BlueViolet;
            btnScatterPlot.Font = new Font("Yu Gothic UI", 11.25F);
            btnScatterPlot.Location = new Point(17, 88);
            btnScatterPlot.Name = "btnScatterPlot";
            btnScatterPlot.Size = new Size(110, 50);
            btnScatterPlot.TabIndex = 26;
            btnScatterPlot.Text = "Scatter";
            btnScatterPlot.UseVisualStyleBackColor = false;
            btnScatterPlot.Click += btnScatterPlot_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.BackColor = Color.BlueViolet;
            btnExportPDF.Font = new Font("Yu Gothic UI", 11.25F);
            btnExportPDF.Location = new Point(143, 100);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(110, 76);
            btnExportPDF.TabIndex = 27;
            btnExportPDF.Text = "Export PDF";
            btnExportPDF.UseVisualStyleBackColor = false;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.ScrollBar;
            txtSearch.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(143, 48);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(380, 37);
            txtSearch.TabIndex = 28;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.BlueViolet;
            btnSearch.Font = new Font("Yu Gothic UI", 12F);
            btnSearch.Location = new Point(548, 41);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 50);
            btnSearch.TabIndex = 29;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(700, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 31);
            label1.TabIndex = 30;
            label1.Text = "Redshift";
            // 
            // rbClose
            // 
            rbClose.AutoSize = true;
            rbClose.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbClose.Location = new Point(797, 68);
            rbClose.Margin = new Padding(4, 5, 4, 5);
            rbClose.Name = "rbClose";
            rbClose.Size = new Size(168, 35);
            rbClose.TabIndex = 31;
            rbClose.TabStop = true;
            rbClose.Text = "Near objects";
            rbClose.UseVisualStyleBackColor = true;
            // 
            // rbDistant
            // 
            rbDistant.AutoSize = true;
            rbDistant.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbDistant.Location = new Point(796, 26);
            rbDistant.Margin = new Padding(4, 5, 4, 5);
            rbDistant.Name = "rbDistant";
            rbDistant.Size = new Size(149, 35);
            rbDistant.TabIndex = 32;
            rbDistant.TabStop = true;
            rbDistant.Text = "Far objects";
            rbDistant.UseVisualStyleBackColor = true;
            // 
            // btnRedshift
            // 
            btnRedshift.BackColor = Color.BlueViolet;
            btnRedshift.Font = new Font("Yu Gothic UI", 12F);
            btnRedshift.Location = new Point(971, 41);
            btnRedshift.Margin = new Padding(4, 5, 4, 5);
            btnRedshift.Name = "btnRedshift";
            btnRedshift.Size = new Size(110, 50);
            btnRedshift.TabIndex = 34;
            btnRedshift.Text = "Order";
            btnRedshift.UseVisualStyleBackColor = false;
            btnRedshift.Click += btnRedshift_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.MediumPurple;
            groupBox4.Controls.Add(lblView);
            groupBox4.Controls.Add(cmbViewOption);
            groupBox4.Controls.Add(rbDistant);
            groupBox4.Controls.Add(btnSearch);
            groupBox4.Controls.Add(btnRedshift);
            groupBox4.Controls.Add(rbClose);
            groupBox4.Controls.Add(txtSearch);
            groupBox4.Controls.Add(btnGoBack);
            groupBox4.Controls.Add(cmbClassFilter);
            groupBox4.Controls.Add(btnFilterClass);
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(13, 14);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(1780, 113);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            // 
            // lblView
            // 
            lblView.AutoSize = true;
            lblView.Font = new Font("Yu Gothic UI", 11.25F);
            lblView.Location = new Point(1492, 41);
            lblView.Name = "lblView";
            lblView.Size = new Size(63, 31);
            lblView.TabIndex = 40;
            lblView.Text = "View";
            // 
            // cmbViewOption
            // 
            cmbViewOption.BackColor = SystemColors.ScrollBar;
            cmbViewOption.FormattingEnabled = true;
            cmbViewOption.Location = new Point(1569, 42);
            cmbViewOption.Name = "cmbViewOption";
            cmbViewOption.Size = new Size(183, 33);
            cmbViewOption.TabIndex = 40;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.MediumPurple;
            groupBox3.Controls.Add(btnSaveSqlChanges);
            groupBox3.Controls.Add(cmbExportFormat);
            groupBox3.Controls.Add(btnExport);
            groupBox3.Controls.Add(btnExportPDF);
            groupBox3.Location = new Point(13, 242);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(260, 192);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Exportar";
            // 
            // btnSaveSqlChanges
            // 
            btnSaveSqlChanges.BackColor = Color.BlueViolet;
            btnSaveSqlChanges.Font = new Font("Yu Gothic UI", 11.25F);
            btnSaveSqlChanges.Location = new Point(13, 100);
            btnSaveSqlChanges.Margin = new Padding(4, 5, 4, 5);
            btnSaveSqlChanges.Name = "btnSaveSqlChanges";
            btnSaveSqlChanges.Size = new Size(110, 76);
            btnSaveSqlChanges.TabIndex = 41;
            btnSaveSqlChanges.Text = "Changes SQL";
            btnSaveSqlChanges.UseVisualStyleBackColor = false;
            btnSaveSqlChanges.Click += btnSaveSqlChanges_Click;
            // 
            // lblData
            // 
            lblData.AllowDrop = true;
            lblData.AutoSize = true;
            lblData.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblData.Location = new Point(810, 562);
            lblData.Margin = new Padding(4, 0, 4, 0);
            lblData.Name = "lblData";
            lblData.Size = new Size(49, 31);
            lblData.TabIndex = 36;
            lblData.Text = "No:";
            // 
            // treeView
            // 
            treeView.Location = new Point(979, 151);
            treeView.Name = "treeView";
            treeView.Size = new Size(469, 393);
            treeView.TabIndex = 37;
            // 
            // txtPlainText
            // 
            txtPlainText.Location = new Point(1454, 151);
            txtPlainText.Multiline = true;
            txtPlainText.Name = "txtPlainText";
            txtPlainText.ScrollBars = ScrollBars.Vertical;
            txtPlainText.Size = new Size(344, 393);
            txtPlainText.TabIndex = 38;
            txtPlainText.Visible = false;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.MediumPurple;
            groupBox5.Controls.Add(btnGraphics);
            groupBox5.Controls.Add(btnScatterPlot);
            groupBox5.Location = new Point(561, 648);
            groupBox5.Margin = new Padding(4, 5, 4, 5);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 5, 4, 5);
            groupBox5.Size = new Size(138, 163);
            groupBox5.TabIndex = 39;
            groupBox5.TabStop = false;
            // 
            // btnEnviarArchivo
            // 
            btnEnviarArchivo.BackColor = Color.BlueViolet;
            btnEnviarArchivo.Font = new Font("Yu Gothic UI", 11.25F);
            btnEnviarArchivo.Location = new Point(309, 562);
            btnEnviarArchivo.Name = "btnEnviarArchivo";
            btnEnviarArchivo.Size = new Size(110, 50);
            btnEnviarArchivo.TabIndex = 40;
            btnEnviarArchivo.Text = "Email";
            btnEnviarArchivo.UseVisualStyleBackColor = false;
            btnEnviarArchivo.Click += btnEnviarArchivo_Click;
            // 
            // pgb
            // 
            pgb.Location = new Point(15, 466);
            pgb.Name = "pgb";
            pgb.Size = new Size(232, 34);
            pgb.TabIndex = 41;
            pgb.Visible = false;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(13, 438);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(0, 25);
            lblProgress.TabIndex = 42;
            // 
            // FrmDataSet
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(1806, 1050);
            Controls.Add(lblProgress);
            Controls.Add(pgb);
            Controls.Add(btnEnviarArchivo);
            Controls.Add(groupBox5);
            Controls.Add(txtPlainText);
            Controls.Add(treeView);
            Controls.Add(lblData);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(formsPlot2);
            Controls.Add(formsPlot1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvData);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmDataSet";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnOpen;
        private DataGridView dgvData;
        private ComboBox cmbDeleteType;
        private Button btnDelete;
        private Button btnClearData;
        private ComboBox cmbExportFormat;
        private Button btnExport;
        private ComboBox cmbClassFilter;
        private Button btnFilterClass;
        private GroupBox groupBox1;
        private Button btnGoBack;
        private GroupBox groupBox2;
        private Button btnGraphics;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
        private Button btnScatterPlot;
        private Button btnExportPDF;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label1;
        private RadioButton rbClose;
        private RadioButton rbDistant;
        private Button btnRedshift;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label lblData;
        private TreeView treeView;
        private TextBox txtPlainText;
        private GroupBox groupBox5;
        private Button btnsqlDate;
        private Button btnSaveSqlChanges;
        private ComboBox cmbViewOption;
        private Label lblView;
        private Button btnEnviarArchivo;
        private ProgressBar pgb;
        private Label lblProgress;
    }
}