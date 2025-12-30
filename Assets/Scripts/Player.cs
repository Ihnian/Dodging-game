using NUnit.Framework.Internal;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;

public class Player : MonoBehaviour
{
    InputController inputActions;
    CharacterController characterController;
    Rigidbody2D rb;
    public GameObject enemy;
    public GameObject Player2;
    public GameObject tekst;
    public GameObject timer;
    public GameObject settings;
    private bool colliding;
    public float speed;
    private int liczba;
    Vector3 moveInput;
    private bool UI = false;
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
        liczba++;
        if (liczba == 300 || liczba == 200)
        {
            GameObject enemy_copy = Instantiate(enemy);
            enemy_copy.SetActive(true);
        }
        
        moveInput = inputActions.Movement.movement.ReadValue<Vector2>();
        moveInput = moveInput.normalized;
        rb.MovePosition(transform.position + moveInput * Time.fixedDeltaTime * speed);

    }
    void Update()
    {
        if (inputActions.Movement.esc.triggered)
        {
            UI = !UI;
            settings.SetActive(UI);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Enemy(Clone)")
        {
            Player2.SetActive(false);
            tekst.SetActive(true);
            timer.SetActive(false);
        }
    }
}
