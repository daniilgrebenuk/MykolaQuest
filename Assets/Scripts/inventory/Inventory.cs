using UnityEngine;

public class Inventory : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    public bool isDown = false;
    public Item[] inventaryItems;


    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        foreach(Item item in inventaryItems)
        {
            item.gameObject.SetActive(false);
        }
        MakeDown();
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (boxCollider.OverlapPoint(mousePosition))
            {
                if (isDown)
                {
                    MakeUp();
                }
                else
                {
                    MakeDown();
                }
            } 
        }
    }

    public void MakeDown()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 2.2f, transform.position.z);
        isDown = true;
        SwitchHideItem();
    }

    public void MakeUp()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2.2f, transform.position.z);
        isDown = false;
        SwitchHideItem();
    }

    private void SwitchHideItem()
    {
        foreach(var item in inventaryItems)
        {
            if(item.IsTaken)
                item.gameObject.SetActive(!isDown);
        }
    }
}
