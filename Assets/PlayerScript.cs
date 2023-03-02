using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Vector2 Player;
    public GameObject pointer;
    float speed = 3;
    public float xAxis;
    public float yAxis;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, pointer.transform.position, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Player.x = Random.Range(-xAxis,xAxis);
            Player.y = Random.Range(-yAxis,yAxis);

           pointer.transform.position = new Vector2(Player.x, Player.y);

            transform.up = pointer.transform.position - transform.position;
           // float angle = Mathf.Atan2(direction.x,direction.y) * Mathf.Rad2Deg;

            //transform.eulerAngles = Vector3.forward * angle;


        }
    }
}
