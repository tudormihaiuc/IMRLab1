using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime;
using System.Security.Cryptography;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
    float distToChangeAnim=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //var distance: Vector3 = target.position - camera.transform.position;
        /*if (Math.Abs(Vector3.Distance(other.position,GetComponent<Camera>().transform.position)))
        {
            myAnimationController.SetBool("playAttack", true);
        }*/
        float Dist = Vector3.Distance(Camera.main.transform.position, transform.position);
            if (Dist <=distToChangeAnim )
        {
            myAnimationController.SetBool("playAttack", true);
        }
        else
        {
            myAnimationController.SetBool("playAttack", false);
        }
    }
}
