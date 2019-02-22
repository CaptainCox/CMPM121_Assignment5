using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Animator anim;
    public int count;
    public GameObject Left;
    public GameObject Right;
    public GameObject Player;
    private Animation Rightanim;
    private Animation Leftanim;
    public bool isOpened = false; //door open status
    //public bool colorGreen = false;
    public float delay;
    public Light light;

    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
        count = 0;
        Rightanim = Right.GetComponent<Animation>();
        Leftanim = Left.GetComponent<Animation>();
        light.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow)
            || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetBool("Walk", true);
            anim.SetBool("Stop", false);

        }
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.LeftArrow)
             || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetBool("Walk", false);
            anim.SetBool("Stop", true);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * 2 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * 1 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(0, 1.5f, 0);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(0, -1.5f, 0);

        if (count == 6)
        {
            isOpened = true;
            //colorGreen = true;
            light.color = Color.green;
        }
        if (!isOpened == true)
        {
            //light.color = Color.green;
            Rightanim["DoorBRight"].speed = 1;
            Leftanim["DoorBLeft"].speed = 1;
            Rightanim["DoorBRight"].time = 0;
            Leftanim["DoorBLeft"].time = 0;
            Rightanim.Play("DoorBRight");
            Leftanim.Play("DoorBLeft");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
        }
    }
}
