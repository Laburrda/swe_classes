# Software Engineering Coursework (AGH)

Solutions to assignments from the Software Engineering course (M.Sc., Computer Science and Econometrics, AGH University of Kraków):
design patterns (Observer, Command) and unit testing in C# with xUnit.

**Stack:** C# · .NET 6 / .NET 8 · xUnit · Moq

Each assignment is a small, self-contained exercise on one topic, not one large application.

## Contents

| Folder | Topic | Origin |
|---|---|---|
| `SpreadSheetApp` | Observer pattern, *push* model, observers cooperating: cells observe other cells (changes propagate along the chain) and `Plot` objects draw cell values | My solution |
| `SpreadSheetCommandPattern` | Command pattern: `Engine` (invoker) executes `Insert` and `Redo` commands on a `SpreadSheet` (receiver); a stack stores overwritten values; combined with cell observers | My solution |
| `Unit_Tests/CUTLibrary` | Classes under test (calculator, tic-tac-toe, string and date utilities) | Provided by the course |
| `Unit_Tests/ZajeciaTest` | Tests for numeric, string and array utilities | My solutions |
| `Unit_Tests/GameTest` | Tests for a tic-tac-toe game: initialisation, placing marks, out-of-range input, win detection | My solutions |
| `Unit_Tests/ReallyBadTest` | Tests written to find defects in a precompiled library (`ReallyBadLib.dll`, provided by the course) | My solutions |
| `Unit_Tests/WykladTest` | Examples from the lecture on testing the `Calculator` class | Lecture material |
| `Unit_Tests/SentenceTest` | Skeleton for the stub / fake / Moq exercise | In progress |


## Testing approach

Tests are written with xUnit (`[Fact]`, `[Theory]` with `[InlineData]`) and follow equivalence-class partitioning and boundary-value analysis.
For example:
- `IsEven`: positive odd and even numbers, zero, negative odd and even numbers;
- `ReverseString`: normal string, empty string, single character, whitespace, special characters, `null` (expects `ArgumentNullException`);
- `Game`: each out-of-range row or column value (`-1`, `3`) for placing and reading marks, writing to an occupied cell, and three-in-a-row for rows, columns and diagonals;
- `GetSum`: one input that reveals a seeded defect and one that does not;
- `ReallyBad`: `null`, empty string, missing character, first / last occurrence.

About 40 test methods across `ZajeciaTest`, `GameTest` and `ReallyBadTest`.

## Running

Requirements: .NET 6 runtime or SDK for `Unit_Tests`; .NET 8 for the spreadsheet projects.

```bash
dotnet run --project SpreadSheetApp
dotnet run --project SpreadSheetCommandPattern

cd Unit_Tests
dotnet test UnitTestLab_Student_NET60_Ver2.sln
```

The console demos wait for a key press between steps.

## Status

Still to do: the stub / fake / Moq exercise (`SentenceTest`) and the time-dependency refactoring of `GetArrivalDate`.
<!-- Remove this section when both are done. -->

Notes on the code:
- `Redo` in `SpreadSheetCommandPattern` restores the value overwritten by the last `Insert`, so it behaves as an undo.
