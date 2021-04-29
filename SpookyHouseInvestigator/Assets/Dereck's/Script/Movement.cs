using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public bool isPaused;
    public GameObject PlayerFoward;
    public GameObject PlayerBackward;
    public GameObject PlayerLeft;
    public GameObject PlayerRight;

    private void Start()
    {
        PlayerFoward.SetActive(true);
        PlayerBackward.SetActive(false);
        PlayerRight.SetActive(false);
        PlayerLeft.SetActive(false);
    }

    void Update()
    {
        if (isPaused == false)
        { 
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
            if (Input.GetKeyDown(KeyCode.W))
            {
                PlayerFoward.SetActive(true);
                PlayerBackward.SetActive(false);
                PlayerRight.SetActive(false);
                PlayerLeft.SetActive(false);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                PlayerFoward.SetActive(false);
                PlayerBackward.SetActive(false);
                PlayerRight.SetActive(false);
                PlayerLeft.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                PlayerFoward.SetActive(false);
                PlayerBackward.SetActive(true);
                PlayerRight.SetActive(false);
                PlayerLeft.SetActive(false);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                PlayerFoward.SetActive(false);
                PlayerBackward.SetActive(false);
                PlayerRight.SetActive(true);
                PlayerLeft.SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused == false)
            {
                isPaused = true;
            }
            else
                isPaused = false;
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
