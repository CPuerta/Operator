using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour {
    public Jack[,] jacks;
    private List<JackPosition> _pluggedJacks = new List<JackPosition>();
    
    //public static Board b = new Board(8,4);
    //private void Awake()
    //{
    //    if (b == null)
    //    {
    //        b = this;
    //    }
    //    else if(b!=null && b != this)
    //    {
    //        Destroy(this);
    //    }
    //}
    //private void OnDestroy()
    //{
    //    if (b == this)
    //    {
    //        Destroy(this);
    //    }
    //}

    public void AddJack(Jack j)
    {
        jacks[j._jackPosition.X,j._jackPosition.Y] = j;
    }
    public Jack GetJack(int x, int y)
    {
        return jacks[x, y];
    }
    //public void AddJackPosition(JackPosition position)
    //{
    //    _pluggedJacks.Add(position);
    //}

    //public void RemoveJackPosition(JackPosition position)
    //{
    //    _pluggedJacks.Remove(position);
    //}

    //public List<JackPosition> GetPluggedJacks()
    //{
    //    return _pluggedJacks;
    //}
}
