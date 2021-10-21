using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue : MonoBehaviour
{

    public GameObject anime;
    public GameObject animetext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            anime.SetActive(true);
            animetext.SetActive(true);
            GameObject.Destroy(gameObject);
        }

    }

}
