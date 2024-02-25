Imports System.Data.SqlClient
Imports RoamLab.BO
Imports RoamLab.Interface
Public Class CategoryDAL
    Implements ICategory
    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand

    Public Function Create(obj As Category) As Integer Implements ICrud(Of Category).Create

        Dim strConn As String = "Server=.\BSISqlExpress;Database=RoamLabRev1;Trusted_Connection=True;"
        Dim conn As New SqlConnection(strConn)

        Dim strSql = "INSERT INTO Category ([Name],[Description]) 
            VALUES (@Name,@Description)"
        cmd = New SqlCommand(strSql, conn)


        cmd.Parameters.AddWithValue("@Name", obj.Name)
        cmd.Parameters.AddWithValue("@Description", obj.Description)


        conn.Open()

        Dim result = cmd.ExecuteNonQuery()
        If result <> 1 Then
            Throw New ArgumentException("Category not created")
        End If

        cmd.Dispose()
        conn.Close()
        Return result
    End Function

    Public Function Update(obj As Category) As Integer Implements ICrud(Of Category).Update
        Dim strConn As String = "Server=.\BSISqlExpress;Database=RoamLabRev1;Trusted_Connection=True;"
        Dim conn As New SqlConnection(strConn)

        Dim strSql = "UPDATE Category
          SET Name = @Name, 
          Description = @Description 
          WHERE CategoryID = @CategoryID"
        cmd = New SqlCommand(strSql, conn)


        cmd.Parameters.AddWithValue("@Name", obj.Name)
        cmd.Parameters.AddWithValue("@Description", obj.Description)
        cmd.Parameters.AddWithValue("@CategoryID", obj.CategoryID)

        conn.Open()

        Dim result = cmd.ExecuteNonQuery()
        If result <> 1 Then
            Throw New ArgumentException("Category not Updated")
        End If

        cmd.Dispose()
        conn.Close()
        Return result
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of Category).Delete
        Dim strConn As String = "Server=.\BSISqlExpress;Database=RoamLabRev1;Trusted_Connection=True;"
        Dim conn As New SqlConnection(strConn)

        Dim strSql = "DELETE FROM Category WHERE CategoryID = @CategoryID;"
        cmd = New SqlCommand(strSql, conn)


        cmd.Parameters.AddWithValue("@CategoryID", id)

        conn.Open()

        Dim result = cmd.ExecuteNonQuery()
        If result <> 1 Then
            Throw New ArgumentException("Category not Deleted")
        End If

        cmd.Dispose()
        conn.Close()
        Return result
    End Function
End Class
