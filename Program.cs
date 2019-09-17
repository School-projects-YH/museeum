using System;

namespace museumet_1976
{
    class Program
    {


        static void Main(string[] args)
        {
            /*
                +------+------+------+
                |      |      |      |      
                |   6  |   7  |   8  |
                +------+------+------+
                |      |      |      |
                |   3  |   4  |   5  |
                +------+------+------+
                |      |      |      |
                |   0  |   1  |   2  |
                +------+------+------+

            Vänster = 0
            Höger = 1
            Ner = 2
            Upp = 3
             */

            int roomIndex = 1; // Mitten längst ner är lobbyn
            int direction;
            int numberOfRoomsUntilExit = 0;
            
            bool exit = false;
            bool isThereFire = false;
            bool fireAlarm = true;

            Random fireBreakout = new Random();
            
            string wrongCommand = "Du har valt ett felaktigt alternativ vänligen skriv in ett giltigt!";
            string wallExptected = "Aj! Du sprang in i en vägg";
            string whereDoYouWantToGo = "Vart vill du ta vägen?: ";


           // PrintRoom.PrintMuseum(2);

            Console.WriteLine("Välkommen till LFT!");
            do{  
                    Console.Clear();
                if (fireBreakout.Next(1,10) == 1){
                    isThereFire = true;
                }
                if (isThereFire){
                    numberOfRoomsUntilExit++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("UTRYM!! Det brinner");
                    
                    for (int i = 0; i < 5; i++){
                        Console.Beep(3500, 2000);
                        Console.Beep(3000, 2000);

                        if (Console.ReadKey() != null){
                            break;
                        }
                    }
                } 
                           
                switch  (roomIndex){                    
                    case 0 :                        

                        Console.WriteLine("Det här är vattnets rum . Även kallat badhus av vissa individer");
                        Console.Write("\n \n [2] Höger \n [4] Uppåt \n\n");
                        Console.WriteLine(whereDoYouWantToGo);
                        
                        direction = Convert.ToInt32(Console.ReadLine()) - 1;

                        switch(direction){
                            case 0 : // vänster
                                Console.WriteLine(wallExptected); 
                                Console.ReadKey();        
                            break;                          

                            case 1 : // Höger
                                roomIndex++;
                            break;
                            
                            case 2 : // Ner går ut
                                Console.WriteLine(wallExptected);
                                Console.ReadKey();  
                            break;
                            
                            case 3 : // upp
                                roomIndex += 3;
                            break;
                            
                            default :
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(wrongCommand);
                                Console.ForegroundColor = ConsoleColor.Gray;
                            break;                 
                        }
                    break;

                    case 1 :

                    Console.WriteLine("Det här rummet är en ganska tråkig lobby. Enbart cement med en liten recpetionsdisk");
                    Console.Write("\n [1] Vänster \n [2] Höger \n [3] Gå ut ur museeumet \n [4] Uppåt \n\n");
                    Console.WriteLine(whereDoYouWantToGo);
                    
                    direction = Convert.ToInt32(Console.ReadLine()) - 1;

                        switch(direction){
                            case 0 : // vänster
                                roomIndex--;
                            break; 

                            case 1 : // Höger
                                roomIndex++;
                            break;

                            case 2 : // Ner går ut
                                exit = true;
                            break;

                            case 3 : // upp
                                roomIndex += 3;
                            break;

                            default :
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(wrongCommand);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                        }

                    break;

                    case 2 :
                        
                        Console.WriteLine("Här brukar Steffe hänga");
                        Console.Write("\n [1] Vänster \n [4] Uppåt \n\n");
                        Console.WriteLine(whereDoYouWantToGo);

                        direction = Convert.ToInt32(Console.ReadLine()) - 1;
                        
                        switch(direction){
                            case 0 : // vänster
                                roomIndex--;
                            break; 

                            case 1 : // Höger
                                Console.WriteLine(wallExptected);
                                Console.ReadKey();  
                            break;

                            case 2 : // Ner går ut
                               Console.WriteLine(wallExptected);
                               Console.ReadKey();  
                            break;

                            case 3 : // upp
                                roomIndex += 3;
                            break;
                            
                            default :
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(wrongCommand);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                        }
                    break;
                    
                    case 3 :

                        Console.WriteLine("Välkommen till TV rummet här går vi ignom TV'ns historia.");
                        Console.Write(" [2] Höger \n [3] Neråt \n [4] Uppåt \n\n");
                        Console.WriteLine(whereDoYouWantToGo);

                        direction = Convert.ToInt32(Console.ReadLine()) - 1;

                        switch(direction){
                            case 0 : // vänster
                                Console.WriteLine(wallExptected);
                                Console.ReadKey();
                            break; 

                            case 1 : // Höger
                                roomIndex ++;
                            break;

                            case 2 : // Ner
                                roomIndex -=3;
                            break;

                            case 3 : // upp
                                roomIndex += 3;
                            break;

                            default:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(wrongCommand);
                                Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                            
                            }
                    break;
                    
                    case 4 :

                        Console.WriteLine("Välkommen till Mat rummet här går vi ignom matens historia.");
                        Console.Write(" [1] Vänster \n [2] Höger \n [3] Neråt \n [4] Uppåt \n\n");
                        Console.WriteLine(whereDoYouWantToGo);

                        direction = Convert.ToInt32(Console.ReadLine()) - 1;
                        
                        switch(direction){
                            case 0 : // vänster
                                roomIndex --;
                            break; 

                            case 1 : // Höger
                                roomIndex ++;
                            break;

                            case 2 : // Ner
                                roomIndex -= 3;
                            break;

                            case 3 : // upp
                                roomIndex += 3;
                            break;

                            default:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(wrongCommand);
                                Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                            
                        }
                    break;
                    
                    case 5 :

                        Console.WriteLine("Välkommen till Kaffe rummet här går vi ignom kaffets historia.");
                        Console.Write(" [1] Vänster \n [3] Neråt \n [4] Uppåt \n\n");
                        Console.WriteLine(whereDoYouWantToGo);

                        direction = Convert.ToInt32(Console.ReadLine()) - 1;
                        switch(direction){
                            case 0 : // vänster
                                roomIndex --;
                            break; 

                            case 1 : // Höger
                                Console.WriteLine(wallExptected);
                                Console.ReadKey();
                            break;

                            case 2 : // Ner
                                roomIndex -= 3;
                            break;

                            case 3 : // upp
                                roomIndex += 3;
                            break;

                            default:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(wrongCommand);
                                Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                            
                        }
                    break;
                    
                    case 6 :
                    Console.WriteLine("Välkommen till ett rum (Rum 6).");
                    Console.WriteLine("Från detta rum kan du gå:");
                        Console.Write("[1] Ner \n[3] Höger");
                        direction = Convert.ToInt32(Console.ReadLine()) - 1;
                    switch(direction){
                            case 0 : // vänster
                                Console.WriteLine(wallExptected);
                            break; 

                            case 1 : // Höger
                                roomIndex ++;
                            break;

                            case 2 : // Ner
                                roomIndex -= 4;
                            break;

                            case 3 : // upp
                                Console.WriteLine(wallExptected);
                            break;
                            
                            default:
                                Console.WriteLine(wrongCommand);
                            break;
                        
                        }
                        
                    break;
                    
                    case 7 :
                    Console.WriteLine("Välkommen till konstiga rummet, här finns konstiga saker från världens alla hörn (Rum 7)");
                    Console.WriteLine("Från detta rum kan du gå:");
                        Console.Write("[1] Ner \n[3] Höger");
                    direction = Convert.ToInt32(Console.ReadLine()) - 1;
                    switch(direction){
                            case 0 : // vänster
                                roomIndex --;
                            break; 

                            case 1 : // Höger
                                roomIndex ++;
                            break;

                            case 2 : // Ner
                                roomIndex -= 3;
                            break;

                            case 3 : // upp
                                Console.WriteLine(wallExptected);
                            break;
                            
                            default:
                            Console.WriteLine(wrongCommand);
                            break;
                        
                        }
                    break;
                    
                    case 8 :
                    Console.Write("Välkommen till Elkabel rummet, här bjuder vi på elkabelns fantastiska historia.(Rum 8) \n I ena hörnet har vi en kabel från 1970 talet helt i bly, fantastiskt!" );
                    Console.WriteLine("Från detta rum kan du gå:");
                        Console.Write("[1] Vänster \n [3] Neråt");
                        direction = Convert.ToInt32(Console.ReadLine()) - 1;
                    switch(direction){
                            case 0 : // vänster
                                roomIndex --;
                            break; 

                            case 1 : // Höger
                                Console.WriteLine(wallExptected);
                            break;

                            case 2 : // Ner
                                roomIndex -= 3;
                            break;

                            case 3 : // upp
                                Console.WriteLine(wallExptected);
                            break;
                            
                            default:
                            Console.WriteLine(wrongCommand);
                            break;
                        
                        }
                    break;
                }
            }while(!exit);
            Console.WriteLine("Hej då du klarade dig från branden genom att gå genom {0} rum", numberOfRoomsUntilExit);

        }
    }
}
