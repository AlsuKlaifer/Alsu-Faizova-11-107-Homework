//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Homework.kontr3
//{
//    public class KitchenTechnic: Technic
//    {
//        public bool BuiltIn { get; }
//        public KitchenTechnic(string name, string country, int power, string energy, bool built) : base(name, country, power, energy) 
//        {
//            BuiltIn = built;
//        }
//        public void Place()
//        {
//            Console.WriteLine($"{Name} установлен.");
//        }
//        public void FileWrite()
//        {
//            var file = new StreamWriter(@"C:\Users\79874\Desktop\txt.txt");
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (CatArr[0] != null)
//                    file.WriteLine($"{arr[i].Name} ({arr[i].Country}). Стоимость ремонта: {arr[i].Repair}");
//            }
//            file.Dispose();
//        }
//    }
//    public static class Extancion
//    {
//        public static int Repair(this KitchenTechnic tec)
//        {
//            int price = Technic.Power * 3; //просто, чтобы разные стоимости были
//            return price;
//        }
//    }
//}
