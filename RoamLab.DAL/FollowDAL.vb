Imports System.Data.SqlClient
Imports RoamLab.BO
Imports RoamLab.Interface
Public Class FollowDAL
    Implements IFollow
    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand

    Public Function Create(obj As Follow) As Integer Implements ICrud(Of Follow).Create
        Dim strConn As String = "Server=.\BSISqlExpress;Database=RoamLabRev1;Trusted_Connection=True;"
        Dim conn As New SqlConnection(strConn)

        Dim strSql = "INSERT INTO Follow ([FollowerID], [FollowedUserID]) 
VALUES (@FollowerID, @FollowedUserID)"
        cmd = New SqlCommand(strSql, conn)

        cmd.Parameters.AddWithValue("@FollowerID", obj.FollowerID);
cmd.Parameters.AddWithValue("@FollowedUserID", obj.FollowedUserID);



        conn.Open()

        Dim result = cmd.ExecuteNonQuery()
        If result <> 1 Then
            Throw New ArgumentException("Follow not created")
        End If

        cmd.Dispose()
        conn.Close()
        Return result
    End Function

    Public Function Update(obj As Follow) As Integer Implements ICrud(Of Follow).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of Follow).Delete
        Throw New NotImplementedException()
    End Function
End Class
