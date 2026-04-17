using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Test03 : MonoBehaviour
{
    

    private void Start()
    {
        for(int i = 2; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Debug.Log(i + "*" + j + "=" + (i * j));
            }
        }
    }
}
