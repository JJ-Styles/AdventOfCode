Imports System.IO
Module Module1
    Sub Main()
        Dim file As String
        Dim Command() As String
        Dim Direction As Integer
        Dim distance As Integer
        Dim FileReader As StreamReader = New StreamReader("AdventOfCode1a.txt")
        file = FileReader.ReadToEnd
        Command = file.Split(",")
        For i = 0 To (Command.Length - 1)
            If Mid(Command(i), 1, 1) = "R" Then
                Direction += 90
                distance += Mid(Command(i), 2, (Command(i).Length - 1))
            Else
                Direction -= 90
                distance -= Mid(Command(i), 2, (Command(i).Length - 1))
            End If
        Next
        If Direction > 360 Or Direction < 0 Then
            Direction -= 360
        End If
        Console.WriteLine(Direction)
        Console.WriteLine(distance)
        Console.ReadKey()
    End Sub

End Module
