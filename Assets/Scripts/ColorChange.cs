using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public static ColorChange intance;
    private Renderer ball;
    private Color originalcolor;
    public Color newColor;

    private void Awake()
    {
        intance = this;
    }
    void Start()
    {
        ball = GetComponent<Renderer>();

    }
    public void ChangeColor(Color colorball)
    {
        ball.material.color = colorball;
    }



}