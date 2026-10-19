namespace SpreadSheetCommandPattern
{
    public interface IObserver
    {
        string Address { get; }
        int Value { get; set; }

        // Pull version
        void Update(Cell cell);

        // Push version
        //void Update(string address, int value);
    }
}