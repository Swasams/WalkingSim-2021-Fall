using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button5 : MonoBehaviour
{
    public GameObject entrance;
    public GameObject longRoad;
    public GameObject doorend;
    public GameObject invisiblewall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

   

    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            if (Input.GetMouseButtonDown(0))
            {
                entrance.SetActive(true);
                longRoad.SetActive(true);
                doorend.SetActive(true);
                invisiblewall.SetActive(false);
            }

        }

    }


}
