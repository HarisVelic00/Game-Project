using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour{

    Vector3 moveVector = Vector3.zero;
    CharacterController characterController;

    public float moveSpeed;
    public float jumpSpeed;
    public float gravity;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal") * moveSpeed;
        moveVector.z = Input.GetAxis("Vertical") * moveSpeed;
        if (characterController.isGrounded && Input.GetButton("Jump"))
            moveVector.y = jumpSpeed;
        moveVector.y -= gravity * Time.deltaTime;
        characterController.Move(moveVector * Time.deltaTime);

        if (Input.GetKey("q")){
            anim.SetBool("Trcanje", true);
        }else{
            anim.SetBool("Trcanje", false);
        }

        if (Input.GetKey("w"))
        {
            anim.SetBool("Hodanje", true);
        }else{
            anim.SetBool("Hodanje", false);
        }

        if (Input.GetKey("t")){
            anim.SetBool("Napad", true);
        }else
        {
            anim.SetBool("Napad", false);
        }

        if (Input.GetKey("z"))
        {
            anim.SetBool("Napad2", true);
        }
        else
        {
            anim.SetBool("Napad2", false);
        }


    }
}
