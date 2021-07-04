using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake_
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
  
    public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
       // foreach (Point p in pList)
        //{ 
        //    p.Draw();
       // }МОЖДНО вместо этого написать 
            base.Draw();
       
          Console.ForegroundColor = ConsoleColor.White;
}
}

}
