namespace SpreadSheetCommandPattern
{
    public class Redo: ICommand
    {
        private SpreadSheet _spreadsheet;

        public Redo(SpreadSheet spreadsheet)
        {
            this._spreadsheet = spreadsheet;
        }

        public void Execute()
        {
            this._spreadsheet.Redo();
        }
    }
}