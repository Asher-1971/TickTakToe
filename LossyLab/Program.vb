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

        Console.WriteLine("THE GAME STARTS NOW")
        Console.WriteLine(" ")
        Console.WriteLine("Enter the position you want to enter your symbol [{0}] :", Symbol)
        Console.Write("Enter the row (1-3): ")
        row = Console.ReadLine()
        While row > 3 Or row < 1
            Console.WriteLine("Invalid row, please try again".ToUpper)
            Console.Write("Enter the row (1-3): ")
            row = Console.ReadLine()
        End While

        Console.Write("Enter the column (1-3): ")
        column = Console.ReadLine()
        While column > 3 Or column < 1
            Console.WriteLine("Invalid row, please try again".ToUpper)
            Console.Write("Enter the column (1-3): ")
            column = Console.ReadLine()
        End While


        GameData(row - 1, column - 1) = Symbol


    End Sub
End Module
