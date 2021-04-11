using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class user
    private int score;
    public answer[] ansQuestions;

    public user()
    {
    this.score = 0;
    }
    
    public void incrementScore(int add)
    {
    this.score += add;
    }
    
    public int getScore()
    {
    return this.score;
    }
}
