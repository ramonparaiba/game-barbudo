using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    private PlayerScore playerScore;

    private void Start(){
        playerScore = GetComponent<PlayerScore>();
    }

    private void OnTriggerEnter2D(Collider2D other){
       if (other.gameObject.tag == "Apple") {
            
            Destroy(other.gameObject);
            playerScore.AddScore(100);
        } 
    }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Enemy"){
            playerScore.SubtractScore(10);
        }
    }

}
