﻿
int[] arr = new[] { 3, 0, 1 };

Console.WriteLine(MissingNumber(arr));

int MissingNumber(int[] nums) { 
    Array.Sort(nums);
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != i)
        {
            return i;
        }
    }

    return nums.Length;
}