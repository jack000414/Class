using UnityEngine;

public class Animal {

    public string name;
    public string sound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Playsound()
    {
        Debug.Log(name + " : " + sound);
    }
}
