using System;
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
        private Unit unit = new Unit();
        string marked = "Hidden";
        int firstClickColumn;
        int firstClickRow;
        int secoundClickColumn;
        int secoundClickRow;
        int teamCounter = 0;
        private Pieces pieces;
     
        public MainWindow()
        {
            InitializeComponent();

            chess = new Chessboard { };
            chess.get_marked(marked);

            //"sets all" units to visible
            for (int i = 0; i < 8; i++){
                for(int j = 0; j < 8; j++){
                    chess.updateImage(i,j);
                }
            }
            this.DataContext = chess;
        }

        private Boolean isEven(int n)
        {
            if (n % 2 == 0)
                return true;
            return false;
        }
 


        private void Grid_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            
            var element = (UIElement)e.Source;
            if (marked=="Hidden")
            {
                firstClickColumn = Grid.GetColumn(element);
                firstClickRow = Grid.GetRow(element);
                marked = "Visible";
                chess.get_marked(marked);
                chess.get_markedColumn(firstClickColumn);
                chess.get_markedRow(firstClickRow);
                Console.WriteLine("Selected" + unit.getUnit(firstClickRow, firstClickColumn).GetType().Name);
                var teamPiece = unit.getUnit(firstClickRow, firstClickColumn).getTeam();
                Console.WriteLine("teamPiece: " + teamPiece);
                   
            }
               
            else
            {
                secoundClickColumn = Grid.GetColumn(element);
                secoundClickRow = Grid.GetRow(element);
                if (unit.sameTeam(unit.getUnit(firstClickRow, firstClickColumn), unit.getUnit(secoundClickRow, secoundClickColumn)))
                {
                    firstClickColumn = secoundClickColumn;
                    firstClickRow = secoundClickRow;
                    chess.get_markedColumn(firstClickColumn);
                    chess.get_markedRow(firstClickRow);
                }
                     
                else
                {
                    if (isEven(teamCounter) && unit.getUnit(firstClickRow, firstClickColumn).getTeam() == Team.WHITE)
                    {

                        chess.unit.move(firstClickColumn, firstClickRow, secoundClickColumn, secoundClickRow);
                        marked = "Hidden";
                        chess.get_marked(marked);
                        chess.updateImage(firstClickRow, firstClickColumn);
                        chess.updateImage(secoundClickRow, secoundClickColumn);
                        Console.WriteLine("Moved");
                        Console.WriteLine("Team moved: " + unit.teamMoved(unit.getUnit(secoundClickRow, secoundClickColumn)));
                        Console.WriteLine(teamCounter);
                        teamCounter++;
                        Console.WriteLine(teamCounter);
                        
                    }
                    else if (!isEven(teamCounter) && unit.getUnit(firstClickRow, firstClickColumn).getTeam() == Team.BLACK)
                    {
                        chess.unit.move(firstClickColumn, firstClickRow, secoundClickColumn, secoundClickRow);
                        marked = "Hidden";
                        chess.get_marked(marked);
                        chess.updateImage(firstClickRow, firstClickColumn);
                        chess.updateImage(secoundClickRow, secoundClickColumn);
                        Console.WriteLine("Moved");
                        Console.WriteLine("Team moved: " + unit.teamMoved(unit.getUnit(secoundClickRow, secoundClickColumn)));
                        Console.WriteLine(teamCounter);
                        teamCounter++;
                        Console.WriteLine(teamCounter);

                    }
                    else
                    {
                        Console.WriteLine("Not your turn!");
                    }
                }
                
                
            }
            this.DataContext = chess;
        }
       
    }
}
