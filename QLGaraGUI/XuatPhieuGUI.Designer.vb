<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XuatPhieuGUI
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDanhSachXe = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbSTT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbVatTu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbSoLuong = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbDonGia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbTienCong = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbThanhTien = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txBienXe = New System.Windows.Forms.TextBox()
        Me.tbNgayTiepNhan = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.dgvNguyenlieu = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgvDanhSachXe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNguyenlieu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Danh xách xe"
        '
        'dgvDanhSachXe
        '
        Me.dgvDanhSachXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachXe.Location = New System.Drawing.Point(94, 51)
        Me.dgvDanhSachXe.Name = "dgvDanhSachXe"
        Me.dgvDanhSachXe.Size = New System.Drawing.Size(255, 99)
        Me.dgvDanhSachXe.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "STT"
        '
        'tbSTT
        '
        Me.tbSTT.Enabled = False
        Me.tbSTT.Location = New System.Drawing.Point(187, 292)
        Me.tbSTT.Name = "tbSTT"
        Me.tbSTT.Size = New System.Drawing.Size(433, 20)
        Me.tbSTT.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nội dung"
        '
        'tbVatTu
        '
        Me.tbVatTu.Location = New System.Drawing.Point(187, 380)
        Me.tbVatTu.Name = "tbVatTu"
        Me.tbVatTu.Size = New System.Drawing.Size(433, 20)
        Me.tbVatTu.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 380)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Vật tư"
        '
        'tbSoLuong
        '
        Me.tbSoLuong.Location = New System.Drawing.Point(187, 474)
        Me.tbSoLuong.Name = "tbSoLuong"
        Me.tbSoLuong.Size = New System.Drawing.Size(433, 20)
        Me.tbSoLuong.TabIndex = 9
        Me.tbSoLuong.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(92, 474)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Số lượng"
        '
        'tbDonGia
        '
        Me.tbDonGia.Location = New System.Drawing.Point(187, 426)
        Me.tbDonGia.Name = "tbDonGia"
        Me.tbDonGia.Size = New System.Drawing.Size(433, 20)
        Me.tbDonGia.TabIndex = 11
        Me.tbDonGia.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(92, 429)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "đơn giá"
        '
        'tbTienCong
        '
        Me.tbTienCong.Location = New System.Drawing.Point(187, 523)
        Me.tbTienCong.Name = "tbTienCong"
        Me.tbTienCong.Size = New System.Drawing.Size(433, 20)
        Me.tbTienCong.TabIndex = 13
        Me.tbTienCong.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(91, 523)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Tiền công"
        '
        'tbThanhTien
        '
        Me.tbThanhTien.Enabled = False
        Me.tbThanhTien.Location = New System.Drawing.Point(187, 564)
        Me.tbThanhTien.Name = "tbThanhTien"
        Me.tbThanhTien.ReadOnly = True
        Me.tbThanhTien.Size = New System.Drawing.Size(433, 20)
        Me.tbThanhTien.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(91, 564)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Thành tiền"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(312, 639)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Xuất phiếu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(91, 206)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Biển Xe"
        '
        'txBienXe
        '
        Me.txBienXe.Location = New System.Drawing.Point(187, 203)
        Me.txBienXe.Name = "txBienXe"
        Me.txBienXe.Size = New System.Drawing.Size(433, 20)
        Me.txBienXe.TabIndex = 18
        '
        'tbNgayTiepNhan
        '
        Me.tbNgayTiepNhan.Location = New System.Drawing.Point(187, 248)
        Me.tbNgayTiepNhan.Name = "tbNgayTiepNhan"
        Me.tbNgayTiepNhan.Size = New System.Drawing.Size(433, 20)
        Me.tbNgayTiepNhan.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(91, 255)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Ngày tiếp nhận"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Sửa Xe", "Rửa Xe", "Bảo trì Xe"})
        Me.ComboBox1.Location = New System.Drawing.Point(187, 336)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(433, 21)
        Me.ComboBox1.TabIndex = 21
        '
        'dgvNguyenlieu
        '
        Me.dgvNguyenlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNguyenlieu.Location = New System.Drawing.Point(417, 51)
        Me.dgvNguyenlieu.Name = "dgvNguyenlieu"
        Me.dgvNguyenlieu.Size = New System.Drawing.Size(240, 99)
        Me.dgvNguyenlieu.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.Location = New System.Drawing.Point(414, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Danh sach nguyen lieu"
        '
        'XuatPhieuGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 722)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dgvNguyenlieu)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.tbNgayTiepNhan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txBienXe)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbThanhTien)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbTienCong)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbDonGia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbSoLuong)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbVatTu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbSTT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvDanhSachXe)
        Me.Controls.Add(Me.Label1)
        Me.Name = "XuatPhieuGUI"
        Me.Text = "XuatPhieuGUI"
        CType(Me.dgvDanhSachXe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNguyenlieu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachXe As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents tbSTT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbVatTu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbSoLuong As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbDonGia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbTienCong As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbThanhTien As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txBienXe As TextBox
    Friend WithEvents tbNgayTiepNhan As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents dgvNguyenlieu As DataGridView
    Friend WithEvents Label11 As Label
End Class
