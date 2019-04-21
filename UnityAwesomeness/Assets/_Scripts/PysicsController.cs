using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PysicsController : MonoBehaviour {

   
    public GameObject bigBoxPrefab;
    public GameObject smallBoxPrefab;

    
    // Use this for initialization
    void Start () {
        Instantiate(bigBoxPrefab);
        Instantiate(smallBoxPrefab);
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
