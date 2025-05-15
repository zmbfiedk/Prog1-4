using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject missilePrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private Transform dummyTarget;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject missile = Instantiate(missilePrefab, firePoint.position, firePoint.rotation);
        HomingMissel homing = missile.GetComponent<HomingMissel>();
        if (homing != null)
        {
            homing.target = dummyTarget;
        }
    }
}