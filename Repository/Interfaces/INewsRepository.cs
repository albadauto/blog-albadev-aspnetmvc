using BlogDoDautin.Models;

namespace BlogDoDautin.Repository.Interfaces
{
    public interface INewsRepository
    {
        NewsModel createPost(NewsModel news);
    }
}
