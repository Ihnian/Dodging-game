using System;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    public float speed;
    public GameObject Player;
    private float distance;
    public GameObject otherObject;
    private Vector2 otherSize;
    public bool enemy_move_var = true;
    
    SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer sr = otherObject.GetComponent<SpriteRenderer>();
        Bounds b = sr.bounds;
        float x = UnityEngine.Random.Range(b.min.x, b.max.x);
        float y = UnityEngine.Random.Range(b.min.y, b.max.y);

        transform.position = new Vector2(x, y);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy_move_var == true)
        {
            enemy_move();    
        }
    }
    void enemy_move()
    {
        distance = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 direction = Player.transform.position - transform.position;
        direction.Normalize();
        double angle = Math.Atan2(direction.y, direction.x);
        float float_angle = (float)angle;
        transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
        transform.rotation = quaternion.Euler(Vector3.forward * float_angle);
        double time = Time.realtimeSinceStartupAsDouble;
    }
}
