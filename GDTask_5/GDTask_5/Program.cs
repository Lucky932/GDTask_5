using System;

int[] arr = { 2, 2, 2, 4, 6, 4, 2, 1, 3, 3, 9, 9 };
int arrlen = arr.Length;

for (int i = 0;  i < arrlen; i++)
{
    for (int j = i + 1; j < arrlen; j++)
    {
        if (arr[i] == arr[j])
        {
            for (int k = j; k < arrlen - 1; k++) 
            {
                //Console.Write($"До замены: {arr[k]} ");
                arr[k] = arr[k + 1];
                //Console.Write($"После: {arr[k]} ");
            }
            arrlen--;
            j--;
        }
    }
}

for (int i = 0; i < arrlen; i++)
{
    Console.Write(arr[i] + " ");
}