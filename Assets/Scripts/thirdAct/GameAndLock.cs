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
        tikTakToe.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
