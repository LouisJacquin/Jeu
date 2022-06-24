using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private int pointDeVie;

    public Text texteVie;
    // Start is called before the first frame update
    void Start()
    {
        pointDeVie = 100;
        texteVie.text = $"Vie : {pointDeVie}";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision other)
    {
        switch(other.gameObject.tag)
        {
            case "Ennemy":
                pointDeVie -= 10;
                break;
            default:
            Debug.Log("rien");
            break;
        }
        texteVie.text = $"Vie : {pointDeVie}";
    }
}
