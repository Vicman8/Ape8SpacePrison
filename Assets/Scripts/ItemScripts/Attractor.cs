using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    private bool attracting = false;
    private GameObject movingTarget;
    
    void Update()
    {
        if (attracting)
        {
            move(movingTarget);
        }
    }
    private void move(GameObject target)
    {
        Vector2 dist = new Vector2(Mathf.Abs(target.transform.position.x - gameObject.transform.position.x), Mathf.Abs(target.transform.position.y - gameObject.transform.position.y));

        transform.position += target.transform.position;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        movingTarget = collision.gameObject;
        attracting = true;
        Debug.Log("test");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        movingTarget = null;
        attracting = false;
    }
}
