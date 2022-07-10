using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabaSetUp : MonoBehaviour
{
    public GameObject babaForSetup;
    public GameObject next;
    public Sprite sprite;
    // Start is called before the first frame update
    void Start()
    {
        babaForSetup.GetComponent<Breeth>().StopBreeth();
        babaForSetup.GetComponent<SpriteRenderer>().sprite = sprite;
        next.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
