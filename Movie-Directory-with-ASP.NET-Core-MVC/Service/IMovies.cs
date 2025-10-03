namespace Movie_Directory_with_ASP.NET_Core_MVC.Service
{
    public interface IMovies
    {
        int Id { get; set; }
        string Title { get; set; }
        string Genre { get; set; }
        decimal Rating { get; set; }
        string Description { get; set; }
    }
}
