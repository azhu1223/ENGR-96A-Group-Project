using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class BulletScript : MonoBehaviour
{
    int speed = 10;
    Rigidbody2D rb; 
    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector3 offset = Camera.main.ScreenToWorldPoint(Input.mousePosition).normalized;
        rb.velocity = new Vector2(offset.x * speed, offset.y * speed); ;
    }
}
