using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personajescript : MonoBehaviour
{
    public int Gula;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnTriggerEntere(Collider col)
    {
        Alimento alimento;
        alimento = col.GetComponent<Alimento>();

        if (alimento)
        {
            TomarAlimento(alimento.valorAlimentario);
            Destroy(col.gameObject);
        }
        TomarAlimento();
        Debug.Log(col.gameObject);
    }

    void TomarAlimento(int valorAlimentario)
    {
        Gula -= valorAlimentario;
        if ( Gula <= 0)
        {
            Gula = 0;
        }
    }
}
