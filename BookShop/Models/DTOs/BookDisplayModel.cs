namespace BookShop.Models.DTOs
{
    public class BookDisplayModel
    {
        public IEnumerable<Books> Books { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public string STerm { get; set; } = "";

        public int GenreId { get; set; }= 0;
    }
}
