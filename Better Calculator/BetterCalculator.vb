'Miranda Breves
'RCET0265
'Spring 2022
'Better Calculator
'https://github.com/MEBreves/BetterCalculator

Option Explicit On
Option Strict On

Module BetterCalculatorS

    Sub Main()

        'Declaring variables
        Dim exitCodeTriggered As Boolean = False
        Dim firstIntCleared As Boolean
        Dim secondIntCleared As Boolean
        Dim userInput As String
        Dim firstInt As Integer
        Dim secondInt As Integer
        Dim userOption As String
        Dim optionChosen As Boolean
        Dim operation As String
        Dim result As Integer

        Do

            Console.WriteLine("Please enter two numbers. Enter 'Q' at any time to quit.")
            firstIntCleared = False
            secondIntCleared = False

            'Getting the first integer value for the calculator.
            Do
                Console.Write("Choose a number: ")
                userInput = Console.ReadLine()

                If userInput.ToLower = "q" Then
                    exitCodeTriggered = True
                    Exit Do
                Else
                    Try
                        firstInt = CInt(userInput)
                        firstIntCleared = True
                        Console.WriteLine($"You entered '{userInput}'")
                    Catch ex As Exception
                        Console.WriteLine($"You entered '{userInput}', please enter a whole number.")
                    End Try
                End If

            Loop Until firstIntCleared

            'Checking if the user has quit.
            If exitCodeTriggered Then
                Exit Do
            End If

            'Getting the second integer value for the calculator.
            Do
                Console.Write("Choose a number: ")
                userInput = Console.ReadLine()

                If userInput.ToLower = "q" Then
                    exitCodeTriggered = True
                    Exit Do
                Else
                    Try
                        secondInt = CInt(userInput)
                        secondIntCleared = True
                        Console.WriteLine($"You entered '{userInput}'")
                    Catch ex As Exception
                        Console.WriteLine($"You entered '{userInput}', please enter a whole number.")
                    End Try
                End If

            Loop Until secondIntCleared

            'Checking if the user has quit.
            If exitCodeTriggered Then
                Exit Do
            End If

            'Having the user choose an option
            Do
                Console.WriteLine("Choose one of the following options:")
                Console.WriteLine("1. Add")
                Console.WriteLine("2. Subtract")
                Console.WriteLine("3. Multiply")
                Console.WriteLine("4. Divide")
                userOption = Console.ReadLine()
                Console.WriteLine($"You entered '{userOption}'")

                optionChosen = True

                'Checking if user input for option was valid
                Select Case userOption.ToLower
                    Case "q"
                        exitCodeTriggered = True
                    Case "1"
                        operation = "+"
                        result = firstInt + secondInt
                    Case "2"
                        operation = "-"
                        result = firstInt - secondInt
                    Case "3"
                        operation = "*"
                        result = firstInt * secondInt
                    Case "4"
                        operation = "/"
                        result = CInt(firstInt / secondInt)
                    Case Else
                        optionChosen = False
                End Select

            Loop Until optionChosen

            If exitCodeTriggered Then
                Exit Do
            End If

            Console.WriteLine($"{firstInt} {operation} {secondInt} = {result}")

        Loop Until exitCodeTriggered

        'Giving farewell remarks to the user
        Console.WriteLine("Have a nice day")
        Console.WriteLine("Press enter to close this window")
        Console.ReadLine()

    End Sub

End Module
