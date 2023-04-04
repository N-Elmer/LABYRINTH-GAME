using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour {
    public float speed;
    public Text countText;
    public Text wintext;

    private Rigidbody rb;
    private int COUNT;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        COUNT = 0;
        setCountText();
        wintext.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            COUNT = COUNT + 1;
            setCountText();
        }
    }

    void setCountText ()
    {
        countText.text = "CUBES " + COUNT.ToString();
        if (COUNT >= 42)
        {
            wintext.text = "YOU WIN!";
        }
        else
        {
            wintext.text = "COLLECT ALL CUBES";
        }
    }
}
