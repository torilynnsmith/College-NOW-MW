using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{
    //COLLEGE NOW IN CLASS

    //GLOBAL VARIABLES
    public GameObject foodPrefab; //declare and set foodPrefab variable in the inspector (use the food prefab we made!)

    //Get Border Positions (so we can spawn the food within them, set in inspector)
    public Transform wallTop;
    public Transform wallBottom;
    public Transform wallLeft;
    public Transform wallRight;

    // Start is called before the first frame update
    void Start()
    {
        //Spawn(); //call Spawn() once after start
        //Invoke("Spawn", 4); //Call Spawn() 4 seconds after start
        InvokeRepeating("Spawn", 4, 4); //Call Spawn() 4 seconds after start, then every 4 seconds after that. 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        //Debug.Log("Spawn Called"); //print to console

        //set x position b/w Left & Right borders
        int xPos = (int)Random.Range(wallLeft.position.x, wallRight.position.x);
        //randomly set the xPos of the food's position to a random integer between the x position values of the Left and right borders
        //NOTE that we are rounding to INTEGERS, not FLOATS

        //set y position b/w Bottom & Top borders
        int yPos =(int)Random.Range(wallBottom.position.y+5, wallTop.position.y-5);
        //ALSO NOTE that I've added/subtracted 5 from each y position, to give our Random Range a little extra buffer and prefent food from accidentally spawning within the borders themselves.

        //INSTANTIATE the foodPrefab at (xPos, yPos) cooordinates
        Instantiate(foodPrefab, new Vector3(xPos, yPos, 0), Quaternion.identity);
        //Instantiate (original, position, rotation)
        //Instantiate creates a new instance of a game object. It has 3 parameters:
        //1. The name of the existing object you want to make a copy of (plug in the variable we made!)
        //2. The position for the new object, declare a new Vector3 and plug in our xPos, yPos variables we just set
        //3. The orientation/rotation of the new object
        //WHAT IS A QUATERNION? Quaternions represent rotation and are relatively complex.
        //We may get into them later, but just use Quaternion.identity to set them for now. This is the default. 
        //Remember: NO IDENTITY CRISES! 

    }
}
