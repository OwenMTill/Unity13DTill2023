using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    float smooth = 5.0f;
    float tiltAngle = 60.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //getting mouse input for paddle position
        Vector3 pos = new Vector3((Input.mousePosition.x - Screen.width/2)/(Screen.width/10), transform.position.y, (Input.mousePosition.y - Screen.width / 2) / (Screen.width / 10));

        //getting input for padddle rotation
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        Quaternion targetRotation = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        transform.rotation = targetRotation;
        transform.position = pos;
    }
}
