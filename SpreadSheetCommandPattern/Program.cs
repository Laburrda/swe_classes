// See https://aka.ms/new-console-template for more information

using SpreadSheetCommandPattern;

SpreadSheet spreadsheet = new SpreadSheet();
Engine engine = new Engine();

Cell a1 = new Cell("A1", 0);
Cell b1 = new Cell("B1", 3);
Cell c1 = new Cell("C1", 3);

spreadsheet.Attach(a1);
spreadsheet.Attach(b1);
spreadsheet.Attach(c1);

a1.Attach(c1);
Console.WriteLine("Cell C1 observs cell A1.");

Insert insert12 = new Insert(spreadsheet, "B1", 12);
Redo redo = new Redo(spreadsheet);

Console.WriteLine("The value of {0} cell is {1}", b1.Address, b1.Value);
Console.ReadKey();


engine.PlaceCommand(insert12);
engine.ExecuteAllCommands();

Console.WriteLine("The value of {0} cell after insert command is {1}", b1.Address, b1.Value);
Console.ReadKey();

engine.PlaceCommand(redo);
engine.ExecuteAllCommands();

Console.WriteLine("The redo command restored {0} to its previous value {1}", b1.Address, b1.Value);
Console.ReadKey();

Insert insert23 = new Insert(spreadsheet, "A1", 23);
engine.PlaceCommand(insert23);
engine.ExecuteAllCommands();

Console.WriteLine("Cell {0}  has new value {1}, and because cell {2} observs that {0} has the same value {3}", a1.Address, a1.Value, c1.Address, c1.Value);
Console.ReadKey();
