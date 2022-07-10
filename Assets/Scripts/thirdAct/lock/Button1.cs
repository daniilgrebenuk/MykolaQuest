using UnityEngine;

public class Button1 : MonoBehaviour
{
    public GameObject button1;
    public BoxCollider2D boxCollider2;
    public LockClicking lockClicking;

    // Start is called before the first frame update
    void Start()
    {
        button1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        button1.SetActive(true);
        GetComponent<BoxCollider2D>().enabled = false;
        lockClicking.number = lockClicking.number + "1";
    }
    public void EnableClicking()
    {
        GetComponent<BoxCollider2D>().enabled = true;
    }
}
