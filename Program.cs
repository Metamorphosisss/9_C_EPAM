using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_C__EPAM
{
    internal class Program
    {
        /*
         - Напишіть клас Automobile (Автомобіль) з полями «Назва» та «Максимальна швидкість» автомобіля. Додайте до класу необхідні методи, конструктори та властивості.
        Зробити колекцію об'єктів типу Automobile (типізований список List). Додати до колекції кілька різних об'єктів типу Automobile. 
        Вивести на екран інформацію про усі автомобілі в колекції. Вивести на екран назву автомобіля, який має найвищу максимальну швидкість.
         */
        static void Main(string[] args)
        {
            List<Automobile> cars = [new Automobile("Toyota", 150), new Automobile("BMW", 200), new Automobile("Skoda", 100)];
            
            foreach (Automobile car in cars)
            {
                Console.WriteLine($"Машина {car.Name} має швидкiсть {car.MaxSpeed}");
            }
            static Automobile FindFastestcar(List<Automobile> array)
            {
                Automobile max = array[0];
                foreach (Automobile car in array)
                {
                    if (car.MaxSpeed >= max.MaxSpeed)
                    {
                        max = car;
                    }
                }
                return max;
            }
            Automobile a = FindFastestcar(cars);
            Console.WriteLine("Найшвидша машина " + a.Name + " зi швидкiстю " + a.MaxSpeed);
        }
    }
}
