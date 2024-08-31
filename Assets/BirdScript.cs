using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidBody;
    public LogicScript logic;
    public AudioSource birdFlap;
    public Animator birdAnimator;
    public float flapStrength;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && gameOver == false)
        {
            birdAnimator.SetBool("isFlapping", true);
            birdRigidBody.velocity = Vector2.up * flapStrength;
            birdFlap.Play();
            // birdAnimator.SetBool("isFlapping", false);   
        }
        if(transform.position.y < -17 || transform.position.y > 17)
        {
            logic.gameOver();
            gameOver = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();   
        gameOver = true;
    }
    public void StopFlapping()
    {
        birdAnimator.SetBool("isFlapping", false);
    }
}
