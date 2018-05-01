using System;
using MementoExample.Memento;

namespace MementoExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var addressList = new AdressList
            {
                City = "Bucharest",
                Street = "Calea Victoriei",
                Number = 23
            };

            var memory = new Memory {Memento = addressList.SaveMemento()};

            addressList.City = "New York";
            addressList.Street = "5th Avenue";
            addressList.Number = 1;

            addressList.RestoreMemento(memory.Memento);

            Console.WriteLine($"City - {addressList.City}; Street - {addressList.Street}; Number - {addressList.Number}");
        }
    }
}
