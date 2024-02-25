Imports System.Data.SqlClient
Imports RoamLab.BO
Imports RoamLab.Interface
Public Class UserDAL
    Implements IUser
    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand

    Public Function Create(obj As User) As Integer Implements ICrud(Of User).Create
        Throw New NotImplementedException()
    End Function

    Public Function Update(obj As User) As Integer Implements ICrud(Of User).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of User).Delete
        Throw New NotImplementedException()
    End Function
End Class
