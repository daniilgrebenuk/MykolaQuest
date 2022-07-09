using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breeth : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public float speed;
    public Sprite normal;
    public Sprite breeth;
    private bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        StartBreeth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartBreeth()
    {
        if (!IsInvoking(nameof(BreethUpdate)))
        {
            InvokeRepeating(nameof(BreethUpdate), speed, speed);
        }
    }

    public void StopBreeth()
    {
        CancelInvoke();
    }

    void BreethUpdate()
    {
        if (flag)
        {
            spriteRenderer.sprite = breeth;
            flag = false;
        }
        else
        {
            spriteRenderer.sprite = normal;
            flag = true;
        }
    }
}
