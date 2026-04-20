using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Test03 : MonoBehaviour
{
    public int a;
    public int b;
    int c=1;
    private void Start()
    {
      int[] n = new int[10] {1,2,3,4,5,6,7,8,9,10};

        foreach(int result in n)
        {
            //c *= b;
            Debug.Log(a * c);
            c *= b;
        }
    }
    


}
