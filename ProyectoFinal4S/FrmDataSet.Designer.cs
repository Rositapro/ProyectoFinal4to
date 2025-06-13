
namespace ProyectoFinal4S.ProyectoFinal4S
{
    public partial class FrmDataSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is not null)
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
            btnOpen = new System.Windows.Forms.Button();
            dgvData = new System.Windows.Forms.DataGridView();
            cmbDeleteType = new System.Windows.Forms.ComboBox();
            btnDelete = new System.Windows.Forms.Button();
            btnClearData = new System.Windows.Forms.Button();
            cmbExportFormat = new System.Windows.Forms.ComboBox();
            btnExport = new System.Windows.Forms.Button();
            cmbClassFilter = new System.Windows.Forms.ComboBox();
            btnFilterClass = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnGoBack = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnsqlDate = new System.Windows.Forms.Button();
            btnGraphics = new System.Windows.Forms.Button();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            btnScatterPlot = new System.Windows.Forms.Button();
            btnExportPDF = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            rbClose = new System.Windows.Forms.RadioButton();
            rbDistant = new System.Windows.Forms.RadioButton();
            btnRedshift = new System.Windows.Forms.Button();
            groupBox4 = new System.Windows.Forms.GroupBox();
            lblView = new System.Windows.Forms.Label();
            cmbViewOption = new System.Windows.Forms.ComboBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            btnSaveSqlChanges = new System.Windows.Forms.Button();
            lblData = new System.Windows.Forms.Label();
            treeView = new System.Windows.Forms.TreeView();
            txtPlainText = new System.Windows.Forms.TextBox();
            groupBox5 = new System.Windows.Forms.GroupBox();
            btnEnviarArchivo = new System.Windows.Forms.Button();
            pgb = new System.Windows.Forms.ProgressBar();
            lblProgress = new System.Windows.Forms.Label();
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
            btnOpen.Font = new System.Drawing.Font("Yu Gothic UI", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOpen.Location = new System.Drawing.Point(13, 34);
            btnOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new System.Drawing.Size(110, 50);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // dgvData
            // 
            dgvData.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new System.Drawing.Point(309, 151);
            dgvData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.Size = new System.Drawing.Size(663, 393);
            dgvData.TabIndex = 5;
            // 
            // cmbDeleteType
            // 
            cmbDeleteType.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cmbDeleteType.FormattingEnabled = true;
            cmbDeleteType.Location = new System.Drawing.Point(13, 25);
            cmbDeleteType.Name = "cmbDeleteType";
            cmbDeleteType.Size = new System.Drawing.Size(164, 39);
            cmbDeleteType.TabIndex = 12;
            // 
            // btnDelete
            // 
            btnDelete.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnDelete.Location = new System.Drawing.Point(13, 75);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(110, 50);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClearData
            // 
            btnClearData.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClearData.Location = new System.Drawing.Point(129, 75);
            btnClearData.Name = "btnClearData";
            btnClearData.Size = new System.Drawing.Size(110, 50);
            btnClearData.TabIndex = 14;
            btnClearData.Text = "Clear data";
            btnClearData.UseVisualStyleBackColor = true;
            btnClearData.Click += btnClearData_Click;
            // 
            // cmbExportFormat
            // 
            cmbExportFormat.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f);
            cmbExportFormat.FormattingEnabled = true;
            cmbExportFormat.Location = new System.Drawing.Point(8, 32);
            cmbExportFormat.Name = "cmbExportFormat";
            cmbExportFormat.Size = new System.Drawing.Size(129, 39);
            cmbExportFormat.TabIndex = 16;
            // 
            // btnExport
            // 
            btnExport.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f);
            btnExport.Location = new System.Drawing.Point(143, 32);
            btnExport.Name = "btnExport";
            btnExport.Size = new System.Drawing.Size(110, 50);
            btnExport.TabIndex = 17;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // cmbClassFilter
            // 
            cmbClassFilter.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f);
            cmbClassFilter.FormattingEnabled = true;
            cmbClassFilter.Location = new System.Drawing.Point(1122, 41);
            cmbClassFilter.Name = "cmbClassFilter";
            cmbClassFilter.Size = new System.Drawing.Size(183, 39);
            cmbClassFilter.TabIndex = 18;

            // 
            // btnFilterClass
            // 
            btnFilterClass.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f);
            btnFilterClass.Location = new System.Drawing.Point(1313, 32);
            btnFilterClass.Name = "btnFilterClass";
            btnFilterClass.Size = new System.Drawing.Size(110, 50);
            btnFilterClass.TabIndex = 19;
            btnFilterClass.Text = "Filter";
            btnFilterClass.UseVisualStyleBackColor = true;
            btnFilterClass.Click += btnFilterClass_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbDeleteType);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnClearData);
            groupBox1.Location = new System.Drawing.Point(8, 500);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Size = new System.Drawing.Size(258, 138);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;

            // 
            // btnGoBack
            // 
            btnGoBack.Font = new System.Drawing.Font("Yu Gothic UI", 12f);
            btnGoBack.Location = new System.Drawing.Point(15, 41);
            btnGoBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new System.Drawing.Size(110, 50);
            btnGoBack.TabIndex = 21;
            btnGoBack.Text = "Go back";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOpen);
            groupBox2.Controls.Add(btnsqlDate);
            groupBox2.Location = new System.Drawing.Point(8, 128);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox2.Size = new System.Drawing.Size(260, 106);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // btnsqlDate
            // 
            btnsqlDate.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f);
            btnsqlDate.Location = new System.Drawing.Point(131, 36);
            btnsqlDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnsqlDate.Name = "btnsqlDate";
            btnsqlDate.Size = new System.Drawing.Size(110, 50);
            btnsqlDate.TabIndex = 40;
            btnsqlDate.Text = "Sql";
            btnsqlDate.UseVisualStyleBackColor = true;
            btnsqlDate.Click += btnsqlDate_Click;
            // 
            // btnGraphics
            // 
            btnGraphics.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f);
            btnGraphics.Location = new System.Drawing.Point(17, 32);
            btnGraphics.Name = "btnGraphics";
            btnGraphics.Size = new System.Drawing.Size(110, 50);
            btnGraphics.TabIndex = 23;
            btnGraphics.Text = "Pie ";
            btnGraphics.UseVisualStyleBackColor = true;
            btnGraphics.Click += btnGraphics_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1f;
            formsPlot1.Location = new System.Drawing.Point(13, 648);
            formsPlot1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new System.Drawing.Size(511, 403);
            formsPlot1.TabIndex = 24;
            // 
            // formsPlot2
            // 
            formsPlot2.DisplayScale = 1f;
            formsPlot2.Location = new System.Drawing.Point(729, 648);
            formsPlot2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new System.Drawing.Size(1069, 403);
            formsPlot2.TabIndex = 25;
            // 
            // btnScatterPlot
            // 
            btnScatterPlot.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f);
            btnScatterPlot.Location = new System.Drawing.Point(17, 88);
            btnScatterPlot.Name = "btnScatterPlot";
            btnScatterPlot.Size = new System.Drawing.Size(110, 50);
            btnScatterPlot.TabIndex = 26;
            btnScatterPlot.Text = "Scatter";
            btnScatterPlot.UseVisualStyleBackColor = true;
            btnScatterPlot.Click += btnScatterPlot_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f);
            btnExportPDF.Location = new System.Drawing.Point(143, 100);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new System.Drawing.Size(110, 76);
            btnExportPDF.TabIndex = 27;
            btnExportPDF.Text = "Export PDF";
            btnExportPDF.UseVisualStyleBackColor = true;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtSearch.Location = new System.Drawing.Point(143, 48);
            txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(380, 37);
            txtSearch.TabIndex = 28;
            // 
            // btnSearch
            // 
            btnSearch.Font = new System.Drawing.Font("Yu Gothic UI", 12f);
            btnSearch.Location = new System.Drawing.Point(548, 41);
            btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(110, 50);
            btnSearch.TabIndex = 29;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(700, 48);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 31);
            label1.TabIndex = 30;
            label1.Text = "Redshift";
            // 
            // rbClose
            // 
            rbClose.AutoSize = true;
            rbClose.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbClose.Location = new System.Drawing.Point(797, 68);
            rbClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rbClose.Name = "rbClose";
            rbClose.Size = new System.Drawing.Size(168, 35);
            rbClose.TabIndex = 31;
            rbClose.TabStop = true;
            rbClose.Text = "Near objects";
            rbClose.UseVisualStyleBackColor = true;

            // 
            // rbDistant
            // 
            rbDistant.AutoSize = true;
            rbDistant.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbDistant.Location = new System.Drawing.Point(796, 26);
            rbDistant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rbDistant.Name = "rbDistant";
            rbDistant.Size = new System.Drawing.Size(149, 35);
            rbDistant.TabIndex = 32;
            rbDistant.TabStop = true;
            rbDistant.Text = "Far objects";
            rbDistant.UseVisualStyleBackColor = true;
            // 
            // btnRedshift
            // 
            btnRedshift.Font = new System.Drawing.Font("Yu Gothic UI", 12f);
            btnRedshift.Location = new System.Drawing.Point(971, 41);
            btnRedshift.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnRedshift.Name = "btnRedshift";
            btnRedshift.Size = new System.Drawing.Size(110, 50);
            btnRedshift.TabIndex = 34;
            btnRedshift.Text = "Order";
            btnRedshift.UseVisualStyleBackColor = true;
            btnRedshift.Click += btnRedshift_Click;
            // 
            // groupBox4
            // 
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
            groupBox4.Location = new System.Drawing.Point(13, 14);
            groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox4.Size = new System.Drawing.Size(1780, 113);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            // 
            // lblView
            // 
            lblView.AutoSize = true;
            lblView.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f);
            lblView.Location = new System.Drawing.Point(1492, 41);
            lblView.Name = "lblView";
            lblView.Size = new System.Drawing.Size(63, 31);
            lblView.TabIndex = 40;
            lblView.Text = "View";
            // 
            // cmbViewOption
            // 
            cmbViewOption.FormattingEnabled = true;
            cmbViewOption.Location = new System.Drawing.Point(1569, 42);
            cmbViewOption.Name = "cmbViewOption";
            cmbViewOption.Size = new System.Drawing.Size(183, 33);
            cmbViewOption.TabIndex = 40;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSaveSqlChanges);
            groupBox3.Controls.Add(cmbExportFormat);
            groupBox3.Controls.Add(btnExport);
            groupBox3.Controls.Add(btnExportPDF);
            groupBox3.Location = new System.Drawing.Point(13, 235);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox3.Size = new System.Drawing.Size(260, 192);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Exportar";
            // 
            // btnSaveSqlChanges
            // 
            btnSaveSqlChanges.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f);
            btnSaveSqlChanges.Location = new System.Drawing.Point(13, 100);
            btnSaveSqlChanges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnSaveSqlChanges.Name = "btnSaveSqlChanges";
            btnSaveSqlChanges.Size = new System.Drawing.Size(110, 76);
            btnSaveSqlChanges.TabIndex = 41;
            btnSaveSqlChanges.Text = "Changes SQL";
            btnSaveSqlChanges.UseVisualStyleBackColor = true;
            btnSaveSqlChanges.Click += btnSaveSqlChanges_Click;
            // 
            // lblData
            // 
            lblData.AllowDrop = true;
            lblData.AutoSize = true;
            lblData.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblData.Location = new System.Drawing.Point(810, 562);
            lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblData.Name = "lblData";
            lblData.Size = new System.Drawing.Size(49, 31);
            lblData.TabIndex = 36;
            lblData.Text = "No:";
            // 
            // treeView
            // 
            treeView.Location = new System.Drawing.Point(979, 151);
            treeView.Name = "treeView";
            treeView.Size = new System.Drawing.Size(469, 393);
            treeView.TabIndex = 37;
            // 
            // txtPlainText
            // 
            txtPlainText.Location = new System.Drawing.Point(1454, 151);
            txtPlainText.Multiline = true;
            txtPlainText.Name = "txtPlainText";
            txtPlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtPlainText.Size = new System.Drawing.Size(344, 393);
            txtPlainText.TabIndex = 38;
            txtPlainText.Visible = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnGraphics);
            groupBox5.Controls.Add(btnScatterPlot);
            groupBox5.Location = new System.Drawing.Point(561, 648);
            groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox5.Size = new System.Drawing.Size(138, 163);
            groupBox5.TabIndex = 39;
            groupBox5.TabStop = false;
            // 
            // btnEnviarArchivo
            // 
            btnEnviarArchivo.Font = new System.Drawing.Font("Yu Gothic UI", 11.25f);
            btnEnviarArchivo.Location = new System.Drawing.Point(309, 562);
            btnEnviarArchivo.Name = "btnEnviarArchivo";
            btnEnviarArchivo.Size = new System.Drawing.Size(110, 50);
            btnEnviarArchivo.TabIndex = 40;
            btnEnviarArchivo.Text = "Email";
            btnEnviarArchivo.UseVisualStyleBackColor = true;
            btnEnviarArchivo.Click += btnEnviarArchivo_Click;
            // 
            // progressBar1
            // 
            pgb.Location = new System.Drawing.Point(15, 464);
            pgb.Name = "progressBar1";
            pgb.Size = new System.Drawing.Size(232, 34);
            pgb.TabIndex = 41;
            pgb.Visible = false;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new System.Drawing.Point(13, 436);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new System.Drawing.Size(0, 25);
            lblProgress.TabIndex = 42;

            // 
            // FrmDataSet
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10f, 25f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightSteelBlue;
            ClientSize = new System.Drawing.Size(1806, 1050);
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
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ComboBox cmbDeleteType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.ComboBox cmbExportFormat;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox cmbClassFilter;
        private System.Windows.Forms.Button btnFilterClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGraphics;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
        private System.Windows.Forms.Button btnScatterPlot;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbClose;
        private System.Windows.Forms.RadioButton rbDistant;
        private System.Windows.Forms.Button btnRedshift;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnsqlDate;
        private System.Windows.Forms.Button btnSaveSqlChanges;
        private System.Windows.Forms.ComboBox cmbViewOption;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Button btnEnviarArchivo;
        private System.Windows.Forms.ProgressBar pgb;
        private System.Windows.Forms.Label lblProgress;
    }
}