using UnityEngine;

public class Item : MonoBehaviour
{
    public Sprite sprite;
    public GameObject listenerObject;
    public bool IsTaken { get; set; } = false;

    void Start()
    {
    }

    // Update is called once per frame
    void Update() { }
    public void OnMouseDown()
    {
        IsTaken = false;
        listenerObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
