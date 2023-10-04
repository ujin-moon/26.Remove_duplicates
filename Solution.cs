using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_duplicates
{
    public class Solution
    {
        public (int, int[]) RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return (0, new int[0]); // Возвращаем 0 и пустой массив
            }

            int k = 0; // Число уникальных элементов

            for (int i = 0; i < nums.Length; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < k; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            int[] uniqueArray = new int[k];
            Array.Copy(nums, uniqueArray, k); // Создаем новый массив с уникальными элементами

            return (k, uniqueArray);
        }
    }
}
