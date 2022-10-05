using BlogDoDautin.Context;
using BlogDoDautin.Models;
using BlogDoDautin.Repository.Interfaces;

namespace BlogDoDautin.Repository
{
    public class NewsRepository : INewsRepository
    {
        private readonly DatabaseContext _context;

        public NewsRepository(DatabaseContext context)
        {
            _context = context;
        }

        public NewsModel createPost(NewsModel news)
        {
            _context.News.Add(news);
            _context.SaveChanges();
            return news;
        }

        public List<NewsModel> getAll(int? UserId)
        {
            return _context.News.Where(x => x.UserId.Equals(UserId)).ToList();
        }
    }
}
