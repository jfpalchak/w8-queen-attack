using System;
using System.Collections.Generic;

namespace QueenAttack.Models
{
  public class Queen
  {
    public int X { get; set; }
    public int Y { get; set; }


    public Queen(int XAxis, int YAxis)
    {
      X = XAxis;
      Y = YAxis;
    }

    public bool CheckLegalMove(int newXAxis, int newYAxis)
    {
      if (((Math.Abs(X - newXAxis)) == Math.Abs(Y - newYAxis)) && (1 < X && X < 8) && (1 < Y && Y < 8) && (1 < newXAxis && newXAxis < 8) && (1 < newYAxis && newXAxis < 8))
      {
        return true;
      }
      else if (((X == newXAxis && Y != newYAxis) || (Y == newYAxis && X != newXAxis)) && ((1 < X && X < 8) && (1 < Y && Y < 8) && (1 < newXAxis && newXAxis < 8) && (1 < newYAxis && newXAxis < 8)))
      {
        return true;
      }
      else 
      {
        return false;
      }
    } 
      

  }

}

