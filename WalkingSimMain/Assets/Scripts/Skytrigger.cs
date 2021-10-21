using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skytrigger : MonoBehaviour
{
    public GameObject Skylight;
    public Animator Sunanimate;

        public void OnTriggerEnter (){
            Sunanimate.Play("sunset");


        }
}
