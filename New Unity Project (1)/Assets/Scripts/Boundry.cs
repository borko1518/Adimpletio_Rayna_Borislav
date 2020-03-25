using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundry : MonoBehaviour
{
    private Vector2 screenbounds;
    private float objW;
    private float objH;
    // Start is called before the first frame update
    void Start()
    {
        screenbounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        objW = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objH = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;


    }


    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 Pos = transform.position;
        Pos.x = Mathf.Clamp(Pos.x, screenbounds.x + objW, screenbounds.x - objW);
        Pos.y = Mathf.Clamp(Pos.y, screenbounds.y + objH, screenbounds.y - objH);
        transform.position = Pos;
    }
}
