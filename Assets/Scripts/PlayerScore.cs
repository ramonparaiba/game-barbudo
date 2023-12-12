using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int score = 0;
    public void AddScore(int pointsToAdd){
        score += pointsToAdd;
        Debug.Log(score);
    }
    public void SubtractScore(int pointsToSubtract){
        score -= pointsToSubtract;
        Debug.Log(score);
    }
}