using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
   private void OnCollisionEnter(Collision collision)
   {
       Debug.Log("Collision detected with: " + collision.gameObject.name);
       if (collision.gameObject.CompareTag("Coin"))
       {
           Destroy(collision.gameObject);
       }
   }
    private void OnTriggerEnter(Collider other)
   {
       Debug.Log(other.gameObject.name);
       if (other.gameObject.tag == "Coin")
       {
           Destroy(other.gameObject);
       }
   }
}
