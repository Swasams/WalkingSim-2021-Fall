using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadEntranceDestory : MonoBehaviour
{


    public Mesh meshes;
    public GameObject wall;
    public GameObject longroad;

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
            //GetComponent<MeshFilter>().mesh = meshes;
            if (longroad.activeSelf)
            {
                wall.SetActive(true);
                gameObject.SetActive(false);
            }
            else {

            }
            


        }
    }


}
