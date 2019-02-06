using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOnStructAndEnumeration_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите численость заявок от студентов для формирования очередности: ");
            int numberOfApplications = int.Parse(Console.ReadLine());
            Console.WriteLine("\n**********************************************************************\n");

            Student[] student = new Student[numberOfApplications];

            Random random = new Random();

            InitListStudent(numberOfApplications, random, student);

            Array.Sort(student, delegate (Student student1, Student student2)
            {
                return student1.EarningsPerFamily.CompareTo(student2.EarningsPerFamily);
            });

            ShowListStudent(student, numberOfApplications);

            Console.ReadLine();
        }

        static void InitListStudent(int numberOfApplications, Random random, Student[] student)
        {
            char[] oneStudentsName;
            int countSymbolInStName;

            int groupNameCount = 8;
            char[] groupName = new char[groupNameCount];

            for (int i = 0; i < numberOfApplications; i++)
            {
                
                #region Инициализация ФИО

                countSymbolInStName = random.Next(15, 20);
                oneStudentsName = new char[countSymbolInStName];
                for (int j = 0; j < countSymbolInStName; j++)
                {
                    oneStudentsName[j] = Convert.ToChar(random.Next('а', 'я'));

                }

                oneStudentsName[0] = char.ToUpper(oneStudentsName[0]);
                oneStudentsName[6] = ' ';
                oneStudentsName[7] = char.ToUpper(oneStudentsName[0]);

                student[i].FullName = new string(oneStudentsName);

                #endregion

                #region Инициализация названия группы

                for (int j = 0; j < (groupNameCount - 5); j++)
                {
                    groupName[j] = Convert.ToChar(random.Next('A', 'Z'));
                }
                groupName[groupNameCount - 5] = '-';
                for (int j = (groupNameCount - 4); j < groupNameCount - 2; j++)
                {
                    groupName[j] = Convert.ToChar(random.Next('1', '9'));
                }
                groupName[groupNameCount - 2] = '-';
                groupName[groupNameCount - 1] = Convert.ToChar(random.Next('1', '9'));

                student[i].GroupName = new string(groupName);

                #endregion

                #region Информация о средней балле

                student[i].AverageScore = random.Next(0, 13);

                #endregion

                #region Информация о средней зарплате на члена семьи

                student[i].EarningsPerFamily = random.Next(10000, 100000);

                #endregion

                #region Информация о поле студента

                student[i].Gender = (Gender)random.Next(0, 2);

                #endregion

                #region Информация о форме обучения студента

                student[i].Educational = (Educational)random.Next (0, 3);

                #endregion
            }
        }
        static void ShowListStudent(Student[] student, int numberOfApplications)
        {
            for (int i = 0; i < numberOfApplications; i++)
            {
                Console.WriteLine("ФИО: " + student[i].FullName + "\n" +
                "Название учебной группы: " + student[i].GroupName + "\n" +
                "Средний балл:" + student[i].AverageScore + "\n" +
                "Cредний заработок в семье: " + student[i].EarningsPerFamily + "\n" +
                "Пол: " + student[i].Gender + "\n" +
                "Форма обучения: " + student[i].Educational + "\n" +
                "___________________________________\n");
            }
            
        }
    }
}
