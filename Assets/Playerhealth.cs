using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playerhealth : MonoBehaviour
{

    public float health;
    public Slider slider;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        slider.value = health;                           //syncing value of slider with player health
        text.text = "Health : " + health;                  //syncing text with player health

    }
    //Function which detects collision
    void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.CompareTag("Enemy"))
        {
            health -= 10;
        }
        if (obj.gameObject.CompareTag("Energy"))
        {
            health += 10;
            Destroy(obj.gameObject);


        }

    }
}

