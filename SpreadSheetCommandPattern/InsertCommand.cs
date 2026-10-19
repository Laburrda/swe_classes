namespace SpreadSheetCommandPattern
{
    public class Insert : ICommand
    {
        private SpreadSheet _spreadsheet;
        private string _address;
        private int _value;

        public Insert(SpreadSheet spreadsheet, string address, int value)
        {
            this._spreadsheet = spreadsheet;
            this._address = address;
            this._value = value;
        }

        public void Execute()
        {
            this._spreadsheet.Insert(this._address, this._value);
        }
    }
}