using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI point;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void IncreaseScore()
    {
        score++;
        point.text = score.ToString();
    }

}
