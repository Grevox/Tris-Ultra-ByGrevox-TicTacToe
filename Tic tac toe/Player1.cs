using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe
{

    public class Pl1
    {
        public char position1 = '.';
        public char position2 = '.';
        public char position3 = '.';
        public char position4 = '.';
        public char position5 = '.';
        public char position6 = '.';
        public char position7 = '.';
        public char position8 = '.';
        public char position9 = '.';
        public const String cheers1 = "player1 wins, congratulations!";
        public const String cheers2 = "player2 wins, unexpected!";
        public Boolean position1b = false;
        public Boolean position2b = false;
        public Boolean position3b = false;
        public Boolean position4b = false;
        public Boolean position5b = false;
        public Boolean position6b = false;
        public Boolean position7b = false;
        public Boolean position8b = false;
        public Boolean position9b = false;

        public void Grid()
        {
            
            Console.Write(position1 + "     "); Console.Write(position2 + "     "); Console.WriteLine(position3);
            Console.Write(position4 + "     "); Console.Write(position5 + "     "); Console.WriteLine(position6);
            Console.Write(position7 + "     "); Console.Write(position8 + "     "); Console.WriteLine(position9);


        }
        public void yPlacer() 
        {
            
                String secondChoice = Console.ReadLine();
                int convertedchoice = Convert.ToInt32(secondChoice);
                if (convertedchoice == 1 && position1b == false)
                {
                    position1 = 'O';
                position1b = true;


                }
                else if (convertedchoice == 2 && position2b == false)
                {
                    position2 = 'O';
                position2b = true;



                }
                else if (convertedchoice == 3 && position3b == false)
                {
                    position3 = 'O';
                position3b = true;



                }
                else if (convertedchoice == 4 && position4b == false)
                {
                    position4 = 'O';
                position4b = true;


                }
                else if (convertedchoice == 5 && position5b == false)
                {
                    position5 = 'O';
                position5b = true;


                }
                else if (convertedchoice == 6 && position6b == false)
                {
                    position6 = 'O';
                position6b = true;


                }
                else if (convertedchoice == 7 && position7b == false)
                {
                    position7 = 'O';
                position7b = true;


                }
                else if (convertedchoice == 8 && position8b == false)
                {
                    position8 = 'O';
                position8b =true;


                }
                else if (convertedchoice == 9 && position9b == false)
                {
                    position9 = 'O';
                position9b = true;


                }


            Grid();
            }

        public void xplacer()    
        {
            String firstChoice = Console.ReadLine();
            


            int convertedchoice = Convert.ToInt32(firstChoice);
            if (convertedchoice == 1 && position1b == false)
            {
                position1 = 'X';
                position1b = true;


            }
            else if (convertedchoice == 2 && position2b == false)
            {
                position2 = 'X';
                position2b = true;



            }
            else if (convertedchoice == 3 && position3b == false)
            {
                position3 = 'X';
                position3b = true;



            }
            else if (convertedchoice == 4&& position4b == false)
            {
                position4 = 'X';
                position4b = true;


            }
            else if (convertedchoice == 5 && position5b == false)
            {
                position5 = 'X';
                position5b = true;


            }
            else if (convertedchoice == 6 && position6b == false)
            {
                position6 = 'X';
                position6b = true;


            }
            else if (convertedchoice == 7 && position7b == false )
            {
                position7 = 'X';
                position7b = true;


            }
            else if (convertedchoice == 8 && position8b == false )
            {
                position8 = 'X';
                position8b = true;


            }
            else if (convertedchoice == 9 && position9b == false)
            {
                position9b = true;
                position9 = 'X';


            }
            
            Grid();
            



        }
        public void WinCheckP1()
        {
            if (position1 == 'X' && position2 == 'X' && position3 == 'X')
            {
                Console.WriteLine(cheers1);
                
                WonNo();
            }
            else if(position1 == 'X' && position5 == 'X' && position9 == 'X') 
            {

                Console.WriteLine(cheers1);
               
                WonNo();

            }
            else if (position3 == 'X' && position5 == 'X' && position7 == 'X')
            {

                Console.WriteLine(cheers1);
                
                WonNo();

            }
            else if (position1 == 'X' && position4 == 'X' && position7 == 'X')
            {

                Console.WriteLine(cheers1);
                
                WonNo();

            }
            else if (position2 == 'X' && position5 == 'X' && position8 == 'X')
            {

                Console.WriteLine(cheers1);
                
                WonNo();

            }
            else if (position7 == 'X' && position8 == 'X' && position9 == 'X')
            {

                Console.WriteLine(cheers1);
                
                WonNo();
            }
            else if (position4 == 'X' && position5 == 'X' && position6 == 'X')
            {

                Console.WriteLine(cheers1);
               
                WonNo();

            }
            else if (position3 == 'X' && position6 == 'X' && position9 == 'X')
            {

                Console.WriteLine(cheers1);
               
                WonNo();

            }
            


        }
        public void WinCheckP2()
        {
            if (position1 == 'O' && position2 == 'O' && position3 == 'O')
            {
                Console.WriteLine(cheers2);
                
                WonNo();
            }
            else if (position1 == 'O' && position5 == 'O' && position9 == 'O')
            {

                Console.WriteLine(cheers2);
                
                WonNo();

            }
            else if (position3 == 'O' && position5 == 'O' && position7 == 'O')
            {

                Console.WriteLine(cheers2);
               
                WonNo();

            }
            else if (position1 == 'O' && position4 == 'O' && position7 == 'O')
            {

                Console.WriteLine(cheers2);
                
                WonNo();

            }
            else if (position2 == 'O' && position5 == 'O' && position8 == 'O')
            {

                Console.WriteLine(cheers2);
                
                WonNo();

            }
            else if (position7 == 'O' && position8 == 'O' && position9 == 'O')
            {

                Console.WriteLine(cheers2);
                
                WonNo();

            }
            else if (position4 == 'O' && position5 == 'O' && position6 == 'O')
            {

                Console.WriteLine(cheers2);
                
                WonNo();

            }
            else if (position3 == 'O' && position6 == 'O' && position9 == 'O')
            {

                Console.WriteLine(cheers2);
                
                WonNo();
                


            }
            


        }
       public void P1turn()
        {
            Console.WriteLine("P1 turn");
            xplacer();
            WinCheckP1();
        }
        public void P2turn() 
        {
        Console.WriteLine("P2 Turn");
            yPlacer();
            WinCheckP2();
        
        
        }
        
        public void WonNo()
        {
            Console.WriteLine("\n\n\n[press enter to continue]");
            
            TicTacToe.callmeplease();
        }
        public void continueNo() 
        {
            if (position1b == true && position2b == true && position3b == true && position4b == true && position5b == true && position6b == true && position7b == true && position8b == true && position9b == true)
            {
                Console.WriteLine("game ended");
                WonNo();
            
            
            
            }
            else if (position1b == false || position2b == false || position3b == false || position4b == false || position5b == false || position6b == false || position7b == false || position8b == false || position9b == false)
            {
                P1turn();
                P2turn();
            }



        }



        public Pl1()
        {
            
            Grid();
            
            Console.WriteLine("P1, GET READY!");
            continueNo();
            continueNo();
            continueNo();
            continueNo();
            continueNo();
            continueNo();
            continueNo();
            continueNo();
            continueNo();
            continueNo();
            continueNo();
            continueNo();
            continueNo();
            continueNo();
            continueNo();
            continueNo();
            continueNo();
            continueNo();
            continueNo();
            continueNo();










        }







    }
    }

