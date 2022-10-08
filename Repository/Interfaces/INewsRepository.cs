using BlogDoDautin.Models;

namespace BlogDoDautin.Repository.Interfaces
{
    public interface INewsRepository
    {
        NewsModel createPost(NewsModel news);
        List<NewsModel> getAll(int? UserId);
        List<NewsModel> getAllNews();
        bool DeleteNews(int id);
        NewsModel getById(int id);
        NewsModel EditPost(NewsModel modelToEdit);
    }
}
