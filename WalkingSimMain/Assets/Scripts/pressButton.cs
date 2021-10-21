using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressButton : MonoBehaviour
{
  
    public GameObject level;
    public GameObject thisButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    

    void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            
            if (Input.GetMouseButtonDown(0)) {
                level.SetActive(true);
                thisButton.SetActive(false);
            }

        }

    }
}
