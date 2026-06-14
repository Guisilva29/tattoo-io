
Public Class Conexao
    Public Shared Function GetConnection() As String
        Return "Server=(localdb)\MSSQLLocalDB;Database=tattoo_io;Integrated Security=True;"
    End Function
End Class