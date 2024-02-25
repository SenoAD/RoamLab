Imports System.Data.SqlClient
Imports RoamLab.BO
Imports RoamLab.Interface
Public Class BookmarkDAL
    Implements IBookmark
    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand

    Public Function Create(obj As Bookmark) As Integer Implements ICrud(Of Bookmark).Create
        Dim strConn As String = "Server=.\BSISqlExpress;Database=RoamLabRev1;Trusted_Connection=True;"
        Dim conn As New SqlConnection(strConn)

        Dim strSql = "INSERT INTO Bookmark ([PlaceID], [UserID]) 
                        VALUES (@PlaceID, @UserID)"
        cmd = New SqlCommand(strSql, conn)


        cmd.Parameters.AddWithValue("@PlaceID", obj.PlaceID)
        cmd.Parameters.AddWithValue("@UserID", obj.UserID)

        conn.Open()

        Dim result = cmd.ExecuteNonQuery()
        If result <> 1 Then
            Throw New ArgumentException("Bookmark not created")
        End If

        cmd.Dispose()
        conn.Close()
        Return result
    End Function

    Public Function Update(obj As Bookmark) As Integer Implements ICrud(Of Bookmark).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of Bookmark).Delete
        Throw New NotImplementedException()
    End Function
End Class
