Imports System.Data.SqlClient
Imports RoamLab.BO
Imports RoamLab.Interface
Public Class RestaurantDAL
    Implements IRestaurant
    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand

    Public Function Create(obj As Restaurant) As Integer Implements ICrud(Of Restaurant).Create
        Throw New NotImplementedException()
    End Function

    Public Function Update(obj As Restaurant) As Integer Implements ICrud(Of Restaurant).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of Restaurant).Delete
        Throw New NotImplementedException()
    End Function
End Class
