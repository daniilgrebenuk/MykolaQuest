using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public BoxCollider2D boxCollider2D;
    // Start is called before the first frame update
    void Start()
    {
        if(Input.GetMouseButtonDown(0)) {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()  
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("FirstAct");
        }
    }
}
