Imports System.Data.SqlClient
Imports RoamLab.BO
Imports RoamLab.Interface
Public Class RecommendedPlanListDAL
    Implements IRecommendedPlaceList
    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand

    Public Function Create(obj As RecommendePlaceLIst) As Integer Implements ICrud(Of RecommendePlaceLIst).Create
        Throw New NotImplementedException()
    End Function

    Public Function Update(obj As RecommendePlaceLIst) As Integer Implements ICrud(Of RecommendePlaceLIst).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of RecommendePlaceLIst).Delete
        Throw New NotImplementedException()
    End Function
End Class
