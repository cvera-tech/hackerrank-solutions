namespace Problems.QueensAttack2;

/// <summary>
/// https://www.hackerrank.com/challenges/queens-attack-2/
/// </summary>
public class QueensAttack2
{
    public static int Run(Arguments arguments)
    {
        int n = arguments.n;
        int k = arguments.k;
        int r_q = arguments.r_q;
        int c_q = arguments.c_q;
        List<List<int>> obstacles = arguments.obstacles;

        // Get the number of spaces between the queen and the edges of the board.
        int up = n - r_q;
        int right = n - c_q;
        int down = r_q - 1;
        int left = c_q - 1;
        int upRight = Math.Min(up, right);
        int downRight = Math.Min(down, right);
        int downLeft = Math.Min(down, left);
        int upLeft = Math.Min(up, left);

        // Iterate over all the obstacles to see if there are obstacles closer to the queen than what is currently stored.
        foreach(List<int> obstacle in obstacles)
        {
            int rowDist = obstacle[0] - r_q;
            int colDist = obstacle[1] - c_q;
            
            if (rowDist == colDist)
            {
                if (rowDist > 0)
                    upRight = Math.Min(upRight, rowDist - 1);
                else
                    downLeft = Math.Min(downLeft, rowDist * -1 - 1);
            }
            else if (rowDist == colDist * -1)
            {
                if (rowDist > 0)
                    upLeft = Math.Min(upLeft, rowDist - 1);
                else
                    downRight = Math.Min(downRight, rowDist * -1 - 1);
            }
            else if (colDist == 0)
            {
                if (rowDist > 0)
                    up = Math.Min(up, rowDist - 1);
                else
                    down = Math.Min(down, rowDist * -1 - 1);
            }
            else if (rowDist == 0)
            {
                if (colDist > 0)
                    right = Math.Min(right, colDist - 1);
                else
                    left = Math.Min(left, colDist * -1 - 1);
            }
        }
        return up + upRight + right + downRight + down + downLeft + left + upLeft;
    }
}
