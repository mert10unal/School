using System;
namespace KADIKÖY_ANADOLU
{
	public class Teacher
	{
        public int Id { get; set; }
        public double PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Branch { get; set; }
        public string Degree { get; set; }
        public int SubjectId { get; set; }

        public List<TeacherClassroom> TeacherClassRooms { get; set; }
        public List<Homework> Homeworks { get; set; }
        public Subject Subject { get; set; }
    }
}

