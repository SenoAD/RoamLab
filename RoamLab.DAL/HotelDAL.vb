Imports System.Data.SqlClient
Imports RoamLab.BO
Imports RoamLab.Interface
Public Class HotelDAL
    Implements IHotel
    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand

    Public Function Create(obj As Hotel) As Integer Implements ICrud(Of Hotel).Create
        Dim strConn As String = "Server=.\BSISqlExpress;Database=RoamLabRev1;Trusted_Connection=True;"
        Dim conn As New SqlConnection(strConn)

        Dim strSql = "INSERT INTO Hotel (PlaceID, Facilitation) 
VALUES (@PlaceID, @Facilitation)"

cmd = New SqlCommand(strSql, conn)

        cmd.Parameters.AddWithValue("@PlaceID", obj.PlaceID)
        cmd.Parameters.AddWithValue("@Facilitation", obj.Facilitation)


        conn.Open()

        Dim result = cmd.ExecuteNonQuery()
        If result <> 1 Then
            Throw New ArgumentException("not created")
        End If

        cmd.Dispose()
        conn.Close()
        Return result
    End Function

    Public Function Update(obj As Hotel) As Integer Implements ICrud(Of Hotel).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of Hotel).Delete
        Throw New NotImplementedException()
    End Function
End Class
