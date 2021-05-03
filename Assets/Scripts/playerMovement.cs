using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public TestController controller;
    public Animator animator;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        //get input
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        //trigger walk anim
        animator.SetFloat("moveSpeed", Mathf.Abs(horizontalMove));

        //set jump to true which is linked to player ocntroller and start jump anim
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
    }

    //function to check ground event in test contoller and stop jump animation
    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    
    }

    //calls the move function from teh controller to allow the player to move and sets initial jump to flase
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
