using System;

namespace TicTacToe
{ 
   class Play
   {
      public enum Status { CONTINUE, WIN, LOSE, TIE }
      private CreateBoard firstGame;
      public Play() 
      {
         firstGame = new CreateBoard();
      }

      public static int GetMove()
      {
         Console.Write("Where do you want to put your 'x' ?> ");
         return Convert.ToInt32(Console.ReadLine());
      }
  
      public static void Main(string[] args)
      {
         Play play = new Play();
         Status gameStatus = Status.CONTINUE;
         
         play.firstGame.DrawBoard();
         int position0 = 0, position1 = 1, position2 = 2, position3 = 3, position4 = 4, position5 = 5, position6 = 6, position7 = 7, position8 = 8;
         Console.WriteLine("Well hello there. \nYou look to be a human of above average intelligence. \nLet's play a round of Tic Tac Toe. I'll be 'o' and you'll be 'x'. \nYou know what? I'll let you go first.\n");

         int humanMove = GetMove();
         while(play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
         {
            Console.Write("That spot's already taken. ");
            humanMove = GetMove();
         }

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

            play.firstGame.SetNewPiece(position4, Convert.ToChar("o"));
            play.firstGame.DrawBoard();
            humanMove = GetMove();
            while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
            {
               Console.Write("That spot's already taken. ");
               humanMove = GetMove();
            }

            if (humanMove == position1)
            {
               play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }

               if (humanMove == position6)
               {
                  play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }

                  if (humanMove == position5)
                  {
                     play.firstGame.SetNewPiece(position7, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }

                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
               else
               {
                  play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  gameStatus = Status.LOSE;
               }
            }
            else if (humanMove == position2)
            {
               play.firstGame.SetNewPiece(position1, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }
               if (humanMove == position7)
               {
                  play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position3)
                  {
                     play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
               else
               {
                  play.firstGame.SetNewPiece(position7, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  gameStatus = Status.LOSE;
               }
            }
            else if (humanMove == position3)
            {
               play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }
               if (humanMove == position2)
               {
                  play.firstGame.SetNewPiece(position1, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position7)
                  {
                     play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position7, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
               else
               {
                  play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  gameStatus = Status.LOSE;
               }
            }
            else if (humanMove == position5)
            {
               play.firstGame.SetNewPiece(position7, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }
               if (humanMove == position1)
               {
                  play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position6)
                  {
                     play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
               else
               {
                  play.firstGame.SetNewPiece(position1, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  gameStatus = Status.LOSE;
               }
            }
            else if (humanMove == position6)
            {
               play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }
               if (humanMove == position5)
               {
                  play.firstGame.SetNewPiece(position7, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position1)
                  {
                     play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position1, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
               else
               {
                  play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  gameStatus = Status.LOSE;
               }
            }
            else if (humanMove == position7)
            {
               play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }
               if (humanMove == position3)
               {
                  play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position2)
                  {
                     play.firstGame.SetNewPiece(position1, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
               else
               {
                  play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  gameStatus = Status.LOSE;
               }
            }
            else if (humanMove == position8)
            {
               play.firstGame.SetNewPiece(position1, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }
               if (humanMove == position7)
               {
                  play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position2)
                  {
                     play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position3)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
               else
               {
                  play.firstGame.SetNewPiece(position7, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  gameStatus = Status.LOSE;
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
            play.firstGame.SetNewPiece(position4, Convert.ToChar("o"));
            play.firstGame.DrawBoard();
            humanMove = GetMove();
            while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
            {
               Console.Write("That spot's already taken. ");
               humanMove = GetMove();
            }
            if (humanMove == position0)
            {
               play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }
               if (humanMove == position6)
               {
                  play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position5)
                  {
                     play.firstGame.SetNewPiece(position7, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
               else
               {
                  play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  gameStatus = Status.LOSE;
               }
            }
            else if (humanMove == position2)
            {
               play.firstGame.SetNewPiece(position0, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }
               if (humanMove == position8)
               {
                  play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position3)
                  {
                     play.firstGame.SetNewPiece(position7, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
               else
               {
                  play.firstGame.SetNewPiece(position8, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  gameStatus = Status.LOSE;
               }
            }
            else if (humanMove == position3)
            {
               play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }
               if (humanMove == position2)
               {
                  play.firstGame.SetNewPiece(position0, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position8)
                  {
                     play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position7)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position8, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
               else
               {
                  play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  gameStatus = Status.LOSE;
               }
            }
            else if (humanMove == position5)
            {
               play.firstGame.SetNewPiece(position8, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }
               if (humanMove == position0)
               {
                  play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position6)
                  {
                     play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position7)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
               else
               {
                  play.firstGame.SetNewPiece(position0, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  gameStatus = Status.LOSE;
               }
            }
            else if (humanMove == position6)
            {
               play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }
               if (humanMove == position5)
               {
                  play.firstGame.SetNewPiece(position8, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position0)
                  {
                     play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position7)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position0, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
               else
               {
                  play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  gameStatus = Status.LOSE;
               }
            }
            else if (humanMove == position7)
            {
               play.firstGame.SetNewPiece(position8, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }
               if (humanMove == position0)
               {
                  play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position5)
                  {
                     play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
               else
               {
                  play.firstGame.SetNewPiece(position0, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  gameStatus = Status.LOSE;
               }
            }
            else if (humanMove == position8)
            {
               play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }
               if (humanMove == position3)
               {
                  play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position2)
                  {
                     play.firstGame.SetNewPiece(position0, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position7)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
               else
               {
                  play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  gameStatus = Status.LOSE;
               }
            }
         }
         //IF THE FIRST HUMAN MOVE IS THE CENTER
         else
         {
            play.firstGame.SetNewPiece(position0, Convert.ToChar("o"));
            play.firstGame.DrawBoard();
            humanMove = GetMove();
            while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
            {
               Console.Write("That spot's already taken. ");
               humanMove = GetMove();
            }
            if (humanMove == position1)
            {
               play.firstGame.SetNewPiece(position7, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }
               if (humanMove == position2)
               {
                  play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position3)
                  {
                     play.firstGame.SetNewPiece(position8, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
               else if (humanMove == position3)
               {
                  play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position2)
                  {
                     play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else if (humanMove == position6)
                  {
                     play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position6)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
               }
               else if (humanMove == position5)
               {
                  play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position6)
                  {
                     play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
               else if (humanMove == position6)
               {
                  play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position3)
                  {
                     play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else if (humanMove == position5)
                  {
                     play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else if (humanMove == position8)
                  {
                     play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position3)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
               }
               else if (humanMove == position8)
               {
                  play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position3)
                  {
                     play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position2)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
            }
            else if (humanMove == position2)
            {
               play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }
               if (humanMove == position3)
               {
                  play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position1)
                  {
                     play.firstGame.SetNewPiece(position7, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else if (humanMove == position2)
                  {
                     play.firstGame.SetNewPiece(position1, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else if (humanMove == position8)
                  {
                     play.firstGame.SetNewPiece(position1, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position7)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
               }
               else
               {
                  play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  gameStatus = Status.LOSE;
               }
            }
            else if (humanMove == position3)
            {
               play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }
               if (humanMove == position1)
               {
                  play.firstGame.SetNewPiece(position7, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position2)
                  {
                     play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else if (humanMove == position6)
                  {
                     play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else if (humanMove == position8)
                  {
                     play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position6)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
               }
               else if (humanMove == position2)
               {
                  play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position1)
                  {
                     play.firstGame.SetNewPiece(position7, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else if (humanMove == position7)
                  {
                     play.firstGame.SetNewPiece(position1, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else if (humanMove == position8)
                  {
                     play.firstGame.SetNewPiece(position1, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position7)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
               }
               else if (humanMove == position6)
               {
                  play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position1)
                  {
                     play.firstGame.SetNewPiece(position8, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position1, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
               else if (humanMove == position7)
               {
                  play.firstGame.SetNewPiece(position1, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position2)
                  {
                     play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
               else if (humanMove == position8)
               {
                  play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position1)
                  {
                     play.firstGame.SetNewPiece(position7, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position6)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position1, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
            }
            else if (humanMove == position5)
            {
               play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }
               if (humanMove == position6)
               {
                  play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position1)
                  {
                     play.firstGame.SetNewPiece(position7, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position1, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
               else
               {
                  play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  gameStatus = Status.LOSE;
               }
            }
            else if (humanMove == position6)
            {
               play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }
               if (humanMove == position1)
               {
                  play.firstGame.SetNewPiece(position7, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position3)
                  {
                     play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else if (humanMove == position5)
                  {
                     play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else if (humanMove == position8)
                  {
                     play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position5)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
               }
               else
               {
                  play.firstGame.SetNewPiece(position1, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  gameStatus = Status.LOSE;
               }
            }
            else if (humanMove == position7)
            {
               play.firstGame.SetNewPiece(position1, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }
               if (humanMove == position2)
               {
                  play.firstGame.SetNewPiece(position6, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position3)
                  {
                     play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position8)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else
                  {
                     play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     gameStatus = Status.LOSE;
                  }
               }
               else
               {
                  play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  gameStatus = Status.LOSE;
               }
            }
            else if (humanMove == position8)
            {
               play.firstGame.SetNewPiece(position2, Convert.ToChar("o"));
               play.firstGame.DrawBoard();
               humanMove = GetMove();
               while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
               {
                  Console.Write("That spot's already taken. ");
                  humanMove = GetMove();
               }
               if (humanMove == position1)
               {
                  play.firstGame.SetNewPiece(position7, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  humanMove = GetMove();
                  while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                  {
                     Console.Write("That spot's already taken. ");
                     humanMove = GetMove();
                  }
                  if (humanMove == position3)
                  {
                     play.firstGame.SetNewPiece(position5, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position6)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else if (humanMove == position5)
                  {
                     play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position6)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
                  else if (humanMove == position6)
                  {
                     play.firstGame.SetNewPiece(position3, Convert.ToChar("o"));
                     play.firstGame.DrawBoard();
                     humanMove = GetMove();
                     while (play.firstGame.SetNewPiece(humanMove, Convert.ToChar('x')))
                     {
                        Console.Write("That spot's already taken. ");
                        humanMove = GetMove();
                     }
                     if (humanMove == position5)
                     {
                        play.firstGame.DrawBoard();
                        gameStatus = Status.TIE;
                     }
                  }
               }
               else
               {
                  play.firstGame.SetNewPiece(position1, Convert.ToChar("o"));
                  play.firstGame.DrawBoard();
                  gameStatus = Status.LOSE;
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
