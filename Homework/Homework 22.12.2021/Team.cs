using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Homework_22._12._2021
{
    public struct Team : IComparable
    {
        public string Name;
        public DateTime Date;
        public int Points { get; set; }

        public Team(string name, DateTime date, int points)
        {
            Name = name;
            Date = date;
            Points = points;
        }
        public static Team[] ReadFromFile(string str)
        {
            string[] lines = File.ReadAllLines(str);
            List<Team> list = new List<Team>();
            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line)) continue;
                var currentline = line.Split(' ');
                if (currentline.Length != 3) continue;
                var date = currentline[1].Split('.');
                list.Add(new Team(currentline[0], new DateTime(ToInt(date[0]), ToInt(date[1]), ToInt(date[2]), ToInt(date[3]), ToInt(date[4]), 0), ToInt(currentline[2])));
                int ToInt(string line)
                {
                    return Int32.Parse(line);
                }
            }
            return list.ToArray();
        }
        public static void DisplayWinner(DateTime date1, DateTime date2, Team[] array)
        {
            var list = array.ToList();
            if (date1 > date2)
            {
                (date1, date2) = (date2, date1);
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Date < date1 || list[i].Date > date2)
                {
                    list.Remove(list[i]);
                }
            }
            list.Sort();
            Console.WriteLine(list[0].Name); //наиболее успешная команда в заданном периоде
        }
        public static Team[] Sort(Team[] matches)
        {
            Team temp;
            for (int i = 0; i < matches.Length - 1; i++)
            {
                for (int j = i + 1; j < matches.Length; j++)
                {
                    if (matches[i].Points > matches[j].Points)
                    {
                        temp = matches[i];
                        matches[i] = matches[j];
                        matches[j] = temp;
                    }
                }
            }
            return matches;
        }
        public int CompareTo(object? obj)
        {
            var obje = (Team)obj;
            if (obj == null) return -1;
            if (obj != null)
            {
                if (obje.Points < Points) return -1;
                else if (obje.Points > Points) return 1;
                else return 0;
            }
            throw new Exception("Unnable to compare objects");
        }
    }
}