using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject picture;
    public GameObject code;
    // Start is called before the first frame update
    void Start()
    {
        picture.SetActive(false);
        code.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
