# School

The problems to solve about the school database are shown belove : 

Design the database of Kadıköy Anatolian High School.
    The courses in the school have name, code, importance level.
    There are teachers, teachers' name, surname, branch, phone number, has a title.
    There are students, there are students' name, surname, class, tcsi, age
    The class has the name of the class, its capacity and its chairperson (a normal student-type
    variable?) are there are there are.
    Each class has lessons.
    One lesson can be taught by more than one teacher.
    Students can be in one class.
    There are teachers in the classroom.
    Homework is given at school. Assignments have a name, code and due date. An assignment
    can be given to many classes. One teacher prepares the assignment and assigns it to many classes.

As a result a database scheme is designed :

![Bildschirmfoto 2023-02-02 um 15 44 21](https://user-images.githubusercontent.com/120198895/216328544-07ac0c60-d27e-41df-9790-7acacc8c6a98.png)

Codes of the school database :

create table Subject(
Id int primary key GENERATED ALWAYS AS IDENTITY,
SubjectName character varying (50),
SubjectCode character varying(5),
ImportanceFrom1To5 character varying(1)
);
insert into Subject(SubjectName,SubjectCode,ImportanceFrom1To5) values ('Math','10023',5)
insert into Subject(SubjectName,SubjectCode,ImportanceFrom1To5) values ('Physics','10023',4)
insert into Subject(SubjectName,SubjectCode,ImportanceFrom1To5) values ('Biology','10023',2)
insert into Subject(SubjectName,SubjectCode,ImportanceFrom1To5) values ('Literature','10023',3)
insert into Subject(SubjectName,SubjectCode,ImportanceFrom1To5) values ('Philosophy','10023',1)
select * from Subject

create table Teacher(
Id int primary key GENERATED ALWAYS AS IDENTITY,
TeacherName character varying (100),
Surname character varying (100),
Branch character varying(100),
Master character varying(100),
SubjectId int,
FOREIGN KEY (SubjectId) REFERENCES Subject(Id)
);
insert into Teacher(TeacherName,Surname,Branch,Master,SubjectId) values ('Mert','Ünal','Physics','Engineering Physics',2)
insert into Teacher(TeacherName,Surname,Branch,Master,SubjectId) values ('Efe','Taycı','Philosophy','Human Psychology',5)
insert into Teacher(TeacherName,Surname,Branch,Master,SubjectId) values ('Burak','Keskin','Literature','Turkish Literature',4)
insert into Teacher(TeacherName,Surname,Branch,Master,SubjectId) values ('Ege','Perçinel','Biology','Cell Biology',3)
insert into Teacher(TeacherName,Surname,Branch,Master,SubjectId) values ('Efe','Yalçın','Maths','Calculus',1)
select * from Teacher

create table Classroom(
Id int primary key GENERATED ALWAYS AS IDENTITY,
PresidentName character varying (100),
Capacity int
);

insert into Classroom(PresidentName,Capacity) values ('Kerem',120)
insert into Classroom(PresidentName,Capacity) values ('Burak',80)
insert into Classroom(PresidentName,Capacity) values ('Fehmi',100)
insert into Classroom(PresidentName,Capacity) values ('Yasin',75)
insert into Classroom(PresidentName,Capacity) values ('Murat',50)
select * from Classroom

create table TeacherClassroom(
Id int primary key GENERATED ALWAYS AS IDENTITY,
TeacherId int,
ClassroomId int,
FOREIGN KEY (TeacherId) REFERENCES Teacher(Id),
FOREIGN KEY (ClassroomId) REFERENCES Classroom(Id)
);
insert into TeacherClassroom(TeacherId,ClassroomId) values (1,2)
insert into TeacherClassroom(TeacherId,ClassroomId) values (2,4)
insert into TeacherClassroom(TeacherId,ClassroomId) values (5,3)
insert into TeacherClassroom(TeacherId,ClassroomId) values (4,1)
insert into TeacherClassroom(TeacherId,ClassroomId) values (3,5)
select * from TeacherClassroom

create table Homework(
Id int primary key GENERATED ALWAYS AS IDENTITY,
HomeworkCode int,
TeacherId int,
FOREIGN KEY (TeacherId) REFERENCES Teacher(Id)
);
insert into Homework(HomeworkCode,TeacherId) values (105,1)
insert into Homework(HomeworkCode,TeacherId) values (115,2)
insert into Homework(HomeworkCode,TeacherId) values (125,4)
insert into Homework(HomeworkCode,TeacherId) values (135,3)
insert into Homework(HomeworkCode,TeacherId) values (145,5)
select * from Homework

create table HomeworkClassroom(
Id int primary key GENERATED ALWAYS AS IDENTITY,
HomeworkId int,
Deadline date,
ClassroomId int,
FOREIGN KEY (ClassroomId) REFERENCES Classroom(Id),
FOREIGN KEY (HomeworkId) REFERENCES Homework(Id)
);
insert into HomeworkClassroom(HomeworkId,Deadline,ClassroomId) values (1,'2023-09-09',1)
insert into HomeworkClassroom(HomeworkId,Deadline,ClassroomId) values (2,'2023-11-03',3)
insert into HomeworkClassroom(HomeworkId,Deadline,ClassroomId) values (3,'2023-12-12',2)
insert into HomeworkClassroom(HomeworkId,Deadline,ClassroomId) values (4,'2023-12-02',5)
insert into HomeworkClassroom(HomeworkId,Deadline,ClassroomId) values (5,'2023-03-05',4)
select * from Homeworkclassroom

create table SubjectClassroom(
Id int primary key GENERATED ALWAYS AS IDENTITY,
SubjectId int,
ClassroomId int,
FOREIGN KEY (ClassroomId) REFERENCES Classroom(Id),
FOREIGN KEY (SubjectId) REFERENCES Subject(Id)
);
insert into SubjectClassroom(SubjectId,ClassroomId) values (1,1)
insert into SubjectClassroom(SubjectId,ClassroomId) values (3,5)
insert into SubjectClassroom(SubjectId,ClassroomId) values (2,4)
insert into SubjectClassroom(SubjectId,ClassroomId) values (5,3)
insert into SubjectClassroom(SubjectId,ClassroomId) values (4,2)
select * from SubjectClassroom

create table Student(
Id int primary key GENERATED ALWAYS AS IDENTITY,
Age int,
StudentName character varying (100),
Surname character varying (100),
IdentityNumber character varying(11),
ClassroomId int,
FOREIGN KEY (ClassroomId) REFERENCES Classroom(Id)
);
insert into Student(Age,StudentName,Surname,IdentityNumber,ClassroomId) values (27,'Nalan','Dilaver','10548326116',2)
insert into Student(Age,StudentName,Surname,IdentityNumber,ClassroomId) values (31,'Emre','Mor','10615278452',1)
insert into Student(Age,StudentName,Surname,IdentityNumber,ClassroomId) values (40,'Burak','Sönmez','10610545867',4)
insert into Student(Age,StudentName,Surname,IdentityNumber,ClassroomId) values (65,'Mert','Aktaş','10324562056',3)
insert into Student(Age,StudentName,Surname,IdentityNumber,ClassroomId) values (43,'Selim','Sönmez','10610545518',5)
select * from Student

In line with my design, some frequently asked questions by the users :

--Branch and name of the teacher of the student with Name 'Mert'
select TeacherName,Branch from Teacher,Subject,SubjectClassroom,Classroom,Student
where Student.ClassroomId=Classroom.Id
and Classroom.Id=SubjectClassroom.ClassroomId
and SubjectClassroom.SubjectId = Subject.Id
and Subject.Id=Teacher.SubjectId
and StudentName = 'Mert'

--Importance of the homework with code 125
select ImportanceFrom1To5 from Homework,HomeworkClassroom,Classroom,SubjectClassroom,Subject
where Homework.Id=HomeworkClassroom.HomeworkId
and HomeworkClassroom.ClassroomId=Classroom.Id
and Classroom.Id=SubjectClassroom.ClassroomId
and SubjectClassroom.SubjectId = Subject.Id
and HomeworkCode = 125

--master degree and subjectid of the teacher whose classroom capacity 100
select Master,Teacher.SubjectId from Teacher,Subject,SubjectClassroom,Classroom
where Teacher.SubjectId=Subject.Id
and Subject.Id=SubjectClassRoom.SubjectId
and SubjectClassroom.ClassroomId = Classroom.Id
and Capacity = 100

