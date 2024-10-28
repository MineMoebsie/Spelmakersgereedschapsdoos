using UnityEngine;

public class PijpMakerScript : MonoBehaviour
{
    public GameObject Pijp;
    public float maakTijd = 2;
    public float hoogteVerschil = 1;
    private float Tijdbijhouder;
    private LogicaScript logica;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logica = GameObject.FindGameObjectsWithTag("Logica")[0].GetComponent<LogicaScript>();
        GenereerPijp();
    }

    // Update is called once per frame
    void Update()
    {
        if (logica.GameIsOver) return; 
        if (Tijdbijhouder < maakTijd) {
            Tijdbijhouder += Time.deltaTime;
        } else {
            GenereerPijp();
            Tijdbijhouder = 0;
        }
    }

    void GenereerPijp() {
        float positieveMaximaleHoogte = transform.position.y + hoogteVerschil;
        float negatieveMaximaleHoogte = transform.position.y - hoogteVerschil;
        Instantiate(Pijp, new Vector3(transform.position.x, Random.Range(negatieveMaximaleHoogte, positieveMaximaleHoogte), transform.position.z), transform.rotation);
    }
}
