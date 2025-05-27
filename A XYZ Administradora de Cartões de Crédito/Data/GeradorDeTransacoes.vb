Imports System.Data.SqlClient

Module GeradorDeTransacoes

    ' Lista de descrições possíveis para as transações, simulando categorias reais.
    Dim descricoes() As String = {
        "CINEMA", "UBER", "SORVETERIA", "RESTAURANTE", "GASOLINA", "LOJA ONLINE", "ACADEMIA", "SUPERMERCADO", "FARMÁCIA", "FAST FOOD",
        "PIZZARIA", "PEDÁGIO", "ESTACIONAMENTO", "LOJA DE ROUPAS", "BAR", "ASSINATURA STREAMING", "PARQUE", "CARTÃO TRANSPORTE",
        "POSTO DE GASOLINA", "DELIVERY", "SALÃO DE BELEZA", "PET SHOP", "LIVRARIA", "JOGOS ONLINE", "VIAGEM", "HOTEL", "PASSAGEM AÉREA",
        "ALUGUEL DE CARRO", "TAXI", "CAFETERIA", "CONVENIÊNCIA", "ELETRODOMÉSTICOS", "ELETRÔNICOS", "LOJA DE CALÇADOS", "SHOW", "TEATRO"
    }

    ' Possíveis status que uma transação pode ter.
    Dim status() As String = {"Aprovada", "Pendente", "Cancelada"}

    ' Gera uma quantidade (padrão 1000) de transações aleatórias e insere no banco.
    ' Cada transação tem número de cartão, valor, data, descrição e status gerados aleatoriamente.
    Public Sub GerarTransacoes(Optional quantidade As Integer = 1000)
        Using conn As New SqlConnection(Connection.ConnectionString)
            conn.Open()
            For i = 1 To quantidade
                ' Gera dados aleatórios para a transação
                Dim numeroCartao As String = GerarNumeroCartao()
                Dim valor As Decimal = GerarValor()
                Dim dataTransacao As DateTime = GerarData2025()
                Dim descricao As String = descricoes(New Random().Next(descricoes.Length))
                Dim statusTransacao As String = status(New Random().Next(status.Length))

                ' Comando SQL para inserir a transação
                Dim cmdText As String = "INSERT INTO Transacoes (Numero_Cartao, Valor_Transacao, Data_Transacao, Descricao, Status_Transacao) " &
                                        "VALUES (@NumeroCartao, @Valor, @Data, @Descricao, @Status)"

                Using cmd As New SqlCommand(cmdText, conn)
                    cmd.Parameters.AddWithValue("@NumeroCartao", numeroCartao)
                    cmd.Parameters.AddWithValue("@Valor", valor)
                    cmd.Parameters.AddWithValue("@Data", dataTransacao)
                    cmd.Parameters.AddWithValue("@Descricao", descricao)
                    cmd.Parameters.AddWithValue("@Status", statusTransacao)
                    cmd.ExecuteNonQuery()
                End Using
            Next
        End Using
    End Sub

    ' Gera um número de cartão de crédito aleatório com 16 dígitos.
    Function GerarNumeroCartao() As String
        Dim rnd As New Random()
        Dim numero As String = ""
        For i As Integer = 1 To 16
            numero &= rnd.Next(0, 10).ToString()
        Next
        Return numero
    End Function

    ' Gera um valor decimal aleatório entre R$ 10,00 e R$ 5.000,00.
    Function GerarValor() As Decimal
        Dim rnd As New Random()
        Return Math.Round(CDec(rnd.Next(1000, 500000)) / 100, 2) ' De 10,00 a 5000,00
    End Function

    ' Gera uma data aleatória dentro do ano de 2025, com hora, minuto e segundo.
    Function GerarData2025() As DateTime
        Dim rnd As New Random()
        Dim ano As Integer = 2025
        Dim mes As Integer = rnd.Next(1, 13)
        Dim dia As Integer = rnd.Next(1, DateTime.DaysInMonth(ano, mes) + 1)
        Dim hora As Integer = rnd.Next(0, 24)
        Dim minuto As Integer = rnd.Next(0, 60)
        Dim segundo As Integer = rnd.Next(0, 60)
        Return New DateTime(ano, mes, dia, hora, minuto, segundo)
    End Function

End Module
