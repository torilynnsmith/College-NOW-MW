using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepMe : MonoBehaviour
{
    //IN CLASS COLLEGE NOW

    //GLOBAL VARIABLES
    public static GameObject instance; //static variables are shared by all instances of a class. This means it preserves its values when "out of scope" or outside of the loaded scene
                                       //NOTE: even though this is a public static variable, it will not appear in the inspector. It is set through code by its mere existence

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Awake is called once when the script instance is loaded
    private void Awake() //if the instance of the game object this script is attached to does not exist when the new scene starts....
    {
        //when the new scene/instance of this script loads...
        if (instance == null)
        {
            Debug.Log("Game Manager not destroyed."); //print to console
            instance = gameObject; //the new static instance becomes equal to this game object. It now exists! 
            DontDestroyOnLoad(gameObject); //don't destory the target object when loading a new Scene
        }
        else //if the instance DOES already exist in the loaded scene...
        {
            Debug.Log("Duplicate Audio Manager Destroyed"); //print to console
            Destroy(gameObject); //destroy the duplicate gameObject in the new scene so you don't have duplicates of things floating around and running code twice
        }

        //The above code is useful for maintaining information between scenes. This can apply to things like:
        //game managers, background music, save states, scores, etc. when moving b/w scenes.

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
