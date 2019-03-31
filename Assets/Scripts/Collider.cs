using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Debug.Log("ygygyyyy");
            Destroy(col.gameObject);
        }
    }
}
