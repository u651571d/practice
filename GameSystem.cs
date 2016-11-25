using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour {

    

    void OnGUI()
    {
        GUILayout.Label("c：カメラ切り替え　ｖ：ジャンプ　x：リスタート");

    }

    // Use this for initialization
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
	

              
                    
                
            
        
	
	
}
