using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class StateString
    {
        private readonly StringBuilder sb = new StringBuilder();

        public StateString(Player currentPlayer, Board board)
        {
            // Add piece placement data
            sb.Append(' ');
            // Add current player
            sb.Append(' ');
            // Add castling rights
            sb.Append(' ');
            // Add en passant data
        }

        private static char PieceChar(Piece piece)
        {

        }
    }
}
