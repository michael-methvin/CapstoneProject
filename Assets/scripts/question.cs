using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class question
{
    public answer[] ans;
    public string text;
    public int points;

    public question(answer[] ans, string text, int points)
    {
        this.ans = ans;
        this.text = text;
        this.points = points;
    }
}
