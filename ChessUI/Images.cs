using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ChessLogic;

namespace ChessUI
{
    public static class Images
    {
        private static readonly Dictionary<PieceType, ImageSource> whiteSources = new()
        {
            { PieceType.Pawn, LoadImage("Assets/PawnW.png") },
            { PieceType.Bishop, LoadImage("Assets/BishopW.png") },
            { PieceType.Knight, LoadImage("Assets/KnightW.png") },
            { PieceType.Rook, LoadImage("Assets/RookW.png") },
            { PieceType.Queen, LoadImage("Assets/QueenW.png") },
            { PieceType.King, LoadImage("Assets/KingW.png") },
        };

        private static ImageSource LoadImage(string filePath)
        {
            return new BitmapImage(new Uri(filePath, UriKind.Relative));
        }
    }
}
