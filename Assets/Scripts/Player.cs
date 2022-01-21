using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public Text scoreView;
    public Transform gameOver;
    public Transform play;

    [SerializeField]
    int impulso;
    [SerializeField]
    int score;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * impulso;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("AddScore")){
            score++;
            scoreView.text = score.ToString();
        }

        if (collision.CompareTag("Pipe"))
        {
            enabled = false;
            gameOver.gameObject.SetActive(true);
            Invoke("Pause", 2);
        }
    }

    void Pause()
    {
        Time.timeScale = 0;
    }
}
