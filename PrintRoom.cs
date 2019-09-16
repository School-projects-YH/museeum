using System;


namespace museumet_1976
{
    public class PrintRoom
    {
        public static void PrintMuseum(int numbeOfRooms)
        {
            Console.Clear();

            Random rand = new Random();        
           

            int oldX = 0;
			int oldLength = 0;

            for (int i = 0; i <= numbeOfRooms; i++){
                int length = rand.Next(5, 12);
                int height = rand.Next(2, 5);
				int startX = rand.Next(0, length);

                PrintOneRoom(length, height, oldX, startX, oldLength);

				oldX = startX;
				oldLength = length;
              
            }
            Console.ReadKey();
        }
        static void PrintOneRoom(int length, int height, int oldX, int startX, int oldLength)
        {  
            
            PrintRow(length, startX, oldX, oldLength);
            PrintContent(length, height, startX);
      
          //  PrintRow(length, startX);
        }
        static void PrintRow(int length, int startX, int oldX, int oldLength)
        {
            if (startX < oldX ){
                for (int y = 0; y < startX; y++ ){
                    Console.Write(y);
                }   
                Console.Write('G');

                for (int i = 0; i < (oldX - startX -1); i++){
                    Console.Write('-');
                }
               	Console.Write('+');

				if ((length + startX) < (oldLength + oldX)){
					for (int i = 0; i < (length - (oldX - startX)); i++){
						Console.Write('-');
					}
					Console.Write("Hej");
					
				}


				


            }else{
                for (int y = 0; y < startX; y++ ){
                    Console.Write(oldX);
                }   
                    Console.Write('+');

                for (int i = 0; i < length; i++){
                    Console.Write('-');
                }
                Console.Write('+');
            }
        }
        static void PrintContent(int length, int height, int startX)
        {
            for (int i = 0; i <= height; i++){
                Console.Write('\n');
                for (int y = 0; y < startX; y++ ){
                    Console.Write(' ');
                }        
                    Console.Write('|');

                for (int u = 0; u < length; u++){
                    Console.Write(' ');
                }
                Console.Write('|');
            }
            Console.Write('\n');
        }
    }


}