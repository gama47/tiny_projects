using System;
using System.IO;
namespace MyApplication{
    class Program{
        static void Main(string[] args){
            ReadInput();
        }
        public static void ReadInput(){
            Console.WriteLine("Save - s");
            Console.WriteLine("Load - l");
            Console.WriteLine("Matrix - m");
            Console.WriteLine("Exit - e");
            string a=Console.ReadLine();
            CheckInput(a);
        }
        public static void CreateMatrix(int x, int y, int coordinatesx=0, int coordinatesy=0){
            for (int i=0; i<y; i++){
                Console.WriteLine();
                for (int j=0; j<x; j++){
                    if(coordinatesx==j&&coordinatesy==i)
                        Console.Write(".[a]");    
                    else
                        Console.Write(".[ ]");
                }
            }
            ReadInput();
        }
        public static void CheckInput(string a){
            switch(a){
                case "s":
                    Save();
                    break;
                case "l":
                    Load();
                    break;
                case "m":
                    CreateMatrix(5, 5);
                    break;
                case "e":
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    ReadInput();
                    break;
            }
        }
        public static void Save(){
            string coordinates="0-0";
            Console.Write("write x coordinates:");
            string x=Console.ReadLine();
            Console.Write("write y coordinates:");
            string y=Console.ReadLine();
            coordinates=x+"-"+y;
            Console.Write("name save file:");
            string n=Console.ReadLine();
            File.WriteAllText(n+".txt", coordinates);
        }
        public static void Load(){
            Console.Write("name load file:");
            string n=Console.ReadLine();
            string coordinates=File.ReadAllText(n+".txt");
            int x=Convert.ToInt32(char.GetNumericValue(coordinates[0]));
            int y=Convert.ToInt32(char.GetNumericValue(coordinates[2]));
            CreateMatrix(5, 5, x, y);
        }
    }
}