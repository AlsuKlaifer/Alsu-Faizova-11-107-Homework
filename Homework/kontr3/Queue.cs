namespace Homework.kontr3
{
    public class Queue : ICloneable
    {
        private KitchenTechnic[] arr { get; set; }
        private int index;
        public Queue()
        {
            arr = new KitchenTechnic[1];
            index = 0;
        }
        public Queue(KitchenTechnic[] kitArr)
        {
            arr = kitArr;
            index = kitArr.Length;
        }
        public void Add(KitchenTechnic tec)
        {
            KitchenTechnic[] newArr = new KitchenTechnic[arr.Length + 1];
            for (int i = 0; i < index; i++)
                newArr[i] = arr[i];
            arr = newArr;
            arr[index] = tec;
            index++;
        }
        public Technic Read()
        {
            KitchenTechnic tecout = arr[0];
            KitchenTechnic[] tecArr = new KitchenTechnic[index - 1];
            for (int i = 1; i < index; i++)
            {
                tecArr[i - 1] = arr[i];
            }
            arr = tecArr;
            index--;
            return tecout;
        }
        public void Print()
        {
            for (int i = 0; i < index; i++)
                Console.WriteLine(arr[i].Name);
        }
        public object Clone()
        {
            return new Queue(arr = this.arr);
        }
        public void FileWrite()
        {
            var file = new StreamWriter(@"C:\Users\Asus\Desktop\txt.txt");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[0] != null)
                    file.WriteLine($"{arr[i].Name} ({arr[i].Country}). Стоимость ремонта: {Extancion.Repair(arr[i])}");
            }
            file.Dispose();
        }
    }
}

