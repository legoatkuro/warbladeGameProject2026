using UnityEngine;

public abstract class Dice : MonoBehaviour
{
    protected string _name;
    protected int _sides;
    protected abstract void InitDice();

    void Awake()
    {
        InitDice();
    }

    public string getName()
    {
        return _name;
    }
        public string getSides()
    {
        return _sides;
    }
    public int Roll() 
    {
        int result = Random.Range(1, _sides + 1);
        return result;
    }
}