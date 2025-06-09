using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtingObjects : MonoBehaviour
{
    public int damagePoints;
    private HealthManager healthManager;
    // Start is called before the first frame update
    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            healthManager.UpdateHealth(-damagePoints);
        }
    }
}
