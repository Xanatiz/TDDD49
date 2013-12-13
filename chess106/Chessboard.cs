using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Media;
using System.Windows.Controls;

namespace chess106
{
    class Chessboard : INotifyPropertyChanged
    {

        public Unit unit = new Unit();


        //these highlight marked rectangle;
        public int markedColumn { get; set; }
        public void get_markedColumn(int column) { markedColumn = column; OnPropertyChanged("markedColumn"); }

        public int markedRow { get; set; }
        public void get_markedRow(int row) { markedRow = row; OnPropertyChanged("markedRow"); }

        public int opacity { get; set; }

        public void get_opacity(bool marked) 
        {
            if (marked)
                opacity = 1;
            else 
                opacity = 0; 
            OnPropertyChanged("opacity"); 
        }



        public string A8 { get; set; }
        public string A7 { get; set; }
        public string A6 { get; set; }
        public string A5 { get; set; }
        public string A4 { get; set; }
        public string A3 { get; set; }
        public string A2 { get; set; }
        public string A1 { get; set; }
        public string B8 { get; set; }
        public string B7 { get; set; }
        public string B6 { get; set; }
        public string B5 { get; set; }
        public string B4 { get; set; }
        public string B3 { get; set; }
        public string B2 { get; set; }
        public string B1 { get; set; }
        public string C8 { get; set; }
        public string C7 { get; set; }
        public string C6 { get; set; }
        public string C5 { get; set; }
        public string C4 { get; set; }
        public string C3 { get; set; }
        public string C2 { get; set; }
        public string C1 { get; set; }
        public string D8 { get; set; }
        public string D7 { get; set; }
        public string D6 { get; set; }
        public string D5 { get; set; }
        public string D4 { get; set; }
        public string D3 { get; set; }
        public string D2 { get; set; }
        public string D1 { get; set; }
        public string E8 { get; set; }
        public string E7 { get; set; }
        public string E6 { get; set; }
        public string E5 { get; set; }
        public string E4 { get; set; }
        public string E3 { get; set; }
        public string E2 { get; set; }
        public string E1 { get; set; }
        public string F8 { get; set; }
        public string F7 { get; set; }
        public string F6 { get; set; }
        public string F5 { get; set; }
        public string F4 { get; set; }
        public string F3 { get; set; }
        public string F2 { get; set; }
        public string F1 { get; set; }
        public string G8 { get; set; }
        public string G7 { get; set; }
        public string G6 { get; set; }
        public string G5 { get; set; }
        public string G4 { get; set; }
        public string G3 { get; set; }
        public string G2 { get; set; }
        public string G1 { get; set; }
        public string H8 { get; set; }
        public string H7 { get; set; }
        public string H6 { get; set; }
        public string H5 { get; set; }
        public string H4 { get; set; }
        public string H3 { get; set; }
        public string H2 { get; set; }
        public string H1 { get; set; }



        private void get_A8(string source) { A8 = source; OnPropertyChanged("A8"); }
        private void get_A7(string source) { A7 = source; OnPropertyChanged("A7"); }
        private void get_A6(string source) { A6 = source; OnPropertyChanged("A6"); }
        private void get_A5(string source) { A5 = source; OnPropertyChanged("A5"); }
        private void get_A4(string source) { A4 = source; OnPropertyChanged("A4"); }
        private void get_A3(string source) { A3 = source; OnPropertyChanged("A3"); }
        private void get_A2(string source) { A2 = source; OnPropertyChanged("A2"); }
        private void get_A1(string source) { A1 = source; OnPropertyChanged("A1"); }
        private void get_B8(string source) { B8 = source; OnPropertyChanged("B8"); }
        private void get_B7(string source) { B7 = source; OnPropertyChanged("B7"); }
        private void get_B6(string source) { B6 = source; OnPropertyChanged("B6"); }
        private void get_B5(string source) { B5 = source; OnPropertyChanged("B5"); }
        private void get_B4(string source) { B4 = source; OnPropertyChanged("B4"); }
        private void get_B3(string source) { B3 = source; OnPropertyChanged("B3"); }
        private void get_B2(string source) { B2 = source; OnPropertyChanged("B2"); }
        private void get_B1(string source) { B1 = source; OnPropertyChanged("B1"); }
        private void get_C8(string source) { C8 = source; OnPropertyChanged("C8"); }
        private void get_C7(string source) { C7 = source; OnPropertyChanged("C7"); }
        private void get_C6(string source) { C6 = source; OnPropertyChanged("C6"); }
        private void get_C5(string source) { C5 = source; OnPropertyChanged("C5"); }
        private void get_C4(string source) { C4 = source; OnPropertyChanged("C4"); }
        private void get_C3(string source) { C3 = source; OnPropertyChanged("C3"); }
        private void get_C2(string source) { C2 = source; OnPropertyChanged("C2"); }
        private void get_C1(string source) { C1 = source; OnPropertyChanged("C1"); }
        private void get_D8(string source) { D8 = source; OnPropertyChanged("D8"); }
        private void get_D7(string source) { D7 = source; OnPropertyChanged("D7"); }
        private void get_D6(string source) { D6 = source; OnPropertyChanged("D6"); }
        private void get_D5(string source) { D5 = source; OnPropertyChanged("D5"); }
        private void get_D4(string source) { D4 = source; OnPropertyChanged("D4"); }
        private void get_D3(string source) { D3 = source; OnPropertyChanged("D3"); }
        private void get_D2(string source) { D2 = source; OnPropertyChanged("D2"); }
        private void get_D1(string source) { D1 = source; OnPropertyChanged("D1"); }
        private void get_E8(string source) { E8 = source; OnPropertyChanged("E8"); }
        private void get_E7(string source) { E7 = source; OnPropertyChanged("E7"); }
        private void get_E6(string source) { E6 = source; OnPropertyChanged("E6"); }
        private void get_E5(string source) { E5 = source; OnPropertyChanged("E5"); }
        private void get_E4(string source) { E4 = source; OnPropertyChanged("E4"); }
        private void get_E3(string source) { E3 = source; OnPropertyChanged("E3"); }
        private void get_E2(string source) { E2 = source; OnPropertyChanged("E2"); }
        private void get_E1(string source) { E1 = source; OnPropertyChanged("E1"); }
        private void get_F8(string source) { F8 = source; OnPropertyChanged("F8"); }
        private void get_F7(string source) { F7 = source; OnPropertyChanged("F7"); }
        private void get_F6(string source) { F6 = source; OnPropertyChanged("F6"); }
        private void get_F5(string source) { F5 = source; OnPropertyChanged("F5"); }
        private void get_F4(string source) { F4 = source; OnPropertyChanged("F4"); }
        private void get_F3(string source) { F3 = source; OnPropertyChanged("F3"); }
        private void get_F2(string source) { F2 = source; OnPropertyChanged("F2"); }
        private void get_F1(string source) { F1 = source; OnPropertyChanged("F1"); }
        private void get_G8(string source) { G8 = source; OnPropertyChanged("G8"); }
        private void get_G7(string source) { G7 = source; OnPropertyChanged("G7"); }
        private void get_G6(string source) { G6 = source; OnPropertyChanged("G6"); }
        private void get_G5(string source) { G5 = source; OnPropertyChanged("G5"); }
        private void get_G4(string source) { G4 = source; OnPropertyChanged("G4"); }
        private void get_G3(string source) { G3 = source; OnPropertyChanged("G3"); }
        private void get_G2(string source) { G2 = source; OnPropertyChanged("G2"); }
        private void get_G1(string source) { G1 = source; OnPropertyChanged("G1"); }
        private void get_H8(string source) { H8 = source; OnPropertyChanged("H8"); }
        private void get_H7(string source) { H7 = source; OnPropertyChanged("H7"); }
        private void get_H6(string source) { H6 = source; OnPropertyChanged("H6"); }
        private void get_H5(string source) { H5 = source; OnPropertyChanged("H5"); }
        private void get_H4(string source) { H4 = source; OnPropertyChanged("H4"); }
        private void get_H3(string source) { H3 = source; OnPropertyChanged("H3"); }
        private void get_H2(string source) { H2 = source; OnPropertyChanged("H2"); }
        private void get_H1(string source) { H1 = source; OnPropertyChanged("H1"); }


