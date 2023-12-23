namespace _2048ClassLibrary
{
    public class GameResult
    {
        public User User { get; set; }
        public int Result { get; set; }
        public GameResult(User user, int result)
        {
            User = user;
            Result = result;
        }
    }
}
