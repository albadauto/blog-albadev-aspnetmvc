namespace BlogDoDautin.Helper
{
    public interface IEmail
    {
        bool Send(string email, string subject, string message);

    }
}
