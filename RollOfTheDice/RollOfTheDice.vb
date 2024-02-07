Option Strict On
Option Explicit On
'Alex Wheelock
'RCET 0265
'Spring 2024
'Roll Of The Dice
'https://github.com/AlexWheelock/RollOfTheDice.git

Imports Microsoft.VisualBasic.Devices

Module RollOfTheDice

    Sub Main()

        Dim two As Integer = 0
        Dim three As Integer = 0
        Dim four As Integer = 0
        Dim five As Integer = 0
        Dim six As Integer = 0
        Dim seven As Integer = 0
        Dim eight As Integer = 0
        Dim nine As Integer = 0
        Dim ten As Integer = 0
        Dim eleven As Integer = 0
        Dim twelve As Integer = 0

        Dim returnedValue As Integer
        Dim outputArray() = {two, three, four, five, six, seven, eight, nine, ten, eleven, twelve}
        Dim header() = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"}

        For rolls = 0 To 1000

            returnedValue = RollTheDice()

            Select Case returnedValue
                Case = 2
                    two += 1
                Case = 3
                    three += 1
                Case = 4
                    four += 1
                Case = 5
                    five += 1
                Case = 6
                    six += 1
                Case = 7
                    seven += 1
                Case = 8
                    eight += 1
                Case = 9
                    nine += 1
                Case = 10
                    ten += 1
                Case = 11
                    eleven += 1
                Case = 12
                    twelve += 1
                Case Else
            End Select

        Next

        For Each letter In header
            Console.Write(letter.PadLeft(3).PadRight(4) & " |")
        Next

        'Dim length As Integer = cint(Len(header)

        Console.WriteLine()
        'For i = 0 To length
        '    Console.Write("-")
        'Next
        Console.WriteLine()

        For Each number In outputArray
            Console.Write(CStr(number).PadLeft(3).PadRight(4) & " |")
        Next

        Console.Read()
    End Sub

    Function RollTheDice() As Integer

        Dim rolledNumber As Integer

        Randomize()
        rolledNumber = (CInt(Math.Floor(CDbl(Rnd() * 12) + 1)))

        Return rolledNumber
    End Function

End Module
