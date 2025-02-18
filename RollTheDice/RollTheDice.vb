'Jason Permann
'Spring 2025
'RCET2265
'Roll The Dice
'https://github.com/JaceFoxman/RollTheDice.git
Imports System.Text.RegularExpressions

Module RollTheDice

    Sub Main()

    End Sub

    Function RNG(min As Integer, max As Integer) As Integer
        Dim value As Single
        Randomize()
        value = Rnd()
        value *= max - min
        value -= min
        Return CInt(Math.Ceiling(value))
    End Function

End Module
