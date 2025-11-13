using TMPro;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreUI;

    private int score;
    public void AddScore(int amount)
    {
        score += amount;
        scoreUI.text = score.ToString();
        Debug.Log(score);
    }
}