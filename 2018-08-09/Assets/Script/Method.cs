using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method : MonoBehaviour {

	// Use this for initialization
	void Start () {
        NoReturnNolnput();
        string helloText = NoInput();
        Debug.Log(helloText);

        Debug.Log(NoInput());
	}

    private void Update()
    {
        NoReturnNolnput();
    }
    // 결과반환 X   인수필요 X
    void NoReturnNolnput ()
    {
        Debug.Log("Hello");
	}

    string NoInput()
    {
        string result = "안녕";
        return result;
    }

    int PickRandomNumber()
    {
        return Random.Range(1, 100);
    }
}
