using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
<<<<<<< Updated upstream

=======
//Just a test
//another test

//final test
>>>>>>> Stashed changes
public class UI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public void SetScoreText(int score)
    {
        scoreText.text = score.ToString();
    }
}
