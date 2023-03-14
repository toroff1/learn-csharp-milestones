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

        Debug.LogFormat("I am {0} years old.", GetAge(name));
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


    public int GetAge(string name)
    {
        Debug.Log("Getting age...");

        return age;
    }

    void TestConditionals()
    {

        if(age == 21)
        {
            Debug.Log("I can rent a car! Maybe.");
        }
        else if(age == 0)
        {
            Debug.Log("I am an infant.");
        }
        else
        {
            Debug.Log("I am some age that isn't 21 or 0.");
        }

        if(isAlive == true)
        {
            Debug.Log("I am alive!");
        }

        if(!isAlive == true)
        {
            Debug.Log("I am not alive.");
        }

        if(isAlive == true)
        {
            if(age == 21)
            {
                Debug.Log("I am alive and 21!");
            }
        }

        switch (age)
        {
            case 21:
                Debug.Log("I can buy alcohol!");
                break;
            case 18:
                Debug.Log("I can buy lottery tickets! And go to war...");
                break;
            default:
                Debug.Log("I am some other age. Meh.");
                break;
        }




    }

    void TestCollectionsAndLoops()
    {
        int[] myDominos = [1, 6, 3, 4];

        List<string> myDominosNames = new List<string>();
        myDominosNames.Add("joe");
        myDominosNames.Add("jimmy");
        myDominosNames.Add("jonny");

        Dictionary<string, int> dominoMatchings = new Dictionary<string, int>()
        {
            {"joe", 1},
            {"jimmy", 6}
        };

        for (int i = 0; i < myDominosNames.Count; i++)
        {
            if (myDominosNames[i] == "joe")
            {
                Debug.Log(myDominosNames[i]);
            }

        }

        foreach (int domino in myDominos)
        {
            Debug.Log(domino);
        }

        foreach(KeyValuePair<string, int> match in dominoMatchings)
        {
            Debug.Log(match.Key);
            Debug.Log(match.Value);
        }

    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
