using UnityEngine;
using TMPro;

public class CountScore : MonoBehaviour
{
    public Detect detect;
    public Detect detect1;
    public Detect detect2;
    
    public int Tscore = 0;

    public TextMeshPro score;

    public void Update()
    {
        Tscore = detect.Points + detect1.Points + detect2.Points;
        score.text = "Score: " + Tscore;
    }
}
