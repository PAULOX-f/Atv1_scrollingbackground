using UnityEngine;
using UnityEngine.InputSystem;

public class nave : MonoBehaviour
{
    Rigidbody2D rb;
    float _xDir;
    [SerializeField] GameObject municaoPrefab;

    [SerializeField] float xSpeed;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Movimentar();
    }

    void Movimentar()
    {
        //Aplicar o movimento no corpo rígido
        rb.linearVelocityX = _xDir * xSpeed;
        
    }

    // Chamado pelo sistema de Input do Unity quando o jogador move o controle ou teclado
    void OnMove(InputValue inputValue)
    {
        //Direção do movimento do jogador no eixo X
        _xDir = inputValue.Get<Vector2>().x;
    }

    void OnAttack()
    {
        //Instanciar a munição na posição da nave
        Instantiate(municaoPrefab, transform.position, Quaternion.identity);
    }
}
