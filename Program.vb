'https://gameinternals.com/understanding-pac-man-ghost-behavior may be my saviour

Imports System
Imports System.Threading

Module Program
    Structure SquareData
        Public x As Integer
        Public y As Integer
        Public isWall As Boolean
        Public isBigDot As Boolean
        Public isSmallDot As Boolean
    End Structure
    Public squares As New List(Of SquareData)
    Sub Main(args As String())
        Dim grid() As Integer = {27, 30} 'i counted this manually
        GenerateGrid(grid)
        PlaceGrid()
    End Sub
    Sub GenerateGrid(grid() As Integer)
        'im gonna kms if i decide to make the grids random
        Dim tempSquareData As New SquareData
        For i = 0 To grid(0)
            tempSquareData.x = i * 2
            tempSquareData.y = 0
            tempSquareData.isSmallDot = True
            squares.Add(tempSquareData)
        Next
    End Sub
    Sub PlaceGrid()
        For i = 0 To squares.Count - 1
            Console.SetCursorPosition(squares(i).x, squares(i).y)
            If squares(i).isWall Then
                Console.BackgroundColor = ConsoleColor.Blue
            ElseIf squares(i).isBigDot Then
                Console.BackgroundColor = ConsoleColor.Magenta
            ElseIf squares(i).isSmallDot Then
                Console.BackgroundColor = ConsoleColor.White
                Console.Write("()")
            End If

            Console.BackgroundColor = ConsoleColor.Blue
            Console.Write("  ")
            Console.ResetColor()
        Next
    End Sub
End Module

