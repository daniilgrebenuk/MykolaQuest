using UnityEngine;

public class NonTakenItem : MonoBehaviour
{
    public Sprite sprite;
    public Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>().sprite;
    }

    // Update is called once per frame
    void Update()
    {   
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Pressed");
            if (inventory.isDown)
            {
                inventory.MakeUp();
            }
            for (int i = 0; i < inventory.inventaryItems.Length; i++)
            {
                Debug.Log(sprite.name);
                if (inventory.inventaryItems[i].sprite.name == sprite.name)
                {
                    inventory.inventaryItems[i].IsTaken = true;
                    bool isActive = inventory.inventaryItems[i].gameObject.activeSelf;
                    inventory.inventaryItems[i].gameObject.SetActive(!isActive);
                }
            }
            gameObject.SetActive(false);
        }
    }

}
