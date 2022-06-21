<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Me.lblPharmacyName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = Global.PHARMACY.My.Resources.Resources.imageedit_46_3215400785
        Me.pbxLogo.Location = New System.Drawing.Point(339, -6)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(185, 149)
        Me.pbxLogo.TabIndex = 1
        Me.pbxLogo.TabStop = False
        '
        'lblPharmacyName
        '
        Me.lblPharmacyName.AutoSize = True
        Me.lblPharmacyName.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPharmacyName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblPharmacyName.Location = New System.Drawing.Point(322, 146)
        Me.lblPharmacyName.Name = "lblPharmacyName"
        Me.lblPharmacyName.Size = New System.Drawing.Size(240, 36)
        Me.lblPharmacyName.TabIndex = 9
        Me.lblPharmacyName.Text = "THE CHEMIST"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label4.Location = New System.Drawing.Point(322, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Your Health Our Breath"
        '
        'btnOrders
        '
        Me.btnOrders.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnOrders.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnOrders.Location = New System.Drawing.Point(557, 255)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(152, 166)
        Me.btnOrders.TabIndex = 11
        Me.btnOrders.Text = "ORDERS"
        Me.btnOrders.UseVisualStyleBackColor = False
        '
        'btnSales
        '
        Me.btnSales.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSales.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSales.Location = New System.Drawing.Point(339, 255)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(152, 166)
        Me.btnSales.TabIndex = 12
        Me.btnSales.Text = "SALES"
        Me.btnSales.UseVisualStyleBackColor = False
        '
        'btnStock
        '
        Me.btnStock.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnStock.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnStock.Location = New System.Drawing.Point(97, 255)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(152, 166)
        Me.btnStock.TabIndex = 13
        Me.btnStock.Text = "STOCK"
        Me.btnStock.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(674, 485)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 42)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "CLOSE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(800, 539)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnStock)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.btnOrders)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPharmacyName)
        Me.Controls.Add(Me.pbxLogo)
        Me.Name = "Reports"
        Me.Text = "Reports"
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents lblPharmacyName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnOrders As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents btnStock As Button
    Friend WithEvents Button1 As Button
End Class
