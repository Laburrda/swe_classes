namespace SpreadSheetApp.ObserverPattern
{
    public interface IObserver
    {
        // Pull version
        //void Update(Cell cell);

        // Push version
        void Update(string address, int value);
    }
}