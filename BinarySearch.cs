using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinarySearch : MonoBehaviour
{
    List<int> my_list = new List<int>{ 1, 3, 5, 7, 9 };

    private void Start()
    {
        print("index" + binary_search(my_list, 3));
    }

    int binary_search(List<int> list, int item)
    {
        int low = 0;
        int high = list.Count - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int guess = list[mid];
            print("guess"+guess);

            if (guess == item)
                return mid;
            if (guess > item)
                high = mid - 1;
            else
                low = mid + 1;
        }
        return -1;
    }
}
