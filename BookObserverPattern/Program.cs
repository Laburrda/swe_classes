

// symulacja dzialania wzorca Obserwator
using BookRental.ObserverPattern;

Book panTadeusz = new Book("Pan Tadeusz", "Adam Mickiewicz");
Book bieguni = new Book("Bieguni", "Olga Tokarczuk");

Customer janek = new Customer("janek");
Customer kasia = new Customer("kasia");

panTadeusz.Attach(janek);
bieguni.Attach(kasia);

Console.WriteLine("Janek obserwuje książka 'Pan Tadeusz'");
Console.WriteLine("Kasia obserwuje książkę 'Bieguni'");
Console.ReadKey();

Console.WriteLine("Książka 'Pan Tadeusz' zmieniła status na pożyczona");
panTadeusz.Status = BookStatus.OnLoan;
Console.ReadKey();

Console.WriteLine("Książka 'Pan Tadeusz' zmieniła status na dostępna");
panTadeusz.Status = BookStatus.Available;
Console.ReadKey();

Console.WriteLine("Książka 'Bieguni' zmieniła status na zarezerowany");
bieguni.Status = BookStatus.OnReserve;
Console.ReadKey();

Console.WriteLine("Książka 'Bieguni' zmieniła status na dostępny");
bieguni.Status = BookStatus.Available;
Console.ReadKey();

Console.WriteLine("Książka 'Pan Tadeusz' zmieniła status na wypożyczony");
panTadeusz.Status = BookStatus.OnLoan;
Console.ReadKey();

Console.WriteLine("Wyrejestrowano użytkownika janek z książki Pan Tadeusz");
panTadeusz.Detach(janek);
Console.ReadKey();

Console.WriteLine("Ksiażka 'Pan Tadeusz' zmieniła status na dostępna");
panTadeusz.Status = BookStatus.Available;
Console.ReadKey();
