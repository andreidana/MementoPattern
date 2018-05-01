namespace MementoExample.Memento
{
    public class AdressMemento
    {
        public string City { get; set; }
        public int Number { get; set; }
        public string Street { get; set; }

        public AdressMemento(string city, string street, int number)
        {
            City = city;
            Street = street;
            Number = number;
        }
    }
}