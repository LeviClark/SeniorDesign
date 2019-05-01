using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = null;
        string name;
        if (GameObject.Find("Winner") != null)
        {
            obj = GameObject.Find("Winner");
            name = obj.GetComponent<GameDriver>().name;
            Canvas can = GameObject.Find("WinnerObject").GetComponent<Canvas>();
            can.transform.Find("winText").GetComponent<Text>().text = name;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
