using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    public float speed;
    public GameObject Player;
    private float distance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 direction = Player.transform.position - transform.position;
        direction.Normalize();
        double angle = Math.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        float float_angle = (float)angle;
        transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
        transform.rotation = quaternion.Euler(Vector3.forward * float_angle);
    }
}
