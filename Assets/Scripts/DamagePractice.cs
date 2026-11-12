using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private int height;
    private object result;

    [ContextMenu("계단")]
    void Da()

    {
        int height = 4;
        string result = "";

       for (int row = height; row > 0; row--)

        {
            for (int i = 0; i < row ; i++)
            {
                result += "*";
            }
            result += "\n";
        }
        Debug.Log(result);
    }

}


