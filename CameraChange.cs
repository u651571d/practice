using UnityEngine;
using System.Collections;

public class CameraChange : MonoBehaviour {

    private GameObject MainCamera;
    private GameObject SubCamera;
    int count;
	// Use this for initialization
	void Start () {
        MainCamera = GameObject.Find("HorizontalCamera");
        SubCamera = GameObject.Find("VerticalCamera");

        SubCamera.SetActive(false);
        count = 0;
        
	
	}
	
	// Update is called once per frame
	void Update ()
    {

                
      if (Input.GetButton("Fire1"))
          {
            if (count == 7)
            {
                if (MainCamera.activeSelf)
                {
                    MainCamera.SetActive(false);
                    SubCamera.SetActive(true);
                }
                else
                {
                    MainCamera.SetActive(true);
                    SubCamera.SetActive(false);
                }

                count = 0;
            }else
            {
                count = count + 1 ;
            }
            }
              
          
   
         
	
	}
}
