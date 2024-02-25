Imports System.Data.SqlClient
Imports RoamLab.BO
Imports RoamLab.Interface
Public Class BudgetDAL
    Implements IBudget
    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand

    Public Function Create(obj As Budget) As Integer Implements ICrud(Of Budget).Create
        Dim strConn As String = "Server=.\BSISqlExpress;Database=RoamLabRev1;Trusted_Connection=True;"
        Dim conn As New SqlConnection(strConn)

        Dim strSql = "INSERT INTO Budget ([PlanID], [Category], [Amount], [Currency]) 
                        VALUES (@PlanID, @Category, @Amount, @Currency)";

        cmd = New SqlCommand(strSql, conn)


        cmd.Parameters.AddWithValue("@PlanID", obj.PlanID)
        cmd.Parameters.AddWithValue("@Category", obj.Category)
        cmd.Parameters.AddWithValue("@Amount", obj.Amount)
        cmd.Parameters.AddWithValue("@Currency", obj.Currency)

        conn.Open()

        Dim result = cmd.ExecuteNonQuery()
        If result <> 1 Then
            Throw New ArgumentException("Budget not created")
        End If

        cmd.Dispose()
        conn.Close()
        Return result
    End Function

    Public Function Update(obj As Budget) As Integer Implements ICrud(Of Budget).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of Budget).Delete
        Throw New NotImplementedException()
    End Function
End Class
