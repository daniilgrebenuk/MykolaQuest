using UnityEngine;

public class Button5 : MonoBehaviour
{
    public GameObject button5;
    public BoxCollider2D boxCollider2;
    public LockClicking lockClicking;

    // Start is called before the first frame update
    void Start()
    {
        button5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        button5.SetActive(true);
        GetComponent<BoxCollider2D>().enabled = false;
        lockClicking.number = lockClicking.number + "5";
    }
    public void EnableClicking()
    {
        GetComponent<BoxCollider2D>().enabled = true;
    }
}
