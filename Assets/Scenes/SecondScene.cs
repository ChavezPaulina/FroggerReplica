using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondScene : MonoBehaviour
{

    public Text NameBox;
    void Start()
    {
        NameBox.text = PlayerPrefs.GetString("name");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
