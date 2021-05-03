using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void Update ()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;
        float y = Input.GetAxisRaw("Vertical");
        float moveByY = y * speed;


        rb2d.velocity = new Vector2(moveBy, moveByY);
    }


    public void Test()
    {
        speed = 9999;
    }

}
