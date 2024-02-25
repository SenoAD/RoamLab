Imports System.Data.SqlClient
Imports RoamLab.BO
Imports RoamLab.Interface
Public Class VacationPlanDAL
    Implements IVacationPlan
    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand

    Public Function Create(obj As VacationPlan) As Integer Implements ICrud(Of VacationPlan).Create
        Throw New NotImplementedException()
    End Function

    Public Function Update(obj As VacationPlan) As Integer Implements ICrud(Of VacationPlan).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of VacationPlan).Delete
        Throw New NotImplementedException()
    End Function
End Class
