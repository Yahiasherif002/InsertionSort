internal class Program
{
    static void InsertionSort(int[] arr)      // This is the first Litration
    {
        int size = arr.Length;          // 0  1   2    3   4   5
        for (int i = 1; i < size; i++) // 80  60  40  30  50  70
        {
            int key = arr[i]; // =60
            int j=i-1; //=0
                             // 80 > 60
            while (j >= 0 && arr[j]<key) {                     // 0   1   2   3   4   5
                arr[j + 1] = arr[j]; // arr[1]=arr[0]==80     // 80  80  40  30  50  70 
                j = j - 1;  // 0-1 = -1 s0 we break;
            }
            arr[j+1] = key; // arr[-1 +1] = arr[0]=60;       // 60 80 40 30 50 70
        }

    }
    static void print(int[] arr)
    {
        int size=arr.Length;
        Console.Write('['  );
        for (int i = 0; i < size; i++)
        {
            Console.Write($" {arr[i]} " );
        }
        Console.Write(']');
    }
    private static void Main(string[] args)
    {
        int[] ages = { 80, 60, 40, 30, 50, 70 };
        InsertionSort(ages);
        print(ages);
        
    }
}