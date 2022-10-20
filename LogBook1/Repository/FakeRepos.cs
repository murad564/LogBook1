using LogBookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBookApp.Repository
{
    public class FakeRepos
    {
        static public List<Student> GetStudents()
        {
            return new()
            {
                new Student(1, "download0.jfif", "Taleh", "Meherremov", "Akif", new DateTime(2022, 10, 3), ParticipationStatus.Unknown, null, null, null, null),
                new Student(2, "download1.png", "Murad", "Meherremli", "Yusif", new DateTime(2022, 10, 4), ParticipationStatus.Absent, null, null, null, null),
                new Student(3, "download2.png", "Cavid", "Ferecov", "Hikmet", new DateTime(2022, 10, 4), ParticipationStatus.Present, null, null, null, null),
                new Student(4, "download3.jfif", "Sefer", "Ceferov", "Beyler", new DateTime(2022, 10, 4), ParticipationStatus.Present, null, null, null, null)
            };
        }
    }
}