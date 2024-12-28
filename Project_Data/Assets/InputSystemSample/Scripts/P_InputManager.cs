using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.InputSystem;

public class P_InputManager : MonoBehaviour
{
    PlayerControlTemp playerControl;
    Rigidbody rb;

    private void Awake()
    {
        playerControl = new PlayerControlTemp();
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        playerControl.Enable();
        playerControl.Basic.Jump.performed += Jump;
    }

    private void OnDisable()
    {
        playerControl.Disable();
        playerControl.Basic.Jump.performed -= Jump;        
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Debugger.Log("점프");
            rb.AddForce(Vector3.up * 4, ForceMode.Impulse);
        }
    }

    public void OnJump()
    {
        Debugger.Log("점프");
        rb.AddForce(Vector3.up * 4, ForceMode.Impulse);
    }

    public void OnMove()
    {
        Debugger.Log("무브");

    }
}
