//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Homework.kontr3
{
    public abstract class Technic
    {
        public readonly string Name;
        public readonly string Country;
        public int Power { get; }
        public string EnergyClass { get; }

        public Technic(string name, string country, int power, string energy)
        {
            Name = name;
            Country = country;
            Power = power;
            EnergyClass = energy;
        }
        public override int GetHashCode()
        {
            int hashcode = Name.GetHashCode();
            hashcode = 31 * hashcode + Country.GetHashCode();
            return hashcode;
        }
        public override bool Equals(object t)
        {
            if (!(t is Technic))
                throw new Exception("not a technic");
            var a = t as Technic;
            if (a.Name != Name || a.Country != Country || a.Power != Power || a.EnergyClass != EnergyClass)
                return false;
            else
                return true;
        }
        public override string ToString()
        {
            return $"Название техники: {Name}" +
                $"Страна производителя: {Country}" +
                $"Мощность: {Power}" +
                $"Класс Энергосбережения {EnergyClass}";
        }
    }
}
