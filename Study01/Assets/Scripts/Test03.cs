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
        int[] n = new int[10];

        for(int i = 1; i < 11; i++)
        {
           
            n[i-1] = a * c;
            c *= b;
        }

        foreach(int result in n)
        {
            Debug.Log(result);
        }
    }
    


}
