Imports System.Data.SqlClient
Imports RoamLab.BO
Imports RoamLab.Interface


Public Class PlaceDAL
    Implements IPlace
    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand

    Public Function Create(obj As Place) As Integer Implements ICrud(Of Place).Create
        Try
            Dim strSql = "dbo.NewPlaceSP"
            Dim strConn As String = "Server=.\BSISqlExpress;Database=RoamLabRev1;Trusted_Connection=True;"
            Dim conn As New SqlConnection(strConn)
            cmd = New SqlCommand(strSql, conn)


            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Name", obj.Name)
            cmd.Parameters.AddWithValue("@Description", obj.Description)
            cmd.Parameters.AddWithValue("@Address", obj.Address)
            cmd.Parameters.AddWithValue("@PhoneNumber", obj.PhoneNumber)
            cmd.Parameters.AddWithValue("@Website", obj.Website)
            cmd.Parameters.AddWithValue("@LocationID", obj.LocationID)
            cmd.Parameters.AddWithValue("@CategoryID", obj.CategoryID)


            conn.Open()

            Dim result = cmd.ExecuteNonQuery()
            If result <> 1 Then
                Throw New ArgumentException("Place not created")
            End If

            cmd.Dispose()
            conn.Close()
            Return result
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Update(obj As Place) As Integer Implements ICrud(Of Place).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of Place).Delete
        Throw New NotImplementedException()
    End Function
End Class