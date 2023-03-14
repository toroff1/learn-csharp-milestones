using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour

{

    private int age = 21;
    private float donutsEaten = 100.5f;
    public string name = "Jeremy Elbertson";
    public bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Hello");
        Debug.LogFormat("My name is {0}.", name);
        Debug.Log("Here I am..." + "Concating Strings!");
        Debug.LogFormat($"I've eaten {donutsEaten} donuts in my lifetime.");

        Debug.LogFormat("I am {0} years old.", getAge(name));
        // Single Line Comment

        /*
         * Multi Line Comment!
         * 
         * 
         * Wowee Zowee
         * 
         */


        ///<summary>
        ///
        /// Summary ooooooh
        /// 
        /// 
        /// </summary>

    }


    public int getAge(string name)
    {
        Debug.Log("Getting age...");

        return age;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
