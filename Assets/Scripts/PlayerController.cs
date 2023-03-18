using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public PlayerInputActions playerControlls;
    Vector2 moveDirection;
    public Rigidbody rb;
    public int speed = 5;
    private InputAction move;
    private InputAction fire;


    private void Awake()
    {
        playerControlls = new PlayerInputActions();
    }

    private void OnEnable()
    {
        move = playerControlls.Player.Move;
        move.Enable();

        fire = playerControlls.Player.Fire;
        fire.Enable();
        fire.performed += Fire;
        //playerControlls.Enable();
    }

    private void OnDisable()
    {
        move.Disable();
        fire.Disable();
        //playerControlls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = move.ReadValue<Vector2>();   
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * speed, 0);
    }

    private void Fire(InputAction.CallbackContext context)
    {
        Debug.Log("test");
    }
}
