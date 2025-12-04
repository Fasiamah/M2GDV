
using UnityEngine;

public class RandomItems : MonoBehaviour
{
    //een lijst(array) maken
    [SerializeField]
    internal string[] fish = new string[9];

    private void Start()
    {
        Debug.Log(fish[2]);
    }
    void iets()
    {
        int boon = Random.Range(0,fish.Length);

        Debug.Log(fish [boon]);
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A)) {
            iets();
        }

    }
}
