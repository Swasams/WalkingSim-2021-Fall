using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterlevel6 : MonoBehaviour
{

    public GameObject someoneElse;
    public GameObject longRoad;

    public GameObject anime;
    public GameObject animetext;

    public GameObject target;
    public Camera main;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "vision")
        {
            someoneElse.SetActive(true);
            longRoad.SetActive(true);
            anime.SetActive(true);
            animetext.SetActive(true);

            GameObject.Destroy(gameObject);

            /*
            main.GetComponent<LockMouse>().enabled = false;
            main.GetComponent<MouseLook>().enabled = false;
            main.transform.LookAt(target.transform);*/

        }
    }

}
