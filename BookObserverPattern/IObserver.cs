namespace BookRental.ObserverPattern
{
    // Interfejs obserwatora
    public interface IObserver
    {
        // Aktualiacja w wersji PULL
        void Update(Book book);

        // Aktualizacja w wersji PUSH
        //void Update(string author, string title, BookStatus status);
    }
}

