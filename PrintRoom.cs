using System;


namespace museumet_1976
{
    public class PrintRoom
    {
        public static void PrintMuseum(int numbeOfRooms)
        {
            Console.Clear();

            Random rand = new Random();        
            int oldHeight = 0;

            for (int i = 0; i <= numbeOfRooms; i++){
                int length = rand.Next(5, 12);
                int height = rand.Next(2, 5);

                if (i < 1){
                    PrintFirstRoom(length, height);
                }else{
                    PrintOneRoom(length, height, oldHeight);
                }
                oldHeight = height;
            }
            Console.ReadKey();
        }
        static void PrintOneRoom(int length, int height, int oldHeight)
        {  
            Random rand = new Random(); 
            int startX = rand.Next(0, length);
            
            Console.SetCursorPosition(startX, oldHeight+2);
            PrintRow(length);
            Console.SetCursorPosition(startX, oldHeight+2);
            PrintContent(length, height);
          //  Console.SetCursorPosition(startX, oldHeight+height);
            PrintRow(length);
        }

        static void PrintFirstRoom(int length, int height)
        {
            PrintRow(length);
            PrintContent(length, height);
            PrintRow(length);            
        }
        static void PrintRow(int length)
        {
            Console.Write('+');
            
            for (int i = 0; i < length; i++){
                Console.Write('-');
            }
            Console.Write('+');
        }
        static void PrintContent(int length, int height)
        {
            for (int i = 0; i <= height; i++){
                Console.Write("\n|");

                for (int u = 0; u < length; u++){
                    Console.Write(' ');
                }
                Console.Write('|');
            }
            Console.Write('\n');
        }
    }


}