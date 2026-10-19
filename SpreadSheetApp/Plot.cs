using System;
using System.Linq;

namespace SpreadSheetApp.ObserverPattern
{
    public class Plot : IObserver
    {
        private string _name;

        public Plot(string name)
        {
            _name = name;
        }

        // Pull
        //public void Update(Cell cell)
        //{
        //    string address = cell.Address;
        //    int value = cell.Value;
        //    string concated = String.Concat(Enumerable.Repeat("+", value));

        //    Console.WriteLine("-------------");
        //    Console.WriteLine("Powiadomienie dla wykresu: {0}, informujacego o komorce {1}", this._name, address);
        //    Console.WriteLine("{0}: {1}", this._name, concated);

        //}

        // Push
        public void Update(string address, int value)
        {
            string concated = String.Concat(Enumerable.Repeat("+", value));

            Console.WriteLine("-------------");
            Console.WriteLine("Powiadomienie dla wykresu: {0}, informujacego o komorce {1}", this._name, address);
            Console.WriteLine("{0}: {1}", this._name, concated);

        }
}
}
