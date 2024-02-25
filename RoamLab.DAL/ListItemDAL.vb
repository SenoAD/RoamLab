Imports System.Data.SqlClient
Imports RoamLab.BO
Imports RoamLab.Interface
Public Class ListItemDAL
    Implements IListItem
    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand

    Public Function Create(obj As ListItem) As Integer Implements ICrud(Of ListItem).Create
        Throw New NotImplementedException()
    End Function

    Public Function Update(obj As ListItem) As Integer Implements ICrud(Of ListItem).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of ListItem).Delete
        Throw New NotImplementedException()
    End Function
End Class
