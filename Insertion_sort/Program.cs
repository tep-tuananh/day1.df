// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int[] arr;
Console.WriteLine("Nhập vào số lượng mảng: ");

int a = int.Parse(Console.ReadLine());
arr = new int[a];
for (int i = 0; i < a; i++)
{
    Console.WriteLine("Nhập vào phần tử thứ: " + i + " là : ");
    arr[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Mảng trước sắp xếp");
for (int i = 0; i < a; i++)
{
    Console.WriteLine(arr[i]);
}
Insertion_sort(arr, a);
Console.WriteLine("Mảng sau sắp xếp");
for (int i = 0; i < a; i++)
{
    Console.WriteLine(arr[i]);
}
static void Insertion_sort(int[]a,int  b)
{
    b=a.Length;
    for(int i = 1; i < b; i++)
    {
      int item = a[i];
        int j= i-1;
        while(j >= 0 && a[j]>item) {
            a[j+1] = a[j];
            j--;
        }
        a[j+1] = item;
    }
}