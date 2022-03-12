using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Parce : MonoBehaviour
{
    public List<Spawn> spawnList = new List<Spawn>();


    SpawnPoints spawnPoints => SystemManager.Instance.SpawnPoints;


    void Awake()
    {
        ReadSpawnFile();

    }

    void Start()
    {
        spawnPoints.StartCoroutine(spawnPoints.SpawnEnemy(spawnList));
        Debug.Log("��");
    }

    void Update()
    {
    }

    void ReadSpawnFile()
    {
        
        spawnList.Clear();

        //TextAsset : �ؽ�Ʈ ���� ���� Ŭ����
        TextAsset textFile = Resources.Load("Stage1") as TextAsset;
        //StringReader : ���� ���� ���ڿ� ������ �б� Ŭ����
        StringReader stringReader = new StringReader(textFile.text);

        while(stringReader != null)
        {
            //ReadLine() = �ؽ�Ʈ �����͸� �� �� �� ��ȯ
            string line = stringReader.ReadLine();
            Debug.Log(line);

            if (line == null)
                break;

            Spawn spawnData = new Spawn();

            spawnData.type = line.Split(',')[0];
            spawnData.point = int.Parse(line.Split(',')[1]);
            spawnData.delay = float.Parse(line.Split(',')[2]);

            spawnList.Add(spawnData);

        }


        //stringReader�� ����� ������ �۾� �� �� �ݱ�
        stringReader.Close();

    }
}
