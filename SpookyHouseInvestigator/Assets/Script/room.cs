using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room : MonoBehaviour
{

    public GameObject camra;
    public GameObject specificroom;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        camra.gameObject.GetComponent<RoomChange>().roomx = specificroom.transform.position.x;
        camra.gameObject.GetComponent<RoomChange>().roomy = specificroom.transform.position.y;
    }

}
