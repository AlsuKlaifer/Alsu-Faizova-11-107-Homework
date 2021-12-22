namespace Homework.Homework_22._12._2021
{
    public struct Aeroflot: IComparable
    {
        public string Destination;
        public int FlightNumber;
        public string TypeOfPlane;
        public Aeroflot(string destination, int flightNumber, string type)
        {
            Destination = destination;
            FlightNumber = flightNumber;
            TypeOfPlane = type;
        }
        public static Aeroflot[] Fulling()
        {
            Console.WriteLine("Enter information about each fligth.");
            Aeroflot[] array = new Aeroflot[7];
            for (int i = 0; i < 7; i++)
            {
                var str = Console.ReadLine().Split(' ');
                array[i] = new Aeroflot(str[0], Check(str[1]), str[2]);
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
            var obj = (Aeroflot)o;
            if (o == null) return -1;
            if (o!= null)
            {
                if (obj.FlightNumber < FlightNumber) return 1;
                else if (obj.FlightNumber > FlightNumber) return -1;
                else return 0;
            }
            throw new Exception("Unnable to compare objects");
        }
        public static void Displaying(Aeroflot[] array, string destination)
        {
            int count = 0;
            foreach (Aeroflot plane in array)
            {
                if (plane.Destination == destination)
                {
                    Print(plane);
                    count++;
                }
            }
            if (count == 0) Console.WriteLine("There are no flights in this destination");
        }
        public static void Print(Aeroflot plane)
        {
            Console.WriteLine($"Destinathion: {plane.Destination}. Flight number: {plane.FlightNumber}. Type of plane: {plane.TypeOfPlane}");
        }
        public static void Print(Aeroflot[] array)
        {
            foreach (Aeroflot plane in array) Print(plane);
        }
    }
}