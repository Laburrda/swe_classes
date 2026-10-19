// See https://aka.ms/new-console-template for more information

using SpreadSheetApp.ObserverPattern;

Cell a1 = new Cell("A1", 0);
Cell b1 = new Cell("B1", 123);
Cell c1 = new Cell("C1", 2);

a1.Attach(b1);
b1.Attach(c1);

Console.WriteLine("Komorka B1 obserwuje komorke A1");
Console.WriteLine("Komorka C1 obserwuje komorke B1");
Console.ReadKey();

Plot plot_a1 = new Plot("Plot_a1");
Plot plot_b1 = new Plot("Plot_b1");
Plot plot_c1 = new Plot("Plot_c1");

a1.Attach(plot_a1);
b1.Attach(plot_b1);
c1.Attach(plot_c1);

Console.WriteLine("Wykres Plot_a1 obserwuje komorke A1");
Console.WriteLine("Wykres Plot_b1 obserwuje komorke B1");
Console.WriteLine("Wykres Plot_c1 obserwuje komorke C1");
Console.ReadKey();

Console.WriteLine("Aktualizacja wartosci dla komorki A1");
a1.Value = 3;
Console.ReadKey();
