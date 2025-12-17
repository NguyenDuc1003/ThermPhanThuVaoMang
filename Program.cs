public class Program
{
    public static void Main(string[] args)
    {
        // Bước 1: Khai báo và khởi tạo mảng số nguyên gồm N phần tử cho trước
        Console.Write("Nhập số phần tử của mảng N: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N + 1]; // Tạo mảng lớn hơn 1 phần tử để có thể chèn
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Nhập phần tử thứ {i}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        // Bước 2: Nhập X là số cần chèn
        Console.Write("Nhập giá trị cần chèn X: ");
        int X = int.Parse(Console.ReadLine());

        // Bước 3: Nhập vào vị trí index cần chèn X vào trong mảng
        Console.Write("Nhập vị trí index cần chèn X: ");
        int index = int.Parse(Console.ReadLine());

        // Bước 4: Kiểm tra điều kiện index
        if (index <= 1 || index >= N - 1)
        {
            Console.WriteLine("Không chèn được phần tử vào mảng.");
        }
        else
        {
            // Bước 5: Thực hiện chèn phần tử X ở vị trí index vào mảng
            for (int i = N; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = X;

            // Bước 6: In ra mảng
            Console.WriteLine("Mảng sau khi chèn:");
            for (int i = 0; i < N + 1; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}