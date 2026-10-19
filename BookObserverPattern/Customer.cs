using System;

namespace BookRental.ObserverPattern
{
    // Obserwator
    //
    // Komentarz!!!
    //
    // Dla lepszego zrozumienia wzorca Obserwator przyjęto, że obserwatorami są
    // obiekty klasy Customer, reprentujące klientów wypożyczalni ksiązek.
    // Mimo, iż jest to wierne odzwierciedlenie świata rzeczywistego - w praktyce nie jest stosowane, 
    // głównie ze względu na niebezpieczeńtwo przeciążenia klasy Customer.
    // W praktyce obserwatorami są specjalnie w tym celu tworzone klasy.
    // W przypadku rozważanego systemu takimi klasami mogą być np. 
    // SMSNotifier - klasa służąca do wysyłania powiadomienia SMS lub
    // EMailNotifier - klasa służąca do wysyłania powiadomienia mailem.
    // Model interakcji w tym przypadku może wyglądać np. tak:
    // Klient wypożyczalni (Customer) po wybraniu książki wywołuje operacje systemową 
    // np. RegisterForNotification(), przekazując jej swoje dane mailowe. 
    // Operacja RegisterForNotification() tworzy obiekt klasy np. EMailNotifier,
    // przekazując mu dane mailowe i o książce,  następnie przy użyciu metody Attach()
    // z wybranej książki rejestruje jako obserwatora obiekt klasy EMailNotifier.
    //
    public class Customer : IObserver
    {
        private string _name;

        public Customer(string name)
        {
            this._name = name;
        }

        // Aktualizacja w wersji "PULL" - wyciąganie danych
        // Obserwator pobiera potrzebe dane z obserowanego podmiotu
        public void Update(Book book)
        {
            // pobieranie danych z obserwowanego podmiotu
            // każdy obserwator może pobrać tylko te dane, które go interesują
            string author = book.Author;
            string title = book.Title;
            BookStatus status = book.Status;

            Console.WriteLine("-------------");
            Console.WriteLine("Powiadomienie dla użytkownika: {0}", this._name);
            Console.WriteLine("Książka: {0} autorstwa: {1} posiada status: {2}", title, author, status);
        }

        //// Aktualizacja w wersji "PUSH" - wypychanie danych
        //// Obserwowany podmiot przekazuje dane do obserwatora jako argumenty metody Update()
        //public void Update(string author, string title, BookStatus status)
        //{
        //    Console.WriteLine("-------------");
        //    Console.WriteLine("Powiadomienie dla użytkownika: {0}", this._name);
        //    Console.WriteLine("Książka: {0} autrstwa: {1} posiada status: {2}", title, author, status);
        //}
    }
}

