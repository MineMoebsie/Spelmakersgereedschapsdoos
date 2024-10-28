using UnityEngine;

public class BirdScript : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D Ridgitbodie;
    public float flapSterkte;
    private LogicaScript logica;
    void Start()
    {
        logica = GameObject.FindGameObjectsWithTag("Logica")[0].GetComponent<LogicaScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < 5) {
            Ridgitbodie.linearVelocity = Vector2.up * flapSterkte;
        }
        if (transform.position.y < -5) logica.gameOver();
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        logica.gameOver(); 
    }
}
