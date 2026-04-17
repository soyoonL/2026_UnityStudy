using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Test03 : MonoBehaviour
{
    

    private void Start()
    {
        // 크기가 5인 int 배열을 만들고, for문을 이용해 각 칸에 10, 20, 30, 40, 50을 넣은 뒤, 배열의 모든 값을 더한 합계를 Debug.Log로 출력하는 프로그램을 작성하세요.

        int[] a = new int[5] ;

        for(int i  = 0; i <5 ; i++)
        {

            a[i] = 2 * 5 * i + 10;

        }

        Debug.Log(a[0] + a[1] + a[2] + a[3] + a[4]);
        Debug.Log(a[0]);
        Debug.Log(a[1]);
        Debug.Log(a[2]);
        Debug.Log(a[3]);
        Debug.Log(a[4]);
    }
}
