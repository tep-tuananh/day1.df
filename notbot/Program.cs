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
BubbleSort(arr,a);
Console.WriteLine("Mảng sau sắp xếp");

for (int k = 0;k < a; k++) {
    Console.WriteLine(arr[k]);
}

static void BubbleSort(int[] a,int n)
{
    n = a.Length;
    int item;
    for (int i = 0;i < n-1; i++)
    {
        for(int j=0;j<n-i-1;j++) 
        {
        if(a[j] > a[j + 1])
        {
                item = a[j];
                a[j] = a[j + 1];
                a[j + 1] = item;
            }
        }
    }
}


