using UnityEngine;

public class MovimentaçãodoPersonagem : MonoBehaviour
{
    private Rigidbody _rigidbody; 
    
    public float velocidade = 10;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Vector3 posicao = transform.position;
        
        //esquerda X-
        if (Input.GetKey(KeyCode.A))
        {
            posicao.x = posicao.x - velocidade * Time.deltaTime;
        }

        //direira  X+
        if (Input.GetKey(KeyCode.D))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime;
        }
        
        //cima  Z+
        if (Input.GetKey(KeyCode.W))
        {
            posicao.z = posicao.z + velocidade * Time.deltaTime;
        }
        
        //baixo Z-
        if (Input.GetKey(KeyCode.S))
        {
            posicao.z = posicao.z - velocidade * Time.deltaTime;
        }
        
        transform.position = posicao;
        
        

    }
}
