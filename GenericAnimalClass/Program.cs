using System;

namespace ALMOSTDONEYAY
{
    public class Animal <A>
    {
        public A field;
        public Animal(A field)
        {
            this.field = field;
        }
        public A getAnimal()
        {
            return field;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal <string> animalName = new ALMOSTDONEYAY.Animal <string> ("ANIMALNAME");
            Animal <string> animalHabitat = new ALMOSTDONEYAY.Animal <string> ("ANIMALHABITAT");
            Animal <bool> endangered = new ALMOSTDONEYAY.Animal <bool> (true);
            Animal <bool> extinct = new ALMOSTDONEYAY.Animal <bool> (true);
            Animal <int> averageLifespan = new ALMOSTDONEYAY.Animal <int> (10);
            // display
            Console.WriteLine(animalName.getAnimal());
            Console.WriteLine(animalHabitat.getAnimal());
            Console.WriteLine(endangered.getAnimal());
            Console.WriteLine(extinct.getAnimal());
            Console.WriteLine(averageLifespan.getAnimal());
        }
    }
}
