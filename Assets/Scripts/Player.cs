using NUnit.Framework.Internal;
using UnityEngine;

public class Player : MonoBehaviour
{
    InputController inputActions;
    CharacterController characterController;
    BoxCollider boxCollider;
    public GameObject enemy;
    public float speed;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        boxCollider = GetComponent<BoxCollider>();
    }
    void Awake()
    {
        inputActions = new InputController();
    }
    void OnEnable()
    {
        inputActions.Enable();
    }
    void OnDisable()
    {
        inputActions.Disable();
    }
    void Update()
    {
        double time = Time.realtimeSinceStartupAsDouble;
        if (time > 10)
        {
            enemy.SetActive(true);
        }
        Vector2 moveInput = inputActions.Movement.movement.ReadValue<Vector2>();
        Vector3 move = new Vector3(moveInput.x, moveInput.y, 0);
        move = Vector3.ClampMagnitude(move, 1f);
        move = move.normalized;
        Vector3 FinalMove = (move * speed);
        characterController.Move(FinalMove * Time.deltaTime);
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("trafion spedalony");
    }
}
