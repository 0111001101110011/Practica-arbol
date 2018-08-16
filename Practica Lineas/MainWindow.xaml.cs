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

namespace Practica_Lineas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //La casaaaa xd

            //La ventana
            plnLinea.Points.Add(new Point(350.0, 350.0));
            plnLinea.Points.Add(new Point(350.0, 450.0));
            plnLinea.Points.Add(new Point(450.0, 450.0));
            plnLinea.Points.Add(new Point(450.0, 350.0));
            plnLinea.Points.Add(new Point(350.0, 350.0));
            plnLinea.Points.Add(new Point(450.0, 450.0));
            plnLinea.Points.Add(new Point(350.0, 450.0));
            plnLinea.Points.Add(new Point(450.0, 350.0));


            //La Baseeeee xd
            plnLinea2.Points.Add(new Point(250.0, 250.0));
            plnLinea2.Points.Add(new Point(250.0, 750.0));
            plnLinea2.Points.Add(new Point(750.0, 750.0));
            plnLinea2.Points.Add(new Point(750.0, 250.0));
            plnLinea2.Points.Add(new Point(250.0, 250.0));

            //El techooooo xd
            plnLinea3.Points.Add(new Point(250.0, 250.0));
            plnLinea3.Points.Add(new Point(500.0, 70.0));
            plnLinea3.Points.Add(new Point(750.0, 250.0));

            //La puerta 
            plnLinea4.Points.Add(new Point(437.5, 750.0));
            plnLinea4.Points.Add(new Point(437.5, 550.0));
            plnLinea4.Points.Add(new Point(550.0, 550.0));
            plnLinea4.Points.Add(new Point(550.0, 750.0));

            //Pos el arbol lila

            //El tronco xdd
            plnLinea6.Points.Add(new Point(1000.0, 750.0));
            plnLinea6.Points.Add(new Point(1000.0, 550.0));
            plnLinea6.Points.Add(new Point(1070.0, 550.0));
            plnLinea6.Points.Add(new Point(1070.0, 750.0));
            plnLinea6.Points.Add(new Point(1000.0, 750.0));


            //Las ramaaaas xd
            plnLinea7.Points.Add(new Point(1000.0, 550.0));
            plnLinea7.Points.Add(new Point(950.0, 450.0));
            plnLinea7.Points.Add(new Point(1020.0, 350.0));
            plnLinea7.Points.Add(new Point(1100.0, 450.0));
            plnLinea7.Points.Add(new Point(1070.0, 550.0));



        }
    }
}
