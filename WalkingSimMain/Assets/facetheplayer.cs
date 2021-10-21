using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class facetheplayer : MonoBehaviour
{
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = player.transform.position;
        Vector3 npcPos = gameObject.transform.position;
        Vector3 delta = new Vector3(playerPos.x - npcPos.x, 0.0f, playerPos.z - npcPos.z);
        Vector3 lookatdoor = new Vector3(-60f,0.0f,0.0f);
        

        if (player.transform.position.x < -11.5)
        {
            
            Vector3 follow = new Vector3(playerPos.x - 1.0f, npcPos.y, npcPos.z);
            gameObject.transform.position = follow;
            Quaternion rotation = Quaternion.LookRotation(lookatdoor);
            gameObject.transform.rotation = rotation;
        }
        else {
            
            Quaternion rotation = Quaternion.LookRotation(delta);
            gameObject.transform.rotation = rotation;
        }

        

    }
    

    
}
