using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerDisappear : MonoBehaviour
{
    public GameObject chert;

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
        if (collision.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            chert.GetComponent<Breeth>().StartBreeth();
        }
    }
}
