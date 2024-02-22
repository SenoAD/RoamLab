Public Interface ICrud(Of T)
    Function Create(ByVal obj As T) As Integer
    Function Update(ByVal obj As T) As Integer
    Function Delete(ByVal id As Integer) As Integer
End Interface