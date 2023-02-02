using System;
namespace KADIKÖY_ANADOLU
{
	public class HomeworkClassroom
	{
        public int Id { get; set; }
        public DateTime Deadline { get; set; }
        public int HomeworkId { get; set; }
        public int ClassroomId { get; set; }

        public Classroom Classroom { get; set; }
        public Homework Homework { get; set; }
    }
}

