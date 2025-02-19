using UnityEngine;
using TMPro;

public class Distance_Detect : MonoBehaviour
{
    public TextMeshPro score;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {

        float distance = Vector3.Distance(Vector3.zero, collision.GetContact(0).point);

        score.text = distance.ToString("#.00");
        }
    }
}
