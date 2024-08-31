using BookApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    // https://localhost:7230/api/books
    [Route("api/[Controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private Book[] _books = new Book[]
        {
            
            new Book { Id = 1, Author = "Leo Tolstoy", Title = "War and Peace"},
            new Book { Id = 2, Author = "Fyodor Dostoevsky", Title = "Crime and Punishment"},
            new Book { Id = 3, Author = "Fyodor Dostoevsky", Title = "The Brothers Karamazov"},
            new Book { Id = 4, Author = "Leo Tolstoy", Title = "Anna Karenina"},
            new Book { Id = 5, Author = "Mikhail Bulgakov", Title = "The Master and Margarita"},
            new Book { Id = 6, Author = "Boris Pasternak", Title = "Doctor Zhivago"},
            new Book { Id = 7, Author = "Aleksandr Solzhenitsyn", Title = "The Gulag Archipelago"},
            new Book { Id = 8, Author = "Ivan Turgenev", Title = "Fathers and Sons"},
            new Book { Id = 9, Author = "Fyodor Dostoevsky", Title = "The Idiot"},
            new Book { Id = 10, Author = "Andrei Bely", Title = "Petersburg"},
            new Book { Id = 11, Author = "Livy", Title = "The History of Rome"},
            new Book { Id = 12, Author = "Suetonius", Title = "The Twelve Caesars"},
            new Book { Id = 13, Author = "Tacitus", Title = "The Annals"},
            new Book { Id = 14, Author = "Marcus Aurelius", Title = "Meditations"},
            new Book { Id = 15, Author = "Julius Caesar", Title = "The Gallic Wars"},
            new Book { Id = 16, Author = "Edward Gibbon", Title = "The Decline and Fall of the Roman Empire"},
            new Book { Id = 17, Author = "Mary Beard", Title = "SPQR: A History of Ancient Rome"},
            new Book { Id = 18, Author = "Tom Holland", Title = "Rubicon: The Last Years of the Roman Republic"},
            new Book { Id = 19, Author = "Barry Strauss", Title = "The Death of Caesar: The Story of History's Most Famous Assassination"},
            new Book { Id = 20, Author = "Adrian Goldsworthy", Title = "Caesar: Life of a Colossus"},
            new Book { Id = 21, Author = "Nolan Grayson", Title = "The Man with the Invincible Gun"},
            new Book { Id = 22, Author = "Nolan Grayson", Title = "Savage Planet, Savage Beasts"},
            new Book { Id = 23, Author = "Nolan Grayson", Title = "Lost Inside the Chasm to Oblivion"},
            new Book { Id = 24, Author = "Julio Cesar", Title = "Bellum Civile"},
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_books);
        }
    }
}
