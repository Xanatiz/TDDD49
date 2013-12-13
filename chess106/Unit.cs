using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Controls;

namespace chess106
{
    class Unit 
    {
        private Rules rules = new Rules();
       /* private chessPieces[,] chessboardArray =
        {{chessPieces.BlackRook, chessPieces.BlackKnight, chessPieces.BlackBishop, chessPieces.BlackQueen, chessPieces.BlackKing, chessPieces.BlackBishop, chessPieces.BlackKnight, chessPieces.BlackRook},
        {chessPieces.BlackPawn, chessPieces.BlackPawn, chessPieces.BlackPawn, chessPieces.BlackPawn, chessPieces.BlackPawn, chessPieces.BlackPawn, chessPieces.BlackPawn, chessPieces.BlackPawn},
        {chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None},
        {chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None},
        {chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None},
        {chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None},
        {chessPieces.WhitePawn, chessPieces.WhitePawn, chessPieces.WhitePawn, chessPieces.WhitePawn, chessPieces.WhitePawn, chessPieces.WhitePawn, chessPieces.WhitePawn, chessPieces.WhitePawn},
        {chessPieces.WhiteRook, chessPieces.WhiteKnight, chessPieces.WhiteBishop, chessPieces.WhiteQueen, chessPieces.WhiteKing, chessPieces.WhiteBishop, chessPieces.WhiteKnight, chessPieces.WhiteRook}};
        */
        private Pieces[,] chessboardArray = { { new Rook(0, 0, Team.BLACK), new Knight(0, 1, Team.BLACK), new Bishop(0, 2, Team.BLACK), new Queen(0, 3, Team.BLACK), new King(0, 4, Team.BLACK), new Bishop(0, 5, Team.BLACK), new Knight(0, 6, Team.BLACK), new Rook(0, 7, Team.BLACK)},
                                             {new Pawn(1, 0, Team.BLACK), new Pawn(1, 1, Team.BLACK), new Pawn(1, 2, Team.BLACK), new Pawn(1, 3, Team.BLACK), new Pawn(1, 4, Team.BLACK), new Pawn(1, 5, Team.BLACK), new Pawn(1, 6, Team.BLACK), new Pawn(1, 7, Team.BLACK) },
                                             {new Pieces(2,0, Team.NONE), new Pieces(2,1, Team.NONE), new Pieces(2,2, Team.NONE), new Pieces(2,3, Team.NONE), new Pieces(2,4, Team.NONE), new Pieces(2,5, Team.NONE), new Pieces(2,6, Team.NONE), new Pieces(2,7, Team.NONE)},
                                             {new Pieces(3,0, Team.NONE), new Pieces(3,1, Team.NONE), new Pieces(3,2, Team.NONE), new Pieces(3,3, Team.NONE), new Pieces(3,4, Team.NONE), new Pieces(3,5, Team.NONE), new Pieces(3,6, Team.NONE), new Pieces(3,7, Team.NONE)},
                                             {new Pieces(4,0, Team.NONE), new Pieces(4,1, Team.NONE), new Pieces(4,2, Team.NONE), new Pieces(4,3, Team.NONE), new Pieces(4,4, Team.NONE), new Pieces(4,5, Team.NONE), new Pieces(4,6, Team.NONE), new Pieces(4,7, Team.NONE)},
                                             {new Pieces(5,0, Team.NONE), new Pieces(5,1, Team.NONE), new Pieces(5,2, Team.NONE), new Pieces(5,3, Team.NONE), new Pieces(5,4, Team.NONE), new Pieces(5,5, Team.NONE), new Pieces(5,6, Team.NONE), new Pieces(5,7, Team.NONE)},
                                             {new Pawn(6, 0, Team.WHITE), new Pawn(6, 1, Team.WHITE), new Pawn(6, 2, Team.WHITE), new Pawn(6, 3, Team.WHITE), new Pawn(6, 4, Team.WHITE), new Pawn(6, 5, Team.WHITE), new Pawn(6, 6, Team.WHITE), new Pawn(6, 7, Team.WHITE) },
                                             { new Rook(0, 7, Team.WHITE), new Knight(7, 1, Team.WHITE), new Bishop(7, 2, Team.WHITE), new Queen(7, 3, Team.WHITE), new King(7, 4, Team.WHITE), new Bishop(7, 5, Team.WHITE), new Knight(7, 6, Team.WHITE), new Rook(7, 7, Team.WHITE)}};
                                            

