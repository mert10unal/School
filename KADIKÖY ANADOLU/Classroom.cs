using System;
namespace KADIKÖY_ANADOLU
{
	public class Classroom
	{
		public int Id { get; set; }
		public int Capacity { get; set; }
		public Student President { get; set; }
        public int PresidentId { get; set; }

        public List<Student> Students { get; set; }
        public List<TeacherClassroom> TeacherClassrooms { get; set; }
        public List<HomeworkClassroom> HomeworkClassrooms { get; set; }
        public List<SubjectClassroom> SubjectClassrooms { get; set; }
    }
}

