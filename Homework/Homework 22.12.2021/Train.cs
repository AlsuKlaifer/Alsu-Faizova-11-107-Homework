namespace Homework.Homework_22._12._2021
{
    public struct Train
    {
        public string Destination;
        public int TrainNumber;
        public string DepartureTime;

        public Train(string destination, int trainNumber, string departureTime)
        {
            Destination = destination;
            TrainNumber = trainNumber;
            DepartureTime = departureTime;
        }
        public static Train[] Fulling()
        {
            Console.WriteLine("Enter information about each trip.");
            Train[] array = new Train[8];
            for (int i = 0; i < 8; i++)
            {
                var str = Console.ReadLine().Split(' ');
                array[i] = new Train(str[0], Check(str[1]), str[2]);
            }
            Console.WriteLine(array.Length);
            return array;
        }
        static int Check(string str)
        {
            int number = 0;
            while (!Int32.TryParse(str, out number))
            {
                Console.WriteLine("Invalid value, enter new value.");
                str = Console.ReadLine();
            }
            return number;
        }
        public int CompareTo(object? o)
        {
            var obj = (Train)o;
            if (o == null) return -1;
            if (o != null)
            {
                if (obj.TrainNumber < TrainNumber) return 1;
                else if (obj.TrainNumber > TrainNumber) return -1;
                else return 0;
            }
            throw new Exception("Unnable to compare objects");
        }
        public static void Displaying(Train[] array, string number)
        {
            int count = 0;
            foreach (Train train in array)
            {
                if (train.TrainNumber == Check(number))
                {
                    Print(train);
                    count++;
                }
            }
            if (count == 0) Console.WriteLine("There are no trains with this number.");
        }
        public static void Print(Train train)
        {
            Console.WriteLine($"Number of train: {train.TrainNumber}. Destination: {train.Destination}. Time: {train.DepartureTime}.");
        }
        public static void Print(Train[] array)
        {
            foreach (Train train in array) Print(train);
        }
    }
}