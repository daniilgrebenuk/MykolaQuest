using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public Sprite[] sprites;
    public Breeth breeth;
    public float spriteChangeSpeed;

    private int spritesIndexes = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 10f;
        float moveX = Input.GetAxis("Horizontal");
        
        rb.MovePosition(rb.position + moveX * speed * Time.deltaTime * Vector2.right);
        if(moveX != 0)
        {
            breeth.StopBreeth();
            if(!IsInvoking(nameof(ChangeSprites)))
                InvokeRepeating(nameof(ChangeSprites), spriteChangeSpeed, spriteChangeSpeed);
            if (moveX > 0)
            {
                sr.flipX = false;
            }
            else if (moveX < 0)
            {
                sr.flipX = true;
            }
        }
        else
        {
            CancelInvoke();
            breeth.StartBreeth();
        }
    }

    void ChangeSprites()
    {
        sr.sprite = sprites[spritesIndexes++];

        if(spritesIndexes == sprites.Length)
        {
            spritesIndexes = 0;
        }
    }
}
