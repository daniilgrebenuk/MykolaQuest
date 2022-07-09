using UnityEngine;

public class Item : MonoBehaviour
{
    public Sprite sprite;
    public bool IsTaken { get; set; } = false;

    void Start()
    {
    }

    // Update is called once per frame
    void Update() { }
    public void OnMouseDown()
    {
        IsTaken = false;
        gameObject.SetActive(false);
    }
}
