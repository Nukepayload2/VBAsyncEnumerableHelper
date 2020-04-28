Option Strict On

Imports System.Runtime.CompilerServices
Imports System.Threading

Public Module AsyncEnumerableExtensions

    <Extension>
    Async Function ForEachAsync(Of TItem)(
        asyncEnumerable As IAsyncEnumerable(Of TItem),
        bodySync As Action(Of TItem),
        Optional cancellationToken As CancellationToken = Nothing) As Task

        Dim readerEnumerator = asyncEnumerable.GetAsyncEnumerator(cancellationToken)

        Dim innerEx As Exception = Nothing
        Try
            ' Caution:
            ' Do not use Return in this Try block.
            Do While Await readerEnumerator.MoveNextAsync
                Dim item = readerEnumerator.Current
                bodySync(item)
            Loop
#Disable Warning CA1031 ' Do not catch general exception types
        Catch ex As Exception
            innerEx = ex
#Enable Warning CA1031 ' Do not catch general exception types
        End Try

        Await readerEnumerator.DisposeAsync
        If innerEx IsNot Nothing Then Throw innerEx
    End Function

    <Extension>
    Async Function ForEachAsync(Of TItem)(
        asyncEnumerable As IAsyncEnumerable(Of TItem),
        bodyAsync As Func(Of TItem, Task),
        Optional cancellationToken As CancellationToken = Nothing) As Task

        Dim readerEnumerator = asyncEnumerable.GetAsyncEnumerator(cancellationToken)

        Dim innerEx As Exception = Nothing
        Try
            ' Caution:
            ' Do not use Return in this Try block.
            Do While Await readerEnumerator.MoveNextAsync
                Dim item = readerEnumerator.Current
                Await bodyAsync(item)
            Loop
#Disable Warning CA1031 ' Do not catch general exception types
        Catch ex As Exception
            innerEx = ex
#Enable Warning CA1031 ' Do not catch general exception types
        End Try

        Await readerEnumerator.DisposeAsync
        If innerEx IsNot Nothing Then Throw innerEx
    End Function

End Module
