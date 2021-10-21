using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destorySomeoneElse : MonoBehaviour
{

    public GameObject endingWhite;
    //public GameObject endingtext;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "vision")
        {
            endingWhite.SetActive(true);
            //endingtext.SetActive(true);

            player.GetComponent<CharacterController>().enabled = false;

            GameObject.Destroy(gameObject);



        }
    }
}
