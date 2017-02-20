using UnityEngine;
using System.Collections;

public class BoatMvt : MonoBehaviour {

	// Déclaration de la variable de vitesse
	public float m_speed = 50f;

    
   

    private float RdnNum(int x,int y)
    {

        System.Random rdn = new System.Random();
        return 0.001f*rdn.Next(x,y);

    }

 


    void Update ()
         
	{

        // creation d'un nombre random pour la vitesse

        
        
        

        // Création d'un nouveau vecteur de déplacement
        Vector3 move = new Vector3();
        Vector3 rot = new Vector3();
        float v = new float();
        float r = new float();
        // Récupération des touches haut et bas

         
        
           
            v =RdnNum(0, 2);
            r= RdnNum(-1, 1);
           
            if (Input.GetKey(KeyCode.UpArrow))
            //if(0==0)
            transform.Translate(Vector3.forward * Time.deltaTime*m_speed);
            if(Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.back * Time.deltaTime*m_speed);

            // Récupération des touches gauche et droite
            if(Input.GetKey(KeyCode.LeftArrow))
				rot.y -= 1f;
            if(Input.GetKey(KeyCode.RightArrow))
            rot.y += 1f;

        
		// On applique le mouvement à l'objet
		transform.position += move;
		transform.Rotate(rot);

	}
		}
	

