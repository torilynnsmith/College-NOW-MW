using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //use Scene Managment Library

public class SceneChanger : MonoBehaviour
{
    //COLLEGE NOW IN CLASS SCRIPT

    //GLOBAL VARIABLES
    public int sceneNumber;
        //0 = StartScene
        //1 = MainScene
        //2 = EndScene

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneNumber == 0) //if we're in the Start Scene
        {
            //use Start Scene Controls
            //Debug.Log("start scene controls");
            StartSceneControls(); //load main scene
        }
        else if (sceneNumber == 1) //if we're in the Main Scene
        {
            //use Main Scene Controls
            //Debug.Log("main scene controls");
        }
        else if (sceneNumber == 2) //if we're in the End Scne
        {
            //use End Scene Controls
            //Debug.Log("end scene controls");
        }
    }

    public void StartSceneControls()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //Debug.Log("Return Key Pressed");
            SceneManager.LoadScene("MainScene");
        }
    }
}
