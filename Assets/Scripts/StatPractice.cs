using UnityEngine;

public class StatPractice : MonoBehaviour
{
    public string playername;
    public int level;
    public float attack;
    public bool isBoss = true;

    [ContextMenu("스텟")]
  
    void Showstat()
    {
        Debug.Log(playername);
        Debug.Log(level);
        Debug.Log(attack);
        Debug.Log(isBoss);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
