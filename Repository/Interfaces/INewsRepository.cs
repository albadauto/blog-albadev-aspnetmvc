using BlogDoDautin.Models;

namespace BlogDoDautin.Repository.Interfaces
{
    public interface INewsRepository
    {
        NewsModel createPost(NewsModel news);
        List<NewsModel> getAll(int? UserId);
        List<NewsModel> getAllNews();
    }
}
