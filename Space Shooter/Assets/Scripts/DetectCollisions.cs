using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DetectCollisions : MonoBehaviour
{
	// OnTriggerEnter2D kullanmal�s�n�z, ��nk� 2D Box Collider kullan�yorsunuz.
	private void OnTriggerEnter2D(Collider2D other)
	{
		// Sadece "Bullet" etiketine sahip nesnelerle �arp��may� kontrol edelim
		
		
			// �arp��an mermiyi yok et
			Destroy(other.gameObject);

			// Kendi nesnenizi yok et
			Destroy(gameObject);
		
	}
}