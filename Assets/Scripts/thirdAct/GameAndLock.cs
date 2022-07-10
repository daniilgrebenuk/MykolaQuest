using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAndLock : MonoBehaviour
{
    public TikTakToe tikTakToe;
    public LockClicking LockClicking;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(tikTakToe.win.picture.activeSelf || tikTakToe.lose.picture.activeSelf || tikTakToe.draw.picture.activeSelf)
        {
            tikTakToe.gameObject.SetActive(false);
            LockClicking.gameObject.SetActive(true);
        }
    }
}
