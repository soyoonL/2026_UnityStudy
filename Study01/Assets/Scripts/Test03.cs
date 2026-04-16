using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Test03 : MonoBehaviour
{
    public int a;
    int result;

    private void Start()
    {
        
        for(int i = 0; i < 10; i++)
        {
            int b = 1;
           
            for (int j = 0; j < i; j++)
            {
                b++;
               
            }
            result = a * b;
            Debug.Log(a +"*"+ b + "="+ result);
        }
    }
}
