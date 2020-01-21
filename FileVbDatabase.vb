Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim arr() As Integer =  {10, 14, 17, 24, 36, 38, 42, 50, 51, 65, 69, 72, 78, 80, 85}
        Dim arr2() As String = {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10"}
        Dim arr3() As String = {"call", "device", "activity", "cs"}
        Dim arr4() As String = {"a", "b", "c", "d", ""}
        Dim i = 0
        Dim j = 0
        Dim count = 0
        Dim count2 = 0
        Dim filerd As System.IO.FileStream
        Dim filerd2 As System.IO.FileStream

        For i = 0 To 14
            For k = 0 To 3
                For j = 0 To 9
                    For m = 0 To 4
                        filerd = New System.IO.FileStream("C:\Mdata\Databases\" & arr3(k) & arr(i) & arr2(j) & arr4(m) & ".arff", IO.FileMode.Open, IO.FileAccess.Read)
                        Dim lala As New System.IO.StreamReader(filerd)
                        Dim str As String = ""
                        While str.CompareTo("@data")
                            str = lala.ReadLine
                            count += 1
                        End While
                        Dim filewr As System.IO.FileStream
                        filewr = New System.IO.FileStream("C:\Mdata\Databases\newones\" & arr3(k) & arr(i) & arr2(j) & arr4(m) & ".data", IO.FileMode.Create, IO.FileAccess.Write)
                        Dim wrt As New System.IO.StreamWriter(filewr)
                        If arr3(k) = "call" Then
                            If arr4(m) = "" Then
                                wrt.WriteLine("9")
                                wrt.WriteLine("#n phonenumber_oid cnid dirid deid dd wd mn duration stime")
                            ElseIf arr4(m) = "a" Then
                                wrt.WriteLine("8")
                                wrt.WriteLine("#n phonenumber_oid cnid dirid deid dd wd duration stime")
                            ElseIf arr4(m) = "b" Then
                                wrt.WriteLine("8")
                                wrt.WriteLine("#n phonenumber_oid cnid dirid deid dd mn duration stime")
                            ElseIf arr4(m) = "c" Then
                                wrt.WriteLine("8")
                                wrt.WriteLine("#n phonenumber_oid cnid dirid deid wd mn duration stime")
                            ElseIf arr4(m) = "d" Then
                                wrt.WriteLine("6")
                                wrt.WriteLine("#n phonenumber_oid cnid dirid deid duration stime")
                            End If
                        ElseIf arr3(k) = "device" Then
                            If arr4(m) = "" Then
                                wrt.WriteLine("6")
                                wrt.WriteLine("#n device_oid dd wd mn duration stime")
                            ElseIf arr4(m) = "a" Then
                                wrt.WriteLine("5")
                                wrt.WriteLine("#n device_oid dd wd duration stime")
                            ElseIf arr4(m) = "b" Then
                                wrt.WriteLine("5")
                                wrt.WriteLine("#n device_oid dd mn duration stime")
                            ElseIf arr4(m) = "c" Then
                                wrt.WriteLine("5")
                                wrt.WriteLine("#n device_oid wd mn duration stime")
                            ElseIf arr4(m) = "d" Then
                                wrt.WriteLine("3")
                                wrt.WriteLine("#n device_oid duration stime")
                            End If
                        ElseIf arr3(k) = "cs" Then
                            If arr4(m) = "" Then
                                wrt.WriteLine("6")
                                wrt.WriteLine("#n celltower_oid dd wd mn duration stime")
                            ElseIf arr4(m) = "a" Then
                                wrt.WriteLine("5")
                                wrt.WriteLine("#n celltower_oid dd wd duration stime")
                            ElseIf arr4(m) = "b" Then
                                wrt.WriteLine("5")
                                wrt.WriteLine("#n celltower_oid dd mn duration stime")
                            ElseIf arr4(m) = "c" Then
                                wrt.WriteLine("5")
                                wrt.WriteLine("#n celltower_oid wd mn duration stime")
                            ElseIf arr4(m) = "d" Then
                                wrt.WriteLine("3")
                                wrt.WriteLine("#n celltower_oid duration stime")
                            End If
                        ElseIf arr3(k) = "activity" Then
                            If arr4(m) = "" Then
                                wrt.WriteLine("5")
                                wrt.WriteLine("#n dd wd mn duration stime")
                            ElseIf arr4(m) = "a" Then
                                wrt.WriteLine("4")
                                wrt.WriteLine("#n dd wd duration stime")
                            ElseIf arr4(m) = "b" Then
                                wrt.WriteLine("4")
                                wrt.WriteLine("#n dd mn duration stime")
                            ElseIf arr4(m) = "c" Then
                                wrt.WriteLine("4")
                                wrt.WriteLine("#n wd mn duration stime")
                            ElseIf arr4(m) = "d" Then
                                wrt.WriteLine("2")
                                wrt.WriteLine("#n duration stime")
                            End If
                        End If

                        While lala.Peek > -1
                            count += 1
                            str = lala.ReadLine
                            Dim tmp As String() = str.Split(",")
                            If arr3(k) = "call" Then
                                If arr4(m) = "" Then
                                    Dim str_to_write = tmp(0) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3) & vbTab & tmp(4) & vbTab & tmp(5) & vbTab & tmp(6) & vbTab & tmp(7) & vbTab & tmp(8) & vbTab & tmp(9)
                                    wrt.WriteLine(str_to_write)
                                ElseIf arr4(m) = "a" Then
                                    Dim str_to_write = tmp(0) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3) & vbTab & tmp(4) & vbTab & tmp(5) & vbTab & tmp(6) & vbTab & tmp(7) & vbTab & tmp(8)
                                    wrt.WriteLine(str_to_write)
                                ElseIf arr4(m) = "b" Then
                                    Dim str_to_write = tmp(0) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3) & vbTab & tmp(4) & vbTab & tmp(5) & vbTab & tmp(6) & vbTab & tmp(7) & vbTab & tmp(8)
                                    wrt.WriteLine(str_to_write)
                                ElseIf arr4(m) = "c" Then
                                    Dim str_to_write = tmp(0) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3) & vbTab & tmp(4) & vbTab & tmp(5) & vbTab & tmp(6) & vbTab & tmp(7) & vbTab & tmp(8)
                                    wrt.WriteLine(str_to_write)
                                ElseIf arr4(m) = "d" Then
                                    Dim str_to_write = tmp(0) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3) & vbTab & tmp(4) & vbTab & tmp(5) & vbTab & tmp(6)
                                    wrt.WriteLine(str_to_write)
                                End If
                            ElseIf arr3(k) = "activity" Then
                                If arr4(m) = "" Then
                                    Dim str_to_write = tmp(0) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3) & vbTab & tmp(4) & vbTab & tmp(5)
                                    wrt.WriteLine(str_to_write)
                                ElseIf arr4(m) = "a" Then
                                    Dim str_to_write = tmp(0) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3) & vbTab & tmp(4)
                                    wrt.WriteLine(str_to_write)
                                ElseIf arr4(m) = "b" Then
                                    Dim str_to_write = tmp(0) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3) & vbTab & tmp(4)
                                    wrt.WriteLine(str_to_write)
                                ElseIf arr4(m) = "c" Then
                                    Dim str_to_write = tmp(0) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3) & vbTab & tmp(4)
                                    wrt.WriteLine(str_to_write)
                                ElseIf arr4(m) = "d" Then
                                    Dim str_to_write = tmp(0) & vbTab & tmp(1) & vbTab & tmp(2)
                                    wrt.WriteLine(str_to_write)
                                End If
                            ElseIf arr3(k) = "device" Then
                                If arr4(m) = "" Then
                                    Dim str_to_write = tmp(0) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3) & vbTab & tmp(4) & vbTab & tmp(5) & vbTab & tmp(6)
                                    wrt.WriteLine(str_to_write)
                                ElseIf arr4(m) = "a" Then
                                    Dim str_to_write = tmp(0) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3) & vbTab & tmp(4) & vbTab & tmp(5)
                                    wrt.WriteLine(str_to_write)
                                ElseIf arr4(m) = "b" Then
                                    Dim str_to_write = tmp(0) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3) & vbTab & tmp(4) & vbTab & tmp(5)
                                    wrt.WriteLine(str_to_write)
                                ElseIf arr4(m) = "c" Then
                                    Dim str_to_write = tmp(0) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3) & vbTab & tmp(4) & vbTab & tmp(5)
                                    wrt.WriteLine(str_to_write)
                                ElseIf arr4(m) = "d" Then
                                    Dim str_to_write = tmp(0) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3)
                                    wrt.WriteLine(str_to_write)
                                End If
                            ElseIf arr3(k) = "cs" Then
                                If arr4(m) = "" Then
                                    Dim str_to_write = tmp(0) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3) & vbTab & tmp(4) & vbTab & tmp(5) & vbTab & tmp(6)
                                    wrt.WriteLine(str_to_write)
                                ElseIf arr4(m) = "a" Then
                                    Dim str_to_write = tmp(0) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3) & vbTab & tmp(4) & vbTab & tmp(5)
                                    wrt.WriteLine(str_to_write)
                                ElseIf arr4(m) = "b" Then
                                    Dim str_to_write = tmp(0) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3) & vbTab & tmp(4) & vbTab & tmp(5)
                                    wrt.WriteLine(str_to_write)
                                ElseIf arr4(m) = "c" Then
                                    Dim str_to_write = tmp(0) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3) & vbTab & tmp(4) & vbTab & tmp(5)
                                    wrt.WriteLine(str_to_write)
                                ElseIf arr4(m) = "d" Then
                                    Dim str_to_write = tmp(0) & vbTab & tmp(1) & vbTab & tmp(2) & vbTab & tmp(3)
                                    wrt.WriteLine(str_to_write)
                                End If
                            End If

                        End While
                        wrt.Close()
                        filewr.Close()
                    Next
                Next
                For m = 0 To 4
                    filerd2 = New System.IO.FileStream("C:\Mdata\Databases\" & arr3(k) & "t" & arr(i) & arr4(m) & ".arff", IO.FileMode.Open, IO.FileAccess.Read)
                    Dim lala2 As New System.IO.StreamReader(filerd2)
                    Dim str2 As String = ""
                    While str2.CompareTo("@data")
                        str2 = lala2.ReadLine
                        count2 += 1
                    End While

                    Dim filewr2 As System.IO.FileStream
                    filewr2 = New System.IO.FileStream("C:\Mdata\Databases\newones\" & arr3(k) & "t" & arr(i) & arr4(m) & ".data", IO.FileMode.Create, IO.FileAccess.Write)
                    Dim wrt2 As New System.IO.StreamWriter(filewr2)
                    If arr3(k) = "call" Then
                        If arr4(m) = "" Then
                            wrt2.WriteLine("9")
                            wrt2.WriteLine("#n phonenumber_oid cnid dirid deid dd wd mn duration stime")
                        ElseIf arr4(m) = "a" Then
                            wrt2.WriteLine("8")
                            wrt2.WriteLine("#n phonenumber_oid cnid dirid deid dd wd duration stime")
                        ElseIf arr4(m) = "b" Then
                            wrt2.WriteLine("8")
                            wrt2.WriteLine("#n phonenumber_oid cnid dirid deid dd mn duration stime")
                        ElseIf arr4(m) = "c" Then
                            wrt2.WriteLine("8")
                            wrt2.WriteLine("#n phonenumber_oid cnid dirid deid wd mn duration stime")
                        ElseIf arr4(m) = "d" Then
                            wrt2.WriteLine("6")
                            wrt2.WriteLine("#n phonenumber_oid cnid dirid deid duration stime")
                        End If
                    ElseIf arr3(k) = "device" Then
                        If arr4(m) = "" Then
                            wrt2.WriteLine("6")
                            wrt2.WriteLine("#n device_oid dd wd mn duration stime")
                        ElseIf arr4(m) = "a" Then
                            wrt2.WriteLine("5")
                            wrt2.WriteLine("#n device_oid dd wd duration stime")
                        ElseIf arr4(m) = "b" Then
                            wrt2.WriteLine("5")
                            wrt2.WriteLine("#n device_oid dd mn duration stime")
                        ElseIf arr4(m) = "c" Then
                            wrt2.WriteLine("5")
                            wrt2.WriteLine("#n device_oid wd mn duration stime")
                        ElseIf arr4(m) = "d" Then
                            wrt2.WriteLine("3")
                            wrt2.WriteLine("#n device_oid duration stime")
                        End If
                    ElseIf arr3(k) = "cs" Then
                        If arr4(m) = "" Then
                            wrt2.WriteLine("6")
                            wrt2.WriteLine("#n celltower_oid dd wd mn duration stime")
                        ElseIf arr4(m) = "a" Then
                            wrt2.WriteLine("5")
                            wrt2.WriteLine("#n celltower_oid dd wd duration stime")
                        ElseIf arr4(m) = "b" Then
                            wrt2.WriteLine("5")
                            wrt2.WriteLine("#n celltower_oid dd mn duration stime")
                        ElseIf arr4(m) = "c" Then
                            wrt2.WriteLine("5")
                            wrt2.WriteLine("#n celltower_oid wd mn duration stime")
                        ElseIf arr4(m) = "d" Then
                            wrt2.WriteLine("3")
                            wrt2.WriteLine("#n celltower_oid duration stime")
                        End If
                    ElseIf arr3(k) = "activity" Then
                        If arr4(m) = "" Then
                            wrt2.WriteLine("5")
                            wrt2.WriteLine("#n dd wd mn duration stime")
                        ElseIf arr4(m) = "a" Then
                            wrt2.WriteLine("4")
                            wrt2.WriteLine("#n dd wd duration stime")
                        ElseIf arr4(m) = "b" Then
                            wrt2.WriteLine("4")
                            wrt2.WriteLine("#n dd mn duration stime")
                        ElseIf arr4(m) = "c" Then
                            wrt2.WriteLine("4")
                            wrt2.WriteLine("#n wd mn duration stime")
                        ElseIf arr4(m) = "d" Then
                            wrt2.WriteLine("2")
                            wrt2.WriteLine("#n duration stime")
                        End If
                    End If
                    While lala2.Peek > -1

                        count2 += 1
                        str2 = lala2.ReadLine
                        Dim tmp2 As String() = str2.Split(",")
                        If arr3(k) = "call" Then
                            If arr4(m) = "" Then
                                Dim str_to_write = tmp2(0) & vbTab & tmp2(1) & vbTab & tmp2(2) & vbTab & tmp2(3) & vbTab & tmp2(4) & vbTab & tmp2(5) & vbTab & tmp2(6) & vbTab & tmp2(7) & vbTab & tmp2(8) & vbTab & tmp2(9)
                                wrt2.WriteLine(str_to_write)
                            ElseIf arr4(m) = "a" Then
                                Dim str_to_write = tmp2(0) & vbTab & tmp2(1) & vbTab & tmp2(2) & vbTab & tmp2(3) & vbTab & tmp2(4) & vbTab & tmp2(5) & vbTab & tmp2(6) & vbTab & tmp2(7) & vbTab & tmp2(8)
                                wrt2.WriteLine(str_to_write)
                            ElseIf arr4(m) = "b" Then
                                Dim str_to_write = tmp2(0) & vbTab & tmp2(1) & vbTab & tmp2(2) & vbTab & tmp2(3) & vbTab & tmp2(4) & vbTab & tmp2(5) & vbTab & tmp2(6) & vbTab & tmp2(7) & vbTab & tmp2(8)
                                wrt2.WriteLine(str_to_write)
                            ElseIf arr4(m) = "c" Then
                                Dim str_to_write = tmp2(0) & vbTab & tmp2(1) & vbTab & tmp2(2) & vbTab & tmp2(3) & vbTab & tmp2(4) & vbTab & tmp2(5) & vbTab & tmp2(6) & vbTab & tmp2(7) & vbTab & tmp2(8)
                                wrt2.WriteLine(str_to_write)
                            ElseIf arr4(m) = "d" Then
                                Dim str_to_write = tmp2(0) & vbTab & tmp2(1) & vbTab & tmp2(2) & vbTab & tmp2(3) & vbTab & tmp2(4) & vbTab & tmp2(5) & vbTab & tmp2(6)
                                wrt2.WriteLine(str_to_write)
                            End If
                        ElseIf arr3(k) = "activity" Then
                            If arr4(m) = "" Then
                                Dim str_to_write = tmp2(0) & vbTab & tmp2(1) & vbTab & tmp2(2) & vbTab & tmp2(3) & vbTab & tmp2(4) & vbTab & tmp2(5)
                                wrt2.WriteLine(str_to_write)
                            ElseIf arr4(m) = "a" Then
                                Dim str_to_write = tmp2(0) & vbTab & tmp2(1) & vbTab & tmp2(2) & vbTab & tmp2(3) & vbTab & tmp2(4)
                                wrt2.WriteLine(str_to_write)
                            ElseIf arr4(m) = "b" Then
                                Dim str_to_write = tmp2(0) & vbTab & tmp2(1) & vbTab & tmp2(2) & vbTab & tmp2(3) & vbTab & tmp2(4)
                                wrt2.WriteLine(str_to_write)
                            ElseIf arr4(m) = "c" Then
                                Dim str_to_write = tmp2(0) & vbTab & tmp2(1) & vbTab & tmp2(2) & vbTab & tmp2(3) & vbTab & tmp2(4)
                                wrt2.WriteLine(str_to_write)
                            ElseIf arr4(m) = "d" Then
                                Dim str_to_write = tmp2(0) & vbTab & tmp2(1) & vbTab & tmp2(2)
                                wrt2.WriteLine(str_to_write)
                            End If
                        ElseIf arr3(k) = "device" Then
                            If arr4(m) = "" Then
                                Dim str_to_write = tmp2(0) & vbTab & tmp2(1) & vbTab & tmp2(2) & vbTab & tmp2(3) & vbTab & tmp2(4) & vbTab & tmp2(5) & vbTab & tmp2(6)
                                wrt2.WriteLine(str_to_write)
                            ElseIf arr4(m) = "a" Then
                                Dim str_to_write = tmp2(0) & vbTab & tmp2(1) & vbTab & tmp2(2) & vbTab & tmp2(3) & vbTab & tmp2(4) & vbTab & tmp2(5)
                                wrt2.WriteLine(str_to_write)
                            ElseIf arr4(m) = "b" Then
                                Dim str_to_write = tmp2(0) & vbTab & tmp2(1) & vbTab & tmp2(2) & vbTab & tmp2(3) & vbTab & tmp2(4) & vbTab & tmp2(5)
                                wrt2.WriteLine(str_to_write)
                            ElseIf arr4(m) = "c" Then
                                Dim str_to_write = tmp2(0) & vbTab & tmp2(1) & vbTab & tmp2(2) & vbTab & tmp2(3) & vbTab & tmp2(4) & vbTab & tmp2(5)
                                wrt2.WriteLine(str_to_write)
                            ElseIf arr4(m) = "d" Then
                                Dim str_to_write = tmp2(0) & vbTab & tmp2(1) & vbTab & tmp2(2) & vbTab & tmp2(3)
                                wrt2.WriteLine(str_to_write)
                            End If
                        ElseIf arr3(k) = "cs" Then
                            If arr4(m) = "" Then
                                Dim str_to_write = tmp2(0) & vbTab & tmp2(1) & vbTab & tmp2(2) & vbTab & tmp2(3) & vbTab & tmp2(4) & vbTab & tmp2(5) & vbTab & tmp2(6)
                                wrt2.WriteLine(str_to_write)
                            ElseIf arr4(m) = "a" Then
                                Dim str_to_write = tmp2(0) & vbTab & tmp2(1) & vbTab & tmp2(2) & vbTab & tmp2(3) & vbTab & tmp2(4) & vbTab & tmp2(5)
                                wrt2.WriteLine(str_to_write)
                            ElseIf arr4(m) = "b" Then
                                Dim str_to_write = tmp2(0) & vbTab & tmp2(1) & vbTab & tmp2(2) & vbTab & tmp2(3) & vbTab & tmp2(4) & vbTab & tmp2(5)
                                wrt2.WriteLine(str_to_write)
                            ElseIf arr4(m) = "c" Then
                                Dim str_to_write = tmp2(0) & vbTab & tmp2(1) & vbTab & tmp2(2) & vbTab & tmp2(3) & vbTab & tmp2(4) & vbTab & tmp2(5)
                                wrt2.WriteLine(str_to_write)
                            ElseIf arr4(m) = "d" Then
                                Dim str_to_write = tmp2(0) & vbTab & tmp2(1) & vbTab & tmp2(2) & vbTab & tmp2(3)
                                wrt2.WriteLine(str_to_write)
                            End If
                        End If
                    End While
                    wrt2.Close()

                    filewr2.Close()
                Next

            Next
        Next
    End Sub
End Class
