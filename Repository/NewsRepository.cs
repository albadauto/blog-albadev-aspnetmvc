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

        public List<NewsModel> getAllNews()
        {
            return _context.News.OrderByDescending(o => o.Id).ToList();
        }

        public bool DeleteNews(int id)
        {
            NewsModel post = this.getById(id);
            _context.News.Remove(post);
            _context.SaveChanges();
            return true;
        }


        public NewsModel getById(int id)
        {
            return _context.News.FirstOrDefault(x => x.Id == id);
        }
    }
}
