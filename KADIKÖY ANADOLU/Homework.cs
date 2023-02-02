using System;
namespace KADIKÖY_ANADOLU
{
	public class Homework
	{
		public int Id { get; set; }
		public int HomeworkCode { get; set; }
		public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }
		public List<HomeworkClassroom> HomeworkClassrooms { get; set; }

    }
}

