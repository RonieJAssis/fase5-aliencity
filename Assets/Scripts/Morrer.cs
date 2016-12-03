using UnityEngine;
using System.Collections;

public class Morrer : MonoBehaviour {

    private bool Reiniciar = false;
    public GameObject Tela2;
    public GameObject player;

    void Start()
    {
        Tela2.SetActive(false);
        player.SetActive(true);
        Reiniciar = false;

    }
  
  
    void Update () {
        if (Reiniciar == true && Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
            
            Tela2.SetActive(false);
            player.SetActive(true);
            Reiniciar = false;
        }
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || (other.gameObject.CompareTag("tiro")))
        {
            player.SetActive(false);
            Reiniciar = true;
            Tela2.SetActive(true);

        }
    }
    

}

