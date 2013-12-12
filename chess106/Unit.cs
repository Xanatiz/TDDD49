﻿using System;
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
        private chessPieces[,] chessboardArray = 
        {{chessPieces.BlackRook, chessPieces.BlackKnight, chessPieces.BlackBishop, chessPieces.BlackQueen, chessPieces.BlackKing, chessPieces.BlackBishop, chessPieces.BlackKnight, chessPieces.BlackRook},
        {chessPieces.BlackPawn, chessPieces.BlackPawn, chessPieces.BlackPawn, chessPieces.BlackPawn, chessPieces.BlackPawn, chessPieces.BlackPawn, chessPieces.BlackPawn, chessPieces.BlackPawn},
        {chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None},
        {chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None},
        {chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None},
        {chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None,chessPieces.None},
        {chessPieces.WhitePawn, chessPieces.WhitePawn, chessPieces.WhitePawn, chessPieces.WhitePawn, chessPieces.WhitePawn, chessPieces.WhitePawn, chessPieces.WhitePawn, chessPieces.WhitePawn},
        {chessPieces.WhiteRook, chessPieces.WhiteKnight, chessPieces.WhiteBishop, chessPieces.WhiteQueen, chessPieces.WhiteKing, chessPieces.WhiteBishop, chessPieces.WhiteKnight, chessPieces.WhiteRook}};

        public void move(int fromColumn, int fromRow, int toColumn, int toRow)
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
            
            }
            chessboardArray[fromRow, fromColumn] = chessPieces.None;


        }


        public chessPieces getUnit(int x, int y)
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
