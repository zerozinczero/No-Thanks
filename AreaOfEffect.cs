using UnityEngine;
using System.Collections;

public class AreaOfEffect : MonoBehaviour
{
    public static float esteem=95;
    public static double sort = 10;
    public static double risk=5;
    public static float eMod;
    public static double sMod;
    public static double rMod;
    public static double timer =15;

    //esteem, sort,  risk, money

    
    void Start()
    {

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Bar")
        {

            eMod = Time.deltaTime * 1;

            rMod = Time.deltaTime * .50;
            esteem += eMod;
            risk += rMod;

            if (esteem >= 100)
            {
                esteem = 100;
                Debug.Log("esteem: " + esteem);
            }
            else
            {
                Debug.Log("esteem: " + esteem);
                Debug.Log("risk: " + risk);
            }
        }


        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            timer = 0;
            Debug.Log("timer: " + timer);
        }
        



        if (other.CompareTag("Clinic"))
        {
           // esteem += sMod;
            // Debug.Log("safety: " + safety);
            Debug.Log("esteem: " + esteem);

        }
    } 


   
}