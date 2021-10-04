using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ttt : MonoBehaviour
{
    Rigidbody2D rbCharacter;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        rbCharacter = GetComponent<Rigidbody2D>();
        //Debug.Log("In the Start");

    }

    // Update is called once per frame
    void Update()
    {
       /* Vector2 myVector;
        // to the right
        if (Input.GetKeyDown("d"))
        {
            speed = 5;
            //Debug.Log("Reckt");

        }
        // to the left
        else if (Input.GetKeyDown("a"))
        {
            speed = -5;


        }
        */



        //myVector = new Vector2(speed, (float)0.0);
        //rbCharacter.velocity = myVector;
        //rbCharacter.AddForce(myVector);
        //Debug.Log("In the Update");
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(new Vector3(x, y, 0.0f));

    }
}
