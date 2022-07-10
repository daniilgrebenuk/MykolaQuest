using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDialogueTrigger : MonoBehaviour
{
    public GameObject nextDialogue;
    private bool flag = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("1");
        if(flag && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("2");
            nextDialogue.SetActive(true);
            flag = false;
        }
    }
}
