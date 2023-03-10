using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{
 private Vector3 _direction;
 public float gravity = -9.8f;
 public float strength = 5f;

 private void Update()
 { 
         _direction.y += gravity * Time.deltaTime;

         transform.position += _direction * Time.deltaTime;

     if (Input.GetKeyDown(KeyCode.Space)|| Input.GetKeyDown(KeyCode.Mouse0))
     {
         _direction = Vector3.up * strength;
     }

     if (Input.touchCount > 0)
     {
         var touch = Input.GetTouch(0);
         if (touch.phase == TouchPhase.Began)
         {
             _direction = Vector3.up * strength;
         }


     }
 }
}
