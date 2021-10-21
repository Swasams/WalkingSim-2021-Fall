using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoryafter : MonoBehaviour
{
    public GameObject door;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionExit(Collision collision)
    {
        
        
            if (collision.gameObject.tag == "vision")
        {
            if (door == null)
            {
                Destroy(gameObject);
            }
        }
        
    }
}
