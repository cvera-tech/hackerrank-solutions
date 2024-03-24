namespace Problems.QueensAttack2;

/*
This first attempt works on 13 out of 22 test cases.
It fails on large values of n due to running out of memory for the matrix allocation.
*/
public class Attempt1
{
    public static int Run(int n, int k, int r_q, int c_q, List<List<int>> obstacles)
    {
        // Build matrix
        int[,] board = new int[n, n];
        foreach(List<int> obstacle in obstacles)
        {
            board[obstacle[0] - 1, obstacle[1] - 1] = 1;
        }

        // Starting at the queen, walk until we encounter an obstacle or the board edge
        (int, int) queenPosition = (r_q - 1, c_q - 1);
        int up = GetFreeSpaces(board, queenPosition, (1, 0));
        int upRight = GetFreeSpaces(board, queenPosition, (1, 1));
        int right = GetFreeSpaces(board, queenPosition, (0, 1));
        int downRight = GetFreeSpaces(board, queenPosition, (-1, 1));
        int down = GetFreeSpaces(board, queenPosition, (-1, 0));
        int downLeft = GetFreeSpaces(board, queenPosition, (-1, -1));
        int left = GetFreeSpaces(board, queenPosition, (0, -1));
        int upLeft = GetFreeSpaces(board, queenPosition, (1, -1));
        return up + upRight + upLeft + right + downRight + down + downLeft + left + upLeft;
    }

    private static int GetFreeSpaces(int[,] board, (int, int) queenPosition, (int, int) step)
    {
        int freeSpaces = 0;
        (int, int) currentPosition = (queenPosition.Item1 + step.Item1, queenPosition.Item2 + step.Item2);
        while
        (
            currentPosition.Item1 < board.GetLength(0) &&
            currentPosition.Item1 >= 0 &&
            currentPosition.Item2 < board.GetLength(1) &&
            currentPosition.Item2 >= 0 &&
            board[currentPosition.Item1, currentPosition.Item2] == 0
        ) {
            freeSpaces++;
            currentPosition = (currentPosition.Item1 + step.Item1, currentPosition.Item2 + step.Item2);
        }
        return freeSpaces;
    }
}