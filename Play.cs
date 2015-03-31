using System;

namespace TicTacToe
{ 
   public class Test
   {
      public static void Main( string[] args)
      {
         int[] humanMove = {0, };
         Play round1 = new Play();
         humanMove = {};
         Play round2 = new Play();
         humanMove = {};
         Play round3 = new Play();
         humanMove = {};
         Play round4 = new Play();
         humanMove = {};
         Play round5 = new Play();
         humanMove = {};
         Play round6 = new Play();
         humanMove = {};

         Console.ReadLine();
      }
   }

   class CreateBoard
   {    
      char[] delimiterChars = {' '};
      string text = "0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15";
      string[] pieces = text.Split(delimiterChars);

      public void DrawBoard()
      {
         Console.WriteLine("\n");
         for (int drawnPosition = 0; drawnPosition < 16; ++drawnPosition)
         {
            if (drawnPosition == 3 || drawnPosition == 7 || drawnPosition == 11)
            {
               Console.WriteLine(pieces[drawnPosition]);
               Console.WriteLine("_   _   _   _");
               Console.WriteLine();
               continue;
            }
            else if (drawnPosition == 15)
            {
               Console.WriteLine(pieces[drawnPosition]);
               continue;
            }

            Console.Write(pieces[drawnPosition] + " | ");
         }
         Console.WriteLine("\n");
      }

      public int GetMove()
      {
         int humanMove = 0;
         bool continueLoop = true;
         do
         {  
            try
            {
               Console.Write("Where do you want to put your 'x'? Or type CtrlZ to quit> ");     
               humanMove = Convert.ToInt32(Console.ReadLine());
               pieces[humanMove] = pieces[humanMove];

               while (SetNewPiece(humanMove, Convert.ToString('x')))
               {
                  Console.WriteLine("That spot's already taken. ");
                  DrawBoard();
                  Console.Write("Where do you want to put your 'x' ?> ");
                  humanMove = Convert.ToInt32(Console.ReadLine());
               }

               continueLoop = false;
               return humanMove;
            }
            catch (FormatException)
            {
               Console.WriteLine("\nI don't think that's right. \nTry typing the integer of a free position on the board.\n");
            }
            catch (IndexOutOfRangeException)
            {
               Console.WriteLine("\nI don't think that's right. \nTry typing the integer of a free position on the board.\n");
            }
         } while(continueLoop);
         return humanMove;
      }

      public bool SetNewPiece(int position, string pieceType)
      {
         if (pieces[position] == Convert.ToString('x') || pieces[position] == Convert.ToString('o'))
         {
            return true;
         }
         else
         {
            pieces[position] = pieceType;
            return false;
         }
      }

      public int ComputerMove(int position)
      {
         Console.WriteLine("\nIt's my turn.");
         SetNewPiece(position, Convert.ToString("o"));
         DrawBoard();
         int humanMove = GetMove();
         return humanMove;
      }

   }
   class Play
   {
      public enum Status { CONTINUE, WIN, LOSE, TIE }
      
      public void Tie(ref Status gameStatus)
      {
         gameStatus = Status.TIE;
      }

      public void Lose(ref Status gameStatus, ref CreateBoard firstGame, int position)
      {
         firstGame.SetNewPiece(position, Convert.ToString("o"));
         gameStatus = Status.LOSE;
      }
  
      CreateBoard firstGame = new CreateBoard();
      Status gameStatus = Status.CONTINUE;
      
      firstGame.DrawBoard();
      int position0 = 0, position1 = 1, position2 = 2, position3 = 4, position4 = 5, position5 = 6, position6 = 8, position7 = 9, position8 = 10, position9 = 3, position10 = 7, position11 = 11, position12 = 12, position13 = 13, position14 = 14, position15 = 15;
      Console.WriteLine("Well hello there. \nYou look to be a human of above average intelligence. \nLet's play a round of Tic Tac Toe. I'll be 'o' and you'll be 'x'. \nYou know what? I'll let you go first.\n");

      int humanMove = firstGame.GetMove();


