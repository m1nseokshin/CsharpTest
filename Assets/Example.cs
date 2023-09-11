using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public int a;   // 정수 integer
    private float b; // 실수 floating number
    private string c; // 스트링(문자열) string
    private char d; // 글자 character
    private bool e; // 불 boolean (참, 거짓)

    void Start()
    {
        a = 3;
        c = "안녕하세요";
        Debug.Log("변수 a의 값은?" + 3);
    }

    void Update()
    {

    }
}