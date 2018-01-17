Module Module1
    'Program Name   FutureValue
    'Programmer Ryan Roque
    'Date:  01/23/2017
    'Description    Determines how much to invest today based on desired future value, rate of return and number of years invested.


    Sub Main()
        'Declarations
        Dim decFutureValue As Decimal = 0
        Dim dblRate As Double = 0
        Dim intYears As Integer = 0
        Dim decPresentValue As Decimal = 0

        'Get input
        Console.Write("What is the desired future amount? ")
        decFutureValue = CDec(Console.ReadLine())
        Console.Write("What is the rate of Return? ")
        dblRate = CDbl(Console.ReadLine())
        Console.Write("How many years will the money be invested? ")
        intYears = CInt(Console.ReadLine())

        'Calculate Present Value
        decPresentValue = CDec(decFutureValue / (1 + dblRate) ^ intYears)

        'Display Present Value
        Console.WriteLine()
        Console.WriteLine("You will need to invest " & decPresentValue)
        Console.WriteLine()

        'Hold Program on the Screen
        Console.Write("Press the enter key to terminate the program. ")
        Console.Read()

    End Sub

End Module