      //FIRST HUMAN MOVE IS IN A CORNER
      if (humanMove == 0 || humanMove == 2 || humanMove == 8 || humanMove == 10)
      {
         if (humanMove == 2)
         {
            position0 = 2;
            position1 = 6;
            position2 = 10;
            position3 = 1;
            position4 = 5;
            position5 = 9;
            position6 = 0;
            position7 = 4;
            position8 = 8;
         }
         else if (humanMove == 8)
         {
            position0 = 8;
            position1 = 4;
            position2 = 0;
            position3 = 9;
            position4 = 5;
            position5 = 1;
            position6 = 10;
            position7 = 6;
            position8 = 2;
         }
         else if (humanMove == 10)
         {
            position0 = 10;
            position1 = 9;
            position2 = 8;
            position3 = 6;
            position4 = 5;
            position5 = 4;
            position6 = 2;
            position7 = 1;
            position8 = 0;
         }

         humanMove = firstGame.ComputerMove(position4);

         if (humanMove == position1)
         {
            humanMove = firstGame.ComputerMove(position2);

            if (humanMove == position6)
            {
               humanMove = firstGame.ComputerMove(position3);
               if (humanMove == position5)
               {
                  firstGame.ComputerMove(position7);
                  Tie(ref gameStatus);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position5);
               }
            }
            else
            {
               Lose(ref gameStatus, ref firstGame, position6);
            }
         }
         else if (humanMove == position2)
         {
            humanMove = firstGame.ComputerMove(position1);
            if (humanMove == position7)
            {
               humanMove = firstGame.ComputerMove(position5);
               if (humanMove == position3)
               {
                  firstGame.ComputerMove(position6);
                  Tie(ref gameStatus);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position3);
               }
            }
            else
            {
               Lose(ref gameStatus, ref firstGame, position7);
            }
         }
         else if (humanMove == position3)
         {
            humanMove = firstGame.ComputerMove(position6);
            if (humanMove == position2)
            {
               humanMove = firstGame.ComputerMove(position1);
               if (humanMove == position7)
               {
                  firstGame.ComputerMove(position5);
                  Tie(ref gameStatus);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position7);
               }
            }
            else
            {
               Lose(ref gameStatus, ref firstGame, position2);
            }
         }
         else if (humanMove == position5)
         {
            humanMove = firstGame.ComputerMove(position7);
            if (humanMove == position1)
            {
               humanMove = firstGame.ComputerMove(position2);
               if (humanMove == position6)
               {
                  firstGame.ComputerMove(position3);
                  Tie(ref gameStatus);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position6);
               }
            }
            else
            {
               Lose(ref gameStatus, ref firstGame, position1);
            }
         }
         else if (humanMove == position6)
         {
            humanMove = firstGame.ComputerMove(position3);
            if (humanMove == position5)
            {
               humanMove = firstGame.ComputerMove(position7);
               if (humanMove == position1)
               {
                  firstGame.ComputerMove(position2);
                  Tie(ref gameStatus);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position1);
               }
            }
            else
            {
               Lose(ref gameStatus, ref firstGame, position5);
            }
         }
         else if (humanMove == position7)
         {
            humanMove = firstGame.ComputerMove(position5);
            if (humanMove == position3)
            {
               humanMove = firstGame.ComputerMove(position6);
               if (humanMove == position2)
               {
                  firstGame.ComputerMove(position1);
                  Tie(ref gameStatus);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position2);
               }
            }
            else
            {
               Lose(ref gameStatus, ref firstGame, position3);
            }
         }
         else if (humanMove == position8)
         {
            humanMove = firstGame.ComputerMove(position1);
            if (humanMove == position7)
            {
               humanMove = firstGame.ComputerMove(position6);
               if (humanMove == position2)
               {
                  firstGame.ComputerMove(position5);
                  Tie(ref gameStatus);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position2);
               }
            }
            else
            {
               Lose(ref gameStatus, ref firstGame, position7);
            }
         }
      }
      //IF FIRST HUMAN MOVE IS A SIDE POSITION
      else if (humanMove == 1 || humanMove == 4 || humanMove == 6 || humanMove == 9)
      {
         if (humanMove == 4)
         {
            position0 = 8;
            position1 = 4;
            position2 = 0;
            position3 = 9;
            position4 = 5;
            position5 = 1;
            position6 = 10;
            position7 = 6;
            position8 = 2;
         }
         else if (humanMove == 6)
         {
            position0 = 2;
            position1 = 6;
            position2 = 10;
            position3 = 1;
            position4 = 5;
            position5 = 9;
            position6 = 0;
            position7 = 4;
            position8 = 8;
         }
         else if (humanMove == 9)
         {
            position0 = 10;
            position1 = 9;
            position2 = 8;
            position3 = 6;
            position4 = 5;
            position5 = 4;
            position6 = 2;
            position7 = 1;
            position8 = 0;
         }
         humanMove = firstGame.ComputerMove(position4);
         if (humanMove == position0)
         {
            humanMove = firstGame.ComputerMove(position2);
            if (humanMove == position6)
            {
               humanMove = firstGame.ComputerMove(position3);
               if (humanMove == position5)
               {
                  firstGame.ComputerMove(position7);
                  Tie(ref gameStatus);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position5);
               }
            }
            else
            {
               Lose(ref gameStatus, ref firstGame, position6);
            }
         }
         else if (humanMove == position2)
         {
            humanMove = firstGame.ComputerMove(position0);
            if (humanMove == position8)
            {
               humanMove = firstGame.ComputerMove(position5);
               if (humanMove == position3)
               {
                  firstGame.ComputerMove(position7);
                  Tie(ref gameStatus);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position3);
               }
            }
            else
            {
               Lose(ref gameStatus, ref firstGame, position8);
            }
         }
         else if (humanMove == position3)
         {
            humanMove = firstGame.ComputerMove(position6);
            if (humanMove == position2)
            {
               humanMove = firstGame.ComputerMove(position0);
               if (humanMove == position8)
               {
                  firstGame.ComputerMove(position5);
                  Tie(ref gameStatus);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position8);
               }
            }
            else
            {
               Lose(ref gameStatus, ref firstGame, position2);
            }
         }
         else if (humanMove == position5)
         {
            humanMove = firstGame.ComputerMove(position8);
            if (humanMove == position0)
            {
               humanMove = firstGame.ComputerMove(position2);
               if (humanMove == position6)
               {
                  firstGame.ComputerMove(position3);
                  Tie(ref gameStatus);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position6);
               }
            }
            else
            {
               Lose(ref gameStatus, ref firstGame, position0);
            }
         }
         else if (humanMove == position6)
         {
            humanMove = firstGame.ComputerMove(position3);
            if (humanMove == position5)
            {
               humanMove = firstGame.ComputerMove(position8);
               if (humanMove == position0)
               {
                  firstGame.ComputerMove(position2);
                  Tie(ref gameStatus);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position0);
               }
            }
            else
            {
               Lose(ref gameStatus, ref firstGame, position5);
            }
         }
         else if (humanMove == position7)
         {
            humanMove = firstGame.ComputerMove(position8);
            if (humanMove == position0)
            {
               humanMove = firstGame.ComputerMove(position2);
               if (humanMove == position5)
               {
                  Lose(ref gameStatus, ref firstGame, position6);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position5);
               }
            }
            else
            {
               Lose(ref gameStatus, ref firstGame, position0);
            }
         }
         else if (humanMove == position8)
         {
            humanMove = firstGame.ComputerMove(position5);
            if (humanMove == position3)
            {
               humanMove = firstGame.ComputerMove(position6);
               if (humanMove == position2)
               {
                  firstGame.ComputerMove(position0);
                  Tie(ref gameStatus);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position2);
               }
            }
            else
            {
               Lose(ref gameStatus, ref firstGame, position3);
            }
         }
      }
      

      //IF THE FIRST HUMAN MOVE IS THE CENTER
      else
      {
         humanMove = firstGame.ComputerMove(position0);
         if (humanMove == position1)
         {
            humanMove = firstGame.ComputerMove(position7);
            if (humanMove == position2)
            {
               humanMove = firstGame.ComputerMove(position6);
               if (humanMove == position3)
               {
                  Lose(ref gameStatus, ref firstGame, position8);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position3);
               }
            }
            else if (humanMove == position3)
            {
               humanMove = firstGame.ComputerMove(position5);
               if (humanMove == position2)
               {
                  firstGame.ComputerMove(position6);
                  Tie(ref gameStatus);
               }
               else if (humanMove == position6)
               {
                  firstGame.ComputerMove(position2);
                  Tie(ref gameStatus);
               }
               else
               {
                  firstGame.ComputerMove(position2);
                  Tie(ref gameStatus);
               }
            }
            else if (humanMove == position5)
            {
               humanMove = firstGame.ComputerMove(position3);
               if (humanMove == position6)
               {
                  firstGame.ComputerMove(position2);
                  Tie(ref gameStatus);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position6);
               }
            }
            else if (humanMove == position6)
            {
               humanMove = firstGame.ComputerMove(position2);
               if (humanMove == position3)
               {
                  firstGame.ComputerMove(position5);
                  Tie(ref gameStatus);
               }
               else if (humanMove == position5)
               {
                  firstGame.ComputerMove(position3);
                  Tie(ref gameStatus);
               }
               else if (humanMove == position8)
               {
                  firstGame.ComputerMove(position5);
                  Tie(ref gameStatus);
               }
            }
            else if (humanMove == position8)
            {
               humanMove = firstGame.ComputerMove(position6);
               if (humanMove == position3)
               {
                  firstGame.ComputerMove(position5);
                  Tie(ref gameStatus);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position3);
               }
            }
         }
         else if (humanMove == position2)
         {
            humanMove = firstGame.ComputerMove(position6);
            if (humanMove == position3)
            {
               humanMove = firstGame.ComputerMove(position5);
               if (humanMove == position1)
               {
                  firstGame.ComputerMove(position7);
                  Tie(ref gameStatus);
               }
               else if (humanMove == position2)
               {
                  firstGame.ComputerMove(position1);
                  Tie(ref gameStatus);
               }
               else if (humanMove == position8)
               {
                  firstGame.ComputerMove(position1);
                  Tie(ref gameStatus);
               }
            }
            else
            {
               Lose(ref gameStatus, ref firstGame, position3);
            }
         }
         else if (humanMove == position3)
         {
            humanMove = firstGame.ComputerMove(position5);
            if (humanMove == position1)
            {
               humanMove = firstGame.ComputerMove(position7);
               if (humanMove == position2)
               {
                  firstGame.ComputerMove(position6);
                  Tie(ref gameStatus);
               }
               else if (humanMove == position6)
               {
                  firstGame.ComputerMove(position2);
                  Tie(ref gameStatus);
               }
               else if (humanMove == position8)
               {
                  firstGame.ComputerMove(position2);
                  Tie(ref gameStatus);
               }
            }
            else if (humanMove == position2)
            {
               humanMove = firstGame.ComputerMove(position6);
               if (humanMove == position1)
               {
                  firstGame.ComputerMove(position7);
                  Tie(ref gameStatus);
               }
               else if (humanMove == position7)
               {
                  firstGame.ComputerMove(position1);
                  Tie(ref gameStatus);
               }
               else if (humanMove == position8)
               {
                  firstGame.ComputerMove(position1);
                  Tie(ref gameStatus);
               }
            }
            else if (humanMove == position6)
            {
               humanMove = firstGame.ComputerMove(position2);
               if (humanMove == position1)
               {
                  Lose(ref gameStatus, ref firstGame, position8);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position1);
               }
            }
            else if (humanMove == position7)
            {
               humanMove = firstGame.ComputerMove(position1);
               if (humanMove == position2)
               {
                  firstGame.ComputerMove(position6);
                  Tie(ref gameStatus);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position2);
               }
            }
            else if (humanMove == position8)
            {
               humanMove = firstGame.ComputerMove(position2);
               if (humanMove == position1)
               {
                  firstGame.ComputerMove(position7);
                  Tie(ref gameStatus);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position1);
               }
            }
         }
         else if (humanMove == position5)
         {
            humanMove = firstGame.ComputerMove(position3);
            if (humanMove == position6)
            {
               humanMove = firstGame.ComputerMove(position2);
               if (humanMove == position1)
               {
                  firstGame.ComputerMove(position7);
                  Tie(ref gameStatus);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position1);
               }
            }
            else
            {
               Lose(ref gameStatus, ref firstGame, position6);
            }
         }
         else if (humanMove == position6)
         {
            humanMove = firstGame.ComputerMove(position2);
            if (humanMove == position1)
            {
               humanMove = firstGame.ComputerMove(position7);
               if (humanMove == position3)
               {
                  firstGame.ComputerMove(position5);
                  Tie(ref gameStatus);
               }
               else if (humanMove == position5)
               {
                  firstGame.ComputerMove(position3);
                  Tie(ref gameStatus);
               }
               else if (humanMove == position8)
               {
                  firstGame.ComputerMove(position3);
                  Tie(ref gameStatus);
               }
            }
            else
            {
               Lose(ref gameStatus, ref firstGame, position1);
            }
         }
         else if (humanMove == position7)
         {
            humanMove = firstGame.ComputerMove(position1);
            if (humanMove == position2)
            {
              humanMove = firstGame.ComputerMove(position6);
               if (humanMove == position3)
               {
                  firstGame.ComputerMove(position5);
                  Tie(ref gameStatus);
               }
               else
               {
                  Lose(ref gameStatus, ref firstGame, position3);
               }
            }
            else
            {
               Lose(ref gameStatus, ref firstGame, position2);
            }
         }
         else if (humanMove == position8)
         {
            humanMove = firstGame.ComputerMove(position2);
            if (humanMove == position1)
            {
               humanMove = firstGame.ComputerMove(position7);
               if (humanMove == position3)
               {
                  firstGame.ComputerMove(position5);
                  Tie(ref gameStatus);
               }
               else if (humanMove == position5)
               {
                  firstGame.ComputerMove(position3);
                  Tie(ref gameStatus);
               }
               else if (humanMove == position6)
               {
                  firstGame.ComputerMove(position3);
                  Tie(ref gameStatus);
               }
            }
            else
            {
               Lose(ref gameStatus, ref firstGame, position1);
            }
         }
      }
      firstGame.DrawBoard();
      switch (gameStatus)
      {
         case Status.TIE:
            Console.WriteLine("\nHm. Looks like we tied. More than I expected from a human. Congratulations.");
            break;
         case Status.LOSE:
            Console.WriteLine("\nLooks like I won! MWAHAHA!");
            break;
         case Status.WIN:
            Console.WriteLine("\nWow. Um. You. Won?");
            break;
         default:
            Console.WriteLine("\nSorry. Error. I guess computers can mess up to.");
            break;
      }

      Console.ReadLine();
   }
}
