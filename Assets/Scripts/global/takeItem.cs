using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeItem : MonoBehaviour
{
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
        if (Input.GetKeyDown("e")) {
            gameObject.SetActive(false);
        }
    }

}
