using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Test03 : MonoBehaviour
{
    // 컬렉션 : 하나의 이름 아래 여러 개의 데이터를 묶어서 관리하는 것
    // 배열과 비슷하지만 다름
    // 컬렉션은 배열과 달리 크기가 정해져있지 않음
    // 배열은 처음에 방을 만들 때 방의 개수를 정해놓고 얘기했지만, 컬렉션은 실시간으로 계속해서 방의 개수를 변화시킬 수 있음.
    // Dictionary, List

    private void Start()
    {
        // Dictionary : 사전
        // 우리가 사전에서 단어를 찾으면 단어와 단어에 관한 내용이 서술되어 있다. 여기서 단어는 Key, 내용은 Value 라고 볼 수 있다.
        // Key값으로 보통 문자열을 많이 사용하지만 숫자가 들어가도 괜춘

        // Key값으로 string, value 값으로 string을 가지는 Dictionary
        // Dictionary는 Key 값으로 값을 가져오기 때문에 순서를 알 수 없으므로 foods[0] 이런 식으로 값을 가져오는 것이 안되며 foods.Insert도 사용이 안된다.
        Dictionary<string,string> foods = new Dictionary<string,string>();

        foods.Add("한국", "약과");
        foods.Add("일본", "당고");
        foods.Add("중국", "탕후루");
        foods.Add("미국", "케이크쉐이크");

        // 중간에 값을 교체하는 것도 가능
        // Key 값이 같은 두 개의 value는 존재할 수 없다
        foods["한국"] = "개성주악";
        Debug.Log(foods["한국"]);

        // ContainsKey : 이 Key를 가지고 있는 원소가 있는지
        Debug.Log(foods.ContainsKey("미국"));

        // ContainsValue : Value 중에 이러한 Value가 존재하는지
        Debug.Log(foods.ContainsValue("당고"));

        // Remove : Key 값을 통해서 삭제를 함
        // Clear도 가능
        foods.Remove("일본");
        foods.Clear();


    }


}
