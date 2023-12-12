using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerTests
{
    private PlayerScore playerScore;
    private PlayerMovement playerMovement;
    [SetUp]
    public void Setup(){
        GameObject gameObject = new GameObject();
        playerScore = gameObject.AddComponent<PlayerScore>();

       
    }

    [Test]
    public void AddScoreTest(){     

        playerScore.AddScore(100);
        Assert.AreEqual(100, playerScore.score);
    }

    [Test]
    public void SubtractScoreTest(){
        int initialScore = playerScore.score;
        playerScore.SubtractScore(10);
        Assert.AreEqual(initialScore-10, playerScore.score);
    }

    [Test]
    public void ChangePositionTest(){
        
        //Arrange
        var gameObject = new GameObject();
        var rb = gameObject.AddComponent<Rigidbody2D>();
        var playerMovement = gameObject.AddComponent<PlayerMovement>();
        playerMovement.Start(); 
        Vector2 initialPosition = rb.transform.position;    

        // Act
        playerMovement.Move(1, 1);
       
        // Assert
        Assert.AreNotEqual(initialPosition, rb.transform.position);
        
    }
  
}
