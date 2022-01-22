using System;
using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;
using Collision2D = UnityEngine.Collision2D;

public class Eat : MonoBehaviour
{

   public bool isDrink;
   
   private void OnCollisionEnter2D(Collision2D other)
   {
      
      Debug.Log("col");
      
      
      if (other.gameObject.tag == "character")
      {
         Debug.Log("char");
         if (other.gameObject.name.Contains("Basil"))
         {
            var flow = GameObject.Find("Flowchart");

            if (!isDrink)
            {
               flow.GetComponent<Flowchart>().ExecuteBlock("EatB");
            }
            else
            {
               flow.GetComponent<Flowchart>().ExecuteBlock("DrinkB");
            }
            
           
         }
         else
         {
            var flow = GameObject.Find("Flowchart");if (!isDrink)
            {
               flow.GetComponent<Flowchart>().ExecuteBlock("EatBlue");
            }
            else
            {
               flow.GetComponent<Flowchart>().ExecuteBlock("DrinkBlue");
            }
         }
      }
   }
}
