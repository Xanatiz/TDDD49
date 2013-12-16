using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using chess106;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Unit unit = new Unit();
        Rules rules = new Rules();
        Boolean expected;
        Boolean actual;

        [TestMethod]
        public void TestBishop()
        {
            //move black bishop in a straight illegal move
            expected = false;
            actual = rules.bishop(4, 1, 4, 3);
            Assert.AreEqual(expected, actual);

            //move black bishop from starting position past occupied square
            expected = false;
            actual = rules.bishop(2, 0, 4, 2);
            Assert.AreEqual(expected, actual);
            
            //move black bishop in a kill move fashion on white piece
            expected = true;
            Pieces none = new Pieces(1, 3, Team.WHITE);
            unit.createUnit(none);
            actual = rules.bishop(2, 0 , 3, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testKing()
        {
            //move black king in a kill move fashion on white piece
            expected = true;
            actual = rules.king(4, 0, 3, 1);
            Assert.AreEqual(expected, actual);

            //move black king on a square occupied by black piece
            expected = false;
            actual = rules.king(4, 0, 4, 1);
            Assert.AreEqual(expected, actual);

            //move black king two squares 
            expected = false;
            actual = rules.king(4, 0, 4, 2);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void testPawn()
        {
            //move pawn one squares from starter position
            expected = true;
            actual = rules.pawn(1, 1, 1, 2, Team.BLACK);
            Assert.AreEqual(expected, actual);

            //move pawn two squares from starter position
            expected = true;
            actual = rules.pawn(1, 1, 1, 3, Team.BLACK);
            Assert.AreEqual(expected, actual);

            //move pawn three squares from starter position
            expected = false;
            actual = rules.pawn(1, 1, 1, 4, Team.BLACK);
            Assert.AreEqual(expected, actual);

            //move pawn two squares from non-starter position
            expected = false;
            actual = rules.pawn(1, 2, 1, 4, Team.BLACK);
            Assert.AreEqual(expected, actual);

            //move pawn in a kill move fashion on white piece
            expected = true;
            Pieces whitePiece = new Pieces(2, 5, Team.WHITE);
            unit.createUnit(whitePiece);
            actual = rules.pawn(6, 1, 5, 2, Team.BLACK);
            Assert.AreEqual(expected, actual);

            //move pawn one square to square occupied by white piece from starting position
            expected = false;
            actual = rules.pawn(5, 1, 5, 2, Team.BLACK);
            Assert.AreEqual(expected, actual);

            //move pawn two squares past white piece from starting position
            expected = false;
            actual = rules.pawn(5, 1, 5, 3, Team.BLACK);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void testRook()
        {
            //Move rook to empty square with legal move
            Pieces piece = new Pieces(3, 3, Team.BLACK);
            unit.createUnit(piece);
            expected = true;
            actual = rules.rook(3, 3, 3, 5);
            Assert.AreEqual(expected, actual);

            //Move rook to empty square with illegal move
            expected = false;
            actual = rules.rook(3, 3, 4, 4);
            Assert.AreEqual(expected, actual);

            //move black rook to square occupied by black piece
            expected = false;
            actual = rules.rook(7, 0, 7, 1);
            Assert.AreEqual(expected, actual);



            //move black rook to square occupied by whte piece
            expected = true;
            Pieces whitePiece = new Pieces(3, 7, Team.WHITE);
            Pieces none = new Pieces(1, 7, Team.NONE);
            unit.createUnit(whitePiece);
            unit.createUnit(none);
            actual = rules.rook(7, 0, 7, 3);
            Assert.AreEqual(expected, actual);

            //move black rook square past an occupied piece
            expected = false;
            actual = rules.rook(7, 0, 7, 4);
            Assert.AreEqual(expected, actual);

        }
        
        [TestMethod]
        public void testKnight()
        {
            //Move black knight to a location occupied by a white piece
            expected = true;
            Pieces piece = new Pieces(2, 0,  Team.WHITE);
            unit.createUnit(piece);
            actual = rules.knight(1, 0, 0, 2);
            Assert.AreEqual(expected, actual);

            //Move black knight to a location occupied by a black piece
            expected = false;
            piece = new Pieces(2, 2, Team.BLACK);
            unit.createUnit(piece);
            actual = rules.knight(1, 0, 2, 2);
            Assert.AreEqual(expected, actual);

            //Move knight to empty square with legal move
            expected = true;
            actual = rules.knight(6, 0, 7, 2);
            Assert.AreEqual(expected, actual);

            //Move knight to empty square with illegal move
            expected = false;
            actual = rules.knight(4, 4, 5, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testQueen()
        {
            // We're using rules from bishop and rook since the movement restrictions
            // for the queen applies on both rook and the bishop.  
        }



    }
}
