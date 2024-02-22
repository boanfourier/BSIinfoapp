Public Interface ICrud(Of T)
    Function GetAll() As List(Of T)
    Function GetById(id As Integer) As T
    Function Insert(entity As T) As Integer


End Interface
