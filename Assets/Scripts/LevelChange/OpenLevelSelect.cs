using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenLevelSelect : LevelSelector

{
    public GameObject levelUI;
    void Update()
    {
        if (Input.GetKeyDown("l"))
        {
            OpenScene();
            SceneManager.LoadScene("LevelSelectMenu");

        }
    }

    
}
