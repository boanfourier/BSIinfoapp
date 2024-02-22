Imports System.Transactions
Imports BSI_info.BO
Imports BSI_info.BO.ConsoleApp1

Public Interface IOrganizer

    Inherits ICrud(Of Transaction)
    Function GetByUserID(userID As Integer) As List(Of Organizers)

End Interface
