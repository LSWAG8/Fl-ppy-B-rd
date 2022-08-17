using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarSpawner : MonoBehaviour
{


    public Camera Camera;
    public GameObject PillarPrefab;
    
    private float nextSpawnTime;
    public float spawnCD = 4f;
    public float speed = 1f;
    public float spawndiscmax = 2f;
    
    

    private void Start()
    {
        DetermineNextSpawnTime();
    }

    private void Update()
    {
        if(Time.time > nextSpawnTime)
        {
            SpawnPillar();
            DetermineNextSpawnTime();
        }
    }

    private void DetermineNextSpawnTime()
    {
        nextSpawnTime = Time.time + spawnCD;
    }


    public void SpawnPillar()
    {
        //Pillar erstellen (in mitte)
        var pillar = Instantiate(PillarPrefab, transform);
        

        //Hälfte der Camerabreite
        var halfWidth = Camera.orthographicSize * Camera.aspect;

        //Höhe Randomizen
        float rdmheight = Random.Range(-spawndiscmax, spawndiscmax);
        //Entfernung von mitte
        var position = new Vector3(halfWidth + 1, rdmheight, 0);
        
        //Pillar an Rand verschieben
        pillar.transform.position = position;
        
        //Pillar nach links schubsen
        var rb = pillar.GetComponent<Rigidbody2D>();
        var direction = new Vector2(-1, 0);

        rb.AddForce(direction * speed, ForceMode2D.Impulse);

        
    


    }
}
