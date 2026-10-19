using System;

namespace SpreadSheetCommandPattern
{
    public class Cell: Subject, IObserver
    {
        private string _address;
        private int _value;
        private int _current_value;

        public string Address
        {
            get { return _address; }
        }

        public int Value
        {
            get { return _value; }
            set
            {
                this._value = value;
                if (this._value != this._current_value)
                    Notify();
            }
        }

        public Cell(string address, int value)
        {
            this._address = address;
            this._value = value;
            this._current_value = value;
        }

        protected override void Notify()
        {
           foreach (IObserver observer in this._observerList)
            {
                // Pull
                observer.Update(this);

                // Push
                //observer.Update(this._address, this._value);
            }
        }

        // Pull version
        public void Update(Cell cell)
        {
            string address = cell.Address;
            int value = cell.Value;

            Console.WriteLine("-------------");
            Console.WriteLine("Powiadomienie dla komorki: {0}", this._address);
            Console.WriteLine("Wartosc bierzacej komorki zostaje nadpisana komorka: {0} z wartoscia: {1}", address, value);

            this._value = value;
            Notify();
        }

        // Push version
        //public void Update(string address, int value)
        //{
        //    Console.WriteLine("-------------");
        //    Console.WriteLine("Powiadomienie dla komorki: {0}", this._address);
        //    Console.WriteLine("Wartosc bierzacej komorki zostaje nadpisana komorka: {0} z wartoscia: {1}", address, value);

        //    this._value = value;
        //    Notify();
        //}
    }
}