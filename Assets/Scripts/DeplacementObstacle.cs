using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float vitesse = 0.03f;
    public float limiteHaut = 10f;
    public float limiteBas = -10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, vitesse, 0);
        if (transform.position.y > limiteHaut) 
        {

            transform.position = new Vector2(transform.position.x, limiteBas);
        }
    }
}
