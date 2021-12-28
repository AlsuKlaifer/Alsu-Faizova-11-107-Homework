namespace Homework.kontr3
{
    public class KitchenTechnic : Technic, ICloneable
    {
        public bool BuiltIn { get; set; }
        public KitchenTechnic(string name, string country, int power, string energy, bool built) : base(name, country, power, energy)
        {
            BuiltIn = built;
        }
        public void Place()
        {
            Console.WriteLine($"{Name} установлен.");
        }
        public object Clone()
        {
            return new KitchenTechnic(Name = this.Name, Country = this.Country, Power = this.Power, EnergyClass = this.EnergyClass, BuiltIn = this.BuiltIn);
        }
    }
    public static class Extancion
    {
        public static int Repair(this KitchenTechnic tec)
        {
            int price = tec.Power * 3; //просто, чтобы разные стоимости были
            return price;
        }
    }
}
