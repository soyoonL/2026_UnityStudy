using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Test03 : MonoBehaviour
{
    // foreach : 배열이나 컬렉션 안의 모든 원소를 한 번씩 꺼내어 쭉 써보겠다는 의미
    // foreach( 데이터타입 변수명 in 배열명 ){}
    // foreach( 데이터타입 변수명 in 컬렉션명 ){}
    private void Start()
    {
        // 가변배열
        int[][] a = new int[5][];
        a[0] = new int[5] { 1, 2, 3, 4, 5 };
        a[1] = new int[5] { 6, 2, 3, 4, 5 };
        a[2] = new int[5] { 7, 2, 3, 4, 5 };
        a[3] = new int[5] { 8, 2, 3, 4, 5 };
        a[4] = new int[5] { 9, 2, 3, 4, 5 };

        foreach (int[] numbers in a)
        {
            foreach (int i in numbers)
            {
                Debug.Log(i);
            }
           
        }
    }



}
