using System;

class Bai1
{
    static void Main()
    {
        // 1. Nhập chuỗi và cắt thành 3 số
        string[] arr = Console.ReadLine().Split();
        int a = int.Parse(arr[0]);
        int b = int.Parse(arr[1]);
        int c = int.Parse(arr[2]);

        // 2. Tìm Max bằng lệnh if đơn giản
        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;

        // 3. Tìm Min bằng lệnh if đơn giản
        int min = a;
        if (b < min) min = b;
        if (c < min) min = c;

        // 4. Tính Tổng và Trung bình cộng
        int sum = a + b + c;
        double avg = (double)sum / 3;

        // 5. In kết quả
        Console.WriteLine($"Lớn nhất: {max}; nhỏ nhất: {min}; tổng: {sum}; trung bình: {avg}");
    }
}