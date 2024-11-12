using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class Playerrunning : MonoBehaviour
{
    public float speed = 6.0f;
    private float horizontal;
    private float deltaSize = 0.3f;
    private float deltaUnSize = -0.3f;
    public Gamemaneger gamemaneger;
    public float maxsize = 4f;
    public float minsize = 0.5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        horizontal = Input.GetAxis("Horizontal");
        // Debug.Log(horizontal);
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontal);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("growUp"))
        {
            Debug.Log("вы столкнулись" + other.tag);
            Destroy(other.gameObject);
            transform.localScale += new Vector3(deltaSize, deltaSize, deltaSize);
            if (transform.localScale.y>maxsize)
            {
                transform.localScale = Vector3.one * maxsize;

            }

        }

        if (other.CompareTag("coins"))
        {
            
            Destroy(other.gameObject);
            gamemaneger.coins++;
            Debug.Log("вы столкнулись" + other.tag + " coins " + gamemaneger.coins);
            gamemaneger.UpdateGui();
        }

        if (other.CompareTag("heart"))
        {
            Destroy(other.gameObject);
            gamemaneger.lives++;
            Debug.Log("вы столкнулись" + other.tag + " lives " + gamemaneger.lives);
            gamemaneger.UpdateGui();
        }

        if (other.CompareTag("growDown"))
        {
            Debug.Log("вы столкнулись" + other.tag);
            Destroy(other.gameObject);
            transform.localScale += new Vector3(deltaUnSize, deltaUnSize, deltaUnSize);
            if (transform.localScale.y<minsize)
            {
                transform.localScale = Vector3.one * minsize;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "obstacel") {
            Debug.Log("вы столкнулись с препятсвием");
            gamemaneger.lives--;
            Debug.Log("lives = " + gamemaneger.lives);
            gamemaneger.UpdateGui();
            if (gamemaneger.lives <= 0)
            {
                gamemaneger.Gameover();
            }
        }

        if (collision.collider.tag == "Finish")
        {
            Debug.Log("вы дошли до двери");
            gamemaneger.WinGame();


        }


    }

    
}
