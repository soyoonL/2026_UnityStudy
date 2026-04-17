using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Test03 : MonoBehaviour
{
    

    private void Start()
    {
        // int[];
        // a라는 이름의 배열
        // 이 안이 어떻게 되어 있는지는 아직 지정이 안된 상태 (null 인 상태)

        //  int[] a = new int[5];
        //  a라는 int 배열에 5개의 정수를 넣을 수 있는 자리를 만듦 (초기화한 상태)
        //  이름과 자리는 정해져 있지만 아직 그 안에 뭐가 들어갈지 정해지지 않은 상태
        //  c#에서는 기본값이 정해져 있는데, 숫자가 들어가는 장소는 0,bool형은 false(거짓), 그 이외에는 null이 기본값

        //int[] a = new int[5] { 2, 3, 4, 5, 6 };

        //for(int i=0; i<5; i++)
        //{
        //    Debug.Log(a[i]);
        //}

        //  값이 차례대로 방으로 들어감
        //  new int[5] 부분은 생략가능

        int[] a = new int[5];

        for (int i = 0; i < 5; i++)
        {
            a[i] = i * 3;
            Debug.Log(a[i]);
        }

        //  프로그램 중간에 변수의 값을 바꾸는 것도 가능
            

    }
}
