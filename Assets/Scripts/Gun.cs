using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour 
{
	public Projectile bullet;
	public Transform muzzle;
	public float fireRate;
	public float bulletSpeed;

	private float nextShootTime = 0;

	void Update()
	{
		if (Input.GetMouseButton (0)) 
		{
			if (Time.time >= nextShootTime) 
			{
				Shoot ();
			}
		}	
	}

	private void Shoot()
	{
		Projectile newBullet = Instantiate (bullet, muzzle.position, muzzle.rotation) as Projectile;
		newBullet.SetSpeed (bulletSpeed);

		nextShootTime = Time.time + fireRate;
	}
}
