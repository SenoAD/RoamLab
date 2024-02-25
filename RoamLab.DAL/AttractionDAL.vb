Imports System.Data.SqlClient
Imports RoamLab.BO
Imports RoamLab.Interface
Public Class AttractionDAL
    Implements IAttraction
    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand

    Public Function Create(obj As Attraction) As Integer Implements ICrud(Of Attraction).Create
        Dim strConn As String = "Server=.\BSISqlExpress;Database=RoamLabRev1;Trusted_Connection=True;"
        Dim conn As New SqlConnection(strConn)

        Dim strSql = "INSERT INTO Attraction ([PlaceID],[Type],[OpeningHours],[AdmissionFee]) 
            VALUES (@PlaceID, @Type, @OpeningHours, @AdmissionFee)"
        cmd = New SqlCommand(strSql, conn)


        cmd.Parameters.AddWithValue("@PlaceID", obj.PlaceID)
        cmd.Parameters.AddWithValue("@Type", obj.Type)
        cmd.Parameters.AddWithValue("@OpeningHours", obj.OpeningHours)
        cmd.Parameters.AddWithValue("@AdmissionFee", obj.AdmissionFee)

        conn.Open()

        Dim result = cmd.ExecuteNonQuery()
        If result <> 1 Then
            Throw New ArgumentException("Attraction not created")
        End If

        cmd.Dispose()
        conn.Close()
        Return result
    End Function

    Public Function Update(obj As Attraction) As Integer Implements ICrud(Of Attraction).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of Attraction).Delete
        Throw New NotImplementedException()
    End Function
End Class
