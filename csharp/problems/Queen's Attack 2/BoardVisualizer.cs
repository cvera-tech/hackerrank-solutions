namespace Problems.QueensAttack2;

public class BoardVisualizer
{
    public static void Draw(int n, (int, int) queenPosition, List<List<int>> obstacles)
    {
        int[,] board = new int[n , n];
        board[queenPosition.Item1 - 1, queenPosition.Item2 - 1] = 9;
        foreach (List<int> obstacle in obstacles)
        {
            board[obstacle[0] - 1, obstacle[1] - 1] = 6;
        };
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write($"{(board[row, col] != 0 ? board[row, col] : "_")}|");
            }
            Console.WriteLine();
        }
    }
}