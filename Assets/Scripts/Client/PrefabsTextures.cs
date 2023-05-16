using UnityEngine;

namespace Client
{
    public class PrefabsTextures : MonoBehaviour
    {
        public Texture[] Textures => _texturesCustomer;
        [SerializeField] private Texture[] _texturesCustomer;
    }
}