using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GafasOn : MonoBehaviour
{
    [SerializeField] GameObject gafas;
    [SerializeField] GameObject collar;
    // Start is called before the first frame update


    // Update is called once per frame
    void Start()
    {
        gafas.SetActive(false);
    }

    public void Gafas()
    {
        gafas.SetActive(true);
    }
    public void Collar()
    {
        collar.SetActive(true);
    }

}
