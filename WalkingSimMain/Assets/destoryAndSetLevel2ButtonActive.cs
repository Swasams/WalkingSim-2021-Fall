using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoryAndSetLevel2ButtonActive : MonoBehaviour
{
    public GameObject door;
    public GameObject button2Pos;
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
            if (door == null)
            {
                button2Pos.SetActive(true);
                Destroy(gameObject);
            }
        }

    }

}
