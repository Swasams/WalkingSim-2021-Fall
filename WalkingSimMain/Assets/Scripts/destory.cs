using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destory : MonoBehaviour
{
    
    void Start()
    {
        
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "vision")
        {
            Destroy(gameObject);

        }
    }
}
