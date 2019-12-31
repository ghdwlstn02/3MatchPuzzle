using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    //private Tile[,] m_TilesArray = new Tile[6,6]; //6*6 2차원 Tile타입의 배열 생성
    private Dictionary<string, Tile> m_TilesDictionary = new Dictionary<string, Tile>();

    private GameObject m_TilePrefab;

    public int m_Width = 16;
    public int m_Height = 16;

    // Start is called before the first frame update
    void Start()
    {
        m_TilePrefab = Resources.Load("Prefabs/CandyPurple") as GameObject;    //프리팹 가져옴
        CreateTiles();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// 프리팹을 이용하여 새로운 타일들을 생성한다.
    /// </summary>
    private void CreateTiles()
    {
        for (int y = 0; y < m_Height; y++)
        {
            for (int x = 0; x < m_Width; x++)
            {
                //key 값 예시 : x,y or 5,2
                string key = x.ToString() + "," +  y.ToString();

                Tile tile = Instantiate<Tile>(m_TilePrefab.transform.GetComponent<Tile>()); //프리팹을 이용하여 게임오브젝트를 만들어야함
                tile.transform.SetParent(this.transform);   //타일의 부모를 Board로 설정 -> 부모 아래에 프리팹이 생성되게 함
                tile.transform.position = new Vector3(x, y, 0f);   

                m_TilesDictionary.Add(key, tile);
            }
        }
        
    }

    /// <summary>
    /// Tile 을 반환한다. 
    /// </summary>
    /// <param name="x">좌표</param>
    /// <param name="y">좌표</param>
    /// <returns>Tile</returns>
    public Tile GetTile(int x, int y)
    {
        string key = x.ToString() + "," + y.ToString();
        return m_TilesDictionary[key];
    }

    /// <summary>
    /// Tile 을 반환한다
    /// </summary>
    /// <param name="xy">좌표</param>
    /// <returns>Tile</returns>
    public Tile GetTile(string xy)
    {
        return m_TilesDictionary[xy];
    }
}
