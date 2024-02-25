Imports BSI_info.BO.ConsoleApp1
Imports ConsoleApp1
Imports DAL.ConsoleApp1

Module Program
    Sub Main()
        Dim dal As New OrganizerDal()
        ' Menambahkan data organizer baru '
        Dim newOrganizer As New Organizer()
        newOrganizer.name = "Pelixz"
        newOrganizer.email = "john.pelix@example.com"
        newOrganizer.phone = "081234567897"
        dal.AddOrganizer(newOrganizer.name, newOrganizer.email, newOrganizer.phone)

        ' Menampilkan data menggunakan GetAll() '
        Dim organizers = dal.GetAll()
        For Each org In organizers
            Console.WriteLine($"{org.organizer_id} lives in {org.name}, {org.email}, {org.phone}")
        Next
    End Sub
End Module
