using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour {
    private List<GameObject> jacks = new List<GameObject>();
    private List<JackPosition> _pluggedJacks = new List<JackPosition>();

    public void AddJackPosition(JackPosition position)
    {
        _pluggedJacks.Add(position);
    }

    public void RemoveJackPosition(JackPosition position)
    {
        _pluggedJacks.Remove(position);
    }

    public List<JackPosition> GetPluggedJacks()
    {
        return _pluggedJacks;
    }
}
