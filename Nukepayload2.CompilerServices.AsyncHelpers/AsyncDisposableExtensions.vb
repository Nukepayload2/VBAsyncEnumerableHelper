Option Strict On

Imports System.Runtime.CompilerServices

Public Module AsyncDisposableExtensions
    Public Async Function UsingAsync(Of T As IAsyncDisposable)(
         resource As T, body As Action(Of T)) As Task
        Dim innerEx As Exception = Nothing
        Try
            body(resource)
        Catch ex As Exception
            innerEx = ex
        End Try
        Await resource.DisposeAsync
        If innerEx IsNot Nothing Then Throw innerEx
    End Function

    Public Async Function UsingAsync(Of T1 As IAsyncDisposable, T2 As IAsyncDisposable)(
         resource1 As T1, resource2 As T2, body As Action(Of T1, T2)) As Task
        Dim innerEx As Exception = Nothing
        Try
            body(resource1, resource2)
        Catch ex As Exception
            innerEx = ex
        End Try
        Await Task.WhenAll(resource1.DisposeAsync.AsTask, resource2.DisposeAsync.AsTask)
        If innerEx IsNot Nothing Then Throw innerEx
    End Function

    Public Async Function UsingAsync(Of T1 As IAsyncDisposable, T2 As IAsyncDisposable, T3 As IAsyncDisposable)(
         resource1 As T1, resource2 As T2, resource3 As T3, body As Action(Of T1, T2, T3)) As Task
        Dim innerEx As Exception = Nothing
        Try
            body(resource1, resource2, resource3)
        Catch ex As Exception
            innerEx = ex
        End Try
        Await Task.WhenAll(resource1.DisposeAsync.AsTask, resource2.DisposeAsync.AsTask, resource3.DisposeAsync.AsTask)
        If innerEx IsNot Nothing Then Throw innerEx
    End Function

    Public Async Function UsingAsync(Of T1 As IAsyncDisposable, T2 As IAsyncDisposable, T3 As IAsyncDisposable, T4 As IAsyncDisposable)(
         resource1 As T1, resource2 As T2, resource3 As T3, resource4 As T4, body As Action(Of T1, T2, T3, T4)) As Task
        Dim innerEx As Exception = Nothing
        Try
            body(resource1, resource2, resource3, resource4)
        Catch ex As Exception
            innerEx = ex
        End Try
        Await Task.WhenAll(resource1.DisposeAsync.AsTask, resource2.DisposeAsync.AsTask, resource3.DisposeAsync.AsTask, resource4.DisposeAsync.AsTask)
        If innerEx IsNot Nothing Then Throw innerEx
    End Function

    Public Async Function UsingAsync(Of T1 As IAsyncDisposable, T2 As IAsyncDisposable, T3 As IAsyncDisposable, T4 As IAsyncDisposable, T5 As IAsyncDisposable)(
         resource1 As T1, resource2 As T2, resource3 As T3, resource4 As T4, resource5 As T5, body As Action(Of T1, T2, T3, T4, T5)) As Task
        Dim innerEx As Exception = Nothing
        Try
            body(resource1, resource2, resource3, resource4, resource5)
        Catch ex As Exception
            innerEx = ex
        End Try
        Await Task.WhenAll(resource1.DisposeAsync.AsTask, resource2.DisposeAsync.AsTask, resource3.DisposeAsync.AsTask, resource4.DisposeAsync.AsTask, resource5.DisposeAsync.AsTask)
        If innerEx IsNot Nothing Then Throw innerEx
    End Function

    Public Async Function UsingAsync(Of T1 As IAsyncDisposable, T2 As IAsyncDisposable, T3 As IAsyncDisposable, T4 As IAsyncDisposable, T5 As IAsyncDisposable, T6 As IAsyncDisposable)(
         resource1 As T1, resource2 As T2, resource3 As T3, resource4 As T4, resource5 As T5, resource6 As T6, body As Action(Of T1, T2, T3, T4, T5, T6)) As Task
        Dim innerEx As Exception = Nothing
        Try
            body(resource1, resource2, resource3, resource4, resource5, resource6)
        Catch ex As Exception
            innerEx = ex
        End Try
        Await Task.WhenAll(resource1.DisposeAsync.AsTask, resource2.DisposeAsync.AsTask, resource3.DisposeAsync.AsTask, resource4.DisposeAsync.AsTask, resource5.DisposeAsync.AsTask, resource6.DisposeAsync.AsTask)
        If innerEx IsNot Nothing Then Throw innerEx
    End Function

    Public Async Function UsingAsync(Of T1 As IAsyncDisposable, T2 As IAsyncDisposable, T3 As IAsyncDisposable, T4 As IAsyncDisposable, T5 As IAsyncDisposable, T6 As IAsyncDisposable, T7 As IAsyncDisposable)(
         resource1 As T1, resource2 As T2, resource3 As T3, resource4 As T4, resource5 As T5, resource6 As T6, resource7 As T7, body As Action(Of T1, T2, T3, T4, T5, T6, T7)) As Task
        Dim innerEx As Exception = Nothing
        Try
            body(resource1, resource2, resource3, resource4, resource5, resource6, resource7)
        Catch ex As Exception
            innerEx = ex
        End Try
        Await Task.WhenAll(resource1.DisposeAsync.AsTask, resource2.DisposeAsync.AsTask, resource3.DisposeAsync.AsTask, resource4.DisposeAsync.AsTask, resource5.DisposeAsync.AsTask, resource6.DisposeAsync.AsTask, resource7.DisposeAsync.AsTask)
        If innerEx IsNot Nothing Then Throw innerEx
    End Function

    Public Async Function UsingAsync(Of T1 As IAsyncDisposable, T2 As IAsyncDisposable, T3 As IAsyncDisposable, T4 As IAsyncDisposable, T5 As IAsyncDisposable, T6 As IAsyncDisposable, T7 As IAsyncDisposable, T8 As IAsyncDisposable)(
         resource1 As T1, resource2 As T2, resource3 As T3, resource4 As T4, resource5 As T5, resource6 As T6, resource7 As T7, resource8 As T8, body As Action(Of T1, T2, T3, T4, T5, T6, T7, T8)) As Task
        Dim innerEx As Exception = Nothing
        Try
            body(resource1, resource2, resource3, resource4, resource5, resource6, resource7, resource8)
        Catch ex As Exception
            innerEx = ex
        End Try
        Await Task.WhenAll(resource1.DisposeAsync.AsTask, resource2.DisposeAsync.AsTask, resource3.DisposeAsync.AsTask, resource4.DisposeAsync.AsTask, resource5.DisposeAsync.AsTask, resource6.DisposeAsync.AsTask, resource7.DisposeAsync.AsTask, resource8.DisposeAsync.AsTask)
        If innerEx IsNot Nothing Then Throw innerEx
    End Function

    Public Async Function UsingAsync(Of T1 As IAsyncDisposable, T2 As IAsyncDisposable, T3 As IAsyncDisposable, T4 As IAsyncDisposable, T5 As IAsyncDisposable, T6 As IAsyncDisposable, T7 As IAsyncDisposable, T8 As IAsyncDisposable, T9 As IAsyncDisposable)(
         resource1 As T1, resource2 As T2, resource3 As T3, resource4 As T4, resource5 As T5, resource6 As T6, resource7 As T7, resource8 As T8, resource9 As T9, body As Action(Of T1, T2, T3, T4, T5, T6, T7, T8, T9)) As Task
        Dim innerEx As Exception = Nothing
        Try
            body(resource1, resource2, resource3, resource4, resource5, resource6, resource7, resource8, resource9)
        Catch ex As Exception
            innerEx = ex
        End Try
        Await Task.WhenAll(resource1.DisposeAsync.AsTask, resource2.DisposeAsync.AsTask, resource3.DisposeAsync.AsTask, resource4.DisposeAsync.AsTask, resource5.DisposeAsync.AsTask, resource6.DisposeAsync.AsTask, resource7.DisposeAsync.AsTask, resource8.DisposeAsync.AsTask, resource9.DisposeAsync.AsTask)
        If innerEx IsNot Nothing Then Throw innerEx
    End Function

    Public Async Function UsingAsync(Of T1 As IAsyncDisposable, T2 As IAsyncDisposable, T3 As IAsyncDisposable, T4 As IAsyncDisposable, T5 As IAsyncDisposable, T6 As IAsyncDisposable, T7 As IAsyncDisposable, T8 As IAsyncDisposable, T9 As IAsyncDisposable, T10 As IAsyncDisposable)(
         resource1 As T1, resource2 As T2, resource3 As T3, resource4 As T4, resource5 As T5, resource6 As T6, resource7 As T7, resource8 As T8, resource9 As T9, resource10 As T10, body As Action(Of T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)) As Task
        Dim innerEx As Exception = Nothing
        Try
            body(resource1, resource2, resource3, resource4, resource5, resource6, resource7, resource8, resource9, resource10)
        Catch ex As Exception
            innerEx = ex
        End Try
        Await Task.WhenAll(resource1.DisposeAsync.AsTask, resource2.DisposeAsync.AsTask, resource3.DisposeAsync.AsTask, resource4.DisposeAsync.AsTask, resource5.DisposeAsync.AsTask, resource6.DisposeAsync.AsTask, resource7.DisposeAsync.AsTask, resource8.DisposeAsync.AsTask, resource9.DisposeAsync.AsTask, resource10.DisposeAsync.AsTask)
        If innerEx IsNot Nothing Then Throw innerEx
    End Function

    Private Async Function UseItAsync(n As IAsyncEnumerator(Of String)) As Task
        Await UsingAsync(n,
        Sub(a)

        End Sub)
    End Function

    Private Async Function UseItAsync2(n As IAsyncEnumerator(Of String)) As Task
        Await UsingAsync(n, n,
        Sub(a, a1)

        End Sub)
    End Function

    Private Function TemplateOfThisModule() As String
        Dim codeGen = <code>
                          <%= From n In Enumerable.Range(2, 9)
                              Select $"
    Public Async Function UsingAsync(Of {Aggregate i In Enumerable.Range(1, n) Select $"T{i} As IAsyncDisposable" Into JoinComma})(
         {Aggregate i In Enumerable.Range(1, n) Select $"resource{i} As T{i}" Into JoinComma}, body As Action(Of {Aggregate i In Enumerable.Range(1, n) Select $"T{i}" Into JoinComma})) As Task
        Dim innerEx As Exception = Nothing
        Try
            body({Aggregate i In Enumerable.Range(1, n) Select $"resource{i}" Into JoinComma})
        Catch ex As Exception
            innerEx = ex
        End Try
        Await Task.WhenAll({Aggregate i In Enumerable.Range(1, n) Select $"resource{i}.DisposeAsync.AsTask" Into JoinComma})
        If innerEx IsNot Nothing Then Throw innerEx
    End Function
                                     "
                          %>
                      </code>
        Return codeGen.Value
    End Function

    <Extension>
    Private Function JoinComma(texts As IEnumerable(Of String)) As String
        Return String.Join(", ", texts)
    End Function
End Module
