using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openthedoor : MonoBehaviour
{

    public GameObject endingWhite;
    //public GameObject endingtext;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            if (Input.GetMouseButtonDown(0))
            {
                endingWhite.SetActive(true);
                //endingtext.SetActive(true);

                player.GetComponent<CharacterController>().enabled = false;
            }

        }

    }

}
