using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public Paddle paddle1, paddle2;
    public Text winText;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(4, 0, 4), ForceMode.Impulse);
        //accelerate to make ball move faster
    }

    public void ReturnToCenter()
    {
        transform.position = new Vector3(0, 0, 0);

        if (paddle1.score >= 11)
        {
            winText.enabled = true;
            winText.text = "Player 1 wins!";
        }
        else if (paddle2.score >= 11)
        {
            winText.enabled = true;
            winText.text = "Player 2 wins!";
        }
    }
    
   
}
