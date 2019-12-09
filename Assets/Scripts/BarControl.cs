using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarControl : MonoBehaviour
{
    [SerializeField] bool otoPlay = false;
    private BallControl ball;
    // Update is called once per frame
    private void Start()
    {
        ball = GameObject.FindObjectOfType<BallControl>();
    }
    void Update()
    {
        if (otoPlay)
            MoveOto();
        else
            MoveWithMouse();
    }

    private void MoveWithMouse()
    {
        Vector3 barLocation = new Vector3(0f, this.transform.position.y, 0f);
        //Screen.width = 800, mousePosition.x will change between 0-800, 
        //16 is frame number of our main camera
        float mouseLocationX = Input.mousePosition.x / Screen.width * 16;
        barLocation.x = Mathf.Clamp(mouseLocationX, 1.5f, 14.5f);
        this.transform.position = barLocation;
    }

    private void MoveOto()
    {
        //y is constant
        //you can not change x,y,z values directly, 
        //so we must change position value with the help of vector3 or vector2
        Vector3 barLocation = new Vector3(0f, this.transform.position.y, 0f);
        float ballLocationX = ball.transform.position.x;
        barLocation.x = ballLocationX;
        this.transform.position = barLocation;
    }
}