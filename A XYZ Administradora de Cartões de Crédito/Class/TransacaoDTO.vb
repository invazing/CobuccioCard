Public Class TransacaoDTO

    Private _idTransacao As Long
    Private _numeroCartao As String
    Private _valorTransacao As Decimal
    Private _dataTransacao As DateTime
    Private _descricao As String
    Private _statusTransacao As String


    Public Property IdTransacao As Long
        Get
            Return _idTransacao
        End Get
        Set(value As Long)
            _idTransacao = value
        End Set
    End Property


    Public Property NumeroCartao As String
        Get
            Return _numeroCartao
        End Get
        Set(value As String)
            _numeroCartao = If(value IsNot Nothing, value.Trim(), String.Empty)
        End Set
    End Property


    Public Property ValorTransacao As Decimal
        Get
            Return _valorTransacao
        End Get
        Set(value As Decimal)
            _valorTransacao = value
        End Set
    End Property


    Public Property DataTransacao As DateTime
        Get
            Return _dataTransacao
        End Get
        Set(value As DateTime)
            _dataTransacao = value
        End Set
    End Property


    Public Property Descricao As String
        Get
            Return _descricao
        End Get
        Set(value As String)
            _descricao = If(value IsNot Nothing, value.Trim(), String.Empty)
        End Set
    End Property


    Public Property StatusTransacao As String
        Get
            Return _statusTransacao
        End Get
        Set(value As String)
            _statusTransacao = If(value IsNot Nothing, value.Trim(), String.Empty)
        End Set
    End Property
End Class
