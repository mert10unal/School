using System;
namespace KADIKÖY_ANADOLU
{
	public class TeacherClassroom
	{
		public int Id { get; set; }
		public int TeacherId { get; set; }
		public int ClassId { get; set; }

		public Teacher Teacher { get; set; }
		public Classroom Classroom { get; set; }

    }
}

