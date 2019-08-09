using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createCard : MonoBehaviour
{

    public bool isEnabled = false;
    public GameObject card;
    
    
    // Start is called before the first frame update
    void Start()
    {
        card.SetActive(isEnabled);
    }

    // Update is called once per frame
    void Update()
    {
        card.SetActive(isEnabled);

    }
}
