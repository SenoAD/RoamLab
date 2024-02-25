Imports System.Data.SqlClient
Imports RoamLab.BO
Imports RoamLab.Interface
Public Class LocationDAL
    Implements ILocation
    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand

    Public Function Create(obj As Location) As Integer Implements ICrud(Of Location).Create
        Throw New NotImplementedException()
    End Function

    Public Function Update(obj As Location) As Integer Implements ICrud(Of Location).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of Location).Delete
        Throw New NotImplementedException()
    End Function
End Class
