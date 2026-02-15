using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTextScript : MonoBehaviour
{
    public TextMeshProUGUI text;


    public void SetScore(int value)
    {
        text.text = value.ToString();
    }
}
