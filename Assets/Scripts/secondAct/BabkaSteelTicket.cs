using UnityEngine;

public class BabkaSteelTicket : MonoBehaviour
{
    public GameObject babka;
    public Sprite babkaStay;
    public Sprite babkaSeat;
    public Breeth breeth;
    public GameObject nextDialogue;
    private bool goFlag = true;

    // Start is called before the first frame update
    void Start()
    {
        breeth = babka.GetComponent<Breeth>();
    }

    // Update is called once per frame
    void Update()
    {
        if (babka.transform.position.x > 7.63 && goFlag)
        {
            babka.transform.Translate(-0.005f, 0, 0);
        }
        else if (babka.transform.position.x < 8.72)
        {
            babka.transform.Translate(0.005f, 0, 0);
            if (goFlag)
            {
                goFlag = false;
                babka.GetComponent<SpriteRenderer>().sprite = babkaStay;
                breeth.StopBreeth();
                Invoke(nameof(BabkaSeat), 1.5f);
                enabled = false;
            }
        } else
        {
            nextDialogue.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    void BabkaSeat()
    {
        babka.GetComponent<SpriteRenderer>().sprite = babkaSeat;
        breeth.StartBreeth();
        enabled = true;
    }
}
