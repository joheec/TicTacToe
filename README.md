# TicTacToe
My first repository on GitHub
This README is for TicTacToe.cs

Project Name: TicTacToe 
* This program is a console application that lets the user play a round of Tic Tac Toe. The user is never supposed to win, and if possible, the program should win. The user is ‘x’ and the program is ‘o’. The user goes first.

Internal Class: TicTacToe.CreateBoard
* This class holds the current state of the board (where the x’s and o’s are).
* This class will set a new piece on the board if the space does not currently have a piece.
* This class will display the current state of the board on the console.

Internal Class: TicTacToe.Play
* This class has the main method which creates the object (firstGame), places new pieces on the board in response to the user’s moves, and tells the user whether they lost or tied based on the enumeration, Status (gameStatus).
* This class will prompt the user for their next move.

Library: .NET Framework class library
* This library allows access to namespace System, which allows the program to interact with the console.

===============================


To run this .NET application, the .NET Framework needs to be installed. If the .NET Framework needs to be installed, please download Mono for your respective operating system using the following link: http://www.mono-project.com/download/

Once the Mono Framework is installed, type “mcs TicTacToe.cs” to compile the program. Then type “mono TicTacToe.exe” to run the program.

If you ever want to uninstall Mono Framework, type in terminal without "":
1. "sudo /bin/sh -x"
2. then on the next line paste the script text:
"
rm -r /Library/Frameworks/Mono.framework
 
rm -r /Library/Receipts/MonoFramework-*
 
for dir in /usr/bin /usr/share/man/man1 /usr/share/man/man3 /usr/share/man/man5; do
(cd ${dir};
for i in `ls -al | grep /Library/Frameworks/Mono.framework/ | awk '{print $9}'`; do
rm ${i}
done);
done
"

=================================


Author: Johee Chung

Questions or problems related directly to the TicTacToe.cs should be addressed to johee.chung@gmail.com.
