using System.Collections;
using UnityEngine;

public class BlocoDePedra : MonoBehaviour
{
    [SerializeField] private float velocidade = 5f;
    [SerializeField] private Vector3 posicaoInicial;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        posicaoInicial = transform.position;
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(AtivaBloco());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AtivaBloco()
    {
        rb.simulated = true;
        yield return new WaitForSeconds(2.0f);
        rb.simulated = false;
        //Move to position
        rb.MovePosition(new Vector3(posicaoInicial.x, posicaoInicial.y - 1.5f, posicaoInicial.z));
        StartCoroutine(AtivaBloco());
    }

}
