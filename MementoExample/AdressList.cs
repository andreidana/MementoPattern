using System;
using MementoExample.Memento;

namespace MementoExample
{
    public class AdressList
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }

        public AdressMemento SaveMemento()
        {
            Console.WriteLine("Saving state");
            return new AdressMemento(City, Street, Number);
        }

        public void RestoreMemento(AdressMemento memento)
        {
            Console.WriteLine("Restoring state");
            this.City = memento.City;
            this.Street = memento.Street;
            this.Number = memento.Number;
        }
    }
}