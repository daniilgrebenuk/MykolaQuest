using UnityEngine;

public class Button3 : MonoBehaviour
{
    public GameObject button3;
    public BoxCollider2D boxCollider2;
    public LockClicking lockClicking;

    // Start is called before the first frame update
    void Start()
    {
        button3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        button3.SetActive(true);
        GetComponent<BoxCollider2D>().enabled = false;
        lockClicking.number = lockClicking.number + "3";
    }
    public void EnableClicking()
    {
        GetComponent<BoxCollider2D>().enabled = true;
    }
}
