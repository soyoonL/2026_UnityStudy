using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Test03 : MonoBehaviour
{
    // 2차원 가변배열을 만들어 정수를 저장한다. 그 가변배열에 저장된 수 중, 10이 넘는 수만을 골라 리스트에 채운다.
   
    private void Start()
    {
        int[][] a = new int[3][];
        List<int> b = new List<int>();

        a[0] =new int[3] { 5,10,15};
        a[1] = new int[3] { 3, 6, 9 };
        a[2] = new int[3] {4,8,12};

       foreach(int[] numbers in a)
       {
            foreach(int i in numbers)
            {
                if (i > 10)
                {
                    b.Add(i);
                    
                }
            }
       }

       foreach(int c in b)
        {
            Debug.Log(c);
        }
    }
    


}
