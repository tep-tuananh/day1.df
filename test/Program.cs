// See https://aka.ms/new-console-template for more information

using System.Text;


Console.OutputEncoding = Encoding.UTF8;
int[] arr;
Console.WriteLine("Nhập vào số lượng mảng: ");

int  a = int.Parse(Console.ReadLine());
 arr= new int[a];
for(int i = 0;i<a; i++)
{
    Console.WriteLine("Nhập vào phần tử thứ: "+i+ " là : ");
     arr[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Nhập vào số cần tìm: ");
int b = int.Parse(Console.ReadLine());
// thuật toán Linear Search: 
for(int j = 0; j < a; j++)
{
    if (arr[j] == b)
    {
        Console.WriteLine("Đã tìm thấy số cần tìm: " + b + " tại vị trí : " + j);
        return;
    }
   
}
Console.WriteLine("Không tìm thấy số cần tìm: " + b);


