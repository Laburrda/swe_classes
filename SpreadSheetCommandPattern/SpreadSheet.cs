using System;
using System.Collections.Generic;

namespace SpreadSheetCommandPattern
{
    public class SpreadSheet: Subject, IObserver
    {
        protected Stack<Dictionary<string, object>> _commandStack = new Stack<Dictionary<string, object>>();

        public string Address
        {
            get {  return string.Empty; }
        }

        public int Value
        {
            get { return 0;  }
            set { throw new NotImplementedException("SpreadSheet does not have any 'Value'.");  }
        }

        public void Insert(string address, int value)
        {
            foreach (Cell cell in this._observerList)
            {
                if (cell.Address == address)
                {
                    _commandStack.Push(new Dictionary<string, object>
                    {
                        {"Address", cell.Address},
                        {"Value", value},
                        {"Overwritten", cell.Value}
                    });

                    cell.Value = value;
                }
            }
        }

        public void Redo()
        {
            try
            {
                Dictionary<string, object> lastcCommand = _commandStack.Pop();
                foreach (Cell cell in this._observerList)
                {
                    if (cell.Address == (string)lastcCommand["Address"])
                    {
                        cell.Value = (int)lastcCommand["Overwritten"];
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        protected override void Notify()
        {
            throw new NotImplementedException("SpreadSheet does not need to notify any object");
        }

        // Pull
        public void Update(Cell cell)
        {
            throw new NotImplementedException("SpreadSheet does not need to update any object");
        }

        // Push
        //public void Update(string address, int value)
        //{
        //    throw new NotImplementedException("SpreadSheet does not need to update any object");
        //}
    }
}
