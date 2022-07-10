using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseCode : MonoBehaviour
{
    public BoxCollider2D boxCollider2d;
    public GameAndLock gameAndLock;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        gameAndLock.tikTakToe.gameObject.SetActive(false);
        gameAndLock.LockClicking.gameObject.SetActive(true);
    }
}
