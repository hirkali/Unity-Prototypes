using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DetectCollisions : MonoBehaviour
{
	// OnTriggerEnter2D kullanmalýsýnýz, çünkü 2D Box Collider kullanýyorsunuz.
	private void OnTriggerEnter2D(Collider2D other)
	{
		// Sadece "Bullet" etiketine sahip nesnelerle çarpýþmayý kontrol edelim
		
		
			// Çarpýþan mermiyi yok et
			Destroy(other.gameObject);

			// Kendi nesnenizi yok et
			Destroy(gameObject);
		
	}
}