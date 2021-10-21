using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToCamera : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform target = Camera.main.transform;
        go.transform.parent = target;
    }

}
