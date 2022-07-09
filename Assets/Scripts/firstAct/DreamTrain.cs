using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamTrain : MonoBehaviour
{
    public GameObject firstSprite;
    public GameObject next;
    public float scaleSpeed;
    private Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(scaleSpeed, scaleSpeed, scaleSpeed);
        firstSprite.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (firstSprite.transform.localScale.y < 1.2f)
        {
            firstSprite.transform.localScale += scaleChange;
        }
        else
        {
            firstSprite.SetActive(false);
            next.SetActive(true);
            enabled = false;
            gameObject.SetActive(false);
        }
    }
}
