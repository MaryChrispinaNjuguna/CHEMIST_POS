<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Invoice
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
        Me.dgvInvoice = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblTotal1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDate1 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.lblInvoiceNo1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInvoice
        '
        Me.dgvInvoice.AllowUserToOrderColumns = True
        Me.dgvInvoice.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column4, Me.Column6, Me.Column5})
        Me.dgvInvoice.Location = New System.Drawing.Point(3, 70)
        Me.dgvInvoice.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvInvoice.Name = "dgvInvoice"
        Me.dgvInvoice.RowTemplate.Height = 25
        Me.dgvInvoice.Size = New System.Drawing.Size(796, 421)
        Me.dgvInvoice.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "No"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column3
        '
        Me.Column3.HeaderText = "Drug Name"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 300
        '
        'Column4
        '
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.Name = "Column4"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Rate"
        Me.Column6.Name = "Column6"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Price"
        Me.Column5.Name = "Column5"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.Location = New System.Drawing.Point(641, 578)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(129, 44)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblTotal1
        '
        Me.lblTotal1.AutoSize = True
        Me.lblTotal1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotal1.Location = New System.Drawing.Point(258, 495)
        Me.lblTotal1.Name = "lblTotal1"
        Me.lblTotal1.Size = New System.Drawing.Size(61, 19)
        Me.lblTotal1.TabIndex = 4
        Me.lblTotal1.Text = "TOTAL"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(352, 495)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 19)
        Me.lblTotal.TabIndex = 5
        '
        'lblDate1
        '
        Me.lblDate1.AutoSize = True
        Me.lblDate1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDate1.Location = New System.Drawing.Point(603, 31)
        Me.lblDate1.Name = "lblDate1"
        Me.lblDate1.Size = New System.Drawing.Size(51, 19)
        Me.lblDate1.TabIndex = 6
        Me.lblDate1.Text = "DATE"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(675, 31)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 19)
        Me.lblDate.TabIndex = 7
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInvoiceNo.Location = New System.Drawing.Point(3, 31)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(105, 19)
        Me.lblInvoiceNo.TabIndex = 8
        Me.lblInvoiceNo.Text = "INVOICE NO"
        '
        'lblInvoiceNo1
        '
        Me.lblInvoiceNo1.AutoSize = True
        Me.lblInvoiceNo1.Location = New System.Drawing.Point(114, 31)
        Me.lblInvoiceNo1.Name = "lblInvoiceNo1"
        Me.lblInvoiceNo1.Size = New System.Drawing.Size(0, 19)
        Me.lblInvoiceNo1.TabIndex = 9
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.Location = New System.Drawing.Point(29, 576)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(132, 46)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "CLOSE"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(786, 633)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblInvoiceNo1)
        Me.Controls.Add(Me.lblInvoiceNo)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblDate1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTotal1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvInvoice)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Invoice"
        Me.Text = "Invoice"
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvInvoice As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents lblTotal1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDate1 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblInvoiceNo As Label
    Friend WithEvents lblInvoiceNo1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents btnCancel As Button
End Class
