using TMPro;
using UnityEngine;

public class DialougeLines : MonoBehaviour
{
    [SerializeField] string[] voiceLines;
    [SerializeField] TMP_Text subtitleUI;

    int currentLine = 0;

    public void NextLines()
    {
        currentLine++;
        subtitleUI.text = voiceLines[currentLine];
    }
}
