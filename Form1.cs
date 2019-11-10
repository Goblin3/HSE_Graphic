using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSE_Graphic_Paint
{

    public partial class Form1 : Form
    {
        //Лист для хранения всех нарисованных 
        //линий, удаления проиводиться отсюда же
      private  List<Line> Lines = new List<Line>();
        //Выбранная линия
    private Line selectLine=new Line();
        //Новая линия
        private Line newLine = new Line();




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Движение 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        /// <summary>
        /// Нажатие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int x1 = Cursor.Position.X;
            int y1 = Cursor.Position.Y;
            newLine = new Line(x1,y1,-1,-1);


        }
        /// <summary>
        /// Отпускание
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int x2 = Cursor.Position.X;
            int y2 = Cursor.Position.Y;
            newLine.x2 = x2;
            newLine.y2 = y2;

            Pen myPen = new Pen( Color.Black,10);
            Graphics g = null;
            
           
          g.DrawLine(myPen , newLine.x1 , newLine.y1, newLine.x2, newLine.y2) ;

        }
    }
}
