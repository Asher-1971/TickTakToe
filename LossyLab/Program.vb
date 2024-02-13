Imports System

Module Program
    Sub Choices()
        Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\")
        Console.WriteLine("======SELECT YOUR CHOICE===============")
        Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\")
        Console.WriteLine("1. Player vs Player")
        Console.WriteLine("2. Player vs Computer")
        Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\")
        Console.Write("Enter your choice: ")

    End Sub

    Sub Main(args As String())

        Console.WriteLine("WELCOME TO THE TICK-TAC-TOE GAME ")
        Console.WriteLine(" ")

        Call Choices()
        Dim choice As Integer = Console.ReadLine()

        While choice > 2 Or choice < 1
            Console.WriteLine()
            Console.WriteLine("Invalid choice, please try again".ToUpper)
            Call Choices()
            choice = Console.ReadLine()
        End While

        Dim Symbol As String
        Console.WriteLine()
        Console.WriteLine("Choose your symbol [PLAYER 1] (X or O): ")
        Symbol = Console.ReadLine().ToUpper
        While Symbol <> "X" And Symbol <> "O"
            Console.WriteLine("Invalid symbol, please try again".ToUpper)
            Console.WriteLine("Enter your symbol (X or O): ")
            Symbol = Console.ReadLine().ToUpper
        End While

        Dim OppSymbol As String
        If Symbol = "X" Then
            OppSymbol = "O"
        Else
            OppSymbol = "X"
        End If

        If choice = 1 Then
            Console.WriteLine("[PLAYER 2] is given Symbol '{0}' ", OppSymbol)
        ElseIf choice = 2 Then
            Console.WriteLine("[COMPUTER] is given Symbol '{0}' ", OppSymbol)
        End If





        Dim GameData(2, 2) As String
        Dim row, column As Integer




    End Sub
End Module
