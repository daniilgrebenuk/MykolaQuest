using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCity : MonoBehaviour
{
    public GameObject firstSprite;
    public GameObject secondSprite;
    public GameObject dialog3;
    public GameObject dialog4;
    public float scaleSpeed;
    private Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(scaleSpeed, scaleSpeed, scaleSpeed);
        firstSprite.SetActive(true);
        secondSprite.SetActive(true);
        dialog3.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (firstSprite.transform.localScale.y < 1.2f)
        {
            firstSprite.transform.localScale += scaleChange;
            secondSprite.transform.localScale += scaleChange;
        }
        else
        {
            firstSprite.SetActive(false);
            secondSprite.SetActive(false);
            dialog3.SetActive(false);
            dialog4.SetActive(true);
            enabled = false;
            gameObject.SetActive(false);
        }
    }
}
