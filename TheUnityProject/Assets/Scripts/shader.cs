using UnityEngine;

public class shader : MonoBehaviour
{
    public Texture Shader, Normal, Metal;

    public Renderer Renderer;
    // Start is called before the first frame update
    void Start()
    {
        Renderer = GetComponent<Renderer>();
        Renderer.material.SetTexture("ShaderTexture", Shader);
        Renderer.material.SetTexture("Normal", Normal);
        Renderer.material.SetTexture("Metal", Metal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
