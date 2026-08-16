using UnityEngine;

public class scrollbackground : MonoBehaviour
{
    Material mat;
    [SerializeField] float velocidade;
    float offsetX;


    void Awake()
    {
         mat = GetComponent<SpriteRenderer>().material;

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        offsetX+= Time.deltaTime * velocidade;
        mat.mainTextureOffset = new Vector2(offsetX, 0);
    }
}
