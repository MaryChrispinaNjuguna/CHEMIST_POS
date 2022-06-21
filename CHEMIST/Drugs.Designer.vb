<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Drugs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvDrugs = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDate1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvDrugs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDrugs
        '
        Me.dgvDrugs.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvDrugs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDrugs.Location = New System.Drawing.Point(-4, 71)
        Me.dgvDrugs.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDrugs.Name = "dgvDrugs"
        Me.dgvDrugs.ReadOnly = True
        Me.dgvDrugs.RowTemplate.Height = 25
        Me.dgvDrugs.Size = New System.Drawing.Size(793, 432)
        Me.dgvDrugs.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(585, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "DATE"
        '
        'lblDate1
        '
        Me.lblDate1.AutoSize = True
        Me.lblDate1.Location = New System.Drawing.Point(645, 32)
        Me.lblDate1.Name = "lblDate1"
        Me.lblDate1.Size = New System.Drawing.Size(0, 19)
        Me.lblDate1.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(665, 579)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 42)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "CLOSE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Drugs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(788, 633)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblDate1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvDrugs)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Drugs"
        Me.Text = "Stock"
        CType(Me.dgvDrugs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDrugs As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDate1 As Label
    Friend WithEvents Button1 As Button
End Class
