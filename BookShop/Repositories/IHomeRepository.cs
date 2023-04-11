namespace BookShop
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Books>> GetBooks(string sTerm = "", int genreId = 0);
        Task<IEnumerable<Genre>> Genres();
    }
}