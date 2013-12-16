using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Controls;

namespace chess106
{
    public class Unit 
    {
        static Team lastTeam = Team.BLACK;
        static Pieces[,] chessboardArray = { { new Rook(0, 0, Team.BLACK), new Knight(0, 1, Team.BLACK), new Bishop(0, 2, Team.BLACK), new Queen(0, 3, Team.BLACK), new King(0, 4, Team.BLACK), new Bishop(0, 5, Team.BLACK), new Knight(0, 6, Team.BLACK), new Rook(0, 7, Team.BLACK)},
                                              { new Pawn(1, 0, Team.BLACK), new Pawn(1, 1, Team.BLACK), new Pawn(1, 2, Team.BLACK), new Pawn(1, 3, Team.BLACK), new Pawn(1, 4, Team.BLACK), new Pawn(1, 5, Team.BLACK), new Pawn(1, 6, Team.BLACK), new Pawn(1, 7, Team.BLACK) },
                                              { new Pieces(2,0, Team.NONE), new Pieces(2,1, Team.NONE), new Pieces(2,2, Team.NONE), new Pieces(2,3, Team.NONE), new Pieces(2,4, Team.NONE), new Pieces(2,5, Team.NONE), new Pieces(2,6, Team.NONE), new Pieces(2,7, Team.NONE)},
                                              { new Pieces(3,0, Team.NONE), new Pieces(3,1, Team.NONE), new Pieces(3,2, Team.NONE), new Pieces(3,3, Team.NONE), new Pieces(3,4, Team.NONE), new Pieces(3,5, Team.NONE), new Pieces(3,6, Team.NONE), new Pieces(3,7, Team.NONE)},
                                              { new Pieces(4,0, Team.NONE), new Pieces(4,1, Team.NONE), new Pieces(4,2, Team.NONE), new Pieces(4,3, Team.NONE), new Pieces(4,4, Team.NONE), new Pieces(4,5, Team.NONE), new Pieces(4,6, Team.NONE), new Pieces(4,7, Team.NONE)},
                                              { new Pieces(5,0, Team.NONE), new Pieces(5,1, Team.NONE), new Pieces(5,2, Team.NONE), new Pieces(5,3, Team.NONE), new Pieces(5,4, Team.NONE), new Pieces(5,5, Team.NONE), new Pieces(5,6, Team.NONE), new Pieces(5,7, Team.NONE)},
                                              { new Pawn(6, 0, Team.WHITE), new Pawn(6, 1, Team.WHITE), new Pawn(6, 2, Team.WHITE), new Pawn(6, 3, Team.WHITE), new Pawn(6, 4, Team.WHITE), new Pawn(6, 5, Team.WHITE), new Pawn(6, 6, Team.WHITE), new Pawn(6, 7, Team.WHITE) },
                                              { new Rook(7, 0, Team.WHITE), new Knight(7, 1, Team.WHITE), new Bishop(7, 2, Team.WHITE), new Queen(7, 3, Team.WHITE), new King(7, 4, Team.WHITE), new Bishop(7, 5, Team.WHITE), new Knight(7, 6, Team.WHITE), new Rook(7, 7, Team.WHITE)}};

        public bool move(int fromColumn, int fromRow, int toColumn, int toRow)
        {
            bool isMovePossible = chessboardArray[fromRow, fromColumn].isMovePossible(toRow, toColumn);
            if(isMovePossible)
            {
                if (chessboardArray[toRow, toColumn].GetType().Name == "King")
                    lastTeam = Team.NONE;
                chessboardArray[toRow, toColumn] = chessboardArray[fromRow, fromColumn];
                chessboardArray[fromRow, fromColumn] = new Pieces(fromRow, fromColumn, Team.NONE);
                chessboardArray[toRow, toColumn].setX(toColumn);
                chessboardArray[toRow, toColumn].setY(toRow);
                changeTeam();
            }
            return isMovePossible;
        }
        
        public Team getLastTeam()
        {
            return lastTeam;
        }

        public void changeTeam()
        {
            switch (lastTeam)
            {
                case Team.BLACK:
                    {
                        lastTeam = Team.WHITE;
                        break;
                    }
                case Team.WHITE:
                    {
                        lastTeam = Team.BLACK;
                        break;
                    }
            }
        }

        public bool isTeamsTurn(Pieces piece)
        {
            return (piece.getTeam() != Team.NONE && piece.getTeam() != lastTeam);
        }

        public Pieces getUnit(int fromRow, int fromColumn)
        {
            return chessboardArray[fromRow, fromColumn];
        }

        public Boolean sameTeam(Pieces piece1, Pieces piece2){
            return piece1.getTeam() == piece2.getTeam();
        }

        public Boolean isOppositeTeam(Pieces piece1, Pieces piece2)
        {
            return ((piece1.getTeam() == Team.BLACK && piece2.getTeam() == Team.WHITE) || (piece1.getTeam() == Team.WHITE && piece2.getTeam() == Team.BLACK));
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
        
        public void createUnit(Pieces chessUnit)
        {
            chessboardArray[chessUnit.getY(), chessUnit.getX()] = chessUnit;
        }
    }
}
