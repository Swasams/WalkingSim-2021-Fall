using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMesh : MonoBehaviour
{
    public Mesh[] meshes;
    public int lastIndex;

    // Start is called before the first frame update
    void Start()
    {
        lastIndex = Random.Range(0, meshes.Length);
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "vision")
        {
            int index = Random.Range(0, meshes.Length);
            Debug.Log(index);
            if (index == lastIndex)
            {
                Debug.Log("Same");
                if (index == meshes.Length - 1)
                {
                    index = 0;
                }
                else
                {
                    index = index + 1;
                }
                GetComponent<MeshFilter>().mesh = meshes[index];
            }
            else
            {
                GetComponent<MeshFilter>().mesh = meshes[index];
            }
            lastIndex = index;
            //GetComponent<MeshFilter>().mesh = meshes[Random.Range(0,meshes.Length)];
        }


    }


}
