using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayControl : MonoBehaviour {

    public float speed;
    private int count;
    public GUIText countText;
    public GUIText winText;

    void Start()
    {
        count = 0;
        setCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        float horizontaolMove = Input.GetAxis("Horizontal");
        float verticavMove = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontaolMove, 0.0f, verticavMove);

        GetComponent<Rigidbody>().AddForce(movement * speed); 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count++;
            setCountText();
            if (count >= 9)
            {
                winText.text = "You Win!";
            }
        }
    }

    void setCountText()
    {
        countText.text = "Count: " + count.ToString();
    }
}
