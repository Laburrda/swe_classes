namespace BookRental.ObserverPattern
{
    // reprezentuje status książki
    public enum BookStatus
    {
        New,         // nowość
        Available,   // dostępna
        OnReserve,   // zarezerwowana
        OnLoan       // wypożyczona
    }

    // Obserwowany podmiot
    public class Book : Subject
    {
        // tytuł filmu
        private string _title;
        public string Title
        {
            get { return this._title; }
        }
        // reżyser
        private string _author;
        public string Author
        {
            get { return this._author; }
        }

        // status książki (możliwe wartości: dostępna, zarezerwowana, wypożyczona)
        private BookStatus _status;
        public BookStatus Status
        {
            get { return this._status; }
            set
            {
                this._status = value;
                if (this._status == BookStatus.Available)
                    Notify();
            }
        }

        public Book(string title, string author)
        {
            this._title = title;
            this._author = author;
            this._status = BookStatus.New;
        }

        // powiadamianie obserwatorów o zmianie danych w obserwowanycn podmiocie (Book)
        // W wersji PULL - implementacje mozna przenieść do nadklasy (Subject)
        protected override void Notify()
        {
            foreach (IObserver observer in this._observerList)
            {
                // Wersja "PULL"
                // Obserwowany podmiot (Book) wywołuje metodę Update() na rzecz każdego obserwatora.
                // Obserwatorzy pobierają samodzielnie interesujące ich dane z obserwowanego podmiotu.
                observer.Update(this);


                // Wersja "PUSH"
                // Obserwowany podmiot (Book) wywołuje metodę Update() na rzecz każdego obserwatora,
                // przekazując potencjalnie interesujące dane.
                // Obserwatorzy w tym przypadku dostają gotowe dane.
                //observer.Update(this._director, this._title, this._status);
            }
        }
    }
}
