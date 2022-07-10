using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolubZoom : MonoBehaviour
{
    public GameObject golub;
    public GameObject next;
    public Sprite[] sprites;
    public Sprite[] sprites2;
    public float scaleSpeed;
    public float golubSpeed;
    private SpriteRenderer sr;
    private int spritesIndexes = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        sr = golub.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(golub.transform.position.y > -1.82f)
        {
            if (!IsInvoking(nameof(ChangeSprites)))
                InvokeRepeating(nameof(ChangeSprites), 0.4f, 0.4f);
            golub.transform.Translate(0, -golubSpeed, 0);
            golub.transform.localScale = new Vector3(golub.transform.localScale.x + scaleSpeed, golub.transform.localScale.y + scaleSpeed, golub.transform.localScale.z + scaleSpeed);
        }
        else
        {
            CancelInvoke(nameof(ChangeSprites));
            if (!IsInvoking(nameof(ChangeSprites2)))
            {
                spritesIndexes = 0;
                InvokeRepeating(nameof(ChangeSprites2), 0.4f, 0.4f);
            }
                
            if (golub.transform.position.x < 8)
            {
                golub.transform.Translate(golubSpeed * 1.5f, 0, 0);
            }
            else
            {
                golub.SetActive(false);
                next.SetActive(true);
                CancelInvoke();
                
                gameObject.SetActive(false);
                
            }
        }
    }

    void ChangeSprites()
    {
        sr.sprite = sprites[spritesIndexes++];

        if (spritesIndexes == sprites.Length)
        {
            spritesIndexes = 0;
        }
    }

    void ChangeSprites2()
    {
        sr.sprite = sprites2[spritesIndexes++];

        if (spritesIndexes == sprites.Length)
        {
            spritesIndexes = 0;
        }
    }
}
