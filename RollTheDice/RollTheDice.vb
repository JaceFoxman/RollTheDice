'Jason Permann
'Spring 2025
'RCET2265
'Roll The Dice
'https://github.com/JaceFoxman/RollTheDice.git

Option Strict On
Option Explicit On
Option Compare Text
Imports System.Text.RegularExpressions

Module RollTheDice

    Sub Main()
        Dim randomNumber(12) As Integer

        For i = 1 To 1000
            randomNumber(RNG(1, 12)) += 1
        Next

        Console.WriteLine("Roll of the Dice".PadLeft(40))
        Console.WriteLine(StrDup(80, "-"))

        For i = 2 To UBound(randomNumber)
            Console.Write($"{CStr(i).PadLeft(4)}  |")
        Next
        Console.WriteLine()

        For i = 2 To UBound(randomNumber)
            Console.Write($"{CStr(randomNumber(i)).PadLeft(4)}  |")
        Next

    End Sub

    Function RNG(min As Integer, max As Integer) As Integer
        Dim value As Single
        Randomize()
        value = Rnd()
        value *= max - min
        value += min
        Return CInt(Math.Ceiling(value))
    End Function

End Module
