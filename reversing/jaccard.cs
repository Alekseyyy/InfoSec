
/*
 * Simple terminal application to compute the Jaccard Index
 *   of two input sets
 * By Alexander Ahmann <alexander.ahmann@outlook.com>
 * After Malware Data Science (Saxe & Sanders 2018, p. 73)
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
public class Jaccard {

    public static void Main(string[] args) {
        int[] testSet1 = {1, 2, 3};
        int[] testSet2 = {1, 2, 3};
        Console.WriteLine("Test Jaccard is: {0}", jaccard(testSet1, testSet2));
    }
    
    public static double jaccard(int[] array1, int[] array2) {
        HashSet<int> set1 = new HashSet<int>();
        HashSet<int> set2 = new HashSet<int>();
        
        for (int i = 0; i < array1.Length; i++)
            set1.Add(array1[i]);
        for (int i = 0; i < array2.Length; i++)
            set2.Add(array2[i]);
        
        // length of set intersection ÷ length of set union
        set1.IntersectWith(set2);
        set2.UnionWith(set2);
        return set1.Count / set2.Count;
    }
}
