Imports ConsoleApp1
Imports DAL.ConsoleApp1

Module Program
    Sub Main()
        Dim dal As New OrganizerDal()

        ' Menambahkan data organizer baru '
        dal.AddOrganizer("Foto Studio Bersama Pelix", "john.pelix@example.com", "081234567897")

        ' Menampilkan data menggunakan GetAll() '
        Dim organizers = dal.GetAll()
        For Each organizer In organizers
            Console.WriteLine($"{organizer.organizer_id} lives in {organizer.name}, {organizer.email}, {organizer.phone}")
        Next
    End Sub
End Module

