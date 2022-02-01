namespace Task3
{
    internal static class Accountant
    {
        public static bool AskForBonus(Post worker)
        {
            return worker.WorkedTime >= (int)Positions.Accountant;
        }
    }
}
