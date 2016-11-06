using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour {


    public bool rotate = false;
    public ScoreBoard mScoreBoard;
    private Animation anim;
    private AudioSource mAudioSource;
    private bool open = false;
    private bool firstBlood = false;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animation>();
        mAudioSource = GetComponent<AudioSource>();

    }

    void Update()
    {
        if (rotate)
        {
            transform.Rotate(-Vector3.up, 30.0f * Time.deltaTime);
        }
    }
	
    public void OpenChest()
    {
        if (anim == null)
            return;
        if(!open && !firstBlood)
        {
            anim.clip = anim.GetClip("Chest_Open");
            anim.Play();
            mAudioSource.Play();
            // TODO: add score
            mScoreBoard.increment();
            firstBlood = true;
        }
        else
        {
            anim.clip = anim.GetClip("Chest_Close");
            anim.Play();
        }
    }
}
