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
Selection_Sort(arr, a);
Console.WriteLine("Mảng sau sắp xếp");
for (int i = 0; i < a; i++)
{
    Console.WriteLine(arr[i]);
}

static void Selection_Sort(int[]a , int n)
{
    n= a.Length;
    for(int  i = 0; i < n - 1; i++)
    {
        for(int j = i+1;j<n;j++)
        {
            if (a[j] < a[i])
            {
                int item = a[j];
                a[j] = a[i];
                a[i] = item;
            }
        }
    }
}