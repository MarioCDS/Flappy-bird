using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    private void Start()
    {
        score = 0;
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    private void Update()
    {
        scoreText.text = score.ToString();
    }
}
