using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Test03 : MonoBehaviour
{
    
    private void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            string stars = "";

            for(int j = 0; j < i*2+1; j++)
            {
                stars += "*";
            }

            Debug.Log(stars);
        }
    }
}
