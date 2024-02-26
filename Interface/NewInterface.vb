Imports BSI_info.BO.ConsoleApp1
Public Interface NewInterface
    Sub AddOrganizer(ByVal organizer As Organizer)
    Function GetAllOrganizer() As List(Of Organizer)
End Interface
