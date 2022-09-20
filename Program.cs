// See https://aka.ms/new-console-template for more information


//Si vuole progettare un sistema per la gestione di una biblioteca. Gli utenti si possono registrare al sistema, fornendo:
//cognome,
//nome,
//email,
//password,
//recapito telefonico,
//Gli utenti registrati possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD).
//I documenti sono caratterizzati da:
//un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
//titolo,
//anno,
//settore(storia, matematica, economia, …),
//stato(In Prestito, Disponibile),
//uno scaffale in cui è posizionato,
//un autore (Nome, Cognome).
//Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.
//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente,
//effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.

List<User> registeredUser = new List<User>();
//utenti registrati
registeredUser.Add(new User("Prova", "Rossi", "rossi@gmail.com", "12345a", "3331112233"));
registeredUser.Add(new User("Prova", "Gialli", "gialli@gmail.com", "12345b", "3332221133"));
registeredUser.Add(new User("Prova", "Verdi", "verdi@gmail.com", "12345c", "3333332211"));

List<Dvd> dvds = new List<Dvd>();
dvds.Add(new Dvd("1234", 100, "Harry Potter", 2002, "Fantasy", true, "12A", "J.K. Rowling"));

foreach (Dvd dvd in dvds)
{
    Console.WriteLine(dvd.Time);
}

List<Book> books = new List<Book>();
books.Add(new Book("123-45678", 100, "Harry Potter", 2022, "Fantasy", false, "F20", "J.K.Rowling"));

//Console.Write("Inserisci il tuo nome: ");
//string name = Console.ReadLine();

//Console.Write("Inserisci il tuo cognome: ");
//string surname = Console.ReadLine();

//Console.Write("Inserisci la tua email: ");
//string email = Console.ReadLine();

//Console.Write("Inserisci una nuova password: ");
//string password = Console.ReadLine();

//Console.Write("Inserisci il tuo recapito telefonico: ");
//string phone = Console.ReadLine();

//User newUser = new User(name, surname, email, password, phone);
