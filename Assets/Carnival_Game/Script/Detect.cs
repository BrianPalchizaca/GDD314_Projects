using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System.Security.Cryptography;
using UnityEditor;

public class Detect : MonoBehaviour
{
   
    public int Points = 0;
    public Animation ani;

    public bool Active;
    float time = 3;
    float Countdown = 0;

    public void Start()
    {
        Countdown = time;
    }
    public void Update()
    {
        //tick.text = Countdown.ToString();
        
        if (!Active)
        {
            Debug.Log("countdown");
            Countdown -= Time.deltaTime;
        }
        
        if(Countdown <= 0 && !Active)
        {
            Debug.Log("up again");
            Countdown = time;
            ani.Play("Block_Up");
            Active = true;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Ball" && Active == true)
        {
            ani.Play("Block_Fall");
            Points++;
            Debug.Log("Hit");
            Active = false;
        }

        /*
        Countdown -= Time.deltaTime;

        if (Countdown <= 0 && !Active)
        {
            Debug.Log("counting");
            ani.Play("Block_Up");
            Countdown = time;

        }
        */
    }

}
