Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button_COVER_Click(sender As System.Object, e As System.EventArgs) Handles Button_COVER.Click
        Dim res As String = Cover2(TextBox_TEN.Text, TextBox_OTHER.Text, TextBox_START.Text)
        TextBox_VALUE.Text = res.Trim
    End Sub



    Private Function Cover2(num As Integer, rexStr As String, initstr As String) As String
        Dim res As String = ""
        'num   1
        'rexStr 123456789ABCDEFGHJKLMNPRSTUWXYZ
        'initstr 111
        '默认31进制是从111开始，换算乘10进制，则是1*31*31 + 1* 31 + 1 = 993 开始属于第一位，则num = num + 992，即传递进来的值应加上992后再做转换
        Dim count As Integer = rexStr.Length   '获得位数，31位
        'Dim box As Char() = {"1", "1", "1"}  '初始化容器数组,编码后传入的1为111，初始化用于位数不够时补全
        Dim box As Char() = {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0"}
        Dim charIndex As Integer = box.Length - 1   'box的索引位置，默认从最后开始，不停的进位
        num = num + 992
        If num = 992 Then
            MsgBox("传递进来的值不可为0")
            res = "ERROR:传递进来的值不可为0"
            Return res
        End If
        If num > 31 * 31 * 31 + 31 * 31 + 31 Then
            MsgBox("传递进来的值已超出流水号位数")
            res = "ERROR:传递进来的值已超出流水号位数"
            Return res
        End If
        While num \ count <> 0
            If num Mod count = 0 Then '整除时不进位
                box(charIndex) = rexStr.Chars(rexStr.Length - 1) '进制中的最后一位
                charIndex = charIndex - 1
                num = num \ count - 1 '将要进位的值退一位回来
            Else
                box(charIndex) = rexStr.Chars((num Mod count) - 1)
                charIndex = charIndex - 1
                num = num \ count
            End If
        End While
        If num > 0 Then
            box(charIndex) = rexStr.Chars((num Mod count) - 1)
        End If
        res = New String(box, charIndex, box.Length - charIndex)
        Return res
    End Function

    Private Sub Button_RUN_Click(sender As System.Object, e As System.EventArgs) Handles Button_RUN.Click
        ListBox_ID.Items.Clear()
        Dim a As Integer = startCount.Text
        Dim b As Integer = endCount.Text
        Dim rexStr As String = TextBox_OTHER.Text
        Dim testTable As Hashtable = New Hashtable
        For i = a To b
            ListBox_ID.Items.Add(Cover2(i, rexStr, ""))
            Try
                testTable.Add(Cover2(i, rexStr, ""), "")
            Catch ex As Exception
                MsgBox("传递进来的值有误")
                Exit Sub
            End Try

        Next
    End Sub
End Class
