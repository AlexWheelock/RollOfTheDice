'Alex Wheelock
'RCET 0265
'Spring 2024
'Roll Of The Dice
'https://github.com/AlexWheelock/RollOfTheDice.git

Option Strict On
Option Explicit On
Module RollOfTheDice

    Sub Main()

        Dim returnedValue As Integer
        Dim outputArray(10) As Integer

        Dim two As Integer
        Dim three As Integer
        Dim four As Integer
        Dim five As Integer
        Dim six As Integer
        Dim seven As Integer
        Dim eight As Integer
        Dim nine As Integer
        Dim ten As Integer
        Dim eleven As Integer
        Dim twelve As Integer

        outputArray(0) = two
        outputArray(1) = three
        outputArray(2) = four
        outputArray(3) = five
        outputArray(4) = six
        outputArray(5) = seven
        outputArray(6) = eight
        outputArray(7) = nine
        outputArray(8) = ten
        outputArray(9) = eleven
        outputArray(10) = twelve

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
            End Select

        Next

        Console.WriteLine(outputArray)

        Console.Read()
    End Sub

    Function RollTheDice() As Integer

        Dim rolledNumber As Integer

        Randomize()
        rolledNumber = (CInt(Rnd() * 12) + 2)

        Return rolledNumber
    End Function

End Module
