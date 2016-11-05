using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour {


    private Animation anim;
    private bool open = false;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animation>();
	}
	
    public void OpenChest()
    {
        if(!open)
        {
            anim.clip = anim.GetClip("Chest_Open");
            anim.Play();
        }
        else
        {
            anim.clip = anim.GetClip("Chest_Close");
            anim.Play();
        }
    }
}
