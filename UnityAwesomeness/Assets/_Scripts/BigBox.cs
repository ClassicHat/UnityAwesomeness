using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BigBox : MonoBehaviour {
    public float digits;
    public float mass;
    public float velocity = -1f;
    public ArrayList newVelList = new ArrayList();
    public int count = 0;

    void Start()
    {
        this.mass = (float)Math.Pow(100, digits - 1);
    }
    

    void FixedUpdate()
    {
        MoveBox();
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Entered OnCOllision");
        //Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "SmallBox(Clone)")
        {
            
            SmallBox smallBox = collision.gameObject.GetComponent<SmallBox>();
            ArrayList newVel = Bounce(smallBox);
            Debug.Log("Big Box Class" + newVel);
            collision.gameObject.GetComponent<SmallBox>().velocity = (float) newVel[1];
            this.velocity = (float) newVel[0];
            count++;
            Debug.Log("Count: " + count);
        }
        else
        {
            Debug.Log("Collision with " + collision.gameObject.name);

        }
    }

    ArrayList Bounce(SmallBox smallBox)
    {
        float sumM = this.mass + smallBox.mass;

        //Calculate newVel of BigBox
        float newVal = ((this.mass - smallBox.mass) / sumM) * this.velocity;
        newVal += (2 * smallBox.mass / sumM) * smallBox.velocity;
        Debug.Log("newVal of BigBox " + newVal);

        //Calculate newVal2 of SmallBox
        float newVal2 = ((smallBox.mass - this.mass) / sumM) * smallBox.velocity;
        newVal2 += (2 * this.mass / sumM) * this.velocity;
        Debug.Log("newVal2 of SmallBox " + newVal2);

         
        newVelList.Add(newVal);
        newVelList.Add(newVal2);

        return newVelList;
    }

    void MoveBox()
    {
        this.transform.Translate(velocity, 0, 0);
    }
}
