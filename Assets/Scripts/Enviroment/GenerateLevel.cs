using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public PlayerMove player;
    public GameObject[] section;
    public GameObject[] Wall;
    public GameObject[] Stuff;
    public GameObject Book;
    public int zPos = 250;
    public int zWall = 30;
    public int zStuff = 15;
    public int zBook = 50;
    public bool creatingSection = false;
    public bool creatingStuff = false;
    public bool creatingWall = false;
    public bool creatingBook = false;
    public bool creatingCoin = false;
    public int secNum;
    public int wallNum;
    public int stuffNum;
    public int bookNum;
    public float GenerateTime;

    void Update()
    {
        GenerateTime = player.moveSpeed;
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
        if(creatingWall == false)
        {
            creatingWall = true;
            StartCoroutine(GenerateWall());
        }
        if(creatingStuff == false)
        {
            creatingStuff = true;
            StartCoroutine(GenerateStuff());
        }
        if (creatingCoin == false)
        {
            creatingCoin = true;
            StartCoroutine(GenerateCoin());
        }
        if (creatingBook == false)
        {
            creatingBook = true;
            StartCoroutine(GenerateBook());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0,2); // ถ้าจะเพิ่มลักษระแมพต้องใส่ Random.Range(ระหว่าง,ระหว่าง);
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds((8/GenerateTime)*5f);
        creatingSection = false;
    }

    IEnumerator GenerateWall()
    {
        wallNum = Random.Range(0, 3);
        Instantiate(Wall[0], new Vector3(Random.Range(-3.8f, 3.8f), 0.35f, zWall), Quaternion.identity);
        Instantiate(Wall[1], new Vector3(Random.Range(-3.8f, 3.8f), 0.35f, zWall + 6), Quaternion.identity);
        Instantiate(Wall[2], new Vector3(Random.Range(-3.8f, 3.8f), 0.5f, zWall + 3), Quaternion.identity );
        Instantiate(Wall[Random.Range(0, 1)], new Vector3(Random.Range(-3.8f, 3.8f), 0.35f, zWall + Random.Range(3f, 6f)), Quaternion.identity);
        zWall += 10;
        yield return new WaitForSeconds((1.5f / GenerateTime) * 5f);
        creatingWall = false;
    }

    IEnumerator GenerateStuff()
    {
        stuffNum = Random.Range(0, 3);
        Instantiate(Stuff[Random.Range(1, 4)], new Vector3(Random.Range(-3.5f, 3.5f), 1.5f, zStuff + 40 ), Quaternion.identity);
        //Instantiate(Stuff[2], new Vector3(Random.Range(-3.5f, 3.5f), 1.5f, zStuff + 50 ), Quaternion.identity);
        //Instantiate(Stuff[3], new Vector3(Random.Range(-3.5f, 3.5f), 1.5f, zStuff + 25 ), Quaternion.identity);
        //Instantiate(Stuff[4], new Vector3(Random.Range(-3.5f, 3.5f), 1.5f, zStuff + +70), Quaternion.identity);
        //8
        zStuff += 20;
        yield return new WaitForSeconds((5f / GenerateTime) * 5f);
        creatingStuff = false;
    }
    IEnumerator GenerateCoin()
    {
        Instantiate(Stuff[0], new Vector3(Random.Range(-3.5f, 3.5f), 1.5f, zStuff), Quaternion.identity);
        Instantiate(Stuff[0], new Vector3(Random.Range(-3.5f, 3.5f), 1.5f, zStuff + 5), Quaternion.identity);
        Instantiate(Stuff[0], new Vector3(Random.Range(-3.5f, 3.5f), 3.5f, zStuff + 10), Quaternion.identity);
        Instantiate(Stuff[0], new Vector3(Random.Range(-3.5f, 3.5f), 3.5f, zStuff + 15), Quaternion.identity);
        //Instantiate(Stuff[2], new Vector3(Random.Range(-3.5f, 3.5f), 1.5f, zStuff + 50 ), Quaternion.identity);
        //Instantiate(Stuff[3], new Vector3(Random.Range(-3.5f, 3.5f), 1.5f, zStuff + 25 ), Quaternion.identity);
        //Instantiate(Stuff[4], new Vector3(Random.Range(-3.5f, 3.5f), 1.5f, zStuff + +70), Quaternion.identity);
        zStuff += 20;
        yield return new WaitForSeconds((3.0f / GenerateTime) * 5f);
        creatingCoin = false;
    }

    IEnumerator GenerateBook()
    {
        Instantiate(Book, new Vector3(Random.Range(-3.5f, 3.5f), 1.5f, zBook), Quaternion.identity);
        zBook += 250;
        yield return new WaitForSeconds((25f / GenerateTime) * 5f);
        creatingBook = false;
    }
}
