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

    void Start()
    {
    }

    void Update()
    {
        offsetX+= Time.deltaTime * velocidade;
        mat.mainTextureOffset = new Vector2(offsetX, 0);
    }
}