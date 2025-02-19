using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class shootBall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            
        }
    }
}
