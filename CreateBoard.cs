using System;

namespace TicTacToe
{ 
   class CreateBoard
   {    
      char[] pieces = "012345678".ToCharArray();
  
      public bool SetNewPiece(int position, char pieceType)
      {
         if (pieces[position] == Convert.ToChar('x') || pieces[position] == Convert.ToChar('o'))
            return true;
         else
         {
            pieces[position] = pieceType;
            return false;
         }
      }


      public void DrawBoard()
      {
         Console.WriteLine("\n");
         for (int drawnPosition = 0; drawnPosition < 9; ++drawnPosition)
         {
            if (drawnPosition == 2 || drawnPosition == 5)
            {
               Console.WriteLine(pieces[drawnPosition]);
               Console.WriteLine("_   _   _");
               Console.WriteLine();
               continue;
            }
            else if (drawnPosition == 8)
            {
               Console.WriteLine(pieces[drawnPosition]);
               continue;
            }

            Console.Write(pieces[drawnPosition] + " | ");
         }
         Console.WriteLine("\n");
      }

   }
}   
