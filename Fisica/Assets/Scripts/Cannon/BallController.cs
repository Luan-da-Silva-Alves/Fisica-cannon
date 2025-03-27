using UnityEngine;

public class BallController : MonoBehaviour
{
    public WinCondition winCondition;
    public GameObject explosionEffect;
    public float radius = 5f;
    public float explositionForce = 700f;


    private void Start()
    {
        winCondition = GameObject.Find("Cannon").GetComponent<WinCondition>();
        Destroy(gameObject, 3f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);

        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider nearbyObjectCollider  in colliders) { 
        
          Rigidbody rigidbody = nearbyObjectCollider.GetComponent<Rigidbody>();

            if (rigidbody != null)
            {

                rigidbody.AddExplosionForce(explositionForce, transform.position,radius, explositionForce);
                Destroy(explosionEffect);
            }
        
        }






        if (collision.collider.CompareTag("Alvo"))
        {
            winCondition.pontuacao++;
            Destroy(collision.gameObject);
        }
        

        Debug.Log($"Objeto {gameObject} colidiu com {collision.gameObject}");

        
    }
}
