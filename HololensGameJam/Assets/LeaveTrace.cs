using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveTrace : MonoBehaviour {
    public GameObject TracePrefab;
    public float interval = 3f;

    List<GameObject> Traces;

	// Use this for initialization
	void Start ()
    {
        Traces = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Traces.Count > 0)
        {
            if (Vector3.Distance(Camera.main.transform.position, Traces[Traces.Count - 1].transform.position) > interval)
            {
                GameObject trace = Instantiate(TracePrefab, Camera.main.transform.position - Vector3.up * 1.7f, Quaternion.identity) as GameObject;
                Traces.Add(trace);
            }
        }
        else
        {
            GameObject trace = Instantiate(TracePrefab, Camera.main.transform.position - Vector3.up * 1.7f, Quaternion.identity) as GameObject;
            Traces.Add(trace);
        }
        
    }
}
