/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject Left;
    public GameObject Right;
    public GameObject Player;
    private Animation Rightanim;
    private Animation Leftanim;
    bool isOpened = false; //door open status
    public Light lt;
    public float delay;

    void Start()
    {
        Rightanim = Right.GetComponent<Animation>();
        Leftanim = Left.GetComponent<Animation>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (!isOpened && col.gameObject.name == "Player")
        {
            lt.color = Color.green;
            Rightanim["DoorBRight"].speed = 1;//set animations from start point
            Leftanim["DoorBLeft"].speed = 1;
            Rightanim["DoorBRight"].time = 0;
            Leftanim["DoorBLeft"].time = 0;
            Rightanim.Play("DoorBRight");
            Leftanim.Play("DoorBLeft");
            isOpened = true;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (isOpened && col.gameObject.name == "Player")
        {
            lt.color = Color.red;
            StartCoroutine("wait");
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(delay);
        isOpened = false;
        Rightanim["DoorBRight"].speed = -1;//set animations from end points
        Leftanim["DoorBLeft"].speed = -1;
        Rightanim["DoorBRight"].time = Rightanim["DoorBRight"].length;//play animations backwards
        Leftanim["DoorBLeft"].time = Leftanim["DoorBLeft"].length;
        Rightanim.Play("DoorBRight");
        Leftanim.Play("DoorBLeft");
    }

}*/