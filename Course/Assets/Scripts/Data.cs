using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    public GameObject input;
    public GameObject showNameAndAge;

    public InputField inputName;
    public InputField inputAge;

    public Text showName;
    public Text showAge;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        inputName.text = string.Empty;
        inputAge.text = string.Empty;
    }

    public void Submit()
    {
        input.SetActive(false);
        showNameAndAge.SetActive(true);

        showName.text = inputName.text;
        showAge.text = inputAge.text;
    }
}
