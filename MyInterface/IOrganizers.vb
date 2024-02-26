
Imports BSI_info.BO.ConsoleApp1
Namespace ConsoleApp1
    Public Interface IOrganizers
        Sub AddOrganizer(ByVal organizer As Organizer)
        Function GetAllOrganizer() As List(Of Organizer)

    End Interface
End Namespace