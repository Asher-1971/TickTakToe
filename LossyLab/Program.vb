Imports System
Imports System.Data.Common

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

    Dim Symbol As String
    Dim OppSymbol As String
    Dim choice As Integer
    Dim row, column As Integer
    Dim GameData(,) As String = New String(2, 2) {{"-", "-", "-"}, {"-", "-", "-"}, {"-", "-", "-"}}


    Sub Main(args As String())

        Console.WriteLine("WELCOME TO THE TICK-TAC-TOE GAME ")
        Console.WriteLine(" ")

        Call Choices()
        choice = Console.ReadLine()

        While choice > 2 Or choice < 1
            Console.WriteLine()
            Console.WriteLine("Invalid choice, please try again".ToUpper)
            Call Choices()
            choice = Console.ReadLine()
        End While


        Console.WriteLine()
        Console.WriteLine("Choose your symbol [PLAYER 1] (X or O): ")
        Symbol = Console.ReadLine().ToUpper
        While Symbol <> "X" And Symbol <> "O"
            Console.WriteLine("Invalid symbol, please try again".ToUpper)
            Console.WriteLine("Enter your symbol (X or O): ")
            Symbol = Console.ReadLine().ToUpper
        End While


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

        Console.WriteLine("THE GAME STARTS NOW")


        Select Case choice
            Case 1
                Call UserInput()


            Case 2
                    Console.WriteLine("FEATURE COMING SOON")

        End Select
    End Sub


    Sub UserInput()
        For gamecount = 1 To 9
            Console.WriteLine(" ")
            Console.WriteLine("TOSSING A COIN FOR 1ST TURN")
            Dim rand As New Random()
            Dim number As Integer = rand.Next(1, 3)

            If number = 1 Then
                Dim playerturn() As Integer = {1, 2, 1, 2, 1, 2, 1, 2, 1}
                Console.WriteLine("its [PLAYER 1]s turn 1st")
            End If


            If number = 2 Then
                Dim playerturn() As Integer = {2, 1, 2, 1, 2, 1, 2, 1, 2}
                Console.WriteLine("its [PLAYER 2]s turn 1st")
            End If


            Console.WriteLine("Enter the position you want to enter your symbol [{0}] :", symbol)
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

            GameData(row - 1, column - 1) = symbol

            For count = 0 To 2
                For count2 = 0 To 2
                    Console.Write(GameData(count, count2) & vbTab)
                Next
                Console.WriteLine()
            Next

        Next
    End Sub
End Module
