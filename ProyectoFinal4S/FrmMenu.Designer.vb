Namespace ProyectoFinal4S
    Partial Class FrmMenu
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
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FrmMenu))
            btnAPI = New System.Windows.Forms.Button()
            btnDataSet = New System.Windows.Forms.Button()
            SuspendLayout()
            ' 
            ' btnAPI
            ' 
            btnAPI.Font = New Drawing.Font("Yu Gothic", 11.25F)
            btnAPI.Location = New Drawing.Point(405, 116)
            btnAPI.Name = "btnAPI"
            btnAPI.Size = New Drawing.Size(124, 41)
            btnAPI.TabIndex = 0
            btnAPI.Text = "NASA API"
            btnAPI.UseVisualStyleBackColor = True
            AddHandler btnAPI.Click, AddressOf btnAPI_Click
            ' 
            ' btnDataSet
            ' 
            btnDataSet.Font = New Drawing.Font("Yu Gothic", 11.25F)
            btnDataSet.Location = New Drawing.Point(405, 183)
            btnDataSet.Name = "btnDataSet"
            btnDataSet.Size = New Drawing.Size(124, 36)
            btnDataSet.TabIndex = 1
            btnDataSet.Text = "DATA SET"
            btnDataSet.UseVisualStyleBackColor = True
            AddHandler btnDataSet.Click, AddressOf btnDataSet_Click
            ' 
            ' Form3
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7F, 15F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            MyBase.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Drawing.Image)
            ClientSize = New Drawing.Size(822, 475)
            Controls.Add(btnDataSet)
            Controls.Add(btnAPI)
            Name = "Form3"
            Text = "Form3"
            ResumeLayout(False)
        End Sub

#End Region

        Private btnAPI As System.Windows.Forms.Button
        Private btnDataSet As System.Windows.Forms.Button
    End Class
End Namespace
