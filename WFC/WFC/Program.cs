internal class Program{
    private static void Main(string[] args) {
        CreateMatrix(3, 3);
    }
    public static void CreateMatrix(int x, int y){
        for (int i=0; i<y; i++){
            Console.WriteLine();
            for (int j=0; j<x; j++){
                Console.Write(".[ ]");
            }
        }
    }
}