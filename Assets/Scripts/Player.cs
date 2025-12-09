using NUnit.Framework.Internal;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Player : MonoBehaviour
{
    InputController inputActions;
    CharacterController characterController;
    Rigidbody2D rb;
    public GameObject enemy;
    public GameObject Player2;
    public GameObject tekst;
    private bool colliding;
    public float speed;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody2D>();
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
    void FixedUpdate()
    {
        double time = Time.realtimeSinceStartupAsDouble;
        if (time > 10)
        {
            GameObject copy = Instantiate(enemy);
            copy.SetActive(true);
        }
        else if(time > 20)
        {
            GameObject copy = Instantiate(enemy);
            copy.SetActive(true);
        }
        Vector3 moveInput = inputActions.Movement.movement.ReadValue<Vector2>();
        moveInput = moveInput.normalized;
        rb.MovePosition(transform.position + moveInput * Time.fixedDeltaTime * speed);

    }
    /*
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Enemy")
        {
            Player2.SetActive(false);
            tekst.SetActive(true);
        }
    }
    */
}
