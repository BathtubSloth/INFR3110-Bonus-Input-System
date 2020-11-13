using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    public bool isGrounded;
    private Rigidbody2D m_rigidBody2D;
    private SpriteRenderer m_spriteRenderer;
    private Animator m_animator;
    //public InputAction jumpAction;

    // Start is called before the first frame update
    void Start()
    {
        m_rigidBody2D = GetComponent<Rigidbody2D>();
        m_spriteRenderer = GetComponent<SpriteRenderer>();
        m_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        //jumpAction.performed += _ => OnJump();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Debug.Log("Move Action performed with: " + context.control.name);
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("Jump Action performed with: " + context.control.name);
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        isGrounded = true;
    }

    public void OnCollisionExit2D(Collision2D other)
    {
        isGrounded = false;
    }
}
