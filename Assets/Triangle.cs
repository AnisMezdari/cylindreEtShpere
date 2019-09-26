using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    public Material mat;
    
    public int sommet1X;
    public int sommet1Y;
    
    public int sommet2X;
    public int sommet2Y;
    
    public int sommet3X;
    public int sommet3Y;
    
    // Use this for initialization
    void Start()
    {
    	//setSommet(0,0,1,0,1,1);
    	//createTriangle();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    public void setSommet(int sommet1X, int sommet1Y, int sommet2X, int sommet2Y, int sommet3X, int sommet3Y){
    	this.sommet1X = sommet1X;
    	this.sommet1Y = sommet1Y;
    	this.sommet2X = sommet2X;
    	this.sommet2Y = sommet2Y;
    	this.sommet3X = sommet3X;
    	this.sommet3Y = sommet3Y;
    	
    	
    }
    
    public void createTriangle(){
    
       gameObject.AddComponent<MeshFilter>();          // Creation d'un composant MeshFilter qui peut ensuite être visualisé
       gameObject.AddComponent<MeshRenderer>();
       
       	Vector3[] vertices = new Vector3[3];            // Création des structures de données qui accueilleront sommets et  triangles
        int[] triangles = new int[3];

        vertices[0] = new Vector3(sommet1X, sommet1Y, 0);            // Remplissage de la structure sommet 
        vertices[1] = new Vector3(sommet2X, sommet2Y, 0);
        vertices[2] = new Vector3(sommet3X, sommet3Y, 0);

        triangles[0] = 0;                               // Remplissage de la structure triangle. Les sommets sont représentés par leurs indices
        triangles[1] = 1;                               // les triangles sont représentés par trois indices (et sont mis bout à bout)
        triangles[2] = 2;

        Mesh msh = new Mesh();                          // Création et remplissage du Mesh

        msh.vertices = vertices;
        msh.triangles = triangles;

        gameObject.GetComponent<MeshFilter>().mesh = msh;           // Remplissage du Mesh et ajout du matériel
        gameObject.GetComponent<MeshRenderer>().material = mat;
    }
    
}
