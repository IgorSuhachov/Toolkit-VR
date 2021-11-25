using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myData : MonoBehaviour
{
    public GameObject Info;
    public GameObject ShowNameAndAge;

    public InputField InName;
    public InputField InAge;

    public Text ShowName;
    public Text ShowAge;
    void Start()
    {

    }

    void Update()
    {

    }
    public void Data ()
    {
        Info.SetActive(false);
        ShowNameAndAge.SetActive(true);
        
        ShowName.text = "Вас зовут " + InName.text;
        ShowAge.text = "Вам " + InAge.text + " лет";
    }

}