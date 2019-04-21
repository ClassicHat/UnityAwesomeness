using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [Header("Set In Inspector")]
    public double vel = 1;
    public double mass = 1;
    public Vector3 pos;
    // public Vector3 blockOneVector = block2.transform.position.x;
    public Vector3 block2Vec;
    public GameObject block1;
    public GameObject block2;

    //Collision detection function
    private void OnCollisionEnter(Collision collision)
    {

    }

    //void void OnBounce()
    //{
    //    double sumMass;
    //    double newV;

    //}

    // Use this for initialization
    void Awake()
    {
        Instantiate(block1);
        
        Instantiate(block2);

        
    }
    
    void Update()
    {
        block2Vec = block2.transform.position;
        block2Vec.x += 10;
        block2.transform.position.Set(block2Vec.x, block2Vec.y, block2Vec.z);
        //block2.transform.position.x = block2Vec.x;
    }
        
    
}


