Sub Sherry()
  Dim Input1 As Long
  Dim Input2 As String
  Const OrderText = "シェリーちゃんかわいい最強天才！"
  MsgBox ("橘シェリーが現れた！")
  Input1 = MsgBox("橘シェリーの要求を拒否する？", vbYesNo + vbQuestion, "いいねヨクナイネ")
  If Input1 = vbYes Then
    MsgBox ("橘シェリー「ひどいですぅ！たまには言ってくれてもいいのにぃ！」")
    Exit Sub
  Else
    MsgBox ("橘シェリーの要求を受け入れた！")
  End If
  MsgBox ("橘シェリーは、「" & OrderText & "」を求めている。")
  Input2 = InputBox("返事をしよう。")
  If Input2 = OrderText Then
    MsgBox ("橘シェリー「やったぁ！う～れし～！」")
  Else
    MsgBox ("橘シェリー「たまには言ってくれてもいいのにぃ！」")
  End If
End Sub

Sub Kakunin3()
  Dim Kuku(9, 9) As Long
  Dim a As Long
  Dim b As Long
  Dim n As Long
  Dim c As Long
  Dim Hyoji As String
  For a = 1 To 9
    For b = 1 To 9
      Kuku(a, b) = a * b
    Next b
  Next a
    n = Val(InputBox("表示する段を指定しろ"))
  If n > 10 Then
    MsgBox ("有効な値ではありません。有効な値は、1から9の整数です。")
  Else
    For c = 1 To 9
      Hyoji = Hyoji & Str(Kuku(n, c))
    Next c
    MsgBox (n & "の段" & Hyoji)
  End If
End Sub

Sub ProgramRei1()
  Dim Kei(3) As Long
  Dim i As Long
  Dim Flg As Boolean
  Dim Sc As String
  Dim n As Long
  Dim p As Long
  For i = 1 To 3
    Kei(i) = 0
  Next i
  Flg = False
  Do While Flg = False
    Sc = InputBox("数値を入力しろ")
    If Sc = "" Then
      Flg = True
    Else
      n = Val(Left(Sc, 1))
      If n > 3 Then
        MsgBox ("不正な値です。")
      Else
        Kei(n) = Kei(n) + 1
      End If
    End If
  Loop
  For p = 1 To 3
    MsgBox (p & "年" & Kei(p) & "人")
  Next
End Sub
