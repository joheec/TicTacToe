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
   class Play
   {
      public enum Status { CONTINUE, WIN, LOSE, TIE }
      private CreateBoard firstGame;
      public Play() {
         firstGame = new CreateBoard();
      }

      public static int GetMove()
      {
         Console.Write("Where do you want to put your 'x' ?> ");
         int humanMove = Convert.ToInt32(Console.ReadLine());
         while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
         {
            Console.Write("That spot's already taken.");
            play.firstGame.DrawBoard();
            Console.Write("Where do you want to put your 'x' ?> ");
            humanMove = Convert.ToInt32(Console.ReadLine());
         }

         return humanMove;
      }

      public static int ComputerMove(int position)
      {
         play.firstGame.SetNewPiece(position, Convert.ToChar("o"));
         play.firstGame.DrawBoard();
         int humanMove = GetMove();
         return humanMove;
      }

      public static void Tie()
      {
         play.firstGame.DrawBoard();
         gameStatus = Status.TIE;
      }

      public static void Lose(int position)
      {
         play.firstGame.SetNewPiece(position, Convert.ToChar("o"));
         play.firstGame.DrawBoard();
         gameStatus = Status.LOSE;
      }
  
      public static void Main(string[] args)
      {
         Play play = new Play();
         Status gameStatus = Status.CONTINUE;
         
         play.firstGame.DrawBoard();
         int position0 = 0, position1 = 1, position2 = 2, position3 = 3, position4 = 4, position5 = 5, position6 = 6, position7 = 7, position8 = 8;
         Console.WriteLine("Well hello there. \nYou look to be a human of above average intelligence. \nLet's play a round of Tic Tac Toe. I'll be 'o' and you'll be 'x'. \nYou know what? I'll let you go first.\n");

         int humanMove = GetMove();


         //FIRST HUMAN MOVE IS IN A CORNER
         if (humanMove % 2 == 0 && humanMove != 4)
         {
            if (humanMove == 2)
            {
               position0 = 2;
               position1 = 5;
               position2 = 8;
               position3 = 1;
               position4 = 4;
               position5 = 7;
               position6 = 0;
               position7 = 3;
               position8 = 6;
            }
            else if (humanMove == 6)
            {
               position0 = 6;
               position1 = 3;
               position2 = 0;
               position3 = 7;
               position4 = 4;
               position5 = 1;
               position6 = 8;
               position7 = 5;
               position8 = 2;
            }
            else if (humanMove == 8)
            {
               position0 = 8;
               position1 = 7;
               position2 = 6;
               position3 = 5;
               position4 = 4;
               position5 = 3;
               position6 = 2;
               position7 = 1;
               position8 = 0;
            }

            humanMove = ComputerMove(position4);

            if (humanMove == position1)
            {
               humanMove = ComputerMove(position2);

               if (humanMove == position6)
               {
                  humanMove = ComputerMove(position3);
                  if (humanMove == position5)
                  {
                     ComputerMove(position7);
                     Tie();
                  }
                  else
                  {
                     Lose(position5);
                  }
               }
               else
               {
                  Lose(position6);
               }
            }
            else if (humanMove == position2)
            {
               humanMove = ComputerMove(position1);
               if (humanMove == position7)
               {
                  humanMove = ComputerMove(position5);
                  if (humanMove == position3)
                  {
                     ComputerMove(position6);
                     Tie();
                  }
                  else
                  {
                     Lose(position3);
                  }
               }
               else
               {
                  Lose(position7);
               }
            }
            else if (humanMove == position3)
            {
               humanMove = ComputerMove(position6);
               if (humanMove == position2)
               {
                  humanMove = ComputerMove(position1);
                  if (humanMove == position7)
                  {
                     ComputerMove(position5);
                     Tie();
                  }
                  else
                  {
                     Lose(position7);
                  }
               }
               else
               {
                  Lose(position2);
               }
            }
            else if (humanMove == position5)
            {
               humanMove = ComputerMove(position7);
               if (humanMove == position1)
               {
                  humanMove = ComputerMove(position2);
                  if (humanMove == position6)
                  {
                     ComputerMove(position3);
                     Tie();
                  }
                  else
                  {
                     Lose(position6);
                  }
               }
               else
               {
                  Lose(position1);
               }
            }
            else if (humanMove == position6)
            {
               humanMove = ComputerMove(position3);
               if (humanMove == position5)
               {
                  humanMove = ComputerMove(position7);
                  if (humanMove == position1)
                  {
                     ComputerMove(position2);
                     Tie();
                  }
                  else
                  {
                     Lose(position1);
                  }
               }
               else
               {
                  Lose(position5);
               }
            }
            else if (humanMove == position7)
            {
               humanMove = ComputerMove(position5);
               if (humanMove == position3)
               {
                  humanMove = ComputerMove(position6);
                  if (humanMove == position2)
                  {
                     ComputerMove(position1);
                     Tie();
                  }
                  else
                  {
                     Lose(position2);
                  }
               }
               else
               {
                  Lose(position3);
               }
            }
            else if (humanMove == position8)
            {
               humanMove = ComputerMove(position1);
               if (humanMove == position7)
               {
                  humanMove = ComputerMove(position6);
                  if (humanMove == position2)
                  {
                     ComputerMove(position5);
                     Tie();
                  }
                  else
                  {
                     Lose(position2);
                  }
               }
               else
               {
                  Lose(position7);
               }
            }
         }
         //IF FIRST HUMAN MOVE IS A SIDE POSITION
         else if (humanMove % 2 == 1)
         {
            if (humanMove == 3)
            {
               position0 = 6;
               position1 = 3;
               position2 = 0;
               position3 = 7;
               position4 = 4;
               position5 = 1;
               position6 = 8;
               position7 = 5;
               position8 = 2;
            }
            else if (humanMove == 5)
            {
               position0 = 2;
               position1 = 5;
               position2 = 8;
               position3 = 1;
               position4 = 4;
               position5 = 7;
               position6 = 0;
               position7 = 3;
               position8 = 6;
            }
            else if (humanMove == 7)
            {
               position0 = 8;
               position1 = 7;
               position2 = 6;
               position3 = 5;
               position4 = 4;
               position5 = 3;
               position6 = 2;
               position7 = 1;
               position8 = 0;
            }
            humanMove = ComputerMove(position4);
            if (humanMove == position0)
            {
               humanMove = ComputerMove(position2);
               if (humanMove == position6)
               {
                  humanMove = ComputerMove(position3);
                  if (humanMove == position5)
                  {
                     ComputerMove(position7);
                     Tie();
                  }
                  else
                  {
                     Lose(position5);
                  }
               }
               else
               {
                  Lose(position6);
               }
            }
            else if (humanMove == position2)
            {
               humanMove = ComputerMove(position0);
               if (humanMove == position8)
               {
                  humanMove = ComputerMove(position5);
                  if (humanMove == position3)
                  {
                     ComputerMove(position7);
                     Tie();
                  }
                  else
                  {
                     Lose(position3);
                  }
               }
               else
               {
                  Lose(position8);
               }
            }
            else if (humanMove == position3)
            {
               humanMove = ComputerMove(position6);
               if (humanMove == position2)
               {
                  humanMove = ComputerMove(position0);
                  if (humanMove == position8)
                  {
                     ComputerMove(position5);
                     Tie();
                  }
                  else
                  {
                     Lose(position8);
                  }
               }
               else
               {
                  Lose(position2);
               }
            }
            else if (humanMove == position5)
            {
               humanMove = ComputerMove(position8);
               if (humanMove == position0)
               {
                  humanMove = ComputerMove(position2);
                  if (humanMove == position6)
                  {
                     ComputerMove(position3);
                     Tie();
                  }
                  else
                  {
                     Lose(position6);
                  }
               }
               else
               {
                  Lose(position0);
               }
            }
            else if (humanMove == position6)
            {
               humanMove = ComputerMove(position3);
               if (humanMove == position5)
               {
                  humanMove = ComputerMove(position8);
                  if (humanMove == position0)
                  {
                     ComputerMove(position2);
                     Tie();
                  }
                  else
                  {
                     Lose(position0);
                  }
               }
               else
               {
                  Lose(position5);
               }
            }
            else if (humanMove == position7)
            {
               humanMove = ComputerMove(position8);
               if (humanMove == position0)
               {
                  humanMove = ComputerMove(position2);
                  if (humanMove == position5)
                  {
                     Lose(position6);
                  }
                  else
                  {
                     Lose(position5);
                  }
               }
               else
               {
                  Lose(position0);
               }
            }
            else if (humanMove == position8)
            {
               humanMove = ComputerMove(position5);
               if (humanMove == position3)
               {
                  humanMove = ComputerMove(position6);
                  if (humanMove == position2)
                  {
                     ComputerMove(position0);
                     Tie();
                  }
                  else
                  {
                     Lose(position2);
                  }
               }
               else
               {
                  Lose(position3);
               }
            }
         }
         //IF THE FIRST HUMAN MOVE IS THE CENTER
         else
         {
            humanMove = ComputerMove(position0);
            if (humanMove == position1)
            {
               humanMove = ComputerMove(position7);
               if (humanMove == position2)
               {
                  humanMove = ComputerMove(position6);
                  if (humanMove == position3)
                  {
                     Lose(position8);
                  }
                  else
                  {
                     Lose(position3);
                  }
               }
               else if (humanMove == position3)
               {
                  humanMove = ComputerMove(position5);
                  if (humanMove == position2)
                  {
                     ComputerMove(position6);
                     Tie();
                  }
                  else if (humanMove == position6)
                  {
                     ComputerMove(position2);
                     Tie();
                  }
                  else
                  {
                     ComputerMove(position2);
                     Tie();
                  }
               }
               else if (humanMove == position5)
               {
                  humanMove = ComputerMove(position3);
                  if (humanMove == position6)
                  {
                     ComputerMove(position2);
                     Tie();
                  }
                  else
                  {
                     Lose(position6);
                  }
               }
               else if (humanMove == position6)
               {
                  humanMove = ComputerMove(position2);
                  if (humanMove == position3)
                  {
                     ComputerMove(position5);
                     Tie();
                  }
                  else if (humanMove == position5)
                  {
                     ComputerMove(position3);
                     Tie();
                  }
                  else if (humanMove == position8)
                  {
                     ComputerMove(position5);
                     Tie();
                  }
               }
               else if (humanMove == position8)
               {
                  humanMove = ComputerMove(position6);
                  if (humanMove == position3)
                  {
                     ComputerMove(position5);
                     Tie();
                  }
                  else
                  {
                     Lose(position3);
                  }
               }
            }
            else if (humanMove == position2)
            {
               humanMove = ComputerMove(position6);
               if (humanMove == position3)
               {
                  humanMove = ComputerMove(position5);
                  if (humanMove == position1)
                  {
                     ComputerMove(position7);
                     Tie();
                  }
                  else if (humanMove == position2)
                  {
                     ComputerMove(position1);
                     Tie();
                  }
                  else if (humanMove == position8)
                  {
                     ComputerMove(position1);
                     Tie();
                  }
               }
               else
               {
                  Lose(position3);
               }
            }
            else if (humanMove == position3)
            {
               humanMove = ComputerMove(position5);
               if (humanMove == position1)
               {
                  humanMove = ComputerMove(position7);
                  if (humanMove == position2)
                  {
                     ComputerMove(position6);
                     Tie();
                  }
                  else if (humanMove == position6)
                  {
                     ComputerMove(position2);
                     Tie();
                  }
                  else if (humanMove == position8)
                  {
                     ComputerMove(position2);
                     Tie();
                  }
               }
               else if (humanMove == position2)
               {
                  humanMove = ComputerMove(position6);
                  if (humanMove == position1)
                  {
                     ComputerMove(position7);
                     Tie();
                  }
                  else if (humanMove == position7)
                  {
                     ComputerMove(position1);
                     Tie();
                  }
                  else if (humanMove == position8)
                  {
                     ComputerMove(position1);
                     Tie();
                  }
               }
               else if (humanMove == position6)
               {
                  humanMove = ComputerMove(position2);
                  if (humanMove == position1)
                  {
                     Lose(position8);
                  }
                  else
                  {
                     Lose(position1);
                  }
               }
               else if (humanMove == position7)
               {
                  humanMove = ComputerMove(position1);
                  if (humanMove == position2)
                  {
                     ComputerMove(position6);
                     Tie();
                  }
                  else
                  {
                     Lose(position2);
                  }
               }
               else if (humanMove == position8)
               {
                  humanMove = ComputerMove(position2);
                  if (humanMove == position1)
                  {
                     ComputerMove(position7);
                     Tie();
                  }
                  else
                  {
                     Lose(position1);
                  }
               }
            }
            else if (humanMove == position5)
            {
               humanMove = ComputerMove(position3);
               if (humanMove == position6)
               {
                  humanMove = ComputerMove(position2);
                  if (humanMove == position1)
                  {
                     ComputerMove(position7);
                     Tie();
                  }
                  else
                  {
                     Lose(position1);
                  }
               }
               else
               {
                  Lose(position6);
               }
            }
            else if (humanMove == position6)
            {
               humanMove = ComputerMove(position2);
               if (humanMove == position1)
               {
                  humanMove = ComputerMove(position7);
                  if (humanMove == position3)
                  {
                     ComputerMove(position5);
                     Tie();
                  }
                  else if (humanMove == position5)
                  {
                     ComputerMove(position3);
                     Tie();
                  }
                  else if (humanMove == position8)
                  {
                     ComputerMove(position3);
                     Tie();
                  }
               }
               else
               {
                  Lose(position1);
               }
            }
            else if (humanMove == position7)
            {
               humanMove = ComputerMove(position1);
               if (humanMove == position2)
               {
                 humanMove = ComputerMove(position6);
                  if (humanMove == position3)
                  {
                     ComputerMove(position5);
                     Tie();
                  }
                  else
                  {
                     Lose(position3);
                  }
               }
               else
               {
                  Lose(position2);
               }
            }
            else if (humanMove == position8)
            {
               humanMove = ComputerMove(position2);
               if (humanMove == position1)
               {
                  humanMove = ComputerMove(position7);
                  if (humanMove == position3)
                  {
                     ComputerMove(position5);
                     Tie();
                  }
                  else if (humanMove == position5)
                  {
                     ComputerMove(position3);
                     Tie();
                  }
                  else if (humanMove == position6)
                  {
                     ComputerMove(position3);
                     Tie();
                  }
               }
               else
               {
                  Lose(position1);
               }
            }
         }
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
}
