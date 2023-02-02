using System;
namespace KADIKÖY_ANADOLU
{
	public class Subject
	{
		public int Id { get; set; }
		public string Name { get; set; }
        public int SubjectCode { get; set; }
		public string Significance { get; set; }

		public List<SubjectClassroom> SubjectClassrooms { get; set; }
		public List<Teacher> Teachers { get; set; }

    }
}

