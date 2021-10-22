using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonappear : MonoBehaviour
{

    public GameObject empty;
    public GameObject button;
    int look = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "vision")
        {
            look += 1;
            if (look > 3) {
                Instantiate(button, empty.transform.position, empty.transform.rotation);
                Destroy(gameObject);
            }
            
        }
    }
}
