using UnityEngine;

public class Button6 : MonoBehaviour
{
    public GameObject button6;
    public BoxCollider2D boxCollider2;
    public LockClicking lockClicking;

    // Start is called before the first frame update
    void Start()
    {
        button6.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        button6.SetActive(true);
        GetComponent<BoxCollider2D>().enabled = false;
        lockClicking.number = lockClicking.number + "6";
    }

    public void EnableClicking()
    {
        GetComponent<BoxCollider2D>().enabled = true;
    }
}
