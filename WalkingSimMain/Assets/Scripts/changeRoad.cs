using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeRoad : MonoBehaviour
{
    public GameObject empty;
    public GameObject otherRoad;
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
           
            Instantiate(otherRoad, empty.transform.position, empty.transform.rotation);
            Destroy(gameObject);
        }
    }


}
