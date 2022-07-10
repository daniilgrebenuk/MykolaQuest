using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerAppear : MonoBehaviour
{

    public GameObject chert;
    public GameObject burger;
    public Sprite chertWithBurger;
    
    // Start is called before the first frame update
    void Start()
    {
        chert.GetComponent<SpriteRenderer>().sprite = chertWithBurger;
        chert.GetComponent<Breeth>().StopBreeth();
        burger.SetActive(true);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
