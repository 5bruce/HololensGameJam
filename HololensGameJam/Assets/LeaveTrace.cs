using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveTrace : MonoBehaviour {
    public GameObject TracePrefab;
    public float interval = 3f;
    public float Offset = 1.7f;

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
            if (Vector3.Distance(Camera.main.transform.position - Vector3.up * Offset, Traces[Traces.Count - 1].transform.position) > interval)
            {
                SpawnTrace();
            }
        }
        else
        {
            SpawnTrace();
        }
        
    }

    void SpawnTrace()
    {
        GameObject trace = Instantiate(TracePrefab, Camera.main.transform.position - Vector3.up * Offset, Quaternion.identity) as GameObject;
        Vector3 rot = -Camera.main.transform.forward;
        rot.y = 0.0f;
        trace.transform.forward = rot;
        Traces.Add(trace);

    }
}
