using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Face : MonoBehaviour, IFace
{
    public Texture2D FaceTexture
    {
        get { return face.sprite.texture; }
        set { face.sprite.texture.SetPixels(value.GetPixels()); }
    }

    public Texture2D EyesTexture
    {
        get { return eyes.sprite.texture; }
        set { eyes.sprite.texture.SetPixels(value.GetPixels()); }
    }

    public Texture2D NoseTexture
    {
        get { return nose.sprite.texture; }
        set { nose.sprite.texture.SetPixels(value.GetPixels()); }
    }

    public Texture2D MouthTexture
    {
        get { return mouth.sprite.texture; }
        set { mouth.sprite.texture.SetPixels(value.GetPixels()); }
    }

    public Texture2D HairTexture
    {
        get { return hair.sprite.texture; }
        set { hair.sprite.texture.SetPixels(value.GetPixels()); }
    }

    [SerializeField]
    private SpriteRenderer face;

    [SerializeField]
    private SpriteRenderer eyes;

    [SerializeField]
    private SpriteRenderer nose;

    [SerializeField]
    private SpriteRenderer mouth;

    [SerializeField]
    private SpriteRenderer hair;

    void Start()
    {
    }

    void Update()
    {
        
    }
}
