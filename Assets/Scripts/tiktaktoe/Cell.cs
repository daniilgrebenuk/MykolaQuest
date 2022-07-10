using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public BoxCollider2D boxCollider2D;
    public GameObject krest;
    public GameObject nol;
    public TikTakToe tikTakToe;

    // Start is called before the first frame update
    void Start()
    {
        krest.SetActive(false);
        nol.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        krest.SetActive(true);
        GetComponent<BoxCollider2D>().size = new Vector2(0, 0);
        if(!tikTakToe.CheckCombination()) tikTakToe.ClickNol();
    }
}
