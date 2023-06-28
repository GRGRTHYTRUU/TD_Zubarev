
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletSpeed = 10f; 
    public float cooldownTime = 3f; 

    private float cooldownTimer = 0f; 

    private void Update()
    {
       
        cooldownTimer -= Time.deltaTime;

        
        if (cooldownTimer <= 0f)
        {
            Shoot();
           
            cooldownTimer = cooldownTime;
        }
    }

    void Shoot()
    {
        
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        
        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.up * bulletSpeed;

        
        Destroy(bullet, 2f);
    }
}