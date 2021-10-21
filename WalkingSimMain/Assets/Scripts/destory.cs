using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destory : MonoBehaviour
{
    public bool exist = true;
    void Start()
    {
        
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "vision")
        {
            exist = false;
            Destroy(gameObject);

        }
    }
}
