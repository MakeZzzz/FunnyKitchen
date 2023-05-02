using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabsTextures : MonoBehaviour
{
    public Texture[] Textures => _texturesCustomer;
    [SerializeField] private Texture[] _texturesCustomer;
}
