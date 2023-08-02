
/* Simple terminal application to compute the Jaccard Index
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
        HashSet<int> testSet1 = new HashSet<int>() {1, 2, 3};
        HashSet<int> testSet2 = new HashSet<int>() {1, 2, 3};
        Console.WriteLine("Test Jaccard is: {0}", jaccard(testSet1, testSet2));
    }
    
    public static double jaccard(HashSet<int> set1, HashSet<int> set2) {
        set1.IntersectWith(set2);
        set2.UnionWith(set2);
        // length of set intersection ÷ length of set union
        return set1.Count / set2.Count;
    }
}
