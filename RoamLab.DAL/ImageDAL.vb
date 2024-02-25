Imports System.Data.SqlClient
Imports RoamLab.BO
Imports RoamLab.Interface
Public Class ImageDAL
    Implements IImage
    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand

    Public Function Create(obj As Image) As Integer Implements ICrud(Of Image).Create
        Throw New NotImplementedException()
    End Function

    Public Function Update(obj As Image) As Integer Implements ICrud(Of Image).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of Image).Delete
        Throw New NotImplementedException()
    End Function
End Class
