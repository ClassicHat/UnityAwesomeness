using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBox : MonoBehaviour {
    public float mass;
    public float velocity = 0f;
    private bool hasCollide = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveBox();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Wall")
        {
            this.velocity *= -1f;
            Debug.Log("Wall Collide");

        }
    }

    //float Bounce(BigBox bigBox)
    //{
    //    float sumM = this.mass + bigBox.mass;
    //    float newVel = (2 * bigBox.mass / sumM) * bigBox.velocity;
    //    newVel += ((this.mass - bigBox.mass) / sumM) * this.velocity;

    //    //float sumM = this.mass + bigBox.mass;
    //    //float newVel = ((this.mass - bigBox.mass) / sumM) * this.velocity;
    //    //newVel += (2 * bigBox.mass / sumM) * bigBox.velocity;

    //    return newVel;

    //}

    void MoveBox()
    {
        this.transform.Translate(velocity, 0, 0);
    }
}
