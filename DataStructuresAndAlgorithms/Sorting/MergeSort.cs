using DataStructuresAndAlgorithms.Helpers;

namespace DataStructuresAndAlgorithms.Sorting;

public class MergeSort
{
    public static int[] MergeTwoSubArrays(int[] arr1, int[] arr2)
    {
        int n1 = arr1.Length;
        int n2 = arr2.Length;
        int i = 0, j = 0;
        int[] result = new int[n1+n2];
        int k = 0;

        while (i < n1 && j < n2) {
            if (arr1[i] <= arr2[j]) {
                result[k] = arr1[i];
                i++;
                
            }
            else {
                result[k] = arr2[j];
                j++;
                
            }
            k++;
        }
        while (i < n1)
        {
            result[k] = arr1[i];
            i++;
            k++;
        }
        while (j < n2)
        {
            result[k] =  arr2[j];
            j++;
            k++;
        }
        
        return result;
    }

    public static void RunTest()
    {
        int[] arr1 = [3, 19];
        int[] arr2 = [2, 11];
        int[] result = MergeTwoSubArrays(arr1, arr2);
        ArrayHelper.PrintArray(result, "Merge two sub arrays: [3, 19] && [2, 11]");
        
        int[] arr3 = [3, 19, 28];
        int[] arr4 = [2, 11, 13, 15];
        int[] result2 = MergeTwoSubArrays(arr3, arr4);
        ArrayHelper.PrintArray(result2, "Merge two sub arrays: [3, 19, 28] && [2, 11, 13, 15]: ");
    }
}