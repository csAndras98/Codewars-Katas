using System.Collections.Generic;

public class ConnectFour
{
    public static string WhoIsWinner(List<string> piecesPositionList)
    {
        char?[,] board = new char?[6, 7];

        foreach (string move in piecesPositionList)
        {
            int charUnicode = (int)move[0] - 65;
            for (int i = 0; i < 6; i++)
            {
                if (!board[i, charUnicode].HasValue)
                {
                    board[i, charUnicode] = move[2];
                    if (WinCheck(board, 'Y'))
                    {
                        return "Yellow";
                    }
                    else if (WinCheck(board, 'R'))
                    {
                        return "Red";
                    }
                    break;
                }
            }
        }
        return "Draw";
    }

    public static bool WinCheck(char?[,] board, char player)
    {
        for (int row = 0; row < board.GetLength(0); row++)
            for (int col = 0; col < board.GetLength(1) - 3; col++)
                if (board[row, col] == player && board[row, col] == board[row, col + 1] && board[row, col] == board[row, col + 2] && board[row, col] == board[row, col + 3])
                    return true;

        for (int col = 0; col < board.GetLength(1); col++)
            for (int row = 0; row < board.GetLength(0) - 3; row++)
                if (board[row, col] == player && board[row, col] == board[row + 1, col] && board[row, col] == board[row + 2, col] && board[row, col] == board[row + 3, col])
                    return true;

        for (int row = 0; row < board.GetLength(0) - 3; row++)
            for (int col = 0; col < board.GetLength(1) - 3; col++)
                if (board[row, col] == player && board[row, col] == board[row + 1, col + 1] && board[row, col] == board[row + 2, col + 2] && board[row, col] == board[row + 3, col + 3])
                    return true;

        for (int row = 0; row < board.GetLength(0) - 3; row++)
            for (int col = 3; col < board.GetLength(1); col++)
                if (board[row, col] == player && board[row, col] == board[row + 1, col - 1] && board[row, col] == board[row + 2, col - 2] && board[row, col] == board[row + 3, col - 3])
                    return true;

        return false;
    }
}