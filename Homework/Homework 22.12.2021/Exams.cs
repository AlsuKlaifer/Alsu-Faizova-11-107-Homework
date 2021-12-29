using System;
using System.IO;

namespace Homework.Homework_22._12._2021
{
    public struct Exam
    {
        public static void DatesOfExams(string s)
        {
            string[] file = File.ReadAllLines(s);
            string[][] arr = new string[file.Length][];
            for (int i = 0; i < file.Length; i++)
                arr[i] = file[i].Split(' ');

            Console.WriteLine($"Сдавать 2 экзамена в один день вредно для здоровья. Возможно следующее расписание экзаменов:");

            for (int i = 1; i < file.Length -1; i++)
            {
                if (arr[i-1][1] != arr[i][1] && arr[i - 1][1] != arr[i+1][1] && arr[i][1] != arr[i+1][1])
                    Console.WriteLine($"Даты экзаменов:\n{arr[i-1][0]} {arr[i-1][1]} \n{arr[i][0]} {arr[i][1]} \n{arr[i+1][0]} {arr[i+1][1]}");   
            }
        }
    }
}
