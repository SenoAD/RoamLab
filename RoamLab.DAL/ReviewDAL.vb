Imports System.Data.SqlClient
Imports RoamLab.BO
Imports RoamLab.Interface
Public Class ReviewDAL
    Implements IReview
    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand

    Public Function Create(obj As Review) As Integer Implements ICrud(Of Review).Create
        Throw New NotImplementedException()
    End Function

    Public Function Update(obj As Review) As Integer Implements ICrud(Of Review).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of Review).Delete
        Throw New NotImplementedException()
    End Function
End Class
