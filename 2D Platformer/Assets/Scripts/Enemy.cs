using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Enemy Stats")]
    public float moveSpeed;// How fast the enemy will move
    public Vector3 moveOffset;// Enemy Direction
    private Vector3 startPos;
    private Vector3 targetPos;




    void Start()
    {
        startPos = transform.position;
        targetPos = startPos;

    }


    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);


        if (transform.position == targetPos)
        {

            if (targetPos == startPos)
            {
                targetPos = startPos + moveOffset;
            }

            else
            {
                targetPos = startPos;
            }
        }
    }
    
    private void OnDrawGizmos()
    {
        Vector3 from;
        Vector3 to;

        if (Application.isPlaying)
        {
            from = startPos;
        }
        else
        {
            from = transform.position;
        }

        to = from + moveOffset;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(from, to);
        Gizmos.DrawWireSphere(to, 0.2f);
        Gizmos.DrawWireSphere(from, 0.2f);
    }
}
