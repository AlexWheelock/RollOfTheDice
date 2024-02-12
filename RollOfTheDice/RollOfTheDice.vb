'Alex Wheelock
'RCET 0265
'Spring 2024
'Roll Of The Dice
'https://github.com/AlexWheelock/RollOfTheDice.git

Option Strict On
Option Explicit On
Imports Microsoft.VisualBasic.Devices

Module RollOfTheDice

    Sub Main()

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
        Dim returnedValue As Integer
        Dim header() = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"}

        'Rolls the set if die 1000 times
        For rolls = 0 To 999

            'Sends the execution to the RollTheDice() function
            'Sets returnedValue to the value returned from function
            returnedValue = RollTheDice()

            'Determines the value of rolled number, and which case it falls into,
            'Adds 1 to the number of times that number has already come up
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

        'Organizes the numbered variables, and the number of times that they were rolled into an array
        Dim outputArray() = {two, three, four, five, six, seven, eight, nine, ten, eleven, twelve}

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

        Dim rolledNumber1 As Integer
        Dim rolledNumber2 As Integer
        Dim rolledTotal As Integer

        'Rolls each dice one time as a random number, then adds the two numbers together
        Randomize()
        rolledNumber1 = (CInt(Math.Floor(CDbl(Rnd() * 6) + 1)))
        rolledNumber2 = (CInt(Math.Floor(CDbl(Rnd() * 6) + 1)))
        rolledTotal = rollednumber1 + rolledNumber2

        Return rolledTotal
    End Function

End Module
