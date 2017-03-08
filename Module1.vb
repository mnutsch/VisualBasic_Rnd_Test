'***********************************************************************************
' Name: VisualBasicRandomTest
' Author: Matt Nutsch
' Date: 3-7-2017
' Description:
' This program will generate x number of random values. 
' It will then display a count of how many of each value was generated.
' The goal is to test whether Visual Basic's Rnd() function.
'***********************************************************************************

Imports System
Module Module1

    Function randomNumber(MaxValue As Integer)

        ' Generate random value between 1 and 10. 
        Dim value As Integer = CInt(Int((MaxValue * Rnd()) + 1))

        'tell us what value was generated
        'Console.WriteLine(value)

        'return the value
        Return value

    End Function

    Public Function outputArray(ByVal argArray() As Integer, MaxValue As Integer) As Integer

        'loop through the array
        For index As Integer = 1 To MaxValue
            Console.WriteLine(index & ": " & argArray(index))
        Next

        Return 1
    End Function

    Sub Main()

        'constant
        Const maximumValue = 10

        'variable to read user input
        Dim userInput As Integer

        'array of numbers to store random numbers
        Dim numberArray(maximumValue) As Integer

        'integer to keep track of the loop
        Dim loopCounter As Integer
        loopCounter = 0

        'variable to temporarily hold a value
        Dim tempValue As Integer

        ' Initialize the random-number generator.
        Randomize()

        'Tell the user what is happening
        Console.WriteLine("This program will generate x many random numbers,")
        Console.WriteLine("where x is the value input by the user.")
        Console.WriteLine() 'blank line

        'prompt the user
        Console.Write("Enter a number: ")

        'read an int from the user
        userInput = Console.ReadLine()
        Console.WriteLine() 'blank line

        'Console.Write("The user input was: ")
        'Console.WriteLine(userInput)
        'Console.WriteLine() 'blank line

        'This is a comment in VB
        Console.WriteLine("Generating random numbers...")

        'loop and generate random numbers
        For index As Integer = 1 To userInput
            tempValue = randomNumber(maximumValue)
            numberArray(tempValue) = numberArray(tempValue) + 1
            loopCounter = index
        Next
        Console.WriteLine() 'blank line

        'Console.Write("We generated ")
        'Console.Write(loopCounter)
        'Console.Write(" random numbers.")
        'Console.WriteLine() 'blank line

        Console.WriteLine("These are the counts of how many times each number was randomly generated.")
        outputArray(numberArray, maximumValue)

    End Sub

End Module
