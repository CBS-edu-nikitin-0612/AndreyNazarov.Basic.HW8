namespace Task3
{
    internal class Post
    {
        public int WorkedTime { get;private set; }
        public Positions Position { get;  }

        public Post(int workedTime, Positions position)
        {
            WorkedTime = workedTime;
            Position = position;
        }
    }
}
