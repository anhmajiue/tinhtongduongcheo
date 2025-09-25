namespace tinhtongduongcheo
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập kích thước ma trận vuông (n x n): ");
            if (!int.TryParse(Console.ReadLine(), out int n) )
            {
                Console.WriteLine("Kích thước không hợp lệ. Vui lòng nhập một số nguyên dương.");
                return;
            }
            int [][] matrix = new int[n][];
            Console.WriteLine("Nhập các phần tử của ma trận:");
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
                Console.WriteLine($"Nhập hàng {i + 1}:");
                for (int j = 0; j < n; j++)
                {
                    if (!int.TryParse(Console.ReadLine(), out matrix[i][j]))
                    {
                        Console.WriteLine("Phần tử không hợp lệ. Vui lòng nhập một số nguyên.");
                        return;
                    }
                }
            }
            Console.WriteLine("Ma trận đã nhập:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i][j] + "\t");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i][i]; 
            
            }
            Console.WriteLine($"Tổng các phần tử trên đường chéo chính là: {sum}");
        } 

    }
}
