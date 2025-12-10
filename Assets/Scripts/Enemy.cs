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
    
    SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer sr = otherObject.GetComponent<SpriteRenderer>();
        otherSize = sr.bounds.size;
        Vector2 position = new Vector2(UnityEngine.Random.Range(0, 10), UnityEngine.Random.Range(0, 10));
        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        enemy_move();
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
