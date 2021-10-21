using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoryafter : MonoBehaviour
{
    public GameObject door;
    void Start()
    {
        
    }

    void OnCollisionExit(Collision collision)
    {
        if (!door.activeSelf) {
            Debug.Log("123");
            if (collision.gameObject.tag == "vision")
            {
                Destroy(gameObject);
            }
        }
        
    }
}
