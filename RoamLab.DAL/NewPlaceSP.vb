Imports System.Data.SqlClient
Imports RoamLab.BO
Imports RoamLab.DAL
Imports RoamLab.Interface


Public Class NewPlaceSP
    Implements IPlace
    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand

    Public Sub New()
        Dim strConn As String = "Server=.\BSISqlExpress;Database=RoamLab;Trusted_Connection=True;"
        Dim conn As New SqlConnection(strConn)
    End Sub

    Public Function NewRow(obj As Place) As Object Implements IPlace.NewRow
        Try
            Dim strSql = "dbo.NewPlaceSP"
            Dim strConn As String = "Server=.\BSISqlExpress;Database=RoamLab;Trusted_Connection=True;"
            Dim conn As New SqlConnection(strConn)
            cmd = New SqlCommand(strSql, conn)


            cmd.CommandType = Data.CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Name", obj.Name)
            cmd.Parameters.AddWithValue("@CategoryID", obj.CategoryID)
            cmd.Parameters.AddWithValue("@MinimalCost", obj.MinimalCost)
            cmd.Parameters.AddWithValue("@MaximalCost", obj.MaximalCost)
            cmd.Parameters.AddWithValue("@AverageCost", obj.AverageCost)
            cmd.Parameters.AddWithValue("@ActiveHour", "10:00:00.0000000")
            cmd.Parameters.AddWithValue("@EndHour", "18:00:00.0000000")
            cmd.Parameters.AddWithValue("@Description", obj.Description)

            conn.Open()

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class