        public void updateImage(int r, int c)
        {

            var piece = unit.getUnit(r, c);
            string source = unit.getUnitSource(piece);

            switch (r.ToString() + c.ToString())
            {
                case "00": { get_A8(source); break; }
                case "10": { get_A7(source); break; }
                case "20": { get_A6(source); break; }
                case "30": { get_A5(source); break; }
                case "40": { get_A4(source); break; }
                case "50": { get_A3(source); break; }
                case "60": { get_A2(source); break; }
                case "70": { get_A1(source); break; }
                case "01": { get_B8(source); break; }
                case "11": { get_B7(source); break; }
                case "21": { get_B6(source); break; }
                case "31": { get_B5(source); break; }
                case "41": { get_B4(source); break; }
                case "51": { get_B3(source); break; }
                case "61": { get_B2(source); break; }
                case "71": { get_B1(source); break; }
                case "02": { get_C8(source); break; }
                case "12": { get_C7(source); break; }
                case "22": { get_C6(source); break; }
                case "32": { get_C5(source); break; }
                case "42": { get_C4(source); break; }
                case "52": { get_C3(source); break; }
                case "62": { get_C2(source); break; }
                case "72": { get_C1(source); break; }
                case "03": { get_D8(source); break; }
                case "13": { get_D7(source); break; }
                case "23": { get_D6(source); break; }
                case "33": { get_D5(source); break; }
                case "43": { get_D4(source); break; }
                case "53": { get_D3(source); break; }
                case "63": { get_D2(source); break; }
                case "73": { get_D1(source); break; }
                case "04": { get_E8(source); break; }
                case "14": { get_E7(source); break; }
                case "24": { get_E6(source); break; }
                case "34": { get_E5(source); break; }
                case "44": { get_E4(source); break; }
                case "54": { get_E3(source); break; }
                case "64": { get_E2(source); break; }
                case "74": { get_E1(source); break; }
                case "05": { get_F8(source); break; }
                case "15": { get_F7(source); break; }
                case "25": { get_F6(source); break; }
                case "35": { get_F5(source); break; }
                case "45": { get_F4(source); break; }
                case "55": { get_F3(source); break; }
                case "65": { get_F2(source); break; }
                case "75": { get_F1(source); break; }
                case "06": { get_G8(source); break; }
                case "16": { get_G7(source); break; }
                case "26": { get_G6(source); break; }
                case "36": { get_G5(source); break; }
                case "46": { get_G4(source); break; }
                case "56": { get_G3(source); break; }
                case "66": { get_G2(source); break; }
                case "76": { get_G1(source); break; }
                case "07": { get_H8(source); break; }
                case "17": { get_H7(source); break; }
                case "27": { get_H6(source); break; }
                case "37": { get_H5(source); break; }
                case "47": { get_H4(source); break; }
                case "57": { get_H3(source); break; }
                case "67": { get_H2(source); break; }
                case "77": { get_H1(source); break; }
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }


    }
}
