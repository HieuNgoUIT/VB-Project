Imports QLGaraBUS
Imports QLGaraDTO
Imports Utility
Imports QLGaraDAL


Public Class DanhSachCacXeGui

    Private biensoBus As BienSoBus
    Private hieuxeBus As HieuXeBus
    Private chuxeBus As ChuXeBus
    Private tiennoBus As TienNoBus
    

    Private Sub DanhSachCacXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        biensoBus = New BienSoBus()
        hieuxeBus = New HieuXeBus()
        chuxeBus = New ChuXeBus()
        tiennoBus = New TienNoBus()
        
		'1.load list bien so xe 
		Dim listBienSoXe = New List(Of BienSoXeDTO)
        Dim result = BienSoXeBus.selectAll(BIENSO)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Biển số xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        BienSoXe.DataSource = New BindingSource(listBienSoXe, String.Empty)
        BienSoXe.DisplayMember = "BienSoXe"
        BienSoXe.ValueMember = "BienSoXe"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(BienSoXe.DataSource)
        myCurrencyManager.Refresh()
        If (listKhoi.Count > 0) Then
            cbKhoi.SELECTedIndex = 0
        End If
    End Sub
	
	
	     
		 
     '2.load list hieu xe
	Private Sub HieuXe_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles HieuXe.SELECTedIndexChanged
         HieuXe.DataSource = Nothing

        
        Dim ListHieuXe = New List(Of HieuXeDTO)
        Dim result As Result
        result = HieuXeBus.selectAll(HIEUXE)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Hieu Xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        HieuXe.DataSource = New BindingSource(ListHieuXe, String.Empty)
        HieuXe.DisplayMember = "HieuXe"
        HieuXe.ValueMember = "HieuXe"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(HieuXe.DataSource)
        myCurrencyManager.Refresh()
        If (listHieuXe.Count > 0) Then
            HieuXe.SelectedIndex = 0
        End If
    End Sub
	
	'3.load list chu xe 
	Private Sub ChuXe_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles ChuXe.SELECTedIndexChanged
         ChuXe.DataSource = Nothing

        
        Dim ListChuXe = New List(Of ChuXeDTO)
        Dim result As Result
        result = ChuXeBus.selectAll(TENCHUXE)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Chu Xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        ChuXe.DataSource = New BindingSource(ListChuXe, String.Empty)
        ChuXe.DisplayMember = "ChuXe"
        ChuXe.ValueMember = "ChuXe"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(ChuXe.DataSource)
        myCurrencyManager.Refresh()
        If (listChuXe.Count > 0) Then
            ChuXe.SelectedIndex = 0
        End If
    End Sub
	'4.load list tien no
	Private Sub TienNo_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles TienNo.SELECTedIndexChanged
         TienNo.DataSource = Nothing

        
        Dim ListTienNo = New List(Of TienNoDTO)
        Dim result As Result
        result = TienNoBus.selectAll(TIENNO)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Chu Xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        TienNo.DataSource = New BindingSource(ListTienNo, String.Empty)
        TienNo.DisplayMember = "TienNo"
        TienNo.ValueMember = "TienNo"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(ChuXe.DataSource)
        myCurrencyManager.Refresh()
        If (listTienNo.Count > 0) Then
            TienNo.SelectedIndex = 0
        End If
    End Sub
	

		
		
		


        '2. Business .....
        xeBus = New DanhSachCacXeBUS()


End Class