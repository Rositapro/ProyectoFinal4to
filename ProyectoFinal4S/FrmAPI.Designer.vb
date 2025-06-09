Namespace ProyectoFinal4S
    Partial Class FrmAPI
        ''' <summary>
        '''  Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        '''  Clean up any resources being used.
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
        '''  Required method for Designer support - do not modify
        '''  the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            dgvData = New System.Windows.Forms.DataGridView()
            btnSearch = New System.Windows.Forms.Button()
            cbMonth = New System.Windows.Forms.ComboBox()
            label1 = New System.Windows.Forms.Label()
            btnGoBack = New System.Windows.Forms.Button()
            CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' dgvData
            ' 
            dgvData.BackgroundColor = Drawing.SystemColors.ControlLight
            dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle1.BackColor = Drawing.SystemColors.Window
            dataGridViewCellStyle1.Font = New Drawing.Font("Yu Gothic UI", 11.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle1.ForeColor = Drawing.SystemColors.ControlText
            dataGridViewCellStyle1.SelectionBackColor = Drawing.Color.LightSteelBlue
            dataGridViewCellStyle1.SelectionForeColor = Drawing.Color.FromArgb(0, 0, 64)
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False
            dgvData.DefaultCellStyle = dataGridViewCellStyle1
            dgvData.Location = New Drawing.Point(160, 171)
            dgvData.Name = "dgvData"
            dgvData.ReadOnly = True
            dgvData.RowHeadersWidth = 62
            dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            dgvData.Size = New Drawing.Size(910, 408)
            dgvData.TabIndex = 0
            AddHandler dgvData.CellContentClick, AddressOf dgvData_CellContentClick
            ' 
            ' btnSearch
            ' 
            btnSearch.Font = New Drawing.Font("Yu Gothic UI", 12F)
            btnSearch.Location = New Drawing.Point(306, 113)
            btnSearch.Name = "btnSearch"
            btnSearch.Size = New Drawing.Size(105, 37)
            btnSearch.TabIndex = 1
            btnSearch.Text = "Search"
            btnSearch.UseVisualStyleBackColor = True
            AddHandler btnSearch.Click, AddressOf Me.btnSearch_Click
            ' 
            ' cbMonth
            ' 
            cbMonth.Font = New Drawing.Font("Yu Gothic UI", 12F)
            cbMonth.FormattingEnabled = True
            cbMonth.Location = New Drawing.Point(160, 118)
            cbMonth.Name = "cbMonth"
            cbMonth.Size = New Drawing.Size(121, 29)
            cbMonth.TabIndex = 2
            AddHandler cbMonth.SelectedIndexChanged, AddressOf cbMonth_SelectedIndexChanged
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Yu Gothic UI Semibold", 18F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label1.Location = New Drawing.Point(515, 48)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(208, 32)
            label1.TabIndex = 3
            label1.Text = "Picture of the day"
            ' 
            ' btnGoBack
            ' 
            btnGoBack.Font = New Drawing.Font("Yu Gothic UI", 12F)
            btnGoBack.Location = New Drawing.Point(160, 28)
            btnGoBack.Name = "btnGoBack"
            btnGoBack.Size = New Drawing.Size(105, 37)
            btnGoBack.TabIndex = 4
            btnGoBack.Text = "Go back"
            btnGoBack.UseVisualStyleBackColor = True
            AddHandler btnGoBack.Click, AddressOf btnGoBack_Click
            ' 
            ' FrmAPI
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7F, 15F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.Color.LightSteelBlue
            ClientSize = New Drawing.Size(1256, 644)
            Controls.Add(btnGoBack)
            Controls.Add(label1)
            Controls.Add(cbMonth)
            Controls.Add(btnSearch)
            Controls.Add(dgvData)
            Name = "FrmAPI"
            Text = "Form1"
            TransparencyKey = Drawing.SystemColors.ScrollBar
            CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

#End Region

        Private dgvData As System.Windows.Forms.DataGridView
        Private btnSearch As System.Windows.Forms.Button
        Private cbMonth As System.Windows.Forms.ComboBox
        Private label1 As System.Windows.Forms.Label
        Private btnGoBack As System.Windows.Forms.Button
    End Class
End Namespace
