Imports System.Data.SqlClient
Imports RoamLab.BO
Imports RoamLab.Interface
Public Class PlanItemDAL
    Implements IPlanItem
    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand

    Public Function Create(obj As PlanItem) As Integer Implements ICrud(Of PlanItem).Create
        Throw New NotImplementedException()
    End Function

    Public Function Update(obj As PlanItem) As Integer Implements ICrud(Of PlanItem).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of PlanItem).Delete
        Throw New NotImplementedException()
    End Function
End Class
