using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController2D : MonoBehaviour
{
    //Value Types
    [Header("Player Settings")]
    public float moveSpeed;
    public float jumpForce;
    public bool isGrounded;
    public float bottomBound;
    [Header("Score")]
    public int score;


    //Refrence Types
    public Rigidbody2D rig;
    public TextMeshProUGUI scoreText;

    // Increase the score and Update the score text UI
    public void AddScore(int amount)
    {
        //Add to score
        score += amount;
        //Update score text UI
        scoreText.text = "Score: " + score;
    }


    void FixedUpdate()
    {
        //Gather Inputs
        float moveInputs = Input.GetAxisRaw("Horizontal");
        // Make the player move side to side
        rig.linearVelocity = new Vector2(moveInputs * moveSpeed, rig.linearVelocity.y);

    }

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            isGrounded = false;
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        if (transform.position.y < bottomBound)
        {
            GameOver();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.GetContact(0).normal == Vector2.up)
        {
            isGrounded = true;
        }
    }
    
    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
