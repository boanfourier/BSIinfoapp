Imports BSI_info.BO.ConsoleApp1

Public Interface ITasks
    Function GetTasks() As List(Of Tasks)
    Sub InsertTask(task As Tasks)


End Interface
