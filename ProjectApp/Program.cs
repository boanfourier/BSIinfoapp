// See https://aka.ms/new-console-template for more information

using ProjectApp;

OrganizerDal dal = new OrganizerDal();
var organizerz = dal.GetAll();
foreach (var organizer in organizerz)
{
    Console.WriteLine($"{organizer.organizer_id} lives in {organizer.name}, {organizer.email},{organizer.phone}");
}