<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhieuThuTienGUI
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
        Me.dgvDanhSachXe = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbBienXe = New System.Windows.Forms.TextBox()
        Me.tbTenChuXe = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbSDT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpNgayThuTien = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvDanhSachXe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDanhSachXe
        '
        Me.dgvDanhSachXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachXe.Location = New System.Drawing.Point(126, 64)
        Me.dgvDanhSachXe.Name = "dgvDanhSachXe"
        Me.dgvDanhSachXe.Size = New System.Drawing.Size(617, 148)
        Me.dgvDanhSachXe.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 297)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Biển Xe"
        '
        'tbBienXe
        '
        Me.tbBienXe.Location = New System.Drawing.Point(221, 290)
        Me.tbBienXe.Name = "tbBienXe"
        Me.tbBienXe.Size = New System.Drawing.Size(311, 20)
        Me.tbBienXe.TabIndex = 2
        '
        'tbTenChuXe
        '
        Me.tbTenChuXe.Location = New System.Drawing.Point(221, 338)
        Me.tbTenChuXe.Name = "tbTenChuXe"
        Me.tbTenChuXe.Size = New System.Drawing.Size(311, 20)
        Me.tbTenChuXe.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tên chủ xe"
        '
        'tbSDT
        '
        Me.tbSDT.Location = New System.Drawing.Point(221, 394)
        Me.tbSDT.Name = "tbSDT"
        Me.tbSDT.Size = New System.Drawing.Size(311, 20)
        Me.tbSDT.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 401)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Số điện thoại"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(146, 463)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ngày thu tiền"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(221, 510)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(311, 20)
        Me.TextBox5.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(146, 517)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Số tiền thu"
        '
        'dtpNgayThuTien
        '
        Me.dtpNgayThuTien.Location = New System.Drawing.Point(222, 463)
        Me.dtpNgayThuTien.Name = "dtpNgayThuTien"
        Me.dtpNgayThuTien.Size = New System.Drawing.Size(310, 20)
        Me.dtpNgayThuTien.TabIndex = 11
        '
        'PhieuThuTienGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 633)
        Me.Controls.Add(Me.dtpNgayThuTien)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbSDT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbTenChuXe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbBienXe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDanhSachXe)
        Me.Name = "PhieuThuTienGUI"
        Me.Text = "PhieuThuTienGUI"
        CType(Me.dgvDanhSachXe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDanhSachXe As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents tbBienXe As TextBox
    Friend WithEvents tbTenChuXe As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbSDT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpNgayThuTien As DateTimePicker
End Class
