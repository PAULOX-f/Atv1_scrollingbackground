using UnityEngine;

public class municao : MonoBehaviour
{

    Rigidbody2D rb;
    [SerializeField] float ySpeed;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.AddForceY(ySpeed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
