Imports System.Threading

Friend Class RangeAsyncEnumerable
    Implements IAsyncEnumerable(Of Integer)

    Private ReadOnly _fromInclusive As Integer
    Private ReadOnly _toInclusive As Integer
    Private ReadOnly _step As Integer
    Private ReadOnly _delayPerReturn As Integer

    Public Sub New(fromInclusive As Integer,
                   toInclusive As Integer,
                   [step] As Integer,
                   delayPerReturn As Integer)
        _fromInclusive = fromInclusive
        _toInclusive = toInclusive
        _step = [step]
        _delayPerReturn = delayPerReturn
    End Sub

    Public Function GetAsyncEnumerator(Optional cancellationToken As CancellationToken = Nothing) As IAsyncEnumerator(Of Integer) Implements IAsyncEnumerable(Of Integer).GetAsyncEnumerator
        Return New RangeAsyncEnumerator(_fromInclusive, _toInclusive, _step, _delayPerReturn, cancellationToken)
    End Function

    Private Class RangeAsyncEnumerator
        Implements IAsyncEnumerator(Of Integer)

        Private ReadOnly _fromInclusive As Integer
        Private ReadOnly _toInclusive As Integer
        Private ReadOnly _step As Integer = 1
        Private ReadOnly _delayPerReturn As Integer
        Private ReadOnly _cancellationToken As CancellationToken

        Private _current As Integer
        Private _started As Boolean

        Public Sub New(fromInclusive As Integer,
                   toInclusive As Integer,
                   [step] As Integer,
                   delayPerReturn As Integer,
                   cancellationToken As CancellationToken)
            _fromInclusive = fromInclusive
            _toInclusive = toInclusive
            _delayPerReturn = delayPerReturn
            _cancellationToken = cancellationToken
            _step = [step]
        End Sub

        Public ReadOnly Property Current As Integer Implements IAsyncEnumerator(Of Integer).Current
            Get
                If Not _started Then
                    Throw New InvalidOperationException
                End If
                Return _current
            End Get
        End Property

        Public Function MoveNextAsync() As ValueTask(Of Boolean) Implements IAsyncEnumerator(Of Integer).MoveNextAsync
            Return New ValueTask(Of Boolean)(MoveNextAsyncInternal)
        End Function

        Private Async Function MoveNextAsyncInternal() As Task(Of Boolean)
            Await Task.Delay(_delayPerReturn, _cancellationToken)
            _cancellationToken.ThrowIfCancellationRequested()
            Dim nextValue As Integer
            If _started Then
                nextValue = _current + _step
            Else
                nextValue = _fromInclusive
            End If
            If nextValue > _toInclusive Then
                Return False
            End If
            _started = True
            _current = nextValue
            Return True
        End Function

        Public Function DisposeAsync() As ValueTask Implements IAsyncDisposable.DisposeAsync
            Return New ValueTask(DisposeInternalAsync())
        End Function

        Private Async Function DisposeInternalAsync() As Task
            Console.WriteLine("Disposing.")
            Await Task.Delay(100)
            Console.WriteLine("Disposed.")
        End Function
    End Class

End Class
