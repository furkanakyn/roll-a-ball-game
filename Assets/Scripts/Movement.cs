using UnityEngine;
using UnityEngine.UI;
public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    private Color colorpoint;
    private Renderer render;
    public float Fast = 2f;
    public float Slow = 0.5f;
    private int sayac;
    public Text scoreText;
    public Text gameoText;
    public int pointSayisi;
    public Movement playerMovement;
    public Image panel;

    void FixedUpdate()
    {
        
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");

        rb.AddForce(yatay * Fast * Time.deltaTime, 0, dikey * Fast * Time.deltaTime,ForceMode.VelocityChange);
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity *= Slow;
        }

    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Point")
        {
            render = other.gameObject.GetComponent<Renderer>();
            colorpoint = render.material.color;
            ColorChange.intance.ChangeColor(colorpoint);
            Destroy(other.gameObject);
            sayac++;
            scoreText.text = "Score: " + sayac;

            if (sayac == pointSayisi)
            {
                playerMovement.enabled = false;
                panel.gameObject.SetActive(true);
                gameoText.gameObject.SetActive(true);
                gameoText.color = colorpoint;

            }
            
       
    }
        if(sayac == 12)
        {
           Time.timeScale = 0;
        }







}
} 

