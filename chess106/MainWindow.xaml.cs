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
     
        public MainWindow()
        {
            InitializeComponent();
            chess = new Chessboard(unit);
            chess.get_marked(marked);
            visualizeAllPieces();
            this.DataContext = chess;
        }

        public void visualizeAllPieces()
        {
            //"sets all" units to visible
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    chess.updateImage(i, j);
                }
            }
        }

        private void Grid_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            var element = (UIElement)e.Source;
            if ( marked == "Hidden" && unit.getLastTeam()!=Team.NONE)
            {
                firstClickColumn = Grid.GetColumn(element);
                firstClickRow = Grid.GetRow(element);
                if(unit.isTeamsTurn(unit.getUnit(firstClickRow, firstClickColumn)))
                {
                    marked = "Visible";
                    chess.get_marked(marked);
                    chess.get_markedColumn(firstClickColumn);
                    chess.get_markedRow(firstClickRow);
                }   
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
                    unit.move(firstClickColumn, firstClickRow, secoundClickColumn, secoundClickRow);
                    marked = "Hidden";
                    chess.get_marked(marked);
                    chess.updateImage(firstClickRow, firstClickColumn);
                    chess.updateImage(secoundClickRow, secoundClickColumn);
                }              
            }
            this.DataContext = chess;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //save
            Console.WriteLine("Save button clicked!");
            unit.convertToList();
            using (var db = new ChessContext())
            {

                var query = from b in db.Units
                            orderby b.ID
                            select b;
                try
                {
                    db.Units.RemoveRange(query);
                    db.SaveChanges();
                }
                catch { }

                db.Units.Add(unit);
                db.SaveChanges();

              }
            Console.WriteLine("Saved!");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //load
            Console.WriteLine("Load button clicked!");
            using (var db = new ChessContext())
            {
                var query2 = from b in db.Units
                             orderby b.ID
                             select b;

                foreach (var item in query2)
                {
                    unit.setChessboardArray(item.listToDatabase);
                    unit.setLastTeam(item.lastTeam);
                }

            }
            visualizeAllPieces();
            Console.WriteLine("Loaded");
        }
    }
}
