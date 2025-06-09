Namespace ProyectoFinal4S
    Partial Class FrmDataSet
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            btnOpen = New System.Windows.Forms.Button()
            dgvData = New System.Windows.Forms.DataGridView()
            cmbDeleteType = New System.Windows.Forms.ComboBox()
            btnDelete = New System.Windows.Forms.Button()
            btnClearData = New System.Windows.Forms.Button()
            cmbExportFormat = New System.Windows.Forms.ComboBox()
            btnExport = New System.Windows.Forms.Button()
            cmbClassFilter = New System.Windows.Forms.ComboBox()
            btnFilterClass = New System.Windows.Forms.Button()
            groupBox1 = New System.Windows.Forms.GroupBox()
            btnGoBack = New System.Windows.Forms.Button()
            groupBox2 = New System.Windows.Forms.GroupBox()
            btnsqlDate = New System.Windows.Forms.Button()
            btnGraphics = New System.Windows.Forms.Button()
            formsPlot1 = New ScottPlot.WinForms.FormsPlot()
            formsPlot2 = New ScottPlot.WinForms.FormsPlot()
            btnScatterPlot = New System.Windows.Forms.Button()
            btnExportPDF = New System.Windows.Forms.Button()
            txtSearch = New System.Windows.Forms.TextBox()
            btnSearch = New System.Windows.Forms.Button()
            label1 = New System.Windows.Forms.Label()
            rbClose = New System.Windows.Forms.RadioButton()
            rbDistant = New System.Windows.Forms.RadioButton()
            btnRedshift = New System.Windows.Forms.Button()
            groupBox4 = New System.Windows.Forms.GroupBox()
            lblView = New System.Windows.Forms.Label()
            cmbViewOption = New System.Windows.Forms.ComboBox()
            groupBox3 = New System.Windows.Forms.GroupBox()
            btnSaveSqlChanges = New System.Windows.Forms.Button()
            lblData = New System.Windows.Forms.Label()
            treeView = New System.Windows.Forms.TreeView()
            txtPlainText = New System.Windows.Forms.TextBox()
            groupBox5 = New System.Windows.Forms.GroupBox()
            btnEnviarArchivo = New System.Windows.Forms.Button()
            pgb = New System.Windows.Forms.ProgressBar()
            lblProgress = New System.Windows.Forms.Label()
            CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
            groupBox1.SuspendLayout()
            groupBox2.SuspendLayout()
            groupBox4.SuspendLayout()
            groupBox3.SuspendLayout()
            groupBox5.SuspendLayout()
            SuspendLayout()
            ' 
            ' btnOpen
            ' 
            btnOpen.Font = New Drawing.Font("Yu Gothic UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            btnOpen.Location = New Drawing.Point(13, 34)
            btnOpen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            btnOpen.Name = "btnOpen"
            btnOpen.Size = New Drawing.Size(110, 50)
            btnOpen.TabIndex = 1
            btnOpen.Text = "Open"
            btnOpen.UseVisualStyleBackColor = True
            AddHandler btnOpen.Click, AddressOf btnOpen_Click
            ' 
            ' dgvData
            ' 
            dgvData.BackgroundColor = Drawing.SystemColors.ControlLight
            dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            dgvData.Location = New Drawing.Point(309, 151)
            dgvData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            dgvData.Name = "dgvData"
            dgvData.RowHeadersWidth = 62
            dgvData.Size = New Drawing.Size(663, 393)
            dgvData.TabIndex = 5
            ' 
            ' cmbDeleteType
            ' 
            cmbDeleteType.Font = New Drawing.Font("Yu Gothic UI", 11.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            cmbDeleteType.FormattingEnabled = True
            cmbDeleteType.Location = New Drawing.Point(13, 25)
            cmbDeleteType.Name = "cmbDeleteType"
            cmbDeleteType.Size = New Drawing.Size(164, 39)
            cmbDeleteType.TabIndex = 12
            ' 
            ' btnDelete
            ' 
            btnDelete.Font = New Drawing.Font("Yu Gothic UI", 11.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            btnDelete.Location = New Drawing.Point(13, 75)
            btnDelete.Name = "btnDelete"
            btnDelete.Size = New Drawing.Size(110, 50)
            btnDelete.TabIndex = 13
            btnDelete.Text = "Delete"
            btnDelete.UseVisualStyleBackColor = True
            AddHandler btnDelete.Click, AddressOf btnDelete_Click
            ' 
            ' btnClearData
            ' 
            btnClearData.Font = New Drawing.Font("Yu Gothic UI", 11.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            btnClearData.Location = New Drawing.Point(129, 75)
            btnClearData.Name = "btnClearData"
            btnClearData.Size = New Drawing.Size(110, 50)
            btnClearData.TabIndex = 14
            btnClearData.Text = "Clear data"
            btnClearData.UseVisualStyleBackColor = True
            AddHandler btnClearData.Click, AddressOf btnClearData_Click
            ' 
            ' cmbExportFormat
            ' 
            cmbExportFormat.Font = New Drawing.Font("Yu Gothic UI", 11.25F)
            cmbExportFormat.FormattingEnabled = True
            cmbExportFormat.Location = New Drawing.Point(8, 32)
            cmbExportFormat.Name = "cmbExportFormat"
            cmbExportFormat.Size = New Drawing.Size(129, 39)
            cmbExportFormat.TabIndex = 16
            ' 
            ' btnExport
            ' 
            btnExport.Font = New Drawing.Font("Yu Gothic UI", 11.25F)
            btnExport.Location = New Drawing.Point(143, 32)
            btnExport.Name = "btnExport"
            btnExport.Size = New Drawing.Size(110, 50)
            btnExport.TabIndex = 17
            btnExport.Text = "Export"
            btnExport.UseVisualStyleBackColor = True
            AddHandler btnExport.Click, AddressOf btnExport_Click
            ' 
            ' cmbClassFilter
            ' 
            cmbClassFilter.Font = New Drawing.Font("Yu Gothic UI", 11.25F)
            cmbClassFilter.FormattingEnabled = True
            cmbClassFilter.Location = New Drawing.Point(1122, 41)
            cmbClassFilter.Name = "cmbClassFilter"
            cmbClassFilter.Size = New Drawing.Size(183, 39)
            cmbClassFilter.TabIndex = 18

            ' 
            ' btnFilterClass
            ' 
            btnFilterClass.Font = New Drawing.Font("Yu Gothic UI", 11.25F)
            btnFilterClass.Location = New Drawing.Point(1313, 32)
            btnFilterClass.Name = "btnFilterClass"
            btnFilterClass.Size = New Drawing.Size(110, 50)
            btnFilterClass.TabIndex = 19
            btnFilterClass.Text = "Filter"
            btnFilterClass.UseVisualStyleBackColor = True
            AddHandler btnFilterClass.Click, AddressOf btnFilterClass_Click
            ' 
            ' groupBox1
            ' 
            groupBox1.Controls.Add(cmbDeleteType)
            groupBox1.Controls.Add(btnDelete)
            groupBox1.Controls.Add(btnClearData)
            groupBox1.Location = New Drawing.Point(8, 500)
            groupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            groupBox1.Name = "groupBox1"
            groupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
            groupBox1.Size = New Drawing.Size(258, 138)
            groupBox1.TabIndex = 20
            groupBox1.TabStop = False

            ' 
            ' btnGoBack
            ' 
            btnGoBack.Font = New Drawing.Font("Yu Gothic UI", 12F)
            btnGoBack.Location = New Drawing.Point(15, 41)
            btnGoBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            btnGoBack.Name = "btnGoBack"
            btnGoBack.Size = New Drawing.Size(110, 50)
            btnGoBack.TabIndex = 21
            btnGoBack.Text = "Go back"
            btnGoBack.UseVisualStyleBackColor = True
            AddHandler btnGoBack.Click, AddressOf btnGoBack_Click
            ' 
            ' groupBox2
            ' 
            groupBox2.Controls.Add(btnOpen)
            groupBox2.Controls.Add(btnsqlDate)
            groupBox2.Location = New Drawing.Point(8, 128)
            groupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            groupBox2.Name = "groupBox2"
            groupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
            groupBox2.Size = New Drawing.Size(260, 106)
            groupBox2.TabIndex = 22
            groupBox2.TabStop = False
            ' 
            ' btnsqlDate
            ' 
            btnsqlDate.Font = New Drawing.Font("Yu Gothic UI", 11.25F)
            btnsqlDate.Location = New Drawing.Point(131, 36)
            btnsqlDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            btnsqlDate.Name = "btnsqlDate"
            btnsqlDate.Size = New Drawing.Size(110, 50)
            btnsqlDate.TabIndex = 40
            btnsqlDate.Text = "Sql"
            btnsqlDate.UseVisualStyleBackColor = True
            AddHandler btnsqlDate.Click, AddressOf btnsqlDate_Click
            ' 
            ' btnGraphics
            ' 
            btnGraphics.Font = New Drawing.Font("Yu Gothic UI", 11.25F)
            btnGraphics.Location = New Drawing.Point(17, 32)
            btnGraphics.Name = "btnGraphics"
            btnGraphics.Size = New Drawing.Size(110, 50)
            btnGraphics.TabIndex = 23
            btnGraphics.Text = "Pie "
            btnGraphics.UseVisualStyleBackColor = True
            AddHandler btnGraphics.Click, AddressOf btnGraphics_Click
            ' 
            ' formsPlot1
            ' 
            formsPlot1.DisplayScale = 1F
            formsPlot1.Location = New Drawing.Point(13, 648)
            formsPlot1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            formsPlot1.Name = "formsPlot1"
            formsPlot1.Size = New Drawing.Size(511, 403)
            formsPlot1.TabIndex = 24
            ' 
            ' formsPlot2
            ' 
            formsPlot2.DisplayScale = 1F
            formsPlot2.Location = New Drawing.Point(729, 648)
            formsPlot2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            formsPlot2.Name = "formsPlot2"
            formsPlot2.Size = New Drawing.Size(1069, 403)
            formsPlot2.TabIndex = 25
            ' 
            ' btnScatterPlot
            ' 
            btnScatterPlot.Font = New Drawing.Font("Yu Gothic UI", 11.25F)
            btnScatterPlot.Location = New Drawing.Point(17, 88)
            btnScatterPlot.Name = "btnScatterPlot"
            btnScatterPlot.Size = New Drawing.Size(110, 50)
            btnScatterPlot.TabIndex = 26
            btnScatterPlot.Text = "Scatter"
            btnScatterPlot.UseVisualStyleBackColor = True
            AddHandler btnScatterPlot.Click, AddressOf btnScatterPlot_Click
            ' 
            ' btnExportPDF
            ' 
            btnExportPDF.Font = New Drawing.Font("Yu Gothic UI", 11.25F)
            btnExportPDF.Location = New Drawing.Point(143, 100)
            btnExportPDF.Name = "btnExportPDF"
            btnExportPDF.Size = New Drawing.Size(110, 76)
            btnExportPDF.TabIndex = 27
            btnExportPDF.Text = "Export PDF"
            btnExportPDF.UseVisualStyleBackColor = True
            AddHandler btnExportPDF.Click, AddressOf btnExportPDF_Click
            ' 
            ' txtSearch
            ' 
            txtSearch.Font = New Drawing.Font("Yu Gothic UI", 11.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            txtSearch.Location = New Drawing.Point(143, 48)
            txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            txtSearch.Name = "txtSearch"
            txtSearch.Size = New Drawing.Size(380, 37)
            txtSearch.TabIndex = 28
            ' 
            ' btnSearch
            ' 
            btnSearch.Font = New Drawing.Font("Yu Gothic UI", 12F)
            btnSearch.Location = New Drawing.Point(548, 41)
            btnSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            btnSearch.Name = "btnSearch"
            btnSearch.Size = New Drawing.Size(110, 50)
            btnSearch.TabIndex = 29
            btnSearch.Text = "Search"
            btnSearch.UseVisualStyleBackColor = True
            AddHandler btnSearch.Click, AddressOf btnSearch_Click
            ' 
            ' label1
            ' 
            label1.AllowDrop = True
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Yu Gothic UI", 11.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label1.Location = New Drawing.Point(700, 48)
            label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(98, 31)
            label1.TabIndex = 30
            label1.Text = "Redshift"
            ' 
            ' rbClose
            ' 
            rbClose.AutoSize = True
            rbClose.Font = New Drawing.Font("Yu Gothic UI", 11.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            rbClose.Location = New Drawing.Point(797, 68)
            rbClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            rbClose.Name = "rbClose"
            rbClose.Size = New Drawing.Size(168, 35)
            rbClose.TabIndex = 31
            rbClose.TabStop = True
            rbClose.Text = "Near objects"
            rbClose.UseVisualStyleBackColor = True

            ' 
            ' rbDistant
            ' 
            rbDistant.AutoSize = True
            rbDistant.Font = New Drawing.Font("Yu Gothic UI", 11.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            rbDistant.Location = New Drawing.Point(796, 26)
            rbDistant.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            rbDistant.Name = "rbDistant"
            rbDistant.Size = New Drawing.Size(149, 35)
            rbDistant.TabIndex = 32
            rbDistant.TabStop = True
            rbDistant.Text = "Far objects"
            rbDistant.UseVisualStyleBackColor = True
            ' 
            ' btnRedshift
            ' 
            btnRedshift.Font = New Drawing.Font("Yu Gothic UI", 12F)
            btnRedshift.Location = New Drawing.Point(971, 41)
            btnRedshift.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            btnRedshift.Name = "btnRedshift"
            btnRedshift.Size = New Drawing.Size(110, 50)
            btnRedshift.TabIndex = 34
            btnRedshift.Text = "Order"
            btnRedshift.UseVisualStyleBackColor = True
            AddHandler btnRedshift.Click, AddressOf btnRedshift_Click
            ' 
            ' groupBox4
            ' 
            groupBox4.Controls.Add(lblView)
            groupBox4.Controls.Add(cmbViewOption)
            groupBox4.Controls.Add(rbDistant)
            groupBox4.Controls.Add(btnSearch)
            groupBox4.Controls.Add(btnRedshift)
            groupBox4.Controls.Add(rbClose)
            groupBox4.Controls.Add(txtSearch)
            groupBox4.Controls.Add(btnGoBack)
            groupBox4.Controls.Add(cmbClassFilter)
            groupBox4.Controls.Add(btnFilterClass)
            groupBox4.Controls.Add(label1)
            groupBox4.Location = New Drawing.Point(13, 14)
            groupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            groupBox4.Name = "groupBox4"
            groupBox4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
            groupBox4.Size = New Drawing.Size(1780, 113)
            groupBox4.TabIndex = 23
            groupBox4.TabStop = False
            ' 
            ' lblView
            ' 
            lblView.AutoSize = True
            lblView.Font = New Drawing.Font("Yu Gothic UI", 11.25F)
            lblView.Location = New Drawing.Point(1492, 41)
            lblView.Name = "lblView"
            lblView.Size = New Drawing.Size(63, 31)
            lblView.TabIndex = 40
            lblView.Text = "View"
            ' 
            ' cmbViewOption
            ' 
            cmbViewOption.FormattingEnabled = True
            cmbViewOption.Location = New Drawing.Point(1569, 42)
            cmbViewOption.Name = "cmbViewOption"
            cmbViewOption.Size = New Drawing.Size(183, 33)
            cmbViewOption.TabIndex = 40
            ' 
            ' groupBox3
            ' 
            groupBox3.Controls.Add(btnSaveSqlChanges)
            groupBox3.Controls.Add(cmbExportFormat)
            groupBox3.Controls.Add(btnExport)
            groupBox3.Controls.Add(btnExportPDF)
            groupBox3.Location = New Drawing.Point(13, 235)
            groupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            groupBox3.Name = "groupBox3"
            groupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
            groupBox3.Size = New Drawing.Size(260, 192)
            groupBox3.TabIndex = 23
            groupBox3.TabStop = False
            groupBox3.Text = "Exportar"
            ' 
            ' btnSaveSqlChanges
            ' 
            btnSaveSqlChanges.Font = New Drawing.Font("Yu Gothic UI", 11.25F)
            btnSaveSqlChanges.Location = New Drawing.Point(13, 100)
            btnSaveSqlChanges.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            btnSaveSqlChanges.Name = "btnSaveSqlChanges"
            btnSaveSqlChanges.Size = New Drawing.Size(110, 76)
            btnSaveSqlChanges.TabIndex = 41
            btnSaveSqlChanges.Text = "Changes SQL"
            btnSaveSqlChanges.UseVisualStyleBackColor = True
            AddHandler btnSaveSqlChanges.Click, AddressOf btnSaveSqlChanges_Click
            ' 
            ' lblData
            ' 
            lblData.AllowDrop = True
            lblData.AutoSize = True
            lblData.Font = New Drawing.Font("Yu Gothic UI", 11.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            lblData.Location = New Drawing.Point(810, 562)
            lblData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            lblData.Name = "lblData"
            lblData.Size = New Drawing.Size(49, 31)
            lblData.TabIndex = 36
            lblData.Text = "No:"
            ' 
            ' treeView
            ' 
            treeView.Location = New Drawing.Point(979, 151)
            treeView.Name = "treeView"
            treeView.Size = New Drawing.Size(469, 393)
            treeView.TabIndex = 37
            ' 
            ' txtPlainText
            ' 
            txtPlainText.Location = New Drawing.Point(1454, 151)
            txtPlainText.Multiline = True
            txtPlainText.Name = "txtPlainText"
            txtPlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            txtPlainText.Size = New Drawing.Size(344, 393)
            txtPlainText.TabIndex = 38
            txtPlainText.Visible = False
            ' 
            ' groupBox5
            ' 
            groupBox5.Controls.Add(btnGraphics)
            groupBox5.Controls.Add(btnScatterPlot)
            groupBox5.Location = New Drawing.Point(561, 648)
            groupBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            groupBox5.Name = "groupBox5"
            groupBox5.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
            groupBox5.Size = New Drawing.Size(138, 163)
            groupBox5.TabIndex = 39
            groupBox5.TabStop = False
            ' 
            ' btnEnviarArchivo
            ' 
            btnEnviarArchivo.Font = New Drawing.Font("Yu Gothic UI", 11.25F)
            btnEnviarArchivo.Location = New Drawing.Point(309, 562)
            btnEnviarArchivo.Name = "btnEnviarArchivo"
            btnEnviarArchivo.Size = New Drawing.Size(110, 50)
            btnEnviarArchivo.TabIndex = 40
            btnEnviarArchivo.Text = "Email"
            btnEnviarArchivo.UseVisualStyleBackColor = True
            AddHandler btnEnviarArchivo.Click, AddressOf btnEnviarArchivo_Click
            ' 
            ' progressBar1
            ' 
            pgb.Location = New Drawing.Point(15, 464)
            pgb.Name = "progressBar1"
            pgb.Size = New Drawing.Size(232, 34)
            pgb.TabIndex = 41
            pgb.Visible = False
            ' 
            ' lblProgress
            ' 
            lblProgress.AutoSize = True
            lblProgress.Location = New Drawing.Point(13, 436)
            lblProgress.Name = "lblProgress"
            lblProgress.Size = New Drawing.Size(0, 25)
            lblProgress.TabIndex = 42

            ' 
            ' FrmDataSet
            ' 
            AutoScaleDimensions = New Drawing.SizeF(10F, 25F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.Color.LightSteelBlue
            ClientSize = New Drawing.Size(1806, 1050)
            Controls.Add(lblProgress)
            Controls.Add(pgb)
            Controls.Add(btnEnviarArchivo)
            Controls.Add(groupBox5)
            Controls.Add(txtPlainText)
            Controls.Add(treeView)
            Controls.Add(lblData)
            Controls.Add(groupBox3)
            Controls.Add(groupBox4)
            Controls.Add(formsPlot2)
            Controls.Add(formsPlot1)
            Controls.Add(groupBox2)
            Controls.Add(groupBox1)
            Controls.Add(dgvData)
            Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Name = "FrmDataSet"
            Text = "Form2"

            CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
            groupBox1.ResumeLayout(False)
            groupBox2.ResumeLayout(False)
            groupBox4.ResumeLayout(False)
            groupBox4.PerformLayout()
            groupBox3.ResumeLayout(False)
            groupBox5.ResumeLayout(False)
            ResumeLayout(False)
            PerformLayout()
        End Sub

#End Region
        Private btnOpen As System.Windows.Forms.Button
        Private dgvData As System.Windows.Forms.DataGridView
        Private cmbDeleteType As System.Windows.Forms.ComboBox
        Private btnDelete As System.Windows.Forms.Button
        Private btnClearData As System.Windows.Forms.Button
        Private cmbExportFormat As System.Windows.Forms.ComboBox
        Private btnExport As System.Windows.Forms.Button
        Private cmbClassFilter As System.Windows.Forms.ComboBox
        Private btnFilterClass As System.Windows.Forms.Button
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private btnGoBack As System.Windows.Forms.Button
        Private groupBox2 As System.Windows.Forms.GroupBox
        Private btnGraphics As System.Windows.Forms.Button
        Private formsPlot1 As ScottPlot.WinForms.FormsPlot
        Private formsPlot2 As ScottPlot.WinForms.FormsPlot
        Private btnScatterPlot As System.Windows.Forms.Button
        Private btnExportPDF As System.Windows.Forms.Button
        Private txtSearch As System.Windows.Forms.TextBox
        Private btnSearch As System.Windows.Forms.Button
        Private label1 As System.Windows.Forms.Label
        Private rbClose As System.Windows.Forms.RadioButton
        Private rbDistant As System.Windows.Forms.RadioButton
        Private btnRedshift As System.Windows.Forms.Button
        Private groupBox4 As System.Windows.Forms.GroupBox
        Private groupBox3 As System.Windows.Forms.GroupBox
        Private lblData As System.Windows.Forms.Label
        Private treeView As System.Windows.Forms.TreeView
        Private txtPlainText As System.Windows.Forms.TextBox
        Private groupBox5 As System.Windows.Forms.GroupBox
        Private btnsqlDate As System.Windows.Forms.Button
        Private btnSaveSqlChanges As System.Windows.Forms.Button
        Private cmbViewOption As System.Windows.Forms.ComboBox
        Private lblView As System.Windows.Forms.Label
        Private btnEnviarArchivo As System.Windows.Forms.Button
        Private pgb As System.Windows.Forms.ProgressBar
        Private lblProgress As System.Windows.Forms.Label
    End Class
End Namespace
