using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class first : MonoBehaviour
{

    public int count = 0;
    private float value = 2.0f;

    // Start is called before the first frame update
    // 첫 프레임 시작 시 호출되는 함수
    void Start()
    {
        Debug.Log("test");
    }

    // Update is called once per frame
    // 매 프레임마다 호출되는 실질적인 동작 등 을 구현하는 핵심 로직이 작성되는 위치, 게속 반복됨
    void Update()
    {
        count++;
        Debug.Log(count);
    }
}
