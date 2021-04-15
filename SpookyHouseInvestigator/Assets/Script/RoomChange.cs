using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomChange : MonoBehaviour
{

    
    public float roomx;
    public float roomy;
    public GameObject room;
    public GameObject cam;

    // Start is called before the first frame update

    

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        var camPos = cam.transform.position;
        camPos.x = roomx;
        camPos.y = roomy;
        cam.transform.position = camPos;

    }


}
