Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System.Math

Public Class Form1
    Public STOPNOW As Boolean 'This is a sentinel variable used in the demo form
    Public palenque As Integer
    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click

        If (palenque = 2) Then
            Me.Close()
        End If
        palenque = 2

        txtNoAutorizacion.Text = txtNoAutorizacion.Text + obtenerVerhoeff(txtNoAutorizacion.Text)
        txtNoFactura.Text = txtNoFactura.Text + obtenerVerhoeff(txtNoFactura.Text)
        txtNIT.Text = txtNIT.Text + obtenerVerhoeff(txtNIT.Text)
        txtFecha.Text = txtFecha.Text + obtenerVerhoeff(txtFecha.Text)

        Dim pero As Double
        If (txtMonto.Text = "") Then
            txtMonto.Text = "0"
        End If
        pero = Convert.ToDouble(txtMonto.Text)
        pero = Round(pero)
        Dim entero As Integer
        entero = Convert.ToInt64(Abs(pero))
        txtMonto.Text = Convert.ToString(pero)

        txtMonto.Text = txtMonto.Text + obtenerVerhoeff(txtMonto.Text)

        Dim aux As Long
        aux = aux + Convert.ToInt64(txtNoAutorizacion.Text)
        aux = aux + Convert.ToInt64(txtNoFactura.Text)
        aux = aux + Convert.ToInt64(txtNIT.Text)
        aux = aux + Convert.ToInt64(txtFecha.Text)
        aux = aux + Convert.ToInt64(txtMonto.Text)

        txtSuma.Text = Convert.ToString(aux)

        aux = Convert.ToInt64(txtSuma.Text) Mod 1073741823
        txtSuma.Text = Convert.ToString(aux)

        txtSuma.Text = BASE64(txtSuma.Text)

        txtSuma.Text = RC4(txtSuma.Text, txtLlave.Text, True)

        btnCalcular.Text = "SALIR"

    End Sub


    Function obtenerVerhoeff(ByRef Numero As String) As String
        Dim Mul As Object '(10, 10) As Integer
        Dim Per As Object '(8, 10) As Integer
        Dim Inv As Object '(10) As Integer
        'UPGRADE_WARNING: Array tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Inv. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        Inv = New Object() {0, 4, 3, 2, 1, 5, 6, 7, 8, 9}
        Dim NumeroInvertido As String
        Dim Check As Short
        Dim i As Short
        Dim aux02, aux01, aux03 As Object
        'UPGRADE_WARNING: Array tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Mul. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        Mul = New Object() {New Object() {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}, New Object() {1, 2, 3, 4, 0, 6, 7, 8, 9, 5}, New Object() {2, 3, 4, 0, 1, 7, 8, 9, 5, 6}, New Object() {3, 4, 0, 1, 2, 8, 9, 5, 6, 7}, New Object() {4, 0, 1, 2, 3, 9, 5, 6, 7, 8}, New Object() {5, 9, 8, 7, 6, 0, 4, 3, 2, 1}, New Object() {6, 5, 9, 8, 7, 1, 0, 4, 3, 2}, New Object() {7, 6, 5, 9, 8, 2, 1, 0, 4, 3}, New Object() {8, 7, 6, 5, 9, 3, 2, 1, 0, 4}, New Object() {9, 8, 7, 6, 5, 4, 3, 2, 1, 0}}
        'UPGRADE_WARNING: Array tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Per. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        Per = New Object() {New Object() {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}, New Object() {1, 5, 7, 6, 2, 8, 3, 0, 9, 4}, New Object() {5, 8, 0, 3, 7, 9, 6, 1, 4, 2}, New Object() {8, 9, 1, 6, 0, 4, 3, 5, 2, 7}, New Object() {9, 4, 5, 3, 1, 2, 6, 8, 7, 0}, New Object() {4, 2, 8, 6, 5, 7, 3, 9, 0, 1}, New Object() {2, 7, 9, 3, 8, 0, 6, 4, 1, 5}, New Object() {7, 0, 4, 6, 9, 1, 3, 2, 5, 8}}

        Check = 0
        NumeroInvertido = swap(Numero)
        For i = 0 To Len(NumeroInvertido) - 1
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aux01. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            aux01 = ((i + 1) Mod 8)
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aux02. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            aux02 = Mid(NumeroInvertido, i + 1, 1)
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aux02. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Per()(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aux03. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            aux03 = Per(aux01)(CShort(aux02))
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Mul()(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            Check = Mul(Check)(aux03) 'Per(((i + 1) Mod 8), Mid(NumeroInvertido, i, 1)))
        Next
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Inv(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        obtenerVerhoeff = Inv(Check)
    End Function

    Function swap(ByRef Numero As String) As String
        Dim i As Short
        Dim aux As String
        aux = ""
        For i = 1 To Len(Numero)
            aux = aux & Mid(Numero, Len(Numero) - i + 1, 1)
        Next i
        swap = aux
    End Function

    Public Function BASE64(ByVal sNum As String) As String
        Dim Dic As Object
        'Dim result As Integer
        Dim Resto As Short
        Dim aux As String
        Dim aux2 As String
        Dim num As Short
        Dim sResto, sResult As String
        Dim i As Short

        aux = ""
        'UPGRADE_WARNING: Array tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Dic. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        Dic = New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "+", "/"}

        Do While sNum <> "0" 'Len(sNum) > 4
            sResult = IntDivide(sNum, "64", sResto)
            Resto = CShort(sResto) 'IntSubtract(sNum, IntMultiply(result, "64"))
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Dic(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            aux = aux & Dic(Resto)
            sNum = sResult
        Loop
        num = CShort(sNum)
        Do While num > 0
            Resto = num Mod 64
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Dic(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            aux = aux & Dic(Resto)
            num = num / 64
        Loop
        For i = 1 To Len(aux)
            aux2 = aux2 & Mid(aux, Len(aux) - i + 1, 1)
        Next i
        BASE64 = aux2
    End Function

    Public Function IntDivide(ByVal FirstNum As String, ByVal SecondNum As String, ByRef Resto As String) As String
        'Before we even alocate memory for variables, test for some very important error values
        If Len(FirstNum) < Len(SecondNum) Or InStr(1, IntSubtract(FirstNum, SecondNum), "-") > 0 Then
            'MsgBox "Fault: Extra Long Division does not support dividing a shorter number by a longer number, as this requires decimals which are not currently handled."
            Resto = FirstNum
            IntDivide = "0"
            Exit Function

        ElseIf TrimZeros(SecondNum) = "" Then
            MsgBox("Fault: Cannot divide by Zero.")

        ElseIf TrimZeros(SecondNum) = "" Then
            GoTo EndFunc

        Else
            GoTo continDivide
        End If
        GoTo ExitDivide
        'After passing the error checking, lets get started with some division
continDivide:
        Dim DivTotal, Num1, DivMult As String
        Dim DifLen As Integer
        Dim DivSub, TempNum As String
        'Initiallize values
        Num1 = FirstNum
        DivTotal = "0"
        DifLen = (Len(Num1) - Len(SecondNum))
        DivMult = New String("0", DifLen)
        DivSub = SecondNum & DivMult

        'Lets do some division
        Do Until (Len(Num1) < Len(SecondNum) Or Num1 = "0" Or (InStr(1, IntSubtract(Num1, SecondNum), "-") > 0 And DivMult = "")) Or STOPNOW = True

            'The way this division works is it subtracts values from the divided number
            'until no more can be subtracted.  This sets up a the largest possible number
            'that can be subtracted from the number so that you remove larger chucks of
            'Numbers at a time and waste less CPU Cycles doing it.
            If DifLen >= 0 Then DivMult = New String("0", DifLen)
            DivSub = SecondNum & DivMult

            If InStr(1, IntSubtract(Num1, DivSub), "-") > 0 Then
                If DifLen > 0 Then
                    DivMult = New String("0", DifLen - 1)
                    DivSub = SecondNum & DivMult
                Else
                    Exit Do
                End If
            End If

            'Perform the accually math.  DivTotal adds up how many times the original
            'number has been subtracted from the divided number. Num1 is the working
            'number.
            DivTotal = IntAddition(DivTotal, "1" & DivMult)
            Num1 = IntSubtract(Num1, DivSub)
            DifLen = Len(Num1) - Len(SecondNum)

            System.Windows.Forms.Application.DoEvents()

            'sentinel
            If STOPNOW = True Then GoTo ExitDivide
        Loop

        'Since there are no decimals, we return return the devide results with a remainder.
        IntDivide = DivTotal '& "r" & Num1
        Resto = Num1

EndFunc:
        Exit Function
ExitDivide:
        IntDivide = "NaN"
    End Function

    Public Function IntAddition(ByVal FirstNum As String, ByVal SecondNum As String) As String
        Dim a, DifLen As Integer
        Dim TempStr As String
        Dim TempNum As Short
        Dim Num1, Num2 As String
        Dim TempNum1, TempNum2 As Short
        Dim CarryOver As Short
        Dim LeftOvers As Integer
        'Setup the numbers so that they are easier to handle.
        'I originally had about 10 nested if statements that this block
        'of code simplifies Dramatically.
        If Len(FirstNum) >= Len(SecondNum) Then
            Num1 = FirstNum
            Num2 = SecondNum
        Else
            Num2 = FirstNum
            Num1 = SecondNum
        End If

        'Just setup some of the variables that need an initial value
        DifLen = Len(Num1) - Len(Num2)
        CarryOver = 0
        LeftOvers = DifLen

        'Ok, now for the real math.  Looping from the end of the numbers
        'just like our preschool teachers taught us, we add numbers that
        'line up in the 'places' (I.E. ones, tens, hundreds, thousands, etc)
        For a = Len(Num2) To 1 Step -1
            TempNum1 = Int(CDbl(Mid(Num1, a + DifLen, 1)))
            TempNum2 = Int(CDbl(Mid(Num2, a, 1)))
            TempNum = TempNum1 + TempNum2 + CarryOver
            CarryOver = TempNum \ 10
            TempStr = (TempNum - (CarryOver * 10)) & TempStr
            System.Windows.Forms.Application.DoEvents()
            If STOPNOW = True Then GoTo StopAdd
        Next a

        'What do we do if there is a 1 or a 2 that carries over outside the
        'numbers that line up in the places, well, we do the following block of
        'code.  The do loop is used incase we get a situation like this:
        '
        '    199999  When you add 1 to a set of nines it continues to
        '    _+___1  Carry over until it hits the first digit
        '    200000
        Do Until CarryOver = 0 Or LeftOvers = 0
            TempNum = Int(CDbl(Mid(Num1, LeftOvers, 1))) + CarryOver
            CarryOver = TempNum \ 10
            TempStr = (TempNum - (CarryOver * 10)) & TempStr
            LeftOvers = LeftOvers - 1
        Loop

        'Since there are two possible ways of exiting the Loop above, we need
        'to test and apply the other variable and its associated values in the following
        'two if statements.
        'Handle a possible carryover that will drop off the front end creating a new place.
        If CarryOver > 0 Then TempStr = CarryOver & TempStr
        'add any of the numbers that are remaining on the left side of the longer string
        If LeftOvers > 0 Then TempStr = (Microsoft.VisualBasic.Left(Num1, LeftOvers)) & TempStr
        'and return the value
StopAdd:
        IntAddition = TrimZeros(TempStr)
    End Function

    Public Function IntSubtract(ByVal FirstNum As String, ByVal SecondNum As String) As String
        '***
        'DO NOT change the integers to bytes, there are negative values in this function
        '***
        Dim Num1, Num2 As String
        Dim a, DifLen As Integer
        Dim Neg As Boolean
        Dim TempStr As String
        Dim TempNum1, TempNum2 As Short
        Dim TempNum As Short
        Dim Barrow As Byte
        'This function operates on a theory known as Two-Compliment.
        'If you want to know more, look for it at www.mathforum.com
        'This function works great now
        'This block of code arranges the numbers into the Num1 and Num2 based on
        'which number is larger.  This prevents a great number of errors if the numbers
        'dont line up, or if the larger number is taken from the smaller number.
        If Len(FirstNum) > Len(SecondNum) Then
            Num1 = FirstNum
            Num2 = SecondNum
            Neg = False
        ElseIf Len(FirstNum) < Len(SecondNum) Then
            Num1 = SecondNum
            Num2 = FirstNum
            Neg = True
        Else

            'In the case that the strings are of equal length we have this pretty little
            'set of code to find which number has the first larger digit.
            For a = 1 To Len(FirstNum)
                If Int(CDbl(Mid(FirstNum, a, 1))) > Int(CDbl(Mid(SecondNum, a, 1))) Then
                    Num1 = FirstNum
                    Num2 = SecondNum
                    Neg = False
                    GoTo ContinSubtraction

                ElseIf Int(CDbl(Mid(FirstNum, a, 1))) < Int(CDbl(Mid(SecondNum, a, 1))) Then
                    Num1 = SecondNum
                    Num2 = FirstNum
                    Neg = True
                    GoTo ContinSubtraction
                End If

                System.Windows.Forms.Application.DoEvents()

                'sentinel
                If STOPNOW = True Then GoTo ExitFunction
            Next a

            'In the case that no larger digit is found, then guess what, its a perfect
            'subtraction, so we don't need to do the function, just assign a 0 outside the end.
            GoTo ExitFunction
        End If

ContinSubtraction:
        'If we have a difference in length then ajust with 0's that will not affect the calculations.
        'This allows us to get all the digits into the final out number.
        DifLen = Len(Num1) - Len(Num2)
        Num2 = New String("0", DifLen) & Num2
        Barrow = 0
        'lets do some math
        For a = Len(Num2) To 1 Step -1

            'Pick out the individual digit from each number
            TempNum1 = Int(CDbl(Mid(Num1, a, 1))) - Barrow
            TempNum2 = Int(CDbl(Mid(Num2, a, 1)))
            Barrow = 0

            'Perform single digit subraction using the Two Compliment theory
            If TempNum1 >= TempNum2 Then
                TempNum = TempNum1 - TempNum2

            ElseIf TempNum1 < TempNum2 Then
                TempNum = (TempNum1 + 10) - TempNum2
                Barrow = 1
            End If

            'Assign new digit to the final string.
            TempStr = CStr(TempNum) & TempStr

            System.Windows.Forms.Application.DoEvents()

            'sentinel
            If STOPNOW = True Then GoTo ExitFunction
        Next a
        'now, since we are subtracting, we need to determine if the number being returned is a negative.
        'Just to note, the Trim is to remove unneccsary zero's at the head(left) of the return number.
        If Neg = True Then
            IntSubtract = "-" & TrimZeros(Trim(TempStr))
        Else
            IntSubtract = TrimZeros(Trim(TempStr))
        End If
        Exit Function
ExitFunction:
        IntSubtract = CStr(0)
    End Function

    Public Function TrimZeros(ByVal num As String) As String
        Dim a As Integer
        Dim TempStr As String
        For a = 1 To Len(num)
            If CDbl(Mid(num, a, 1)) <> 0 Then GoTo YuckFu
        Next a
        TrimZeros = "0"
        Exit Function
YuckFu:
        TrimZeros = Mid(num, a, Len(num) - a + 1)
    End Function

    Public Function RC4(ByVal Expression As String, ByVal Password As String, Optional ByVal guion As Boolean = True) As String
        On Error Resume Next
        Dim RB(255) As Short
        Dim Y, X, Z As Integer
        Dim Key() As Byte
        Dim ByteArray() As Byte
        Dim Temp As Byte
        Dim aux As String
        aux = ""
        If Len(Password) = 0 Then
            Exit Function
        End If
        If Len(Expression) = 0 Then
            Exit Function
        End If
        If Len(Password) > 256 Then
            'UPGRADE_ISSUE: No se actualizó la constante vbFromUnicode. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
            'UPGRADE_TODO: El código se actualizó para usar System.Text.UnicodeEncoding.Unicode.GetBytes(), que podría no tener el mismo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1059"'
            'Key = System.Text.UnicodeEncoding.Unicode.GetBytes(StrConv(VB.Left(Password, 256), vbFromUnicode))
            Key = System.Text.Encoding.GetEncoding(1252).GetBytes(Microsoft.VisualBasic.Left(Password, 256))
        Else
            'UPGRADE_ISSUE: No se actualizó la constante vbFromUnicode. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
            'UPGRADE_TODO: El código se actualizó para usar System.Text.UnicodeEncoding.Unicode.GetBytes(), que podría no tener el mismo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1059"'
            'Key = System.Text.UnicodeEncoding.Unicode.GetBytes(StrConv(Password, vbFromUnicode))
            Key = System.Text.Encoding.GetEncoding(1252).GetBytes(Password)
        End If
        For X = 0 To 255
            RB(X) = X
        Next X
        X = 0
        Y = 0
        Z = 0
        For X = 0 To 255
            Y = (Y + RB(X) + Key(X Mod Len(Password))) Mod 256
            Temp = RB(X)
            RB(X) = RB(Y)
            RB(Y) = Temp
        Next X
        X = 0
        Y = 0
        Z = 0
        'UPGRADE_ISSUE: No se actualizó la constante vbFromUnicode. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
        'UPGRADE_TODO: El código se actualizó para usar System.Text.UnicodeEncoding.Unicode.GetBytes(), que podría no tener el mismo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1059"'
        'ByteArray = System.Text.UnicodeEncoding.Unicode.GetBytes(StrConv(Expression, vbFromUnicode))
        ByteArray = System.Text.Encoding.GetEncoding(1252).GetBytes(Expression)
        For X = 0 To Len(Expression)
            Y = (Y + 1) Mod 256
            Z = (Z + RB(Y)) Mod 256
            Temp = RB(Y)
            RB(Y) = RB(Z)
            RB(Z) = Temp
            ByteArray(X) = ByteArray(X) Xor (RB((RB(Y) + RB(Z)) Mod 256))
            aux = aux & Microsoft.VisualBasic.Right(New String("0", 2) & Hex(ByteArray(X)), 2)
            If guion And (X < Len(Expression) - 1) Then
                aux = aux & "-"
            End If
        Next X
        RC4 = aux 'StrConv(ByteArray, vbUnicode)

    End Function

#Region "keys"

    Private Sub txtLlave_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLlave.KeyPress
        Dim tecla As Integer
        tecla = Convert.ToInt32(e.KeyChar)
        If (Not ((tecla >= 65 And tecla <= 90) Or (tecla >= 96 And tecla <= 122) Or (tecla >= 48 And tecla <= 57))) Then
            e.Handled = True
        End If
        'If (tecla == (int)Keys.Escape) Then
        '    txtLlave.Text = ""
        'End If
    End Sub

    Private Sub txtNoAutorizacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoAutorizacion.KeyPress
        Dim tecla As Integer
        tecla = Convert.ToInt32(e.KeyChar)
        If (Not (tecla >= 48 And tecla <= 57)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNoFactura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoFactura.KeyPress
        Dim tecla As Integer
        tecla = Convert.ToInt32(e.KeyChar)
        If (Not (tecla >= 48 And tecla <= 57)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNIT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNIT.KeyPress
        Dim tecla As Integer
        tecla = Convert.ToInt32(e.KeyChar)
        If (Not (tecla >= 48 And tecla <= 57)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFecha_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFecha.KeyPress
        Dim tecla As Integer
        tecla = Convert.ToInt32(e.KeyChar)
        If (Not (tecla >= 48 And tecla <= 57)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        Dim tecla As Integer
        tecla = Convert.ToInt32(e.KeyChar)
        'Or tecla = 46
        If (Not ((tecla >= 48 And tecla <= 57) Or tecla = 44)) Then
            e.Handled = True
        End If
    End Sub
#End Region

End Class
