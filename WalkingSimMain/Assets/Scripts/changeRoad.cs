using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeRoad : MonoBehaviour
{
    public GameObject returnRoad;
    public GameObject entrance;
    public GameObject button5;
    public GameObject triggerforNPC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "vision")
        {

            if (entrance.activeSelf)
            {
                returnRoad.SetActive(true);
                gameObject.SetActive(false);
                triggerforNPC.SetActive(true);
            }
            else
            {
                button5.SetActive(true);
                gameObject.SetActive(false);
            }
           
            
        }
    }


}
