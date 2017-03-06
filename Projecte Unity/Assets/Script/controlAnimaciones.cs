using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlAnimaciones : MonoBehaviour {

    public Animator anim;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w"))
        {
            anim.SetBool("Wpress", true);
            anim.SetBool("Spress", false);
            anim.SetBool("Dpress", false);
            anim.SetBool("Apress", false);
            anim.SetBool("SpacePress", false);
        }

        if (Input.GetKey("s"))
        {
            anim.SetBool("Wpress", false);
            anim.SetBool("Spress", true);
            anim.SetBool("Dpress", false);
            anim.SetBool("Apress", false);
            anim.SetBool("SpacePress", false);
        }
        if (Input.GetKey("d"))
        {
            anim.SetBool("Wpress", false);
            anim.SetBool("Spress", false);
            anim.SetBool("Dpress", true);
            anim.SetBool("Apress", false);
            anim.SetBool("SpacePress", false);
        }
        if (Input.GetKey("a"))
        {
            anim.SetBool("Wpress", false);
            anim.SetBool("Spress", false);
            anim.SetBool("Dpress", false);
            anim.SetBool("Apress", true);
            anim.SetBool("SpacePress", false);
        }
        if (Input.GetKey("space"))
        {
            anim.SetBool("SpacePress", true);
            anim.SetBool("Wpress", false);
            anim.SetBool("Spress", false);
            anim.SetBool("Dpress", false);
            anim.SetBool("Apress", false);
        }
        if (Input.anyKey == false)
        {
            anim.SetBool("Wpress", false);
            anim.SetBool("Spress", false);
            anim.SetBool("Dpress", false);
            anim.SetBool("Apress", false);
            anim.SetBool("SpacePress", false);
        }

        
    }
}
