using UnityEditorInternal;
using UnityEngine;

public class PijpBeweegScriptje : MonoBehaviour
{
    public float beweegSnelheid = 5;
    
    private LogicaScript logica;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        logica = GameObject.FindGameObjectsWithTag("Logica")[0].GetComponent<LogicaScript>();
    }
    private void FixedUpdate() {
        if (logica.GameIsOver) return;
        transform.position = transform.position + (Vector3.left * beweegSnelheid);
        if (transform.position.x < -13) {
            Destroy(gameObject);
        }
    }
}

