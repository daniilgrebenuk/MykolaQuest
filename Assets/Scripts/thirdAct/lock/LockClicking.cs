using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockClicking : MonoBehaviour
{
    public GameObject[] knopki;
    public Button1 button1;
    public Button3 button3;
    public Button5 button5;
    public Button6 button6;
    public GameObject unlocked;
    public GameObject zamok;
    public string number = "";
    public string correctNumer = "1653";
    // Start is called before the first frame update
    void Start()
    {
        unlocked.SetActive(false);
        zamok.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (knopki.Length >= 4) 
        {
            if(number.Length == 4)
            {
                if(number.Equals(correctNumer))
                {
                    unlocked.SetActive(true);
                } else
                {
                    button1.button1.SetActive(false);
                    button3.button3.SetActive(false);
                    button5.button5.SetActive(false);
                    button6.button6.SetActive(false);
                    button1.EnableClicking();
                    button3.EnableClicking();
                    button5.EnableClicking();
                    button6.EnableClicking();
                    number = "";
                }
            }
        }
    }
}
