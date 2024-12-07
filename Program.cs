namespace B;

class Program
{
    static void Main(string[] args)
    {
        int[] x = {1, 2, 3, 4, 5};
        int k = 3;
        Console.WriteLine(string.Join(", ", x));
        RotateArray(x, k);
        Console.WriteLine(string.Join(", ", x));
        Console.WriteLine("----------------------------------------------------------");
        int[] array1 = {1, 2, 3, 4, 52, 2, 2, 5, 6, 6, 8};
        int[] array2 = {5, 6, 7, 8};
        int[] newArray = new int[array1.Length + array2.Length];
        for (int i = 0; i < array1.Length; i++){
            newArray[i] = array1[i];
        }
        for (int i = 0; i < array2.Length; i++){
            newArray[array1.Length + i] = array2[i];
        }
        int[] newArray_uniq = newArray.Distinct().ToArray();
        Console.WriteLine(string.Join(", ", newArray_uniq));


    }
    static void RotateArray(int[] arr, int k){
        int len_arr = arr.Length;
        k = k % len_arr;

        int[] temp = new int[len_arr];
        Array.Copy(arr, len_arr - k, temp, 0, k);

        for (int i = len_arr - 1; i >= k; i--){
            arr[i] = arr[i - k];
        }
        
        for (int i = 0; i < k; i++){
            arr[i] = temp[i];
        }
    }
}
