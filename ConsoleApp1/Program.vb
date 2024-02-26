Imports BSI_info.BO.ConsoleApp1
Imports ConsoleApp1
Imports DAL.ConsoleApp1
Imports [Interface]

Module Program
    Sub Main()
        Dim dal As New OrganizerDal()
        ' Menambahkan data organizer baru '
        Dim newOrganizer As New Organizer()
        newOrganizer.name = "Pelixz"
        newOrganizer.email = "john.pelix@example.com"
        newOrganizer.phone = "081234567897"
        dal.AddOrganizer(newOrganizer)

        ' Menampilkan data menggunakan GetAll() '
        Dim organizers = dal.GetAll()
        For Each org In organizers
            Console.WriteLine($"{org.organizer_id} lives in {org.name}, {org.email}, {org.phone}")
        Next

        ' Create an instance of TasksDAL
        Dim tasksDAL As ITasks = New TasksDal()
        ' Example: Get tasks from the database
        Dim tasksList As List(Of Tasks) = tasksDAL.GetTasks()
        Console.WriteLine("Tasks in the database:")
        For Each task As Tasks In tasksList
            Console.WriteLine($"Task ID: {task.task_id}, Event ID: {task.event_id}, Description: {task.description}, Deadline: {task.deadline}, Status: {task.status}")
        Next

        ' Example: Insert a new task into the database
        Dim newTask As New Tasks() With {
            .event_id = 5,
            .description = "New Task",
            .deadline = DateTime.Now.AddDays(7),
            .status = "Pending"
        }
        tasksDAL.InsertTask(newTask)
        Console.WriteLine("New task inserted into the database.")
        Console.ReadLine()
    End Sub

End Module
