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
        //private Unit unit = new Unit();
   
        
        
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
            int c = Grid.GetColumn(element);
            int r = Grid.GetRow(element);
            chess.unit.move(c, r);
            chess.updateImage(r,c);
            chess.updateImage(5, 5); 

            this.DataContext = chess;
        }

       
    }
}
