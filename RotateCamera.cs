using UnityEngine;
using System.Collections;

public class RotateCamera : MonoBehaviour {

    public int maxAngle = 60;
    public int minAngle = 359;
    public float speed = 360.0f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            this.transform.Rotate(0, horizontal, 0, Space.World);
            if (this.transform.localEulerAngles.x + vertical <= maxAngle||
                this.transform.localEulerAngles.x + vertical >= minAngle)
            {
                this.transform.Rotate(vertical, 0, 0, Space.Self);
            }
        }
	
	}
}
