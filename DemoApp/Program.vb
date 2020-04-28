Imports Nukepayload2.CompilerServices.AsyncHelpers

Module Program
    Sub Main()
        MainAsync.GetAwaiter.GetResult()
    End Sub

    Private Async Function MainAsync() As Task
        Dim oneTo5 As New RangeAsyncEnumerable(1, 5, 1, 100)

        Console.WriteLine("Demo 1: Print 1 to 5 step 1 delay 100ms.")
        Await oneTo5.ForEachAsync(
        Sub(item)
            Console.WriteLine(item)
        End Sub)

        Console.WriteLine()
        Console.WriteLine("Demo 2: Print 1 to 5 step 1 delay 100ms and async loop body.")
        Await oneTo5.ForEachAsync(
        Async Function(item)
            Console.Write("Printing ")
            Await Task.Delay(100)
            Console.WriteLine(item)
        End Function)

        Console.WriteLine()
        Console.WriteLine("Demo 3: Print exception immediately.")
        Try
            Await oneTo5.ForEachAsync(
            Sub(item)
                Throw New Exception
            End Sub)
            Console.WriteLine("Error: The exception was lost.")
        Catch ex As Exception
            Console.WriteLine("Catch: " & ex.Message)
        End Try

        Console.WriteLine()
        Console.WriteLine("Demo 4: If number = 4 then throw exception.")
        Try
            Await oneTo5.ForEachAsync(
            Sub(item)
                If item = 4 Then
                    Throw New Exception
                End If
                Console.WriteLine(item)
            End Sub)
            Console.WriteLine("Error: The exception was lost.")
        Catch ex As Exception
            Console.WriteLine("Catch: " & ex.Message)
        End Try

        Console.WriteLine()
        Console.WriteLine("Demo 5: If number = 3 then throw exception after 500ms.")
        Try
            Await oneTo5.ForEachAsync(
            Async Function(item)
                If item = 3 Then
                    Console.WriteLine("Waiting.")
                    Await Task.Delay(500)
                    Console.WriteLine("Throw.")
                    Throw New Exception
                End If
                Console.WriteLine(item)
            End Function)
            Console.WriteLine("Error: The exception was lost.")
        Catch ex As Exception
            Console.WriteLine("Catch: " & ex.Message)
        End Try
    End Function

End Module
