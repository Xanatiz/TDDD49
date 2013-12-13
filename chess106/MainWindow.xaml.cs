﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace chess106
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Chessboard chess;
        //private Unit unit = new Unit();
        bool marked = false;
        int firstClickColumn;
        int firstClickRow;
        int secoundClickColumn;
        int secoundClickRow;
        private Pieces[,] board = { { new Rook(0, 0, Team.BLACK) }, { new Knight(0, 1, Team.BLACK) } }; 
        public MainWindow()
        {
            InitializeComponent();

            chess = new Chessboard { };
            
            //"sets all" units to visible
            for (int i = 0; i < 8; i++){
                for(int j = 0; j < 8; j++){
                    chess.updateImage(i,j);
                }
            }
            this.DataContext = chess;
        }
 


        private void Grid_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            
            var element = (UIElement)e.Source;
            if(!marked){
                firstClickColumn = Grid.GetColumn(element);
                firstClickRow = Grid.GetRow(element);
                marked = !marked;
                chess.get_markedColumn(firstClickColumn);
                chess.get_markedRow(firstClickRow);
                //chess.get_opacity(marked);
               // chess.updateImage(firstClickRow, firstClickColumn);
                
            }
            else
            {
                secoundClickColumn = Grid.GetColumn(element);
                secoundClickRow = Grid.GetRow(element);
             //   chess.unit.move(firstClickColumn, firstClickRow, secoundClickColumn, secoundClickRow);
                chess.updateImage(firstClickRow, firstClickColumn);
                chess.updateImage(secoundClickRow, secoundClickColumn);
                marked = !marked;
                //chess.get_markedColumn(secoundClickColumn);
                //chess.get_markedRow(secoundClickRow);
                chess.get_opacity(marked);
                this.DataContext = chess;
            }
          
        }
       
    }
}
