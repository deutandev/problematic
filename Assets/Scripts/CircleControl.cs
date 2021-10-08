using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleControl : MonoBehaviour
{
    // Variabel kecepatan lingkaran, gaya awal sumbu x, dan gaya awal sumbu y
    public float speed;
    public float initialForceX;
	public float initialForceY;
    
	private Rigidbody2D rigidbody2D;

	// Start is called before the first frame update
	void Start()
	{
        // Get komponen rigidbody2d
		rigidbody2D = GetComponent<Rigidbody2D>();
        // Gerakkan lingkaran
		PushCircle();
	}

    // fungsi untuk memberi gaya lingkaran agar bergerak
	public void PushCircle()
	{
        // nilai gaya x dan y acak
		float directionx = Random.Range(-initialForceX, initialForceX);
		float directiony = Random.Range(-initialForceY, initialForceY);
        // Normalized vektor direction agar kecepatan konstan di setiap arah
        rigidbody2D.AddForce(new Vector2(directionx, directiony).normalized * speed);
	}
}
