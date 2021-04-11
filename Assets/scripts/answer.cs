using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class answer
{
    public string text;
    public bool correct;
    
    public answer(string ans, bool cor)
    {
        this.text = ans;
        this.correct = cor;
    }

    public bool isCorrect()
    {
        return this.correct;
    }
}
