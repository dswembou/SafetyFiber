using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float walkSpeed = 2f;
    [SerializeField] private float turnSpeed = 15f;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Walking();
        Turning();
    }

    void Walking()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        if (vertical != 0)
        {
            animator.SetBool("walking", true);
        }
        else
        {
            animator.SetBool("walking", false);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("running", true);
            walkSpeed = 7f;
        }
        else
        {
            animator.SetBool("running", false);
            walkSpeed = 2f;
        }
        transform.Translate(vertical * Time.deltaTime * walkSpeed, 0f, 0f);
    }

    void Turning()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        
        transform.Rotate(0,0,-horizontal * Time.deltaTime * turnSpeed);
    }
}