      /*  public void move(int fromColumn, int fromRow, int toColumn, int toRow)
        //r and c is inverted from function call
        {
            int black = 1;
            int white = -1;
            switch (getUnit(fromRow, fromColumn))
            {
                case chessPieces.BlackBishop:
                    {
                        if (rules.bishop(fromRow, fromColumn, toRow, toColumn))
                        {
                            chessboardArray[toRow, toColumn] = chessPieces.BlackBishop;
                            chessboardArray[fromRow, fromColumn] = chessPieces.None;
                        }
                        break;
                    }
                case chessPieces.BlackPawn:
                    {
                        if (rules.pawn(fromRow, fromColumn, toRow, toColumn, black))
                        {
                            chessboardArray[toRow, toColumn] = chessPieces.BlackPawn;
                            chessboardArray[fromRow, fromColumn] = chessPieces.None;
                        }
                        break;
                    }
                case chessPieces.BlackKnight:
                    {
                        if (rules.knight(fromRow, fromColumn, toRow, toColumn))
                        {
                            chessboardArray[toRow, toColumn] = chessPieces.BlackKnight;
                            chessboardArray[fromRow, fromColumn] = chessPieces.None;
                        }
                        break;
                    }
                case chessPieces.BlackQueen:
                    {
                        if (rules.queen(fromRow, fromColumn, toRow, toColumn))
                        {
                            chessboardArray[toRow, toColumn] = chessPieces.BlackQueen;
                            chessboardArray[fromRow, fromColumn] = chessPieces.None;
                        }
                        break;
                    }
                case chessPieces.BlackKing:
                    {
                        if (rules.king(fromRow, fromColumn, toRow, toColumn))
                        {
                            chessboardArray[toRow, toColumn] = chessPieces.BlackKing;
                            chessboardArray[fromRow, fromColumn] = chessPieces.None;
                        }
                        break;
                    }
                case chessPieces.BlackRook:
                    {
                        if (rules.rook(fromRow, fromColumn, toRow, toColumn))
                        {
                            chessboardArray[toRow, toColumn] = chessPieces.BlackRook;
                            chessboardArray[fromRow, fromColumn] = chessPieces.None;
                        }
                        break;
                    }
            
            
            }
            


        }*/


        public Pieces getUnit(int x, int y)
        {
            return chessboardArray[x, y];
        }

        public Boolean sameTeam(chessPieces firstPiece, chessPieces secoundPiece){
            if (secoundPiece != chessPieces.None)
            {

            }
            return false;
        }


        public String getUnitSource(chessPieces obj)
        {
            String returner = "";
            switch (obj)
            {
                case chessPieces.BlackBishop:
                    returner = "/Images/Black B.png";
                    break;
                case chessPieces.BlackKing:
                    returner = "/Images/Black K.png";
                    break;
                case chessPieces.BlackKnight:
                    returner = "/Images/Black N.png";
                    break;
                case chessPieces.BlackPawn:
                    returner = "/Images/Black P.png";
                    break;
                case chessPieces.BlackQueen:
                    returner = "/Images/Black Q.png";
                    break;
                case chessPieces.BlackRook:
                    returner = "/Images/Black R.png";
                    break;
                case chessPieces.WhiteBishop:
                    returner = "/Images/White B.png";
                    break;
                case chessPieces.WhiteKing:
                    returner = "/Images/White K.png";
                    break;
                case chessPieces.WhiteKnight:
                    returner = "/Images/White N.png";
                    break;
                case chessPieces.WhitePawn:
                    returner = "/Images/White P.png";
                    break;
                case chessPieces.WhiteQueen:
                    returner = "/Images/White Q.png";
                    break;
                case chessPieces.WhiteRook:
                    returner = "/Images/White R.png";
                    break;
                case chessPieces.None:
                    returner = "/Images/None.png";
                    break;
            }
            return returner;
        }
    }
}
