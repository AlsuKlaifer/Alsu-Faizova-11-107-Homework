namespace Homework.Homework_22._12._2021
{
    public class TextFile
    {
        public static void ReturnTime()
        {
            File.WriteAllText(@"C:\Text1.txt", $"{DateTime.Now}");
            File.WriteAllText(@"C:\Text2.txt", $"{DateTime.Now}");
            File.WriteAllText(@"C:\Text3.txt", $"{DateTime.Now}");
            var array = Directory.GetFiles(@"C:\");
            var maximum = array[0];
            foreach (var member in array)
            {
                if (File.GetLastWriteTime(maximum) < File.GetLastWriteTime(member))
                    maximum = member;
            }
            Console.WriteLine(File.GetLastWriteTime(maximum));
        }
    }
}
