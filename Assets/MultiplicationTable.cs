using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
     public int Multiply(int n, int r)
    {
        return n * r;
    }

    void Start()
    { 

     //string y = "najd";
     

     //int result = Multiply(5, 3);
     //Debug.Log("The result is: " + result); //حل السؤال الثالث
     //Debug.Log("the result is: " + 7 *5);
      
      for (int i = 1; i <= 10; i++)
        {
            // حل السؤال الرابع
            int result = Multiply(5, i);

            Debug.Log("5 x " + i + " = " + result);
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
