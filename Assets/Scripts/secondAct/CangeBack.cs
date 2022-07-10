using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CangeBack : MonoBehaviour
{
    
    public GameObject from;
    public GameObject to;
    public GameObject player;
    public bool isFirst;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        from.SetActive(false);
        to.SetActive(true);
        if (isFirst)
        {
            player.transform.position = new Vector3(9.05f, player.transform.position.y, player.transform.position.y);
        }
        else
        {
            player.transform.position = new Vector3(-9.01f, player.transform.position.y, player.transform.position.y);
        }
    }
}
