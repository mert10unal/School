using System;
namespace KADIKÖY_ANADOLU
{
	public class SubjectClassroom
	{
		public int Id { get; set; }
		public int SubjectId { get; set; }
		public int ClassroomId { get; set; }

		public Subject Subject { get; set; }
		public Classroom Classroom { get; set; }
    }
}

