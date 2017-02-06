using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Morte : MonoBehaviour
{
    public int Vida = 100 ;

    public GameObject Tela2;
    public GameObject player;
    private bool Reiniciar = false;
    public Slider vidabarra;
    public long vibra;





    void Start()
    {
        Tela2.SetActive(false);
        Reiniciar = false;
        player.SetActive(true);
        
        
        

        
        Vida = 100;



    }

    // Update is called once per frame
    void Update()
         
    {
        vidabarra.value = Vida;

        if (Reiniciar == true && Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);

            Tela2.SetActive(false);
            player.SetActive(true);
            Reiniciar = false;
        }

        if (Vida <= 0)
        {
            player.SetActive(false);
            Reiniciar = true;
            Tela2.SetActive(true);
        }


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Morte"))
        {
            Vida -= 50;
            Vibration.Vibrate(vibra);
            
        }
        if (other.gameObject.CompareTag("Morte2"))
        {
            Vida -= 25;
            Vibration.Vibrate(vibra);




        }
        if (other.gameObject.CompareTag("Morte3"))
        {
            Vida -= 100;
            Vibration.Vibrate(vibra);



        }
        if (other.gameObject.CompareTag("Vida")&& Vida<100)
        {
            Vida = 100;
           
            other.gameObject.SetActive(false);

        }
    }
}

