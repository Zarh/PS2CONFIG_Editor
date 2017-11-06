
Imports System.IO
Imports System.Text

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CommandID.SelectedIndex = 0
        Me.ListBox1.Items.Add("0x00")
        Me.ListBox1.Items.Add("0x3D")
        Me.GroupBox0.Visible = False
        Me.GroupBox1.Visible = False
        Me.GroupBox2.Visible = False
        Me.GroupBox3.Visible = False
        Me.GroupBox4.Visible = False
        Me.GroupBox5.Visible = False
        Me.GroupBox6.Visible = False
        Me.GroupBox7.Visible = False
        Me.GroupBox8.Visible = False
        Me.GroupBox9.Visible = False
        Me.GroupBoxA.Visible = False
        Me.GroupBoxB.Visible = False
        Me.GroupBoxC.Visible = False
        Me.GroupBoxD.Visible = False
        Me.GroupBoxE.Visible = False
        Me.GroupBoxF.Visible = False
        Me.GroupBox10.Visible = False
        Me.GroupBox11.Visible = False
        Me.GroupBox12.Visible = False
        Me.GroupBox13.Visible = False
        Me.GroupBox14.Visible = False
        Me.GroupBox15.Visible = False
        Me.GroupBox16.Visible = False
        Me.GroupBox17.Visible = False
        Me.GroupBox18.Visible = False
        Me.GroupBox19.Visible = False
        Me.GroupBox1A.Visible = False
        Me.GroupBox1B.Visible = False
        Me.GroupBox1C.Visible = False
        Me.GroupBox1D.Visible = False
        Me.GroupBox1E.Visible = False
        Me.GroupBox1F.Visible = False
        Me.GroupBox20.Visible = False
        Me.GroupBox21.Visible = False
        Me.GroupBox22.Visible = False
        Me.GroupBox23.Visible = False
        Me.GroupBox24.Visible = False
        Me.GroupBox25.Visible = False
        Me.GroupBox26.Visible = False
        Me.GroupBox27.Visible = False
        Me.GroupBox28.Visible = False
        Me.GroupBox29.Visible = False
        Me.GroupBox2A.Visible = False
        Me.GroupBox2B.Visible = False
        Me.GroupBox2C.Visible = False
        Me.GroupBox2D.Visible = False
        Me.GroupBox2E.Visible = False
        Me.GroupBox2F.Visible = False
        Me.GroupBox35.Visible = False
        Me.GroupBox3D.Visible = False
        Me.GroupBox3E.Visible = False
        Me.GroupBox3F.Visible = False
        Me.GroupBox40.Visible = False
        Me.GroupBox41.Visible = False
        Me.GroupBox42.Visible = False
        Me.GroupBox43.Visible = False
        Me.GroupBox44.Visible = False
        Me.GroupBox45.Visible = False
        Me.GroupBox46.Visible = False
        Me.GroupBox47.Visible = False
        Me.GroupBox48.Visible = False
        Me.GroupBox49.Visible = False
        Me.GroupBox4A.Visible = False
        Me.GroupBox4B.Visible = False
        Me.GroupBox4C.Visible = False
        Me.GroupBox4D.Visible = False
        Me.GroupBox50.Visible = False

    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click

        If Not ListBox1.Items.Contains(CommandID.SelectedItem.ToString) Then
            ListBox1.Items.Add(CommandID.SelectedItem.ToString)
            For Each box In Me.Tab_Simple.Controls
                If TypeOf box Is CheckBox Then
                    If box.text = CommandID.SelectedItem.ToString Then
                        box.Checked = True
                    End If
                End If
            Next
        End If

    End Sub

    Private Sub Remove_Click(sender As Object, e As EventArgs) Handles Remove.Click
        If Not ListBox1.SelectedItem = "0x00" And Not ListBox1.SelectedItem = "0x3D" Then
            If Not ListBox1.SelectedItem = Nothing Then
                For Each box In Me.Tab_Simple.Controls
                    If TypeOf box Is CheckBox Then
                        If box.text = ListBox1.SelectedItem Then
                            box.Checked = False
                        End If
                    End If
                Next
                ListBox1.Items.Remove(ListBox1.SelectedItem)
            End If
        End If
    End Sub

    Private Sub CheckBox_ID03_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox_ID50.CheckStateChanged, CheckBox_ID4A.CheckStateChanged, CheckBox_ID49.CheckStateChanged, CheckBox_ID47.CheckStateChanged, CheckBox_ID46.CheckStateChanged, CheckBox_ID45.CheckStateChanged, CheckBox_ID44.CheckStateChanged, CheckBox_ID40.CheckStateChanged, CheckBox_ID35.CheckStateChanged, CheckBox_ID2B.CheckStateChanged, CheckBox_ID2A.CheckStateChanged, CheckBox_ID23.CheckStateChanged, CheckBox_ID22.CheckStateChanged, CheckBox_ID1B.CheckStateChanged, CheckBox_ID1A.CheckStateChanged, CheckBox_ID19.CheckStateChanged, CheckBox_ID14.CheckStateChanged, CheckBox_ID06.CheckStateChanged, CheckBox_ID03.CheckStateChanged, CheckBox_3E.CheckStateChanged, CheckBox__ID41.CheckStateChanged
        For Each box In Me.Tab_Simple.Controls
            If TypeOf box Is CheckBox Then
                If box.checked = True Then
                    If Not ListBox1.Items.Contains(box.text) Then
                        ListBox1.Items.Add(box.text)
                    End If
                Else
                    ListBox1.Items.Remove(box.text)
                End If
            End If
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        For Each ctrl As Control In Me.Tab_Advanced.Controls
            If TypeOf ctrl Is GroupBox Then
                If Not ListBox1.SelectedItem = Nothing Then
                    If ctrl.Text.Contains(ListBox1.SelectedItem.ToString) Then
                        ctrl.Visible = True
                    Else
                        ctrl.Visible = False
                    End If
                Else
                    ctrl.Visible = False
                End If
            End If
        Next
    End Sub

    Private Sub Number_ID01_ValueChanged(sender As Object, e As EventArgs) Handles Number_ID01.ValueChanged
        If Not Me.DataGridView_ID01.ColumnCount = 0 Then
            While Number_ID01.Value > Me.DataGridView_ID01.RowCount
                Me.DataGridView_ID01.Rows.Add()
            End While
            While Number_ID01.Value < Me.DataGridView_ID01.RowCount
                Me.DataGridView_ID01.Rows.RemoveAt(Me.DataGridView_ID01.RowCount - 1)
            End While
        End If
    End Sub
    Private Sub Number_ID8_ValueChanged(sender As Object, e As EventArgs) Handles Number_ID8.ValueChanged
        If Not Me.DataGridView1_ID8.ColumnCount = 0 And Not Me.DataGridView2_ID8.ColumnCount = 0 Then
            While Number_ID8.Value > Me.DataGridView1_ID8.RowCount
                Me.DataGridView1_ID8.Rows.Add()
                Me.DataGridView2_ID8.Rows.Add()
            End While
            While Number_ID8.Value < Me.DataGridView1_ID8.RowCount
                Me.DataGridView1_ID8.Rows.RemoveAt(Me.DataGridView1_ID8.RowCount - 1)
                Me.DataGridView2_ID8.Rows.RemoveAt(Me.DataGridView1_ID8.RowCount - 1)
            End While
        End If
    End Sub
    Private Sub Number_ID9_ValueChanged(sender As Object, e As EventArgs) Handles Number_ID9.ValueChanged
        If Not Me.DataGridView_ID9.ColumnCount = 0 Then
            While Number_ID9.Value > Me.DataGridView_ID9.RowCount
                Me.DataGridView_ID9.Rows.Add()
            End While
            While Number_ID9.Value < Me.DataGridView_ID9.RowCount
                Me.DataGridView_ID9.Rows.RemoveAt(Me.DataGridView_ID9.RowCount - 1)
            End While
        End If
    End Sub
    Private Sub Number_IDA_ValueChanged(sender As Object, e As EventArgs) Handles Number_IDA.ValueChanged
        If Not Me.DataGridView_IDA.ColumnCount = 0 Then
            While Number_IDA.Value > Me.DataGridView_IDA.RowCount
                Me.DataGridView_IDA.Rows.Add()
            End While
            While Number_IDA.Value < Me.DataGridView_IDA.RowCount
                Me.DataGridView_IDA.Rows.RemoveAt(Me.DataGridView_IDA.RowCount - 1)
            End While
        End If
    End Sub
    Private Sub Number_IDB_ValueChanged(sender As Object, e As EventArgs) Handles Number_IDB.ValueChanged
        If Not Me.DataGridView_IDB.ColumnCount = 0 Then
            While Number_IDB.Value > Me.DataGridView_IDB.RowCount
                Me.DataGridView_IDB.Rows.Add()
            End While
            While Number_IDB.Value < Me.DataGridView_IDB.RowCount
                Me.DataGridView_IDB.Rows.RemoveAt(Me.DataGridView_IDB.RowCount - 1)
            End While
        End If
    End Sub
    Private Sub Number_IDE_ValueChanged(sender As Object, e As EventArgs) Handles Number_IDE.ValueChanged
        If Not Me.DataGridView_IDE.ColumnCount = 0 Then
            While Number_IDE.Value > Me.DataGridView_IDE.RowCount
                Me.DataGridView_IDE.Rows.Add()
            End While
            While Number_IDE.Value < Me.DataGridView_IDE.RowCount
                Me.DataGridView_IDE.Rows.RemoveAt(Me.DataGridView_IDE.RowCount - 1)
            End While
        End If
    End Sub

    Private Sub Number_IDF_ValueChanged(sender As Object, e As EventArgs) Handles Number_IDF.ValueChanged
        If Not Me.DataGridView_IDF.ColumnCount = 0 Then
            While Number_IDF.Value > Me.DataGridView_IDF.RowCount
                Me.DataGridView_IDF.Rows.Add()
            End While
            While Number_IDF.Value < Me.DataGridView_IDF.RowCount
                Me.DataGridView_IDF.Rows.RemoveAt(Me.DataGridView_IDF.RowCount - 1)
            End While
        End If
    End Sub
    Private Sub Number_ID10_ValueChanged(sender As Object, e As EventArgs) Handles Number_ID10.ValueChanged
        If Not Me.DataGridView_ID10.ColumnCount = 0 Then
            While Number_ID10.Value > Me.DataGridView_ID10.RowCount
                Me.DataGridView_ID10.Rows.Add()
            End While
            While Number_ID10.Value < Me.DataGridView_ID10.RowCount
                Me.DataGridView_ID10.Rows.RemoveAt(Me.DataGridView_ID10.RowCount - 1)
            End While
        End If
    End Sub
    Private Sub Number_ID11_ValueChanged(sender As Object, e As EventArgs) Handles Number_ID11.ValueChanged
        If Not Me.DataGridView_ID11.ColumnCount = 0 Then
            While Number_ID11.Value > Me.DataGridView_ID11.RowCount
                Me.DataGridView_ID11.Rows.Add()
            End While
            While Number_ID11.Value < Me.DataGridView_ID11.RowCount
                Me.DataGridView_ID11.Rows.RemoveAt(Me.DataGridView_ID11.RowCount - 1)
            End While
        End If
    End Sub
    Private Sub Number_ID12_ValueChanged(sender As Object, e As EventArgs) Handles Number_ID12.ValueChanged
        If Not Me.DataGridView_ID12.ColumnCount = 0 Then
            While Number_ID12.Value > Me.DataGridView_ID12.RowCount
                Me.DataGridView_ID12.Rows.Add()
            End While
            While Number_ID12.Value < Me.DataGridView_ID12.RowCount
                Me.DataGridView_ID12.Rows.RemoveAt(Me.DataGridView_ID12.RowCount - 1)
            End While
        End If
    End Sub
    Private Sub Number_ID26_ValueChanged(sender As Object, e As EventArgs) Handles Number_ID26.ValueChanged
        If Not Me.DataGridView_ID26.ColumnCount = 0 Then
            While Number_ID26.Value > Me.DataGridView_ID26.RowCount
                Me.DataGridView_ID26.Rows.Add()
            End While
            While Number_ID26.Value < Me.DataGridView_ID26.RowCount
                Me.DataGridView_ID26.Rows.RemoveAt(Me.DataGridView_ID26.RowCount - 1)
            End While
        End If
    End Sub
    Private Sub Number_ID27_ValueChanged(sender As Object, e As EventArgs) Handles Number_ID27.ValueChanged
        If Not Me.DataGridView_ID27.ColumnCount = 0 Then
            While Number_ID27.Value > Me.DataGridView_ID27.RowCount
                Me.DataGridView_ID27.Rows.Add()
            End While
            While Number_ID27.Value < Me.DataGridView_ID27.RowCount
                Me.DataGridView_ID27.Rows.RemoveAt(Me.DataGridView_ID27.RowCount - 1)
            End While
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click, Save_Simple.Click

        If Not ListBox1.Items.Contains("0x00") Then
            MsgBox("You have to add the cmd ""0x00""")
            Exit Sub
        End If

        If Not ListBox1.Items.Contains("0x3D") Then
            MsgBox("You have to add the cmd ""0x3D""")
            Exit Sub
        End If

        

        For Each list_item In ListBox1.Items
            For Each group In Me.Tab_Advanced.Controls
                If TypeOf group Is GroupBox Then
                    If group.text.contains(list_item) Then
                        For Each element In group.Controls
                            If TypeOf element Is TextBox Then
                                If element.Text = Nothing Then
                                    If Not group.text.ToString.Contains("0x00") Then
                                        MsgBox("A parameter for the '" & group.text & "' is missing")
                                        Exit Sub
                                    End If
                                End If
                            End If
                            If TypeOf element Is DataGridView Then
                                element.EndEdit()
                                Dim i = 0
                                Dim j = 0
                                For i = 0 To element.RowCount - 1 Step 1
                                    For j = 0 To element.ColumnCount - 1 Step 1
                                        If element.item(j, i).value = Nothing Then
                                            MsgBox("A parameter for the '" & group.text & "' is missing")
                                            Exit Sub
                                        End If
                                    Next
                                Next

                            End If
                        Next
                    End If
                End If
            Next
        Next

        BIG_ENDIAN_ID09.Checked = False

        Using writer As BinaryWriter = New BinaryWriter(File.Open("CONFIG", FileMode.Create))
            Dim u32 As UInt32
            u32 = Convert.ToUInt32(Param_ID3D.Text, 16)
            writer.Write(&H3D)
            writer.Write(u32)


            For Each list_item In ListBox1.Items

                If Not list_item = "0x00" And
                    Not list_item = "0x3D" And
                    Not list_item = "0x01" And
                    Not list_item = "0x08" And
                    Not list_item = "0x0E" And
                    Not list_item = "0x0F" And
                    Not list_item = "0x10" And
                    Not list_item = "0x11" And
                    Not list_item = "0x26" And
                    Not list_item = "0x27" Then
                    u32 = Convert.ToUInt32(list_item.Substring(2), 16)
                    writer.Write(u32)
                End If

                If list_item = "0x01" Then
                    Dim i As Integer
                    For i = 0 To Number_ID01.Value - 1 Step 1
                        u32 = Convert.ToUInt32(list_item.Substring(2), 16)
                        writer.Write(u32)

                        u32 = Convert.ToUInt32(DataGridView_ID01.Item(0, i).Value.ToString, 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView_ID01.Item(1, i).Value.ToString, 16)
                        writer.Write(u32)
                    Next
                End If
                If list_item = "0x02" Then
                    u32 = Convert.ToUInt32(Param_ID2.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x04" Then
                    u32 = Convert.ToUInt32(Param_ID04.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x07" Then
                    u32 = Convert.ToUInt32(Param_ID7.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x08" Then
                    Dim i As Integer
                    For i = 0 To Number_ID8.Value - 1 Step 1
                        u32 = Convert.ToUInt32(list_item.Substring(2), 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView1_ID8.Item(0, i).Value.ToString, 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView1_ID8.Item(1, i).Value.ToString, 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView1_ID8.Item(2, i).Value.ToString, 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView1_ID8.Item(3, i).Value.ToString, 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView2_ID8.Item(0, i).Value.ToString, 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView2_ID8.Item(1, i).Value.ToString, 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView2_ID8.Item(2, i).Value.ToString, 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView2_ID8.Item(3, i).Value.ToString, 16)
                        writer.Write(u32)
                    Next
                End If
                If list_item = "0x09" Then
                    u32 = Number_ID9.Value
                    writer.Write(u32)

                    Dim i As Integer
                    For i = 0 To Number_ID9.Value - 1 Step 1
                        u32 = Convert.ToUInt32(DataGridView_ID9.Item(0, i).Value.ToString, 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView_ID9.Item(1, i).Value.ToString, 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView_ID9.Item(2, i).Value.ToString, 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView_ID9.Item(3, i).Value.ToString, 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView_ID9.Item(4, i).Value.ToString, 16)
                        writer.Write(u32)

                    Next
                End If
                If list_item = "0x0A" Then
                    u32 = Number_IDA.Value
                    writer.Write(u32)

                    Dim i As Integer
                    For i = 0 To Number_IDA.Value - 1 Step 1
                        u32 = Convert.ToUInt32(DataGridView_IDA.Item(0, i).Value.ToString, 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView_IDA.Item(1, i).Value.ToString, 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView_IDA.Item(2, i).Value.ToString, 16)
                        writer.Write(u32)
                    Next
                End If
                If list_item = "0x0B" Then
                    u32 = Number_IDB.Value
                    writer.Write(u32)

                    Dim i As Integer
                    For i = 0 To Number_IDB.Value - 1 Step 1
                        u32 = Convert.ToUInt32(DataGridView_IDB.Item(0, i).Value.ToString, 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView_IDB.Item(1, i).Value.ToString, 16)
                        writer.Write(u32)
                        Dim size As UInt32
                        size = DataGridView_IDB.Item(2, i).Value.ToString.Length / 2
                        writer.Write(size)
                        Dim j As Integer
                        For j = 0 To size - 1 Step 1
                            Dim byt = Convert.ToByte(DataGridView_IDB.Item(2, i).Value.ToString.Substring(j * 2, 2), 16)
                            writer.Write(byt)
                        Next
                        For j = 0 To size - 1 Step 1
                            Dim byt = Convert.ToByte(DataGridView_IDB.Item(3, i).Value.ToString.Substring(j * 2, 2), 16)
                            writer.Write(byt)
                        Next
                    Next
                End If
                If list_item = "0x0C" Then
                    u32 = Convert.ToUInt32(Param_IDC.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x0D" Then
                    If CheckBox_0D.Checked = True Then
                        writer.Write(&H1)
                    Else
                        writer.Write(&H0)
                    End If
                End If
                If list_item = "0x0E" Then
                    Dim i As Integer
                    For i = 0 To Number_IDE.Value - 1 Step 1
                        u32 = Convert.ToUInt32(list_item.Substring(2), 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView_IDE.Item(0, i).Value.ToString, 16)
                        writer.Write(u32)
                    Next
                End If
                If list_item = "0x0F" Then
                    Dim i As Integer
                    For i = 0 To Number_IDF.Value - 1 Step 1
                        u32 = Convert.ToUInt32(list_item.Substring(2), 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView_IDF.Item(0, i).Value.ToString, 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView_IDF.Item(1, i).Value.ToString, 16)
                        writer.Write(u32)
                    Next
                End If
                If list_item = "0x10" Then
                    Dim i As Integer
                    For i = 0 To Number_ID10.Value - 1 Step 1
                        u32 = Convert.ToUInt32(list_item.Substring(2), 16)
                        writer.Write(u32)

                        u32 = Convert.ToUInt32(DataGridView_ID10.Item(0, i).Value.ToString, 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView_ID10.Item(1, i).Value.ToString, 16)
                        writer.Write(u32)
                    Next
                End If
                If list_item = "0x11" Then
                    Dim i As Integer
                    For i = 0 To Number_ID11.Value - 1 Step 1
                        u32 = Convert.ToUInt32(list_item.Substring(2), 16)
                        writer.Write(u32)

                        u32 = Convert.ToUInt32(DataGridView_ID11.Item(0, i).Value.ToString, 16)
                        writer.Write(u32)
                    Next
                End If
                If list_item = "0x12" Then
                    u32 = Number_ID12.Value
                    writer.Write(u32)

                    Dim i As Integer
                    For i = 0 To Number_ID12.Value - 1 Step 1
                        u32 = Convert.ToUInt32(DataGridView_ID12.Item(0, i).Value.ToString, 16)
                        writer.Write(u32)
                    Next
                End If
                If list_item = "0x13" Then
                    u32 = Convert.ToUInt32(Param_ID13.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x15" Then
                    u32 = Convert.ToUInt32(Param_ID15.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x17" Then
                    If CheckBox_17.Checked = True Then
                        writer.Write(&H1)
                    Else
                        writer.Write(&H0)
                    End If
                End If
                If list_item = "0x1C" Then
                    u32 = Convert.ToUInt32(Param_ID1C.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x1D" Then
                    u32 = Convert.ToUInt32(Param_ID1D.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x1E" Then
                    u32 = Convert.ToUInt32(Param_ID1E.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x1F" Then
                    u32 = Convert.ToUInt32(Param_ID1F.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x20" Then
                    Dim u64 As UInt64
                    u64 = Convert.ToUInt64(Param_ID1F.Text, 16)
                    writer.Write(u64)
                End If
                If list_item = "0x21" Then
                    u32 = Number_ID21.Value
                    writer.Write(u32)
                End If
                If list_item = "0x24" Then
                    Dim u64 As UInt64
                    u64 = Convert.ToUInt64(Param_ID24.Text, 16)
                    writer.Write(u64)
                End If
                If list_item = "0x26" Then
                    Dim i As Integer
                    For i = 0 To Number_ID26.Value - 1 Step 1
                        u32 = Convert.ToUInt32(list_item.Substring(2), 16)
                        writer.Write(u32)

                        u32 = Convert.ToUInt32(DataGridView_ID26.Item(0, i).Value.ToString, 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView_ID26.Item(1, i).Value.ToString, 16)
                        writer.Write(u32)
                    Next
                End If
                If list_item = "0x27" Then
                    Dim i As Integer
                    For i = 0 To Number_ID27.Value - 1 Step 1
                        u32 = Convert.ToUInt32(list_item.Substring(2), 16)
                        writer.Write(u32)

                        u32 = Convert.ToUInt32(DataGridView_ID27.Item(0, i).Value.ToString, 16)
                        writer.Write(u32)
                        u32 = Convert.ToUInt32(DataGridView_ID27.Item(1, i).Value.ToString, 16)
                        writer.Write(u32)
                    Next
                End If
                If list_item = "0x28" Then
                    u32 = Convert.ToUInt32(Param_ID28.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x29" Then
                    u32 = Convert.ToUInt32(Param1_ID29.Text, 16)
                    writer.Write(u32)
                    u32 = Convert.ToUInt32(Param2_ID29.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x2C" Then
                    u32 = Convert.ToUInt32(Param_ID2C.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x2E" Then
                    u32 = Convert.ToUInt32(Param_ID2E.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x2F" Then
                    u32 = Convert.ToUInt32(Param_ID2F.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x3F" Then
                    u32 = Convert.ToUInt32(Param_ID3F.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x42" Then
                    u32 = Convert.ToUInt32(Param_ID42.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x43" Then
                    u32 = Convert.ToUInt32(Param_ID43.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x48" Then
                    u32 = Convert.ToUInt32(Param1_ID48.Text, 16)
                    writer.Write(u32)
                    u32 = Convert.ToUInt32(Param2_ID48.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x4B" Then
                    u32 = Convert.ToUInt32(Param1_ID4B.Text, 16)
                    writer.Write(u32)
                    u32 = Convert.ToUInt32(Param2_ID4B.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x4C" Then
                    u32 = Convert.ToUInt32(Param1_ID4C.Text, 16)
                    writer.Write(u32)
                    u32 = Convert.ToUInt32(Param2_ID4C.Text, 16)
                    writer.Write(u32)
                End If
                If list_item = "0x4D" Then
                    u32 = Convert.ToUInt32(Param_ID4D.Text, 16)
                    writer.Write(u32)
                End If
            Next

            writer.Write(&H0)
            Dim data() As Byte
            data = Encoding.ASCII.GetBytes(Param_ID00.Text)
            writer.Write(data)

        End Using

    End Sub

    Private Sub Param_Simple_ID00_TextChanged(sender As Object, e As EventArgs) Handles Param_Simple_ID00.TextChanged
        Param_ID00.Text = Param_Simple_ID00.Text
    End Sub

    Private Sub Param1_ID01_TextChanged(sender As Object, e As EventArgs)
        Param_Simple_ID00.Text = Param_ID00.Text
    End Sub

    Private Sub Clean()
        For Each box In Me.Tab_Simple.Controls
            If TypeOf box Is CheckBox Then
                box.Checked = False
            ElseIf TypeOf box Is TextBox Then
                box.Text = Nothing
            End If
        Next

        For Each ctrl As Control In Me.Tab_Advanced.Controls
            If TypeOf ctrl Is GroupBox Then
                For Each box In ctrl.Controls
                    If TypeOf box Is CheckBox Then
                        box.Checked = False
                    ElseIf TypeOf box Is TextBox Then
                        box.Text = Nothing
                    ElseIf TypeOf box Is NumericUpDown Then
                        box.Value = 0
                    ElseIf TypeOf box Is DataGridView Then
                        box.Rows.Clear()
                    End If
                Next
            End If
        Next

        ListBox1.Items.Clear()
        Me.ListBox1.Items.Add("0x00")
        Me.ListBox1.Items.Add("0x3D")
        ListBox1.SelectedIndex = 0

    End Sub
    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles TabControl1.DragDrop

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim filePath = CType(e.Data.GetData(DataFormats.FileDrop), String())(0)

            Clean()

            Using reader As BinaryReader = New BinaryReader(File.Open(filePath, FileMode.Open))
                Dim u32 As UInt32
                u32 = reader.ReadUInt32()
                If Not u32 = &H3D Then
                    MsgBox("Command 0x3D (rev) not found.")
                    Exit Sub
                End If
                u32 = reader.ReadUInt32()
                Param_ID3D.Text = Convert.ToString(u32, 16).ToUpper

                While reader.PeekChar() >= 0

                    u32 = reader.ReadUInt32()

                    Dim ID = "0x" & Convert.ToString(u32, 16).ToUpper.PadLeft(2, "0")
                    If Not ListBox1.Items.Contains(ID) Then
                        ListBox1.Items.Add(ID)
                         For Each box In Me.Tab_Simple.Controls
                            If TypeOf box Is CheckBox Then
                                If box.text = ID Then
                                    box.Checked = True

                                End If
                            End If
                        Next
                    End If

                    If ID = "0x00" Then
                        Dim GameID = reader.ReadChars(10)
                        If Not GameID = Nothing Then
                            Param_ID00.Text = GameID
                            Param_Simple_ID00.Text = GameID
                        End If
                        Exit Sub
                    End If
                    If ID = "0x01" Then
                        Number_ID01.Value += 1

                        u32 = reader.ReadUInt32()
                        DataGridView_ID01.Item(0, CInt(Number_ID01.Value - 1)).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                        u32 = reader.ReadUInt32()
                        DataGridView_ID01.Item(1, CInt(Number_ID01.Value - 1)).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x02" Then
                        u32 = reader.ReadUInt32()
                        Param_ID2.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x04" Then
                        u32 = reader.ReadUInt32()
                        Param_ID04.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x07" Then
                        u32 = reader.ReadUInt32()
                        Param_ID7.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x08" Then
                        Number_ID8.Value += 1

                        u32 = reader.ReadUInt32()
                        DataGridView1_ID8.Item(0, CInt(Number_ID8.Value - 1)).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                        u32 = reader.ReadUInt32()
                        DataGridView1_ID8.Item(1, CInt(Number_ID8.Value - 1)).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                        u32 = reader.ReadUInt32()
                        DataGridView1_ID8.Item(2, CInt(Number_ID8.Value - 1)).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                        u32 = reader.ReadUInt32()
                        DataGridView1_ID8.Item(3, CInt(Number_ID8.Value - 1)).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                        u32 = reader.ReadUInt32()
                        DataGridView2_ID8.Item(0, CInt(Number_ID8.Value - 1)).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                        u32 = reader.ReadUInt32()
                        DataGridView2_ID8.Item(1, CInt(Number_ID8.Value - 1)).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                        u32 = reader.ReadUInt32()
                        DataGridView2_ID8.Item(2, CInt(Number_ID8.Value - 1)).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                        u32 = reader.ReadUInt32()
                        DataGridView2_ID8.Item(3, CInt(Number_ID8.Value - 1)).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                        u32 = reader.ReadUInt32()
                    End If
                    If ID = "0x09" Then
                        u32 = reader.ReadUInt32()
                        Number_ID9.Value = u32

                        Dim i As Integer
                        For i = 0 To Number_ID9.Value - 1 Step 1
                            u32 = reader.ReadUInt32()
                            DataGridView_ID9.Item(0, i).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                            u32 = reader.ReadUInt32()
                            DataGridView_ID9.Item(1, i).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                            u32 = reader.ReadUInt32()
                            DataGridView_ID9.Item(2, i).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                            u32 = reader.ReadUInt32()
                            DataGridView_ID9.Item(3, i).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                            u32 = reader.ReadUInt32()
                            DataGridView_ID9.Item(4, i).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                        Next
                    End If
                    If ID = "0x0A" Then
                        u32 = reader.ReadUInt32()
                        Number_IDA.Value = u32

                        Dim i As Integer
                        For i = 0 To Number_IDA.Value - 1 Step 1
                            u32 = reader.ReadUInt32()
                            DataGridView_IDA.Item(0, i).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                            u32 = reader.ReadUInt32()
                            DataGridView_IDA.Item(1, i).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                            u32 = reader.ReadUInt32()
                            DataGridView_IDA.Item(2, i).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                        Next
                    End If
                    If ID = "0x0B" Then
                        u32 = reader.ReadUInt32()
                        Number_IDB.Value = u32

                        Dim i As Integer
                        For i = 0 To Number_IDB.Value - 1 Step 1
                            u32 = reader.ReadUInt32()
                            DataGridView_IDB.Item(0, i).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                            u32 = reader.ReadUInt32()
                            DataGridView_IDB.Item(1, i).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")

                            Dim size As UInt32
                            size = reader.ReadUInt32()
                            Dim j As Integer
                            For j = 0 To size - 1 Step 1
                                Dim byt = reader.ReadByte()
                                DataGridView_IDB.Item(2, i).Value += Convert.ToString(byt, 16).ToUpper.PadLeft(2, "0")
                            Next
                            For j = 0 To size - 1 Step 1
                                Dim byt = reader.ReadByte()
                                DataGridView_IDB.Item(3, i).Value += Convert.ToString(byt, 16).ToUpper.PadLeft(2, "0")
                            Next

                        Next
                    End If
                    If ID = "0x0C" Then
                        u32 = reader.ReadUInt32()
                        Param_IDC.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x0D" Then
                        u32 = reader.ReadUInt32()
                        If u32 = &H1 Then
                            CheckBox_0D.Checked = True
                        Else
                            CheckBox_0D.Checked = False
                        End If
                    End If
                    If ID = "0x0E" Then
                        Number_IDE.Value += 1
                        u32 = reader.ReadUInt32()
                        DataGridView_IDE.Item(0, CInt(Number_IDE.Value - 1)).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x0F" Then
                        Number_IDF.Value += 1

                        u32 = reader.ReadUInt32()
                        DataGridView_IDF.Item(0, CInt(Number_IDF.Value - 1)).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                        u32 = reader.ReadUInt32()
                        DataGridView_IDF.Item(1, CInt(Number_IDF.Value - 1)).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x10" Then
                        Number_ID10.Value += 1

                        u32 = reader.ReadUInt32()
                        DataGridView_ID10.Item(0, CInt(Number_ID10.Value - 1)).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                        u32 = reader.ReadUInt32()
                        DataGridView_ID10.Item(1, CInt(Number_ID10.Value - 1)).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x11" Then
                        Number_ID11.Value += 1

                        u32 = reader.ReadUInt32()
                        DataGridView_ID11.Item(0, CInt(Number_ID10.Value - 1)).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x12" Then
                        u32 = reader.ReadUInt32()
                        Number_ID12.Value = u32
                        Dim i As Integer
                        For i = 0 To Number_ID12.Value - 1 Step 1
                            u32 = reader.ReadUInt32()
                            DataGridView_ID12.Item(0, i).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                        Next
                    End If
                    If ID = "0x13" Then
                        u32 = reader.ReadUInt32()
                        Param_ID13.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x15" Then
                        u32 = reader.ReadUInt32()
                        Param_ID15.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x17" Then
                        u32 = reader.ReadUInt32()
                        If u32 = &H1 Then
                            CheckBox_17.Checked = True
                        Else
                            CheckBox_17.Checked = False
                        End If
                    End If
                    If ID = "0x1C" Then
                        u32 = reader.ReadUInt32()
                        Param_ID1C.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x1D" Then
                        u32 = reader.ReadUInt32()
                        Param_ID1D.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x1E" Then
                        u32 = reader.ReadUInt32()
                        Param_ID1E.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x1F" Then
                        u32 = reader.ReadUInt32()
                        Param_ID1F.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x20" Then
                        Dim u64 As UInt64
                        u64 = reader.ReadUInt64()
                        u32 = u64
                        Param_ID1F.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(16, "0") 'Cannot convert u64...
                    End If
                    If ID = "0x21" Then
                        u32 = reader.ReadUInt32()
                        Number_ID21.Value = u32
                    End If
                    If ID = "0x24" Then
                        Dim u64 As UInt64
                        u64 = reader.ReadUInt64()
                        u32 = u64
                        Param_ID24.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0") 'Cannot convert u64...
                    End If
                    If ID = "0x26" Then
                        Number_ID26.Value += 1

                        u32 = reader.ReadUInt32()
                        DataGridView_ID26.Item(0, CInt(Number_ID26.Value - 1)).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                        u32 = reader.ReadUInt32()
                        DataGridView_ID26.Item(1, CInt(Number_ID26.Value - 1)).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x27" Then
                        Number_ID27.Value += 1

                        u32 = reader.ReadUInt32()
                        DataGridView_ID27.Item(0, CInt(Number_ID26.Value - 1)).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                        u32 = reader.ReadUInt32()
                        DataGridView_ID27.Item(1, CInt(Number_ID26.Value - 1)).Value = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x28" Then
                        u32 = reader.ReadUInt32()
                        Param_ID28.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x29" Then
                        u32 = reader.ReadUInt32()
                        Param1_ID29.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                        u32 = reader.ReadUInt32()
                        Param2_ID29.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x2C" Then
                        u32 = reader.ReadUInt32()
                        Param_ID2C.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x2E" Then
                        u32 = reader.ReadUInt32()
                        Param_ID2E.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x2F" Then
                        u32 = reader.ReadUInt32()
                        Param_ID2F.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x3F" Then
                        u32 = reader.ReadUInt32()
                        Param_ID3F.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x42" Then
                        u32 = reader.ReadUInt32()
                        Param_ID42.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x43" Then
                        u32 = reader.ReadUInt32()
                        Param_ID43.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x48" Then
                        u32 = reader.ReadUInt32()
                        Param1_ID48.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                        u32 = reader.ReadUInt32()
                        Param2_ID48.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x4B" Then
                        u32 = reader.ReadUInt32()
                        Param1_ID4B.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                        u32 = reader.ReadUInt32()
                        Param2_ID4B.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x4C" Then
                        u32 = reader.ReadUInt32()
                        Param1_ID4C.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                        u32 = reader.ReadUInt32()
                        Param2_ID4C.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If
                    If ID = "0x4D" Then
                        u32 = reader.ReadUInt32()
                        Param_ID4D.Text = Convert.ToString(u32, 16).ToUpper.PadLeft(8, "0")
                    End If

                End While

            End Using
        End If

    End Sub

    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles TabControl1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub


    Private Sub BIG_ENDIAN_ID09_CheckedChanged(sender As Object, e As EventArgs) Handles BIG_ENDIAN_ID09.CheckedChanged
        If BIG_ENDIAN_ID09.Checked = True Then
            DataGridView_ID9.Columns.Item(1).DisplayIndex = 2
            DataGridView_ID9.Columns.Item(3).DisplayIndex = 4
        Else
            DataGridView_ID9.Columns.Item(1).DisplayIndex = 1
            DataGridView_ID9.Columns.Item(3).DisplayIndex = 3
        End If

        Dim i As Integer
        Dim val As String
        For i = 0 To Number_ID9.Value - 1 Step 1
            val = DataGridView_ID9.Item(1, i).Value.ToString()
            val = val.Substring(6, 2) + val.Substring(4, 2) + val.Substring(2, 2) + val.Substring(0, 2)
            DataGridView_ID9.Item(1, i).Value = val

            val = DataGridView_ID9.Item(2, i).Value.ToString()
            val = val.Substring(6, 2) + val.Substring(4, 2) + val.Substring(2, 2) + val.Substring(0, 2)
            DataGridView_ID9.Item(2, i).Value = val

            val = DataGridView_ID9.Item(3, i).Value.ToString()
            val = val.Substring(6, 2) + val.Substring(4, 2) + val.Substring(2, 2) + val.Substring(0, 2)
            DataGridView_ID9.Item(3, i).Value = val

            val = DataGridView_ID9.Item(4, i).Value.ToString()
            val = val.Substring(6, 2) + val.Substring(4, 2) + val.Substring(2, 2) + val.Substring(0, 2)
            DataGridView_ID9.Item(4, i).Value = val
        Next

    End Sub
End Class
