using System.Collections.Generic;

namespace SpreadSheetApp.ObserverPattern
{
    public abstract class Subject
    {
        protected List<IObserver> _observerList = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            if (!this._observerList.Contains(observer))
                this._observerList.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            if (this._observerList.Contains(observer))
                this._observerList.Remove(observer);
        }

        abstract protected void Notify();
    }
}