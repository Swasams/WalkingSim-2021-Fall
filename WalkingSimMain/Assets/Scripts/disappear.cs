using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear : MonoBehaviour
{
    public Mesh meshes;

    // Start is called before the first frame update
    void Start()
    {

    }


    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "vision")
        {
            //Debug.Log("123");
            GetComponent<MeshFilter>().mesh = meshes;

        }
    }




}
