using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp23
{
    //number1
    //public struct Stuff
    //{

    //    public string firstName;
    //    public string lastName;
    //    public int salary;
    //    public DateTime workStartDate;


    //}

    //number2
    struct Student
    {

        public string FullName { get; set; }
        public string GroupName { get; set; }
        public double AvgMark { get; set; }
        public int IncomePerFamilyMember { get; set; }
        public int GenderSave { get; set; }
        public int StudyFormSave { get; set; }
        public enum Gender
        {
            Male = 1,
            Female = 2
        }
        public enum StudyForm
        {
            Intramural = 1,
            Correspondence = 2
        }
    }
    class Program
    {
        //const int ZERO = 0, THREE = 3;

        //static void Main(string[] args)
        //{


        //        int size = ZERO;
        //        bool isPars;
        //        string firstName, lastName;
        //        int salary;
        //        DateTime workStartDate;

        //        Stuff clerk = new Stuff();

        //        WriteLine("Введите количество сотрудников:");
        //        isPars = int.TryParse(ReadLine(), out size);

        //        if (isPars == false)
        //        {
        //            WriteLine("Не коректный ввод");
        //            Environment.Exit(ZERO);
        //        }
        //        else
        //        {

        //            List<Stuff> managers = new List<Stuff>();
        //            List<Stuff> clerks = new List<Stuff>();

        //            for (int i = ZERO; i < size; i++)
        //            {
        //                WriteLine("\nВведите фамилию сотрудника:");
        //                lastName = ReadLine();

        //                WriteLine("\nВведите имя сотрудника:");
        //                firstName = ReadLine();

        //                WriteLine("\nВведите зарплату сотрудника:");
        //                isPars = int.TryParse(ReadLine(), out salary);

        //                WriteLine("\nВведите дату трудоустройства сотрудника:");
        //                isPars = DateTime.TryParse(ReadLine(), out workStartDate);

        //                clerk.firstName = firstName;
        //                clerk.lastName = lastName;
        //                clerk.salary = salary;
        //                clerk.workStartDate = workStartDate;

        //                clerks.Add(clerk);
        //            }


        //            Stuff boss = new Stuff();

        //            WriteLine("\nВведите фамилию босс:");
        //            lastName = ReadLine();

        //            WriteLine("\nВведите имя босс:");
        //            firstName = ReadLine();

        //            WriteLine("\nВведите зарплату босс:");
        //            isPars = int.TryParse(ReadLine(), out salary);

        //            WriteLine("\nВведите дату трудоустройства босс:");
        //            isPars = DateTime.TryParse(ReadLine(), out workStartDate);

        //            boss.firstName = firstName;
        //            boss.lastName = lastName;
        //            boss.salary = salary;
        //            boss.workStartDate = workStartDate;

        //            WriteLine("\nВывод всего персонала.");
        //            ShowAllStaff(managers, clerks, boss);

        //            WriteLine("\nВывод всех мэнэджеров.");
        //            FindManager(managers, clerks);

        //            WriteLine("\nВывод всего персонала после прихода босса.");
        //            FindAfterBoss(clerks, boss);

        //            ReadKey();
        //        }
        //    ReadKey();
        //}
        //    static void ShowAllStaff(List<Stuff> managers, List<Stuff> clerks, Stuff boss)
        //    {

        //        for (int i = 0; i < clerks.Count; i++)
        //        {
        //            WriteLine(i + ".");
        //            WriteLine("Имя сотрудника:" + clerks[i].firstName);
        //            WriteLine("Фамилия сотрудника:" + clerks[i].lastName);
        //            WriteLine("Зарплата:" + clerks[i].salary);
        //            WriteLine("Дата трудоустройства:" + clerks[i].workStartDate + "\n");
        //        }


        //        WriteLine("\n\n\n");

        //        WriteLine("Имя босса:" + boss.firstName);
        //        WriteLine("Фамилия босса:" + boss.lastName);
        //        WriteLine("Зарплата:" + boss.salary);
        //        WriteLine("Дата трудоустройства:" + boss.workStartDate + "\n");
        //    }

        //    static void FindManager(List<Stuff> managers, List<Stuff> clerks)
        //    {
        //        Stuff manager = new Stuff();

        //        int avgSalary = 0, salarySum = 0;

        //        for (int i = 0; i < clerks.Count; i++)
        //        {
        //            salarySum += clerks[i].salary;
        //        }

        //        avgSalary = salarySum / clerks.Count;

        //        for (int i = 0; i < clerks.Count; i++)
        //        {
        //            if (avgSalary < clerks[i].salary)
        //            {
        //                manager.firstName = clerks[i].firstName;
        //                manager.lastName = clerks[i].lastName;
        //                manager.salary = clerks[i].salary;
        //                manager.workStartDate = clerks[i].workStartDate;

        //                managers.Add(manager);
        //            }
        //        }
        //        var sortedUsers = managers.OrderBy(u => u.lastName);

        //        WriteLine("\n\n\n");

        //        foreach (Stuff sortedManager in sortedUsers)
        //        {
        //            WriteLine("Имя мэнеджера:" + sortedManager.firstName);
        //            WriteLine("Фамилия мэнеджера:" + sortedManager.lastName);
        //            WriteLine("Зарплата:" + sortedManager.salary);
        //            WriteLine("Дата трудоустройства:" + sortedManager.workStartDate + "\n");
        //        }

        //    }
        //    static void FindAfterBoss(List<Stuff> clerks, Stuff boss)
        //    {
        //        List<Stuff> stuffAfter = new List<Stuff>();
        //        Stuff clerk = new Stuff();

        //        for (int i = 0; i < clerks.Count; i++)
        //        {
        //            if (boss.workStartDate < clerks[i].workStartDate)
        //            {
        //                clerk.firstName = clerks[i].firstName;
        //                clerk.lastName = clerks[i].lastName;
        //                clerk.salary = clerks[i].salary;
        //                clerk.workStartDate = clerks[i].workStartDate;

        //                stuffAfter.Add(clerk);
        //            }
        //        }
        //        var sortedUsers = stuffAfter.OrderBy(u => u.lastName);

        //        WriteLine("\n\n\n");

        //        foreach (Stuff sortedClerk in sortedUsers)
        //        {
        //            WriteLine("Имя сотрудника:" + sortedClerk.firstName);
        //            WriteLine("Фамилия сотрудника:" + sortedClerk.lastName);
        //            WriteLine("Зарплата:" + sortedClerk.salary);
        //            WriteLine("Дата трудоустройства:" + sortedClerk.workStartDate + "\n");
        //        }

        //    }
        const int ZERO = 0, ONE = 1, THREE = 3, minimumSalaryInKazahstan = 56568;

        static void Main(string[] args)
        {

            ConsoleKey button;
            int count = ONE, incomePerFamilyMember;
            bool isPars, isContinue = true;
            string fullName, groupName;
            double avgMark;

            List<Student> students = new List<Student>();
            Student student = new Student();

            Student.Gender gender = new Student.Gender();
            Student.StudyForm studyForm = new Student.StudyForm();

            while (isContinue == true)
            {

                WriteLine("\nВведите полное имя студента:");
                fullName = ReadLine();

                WriteLine("\nВведите группу студента:");
                groupName = ReadLine();

                WriteLine("\nВведите средний балл:");
                isPars = double.TryParse(ReadLine(), out avgMark);

                WriteLine("\nВведите зарплату на члена семьй:\n");
                isPars = int.TryParse(ReadLine(), out incomePerFamilyMember);


                WriteLine("\nНажимите 1 если вы мужчина, 2 если женщина:\n");
                button = ReadKey().Key;

                if (button == ConsoleKey.D1)
                {
                    gender = Student.Gender.Male;
                }
                else if (button == ConsoleKey.D2)
                {
                    gender = Student.Gender.Female;
                }
                else
                {
                    WriteLine("Не коректный ввод");
                    Environment.Exit(ZERO);
                    ReadKey();
                }

                WriteLine("\nНажимите 1 если вы на очной форме обучение, 2 если на заочной:\n");
                button = ReadKey().Key;

                if (button == ConsoleKey.D1)
                {
                    studyForm = Student.StudyForm.Intramural;
                }
                else if (button == ConsoleKey.D2)
                {
                    studyForm = Student.StudyForm.Correspondence;
                }
                else
                {
                    WriteLine("Не корекнтый ввод");
                    Environment.Exit(ZERO);
                    ReadKey();
                }



                student.FullName = fullName;
                student.GroupName = groupName;
                student.AvgMark = avgMark;
                student.IncomePerFamilyMember = incomePerFamilyMember;
                student.GenderSave = (int)gender;
                student.StudyFormSave = (int)studyForm;


                students.Add(student);

                WriteLine("\nНажимите ESC если хотите прекратить ввод данных, если хотите продолжить нажимите на любую кнопку");
                button = ReadKey().Key;

                if (button == ConsoleKey.Escape)
                {
                    isContinue = false;
                }
                else
                {
                    isContinue = true;
                }

                Clear();

            }

            WriteLine("Полный вывод информаций.");
            foreach (Student i in students)
            {
                WriteLine("\n" + count + ".Полное имя студента: " + i.FullName);
                WriteLine("  Группа студента: " + i.GroupName);
                WriteLine("  Средний балл студента:" + i.AvgMark);
                WriteLine("  Зарплата на члена семьй: " + i.IncomePerFamilyMember);
                WriteLine("  Пол студента: " + i.GenderSave);
                WriteLine("  Форма обучение студента:" + i.StudyFormSave);
                count++;
            }
            List<Student> minSalaryStudents = new List<Student>();
            List<Student> avgSortStudents = new List<Student>();

            foreach (Student i in students)
            {
                if (i.IncomePerFamilyMember < minimumSalaryInKazahstan)
                {
                    minSalaryStudents.Add(i);
                }
                else
                {
                    avgSortStudents.Add(i);
                }
            }
            var sortedStudents = avgSortStudents.OrderBy(u => u.AvgMark);

            count = ONE;

            WriteLine("\nВывод студентов, меньше минимального дохода на члена семьи, для выдачи комнаты.");
            foreach (Student i in minSalaryStudents)
            {
                WriteLine("\n" + count + ".Полное имя студента: " + i.FullName);
                WriteLine("  Группа студента: " + i.GroupName);
                WriteLine("  Средний балл студента:" + i.AvgMark);
                WriteLine("  Зарплата на члена семьй: " + i.IncomePerFamilyMember);
                WriteLine("  Пол студента: " + i.GenderSave);
                WriteLine("  Форма обучение студента:" + i.StudyFormSave);
                count++;
            }

            WriteLine("\nВывод студентов, с высокими баллами, для выдачи комнаты");
            foreach (Student i in minSalaryStudents)
            {
                WriteLine("\n" + count + ".Полное имя студента: " + i.FullName);
                WriteLine("  Группа студента: " + i.GroupName);
                WriteLine("  Средний балл студента:" + i.AvgMark);
                WriteLine("  Зарплата на члена семьй: " + i.IncomePerFamilyMember);
                WriteLine("  Пол студента: " + i.GenderSave);
                WriteLine("  Форма обучение студента:" + i.StudyFormSave);
                count++;
            }
            ReadKey();
        }
    }
}
