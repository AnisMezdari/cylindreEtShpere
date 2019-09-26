using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate : MonoBehaviour
{
	public GameObject triangle;
	public int largeur;
	public int hauteur;
	
    // Start is called before the first frame update
    void Start()
    {
    	for(int i =0;i< largeur; i++){
    		for(int j =0;j< largeur; j++){
    			triangle = Instantiate(triangle);
    			triangle.name = "triangle" + i + "_" + j;
    			Triangle triangleScript = triangle.GetComponent<Triangle>();
    			triangleScript.setSommet(i, j, i+1, j, i+1, j+1);
    			triangleScript.createTriangle();
    			
    			triangle = Instantiate(triangle);
    			triangle.name = "triangle Superpose" + i + "_" + j;
    			Triangle triangleScript2 = triangle.GetComponent<Triangle>();
    			triangleScript2.setSommet(i, j, i, j+1, i+1, j+1);
    			triangleScript2.createTriangle();
    			
    		}
    	}
    	
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
