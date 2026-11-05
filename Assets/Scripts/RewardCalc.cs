using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725, gold = 1234, members = 4, kills = 7, expPerKill = 35, totalDamage = 250, hits = 20;

    public float expRate = 1.5f;

   
    void Play()
    {
        int h = playSeconds / 3600;
        int m  = playSeconds  % 3600 / 60;
        int s = playSeconds / 60;
        Debug.Log ("플레이 시간" +  h + ":" +  m / 10 + m % 10 + ":" + s / 10 + s % 10 );

        int share = gold / members;
        int bouns = members % gold;
        Debug.Log("1인당" +  bouns + "G" + "리더보너스" +bouns + "G");

        int baseExp = kills * expPerKill;
        int finalExp = (int) (baseExp  * expRate);
        Debug.Log("경험치" + finalExp + "(기본" + baseExp + ")");

        int level = finalExp / 100 + 1;
        int toNext = (int) (level * expRate);

    }




}
