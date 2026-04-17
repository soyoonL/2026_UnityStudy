using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Test03 : MonoBehaviour
{


    private void Start()
    {
        // 가변배열
        // 배열 안에 배열

        int[][] a = new int[3][];
        // 뒤가 비어있는 이유는 배열 안에 있는 배열의 크기가 각각 다르기 때문이다

        a[0] = new int[3] { 1, 2, 3 };
        a[1] = new int[2] { 2,4 };
        a[2] = new int[4] {5,6,7,8};

        Debug.Log(a[1][1]);
    }
}
