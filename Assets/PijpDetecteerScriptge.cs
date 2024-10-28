using UnityEngine;

public class PijpDetecteerScriptge : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private LogicaScript logica;
    void Start()
    {
        logica = GameObject.FindGameObjectsWithTag("Logica")[0].GetComponent<LogicaScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // wollahi salami je zit erin
    }

    void OnTriggerEnter2D() {
        logica.addScore();
    }
}
