using UnityEngine;
using System.Collections;

public class MoveStage : MonoBehaviour
{
    private CharacterController controller;
    int count = 0;
    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 0) { 
        controller.Move(new Vector3(2, 0, 0));
        count = count + 1;
        }

    else{
            count = count + 1;
    }
        if (count == 50){
             controller.Move(new Vector3(-2, 0, 0));
                    }
        if (count == 100)
        {
            count = 0;
        }
       

    }
}
