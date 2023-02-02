using System;
namespace KADIKÖY_ANADOLU
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Grade { get; set; }
		public string IdentityNumber { get; set; }
		public int Age { get; set; }
		public int ClassroomId { get; set; }

        public Classroom Classroom { get; set; }
		

    }
}

