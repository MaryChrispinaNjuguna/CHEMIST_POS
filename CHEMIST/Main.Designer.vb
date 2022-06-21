<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.btnInvoice = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPharmacyName = New System.Windows.Forms.Label()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = Global.PHARMACY.My.Resources.Resources.imageedit_46_3215400785
        Me.pbxLogo.Location = New System.Drawing.Point(322, -11)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(185, 149)
        Me.pbxLogo.TabIndex = 0
        Me.pbxLogo.TabStop = False
        '
        'btnInvoice
        '
        Me.btnInvoice.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnInvoice.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnInvoice.Location = New System.Drawing.Point(93, 268)
        Me.btnInvoice.Name = "btnInvoice"
        Me.btnInvoice.Size = New System.Drawing.Size(152, 166)
        Me.btnInvoice.TabIndex = 1
        Me.btnInvoice.Text = "INVOICE"
        Me.btnInvoice.UseVisualStyleBackColor = False
        '
        'btnOrder
        '
        Me.btnOrder.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnOrder.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnOrder.Location = New System.Drawing.Point(355, 268)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(152, 166)
        Me.btnOrder.TabIndex = 2
        Me.btnOrder.Text = "ORDER"
        Me.btnOrder.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnReports.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReports.Location = New System.Drawing.Point(618, 268)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(152, 166)
        Me.btnReports.TabIndex = 3
        Me.btnReports.Text = "REPORTS"
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label4.Location = New System.Drawing.Point(310, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Your Health Our Breath"
        '
        'lblPharmacyName
        '
        Me.lblPharmacyName.AutoSize = True
        Me.lblPharmacyName.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPharmacyName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblPharmacyName.Location = New System.Drawing.Point(310, 139)
        Me.lblPharmacyName.Name = "lblPharmacyName"
        Me.lblPharmacyName.Size = New System.Drawing.Size(240, 36)
        Me.lblPharmacyName.TabIndex = 8
        Me.lblPharmacyName.Text = "THE CHEMIST"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(856, 579)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPharmacyName)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.btnInvoice)
        Me.Controls.Add(Me.pbxLogo)
        Me.Name = "Main"
        Me.Text = "Main"
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents btnInvoice As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPharmacyName As Label
End Class
