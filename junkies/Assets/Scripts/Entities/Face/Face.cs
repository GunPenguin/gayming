using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Face : MonoBehaviour, IFace
{
    public Texture2D FaceTexture
    {
        get { return face.sprite.texture; }
        set { face.sprite = 
                Sprite.Create(
                    value, 
                    new Rect(0, 0, value.width, value.height), 
                    new Vector2(0f, 0f));
        }
    }

    public Texture2D EyesTexture
    {
        get { return eyes.sprite.texture; }
        set { eyes.sprite =
                Sprite.Create(
                    value,
                    new Rect(0, 0, value.width, value.height),
                    new Vector2(0f, 0f));
        }
    }

    public Texture2D NoseTexture
    {
        get { return nose.sprite.texture; }
        set { nose.sprite =
                Sprite.Create(
                    value,
                    new Rect(0, 0, value.width, value.height),
                    new Vector2(0f, 0f));
        }
    }

    public Texture2D MouthTexture
    {
        get { return mouth.sprite.texture; }
        set { mouth.sprite =
                Sprite.Create(
                    value,
                    new Rect(0, 0, value.width, value.height),
                    new Vector2(0f, 0f));
        }
    }

    public Texture2D HairTexture
    {
        get { return hair.sprite.texture; }
        set { hair.sprite =
                Sprite.Create(
                    value,
                    new Rect(0, 0, value.width, value.height),
                    new Vector2(0f, 0f));
        }
    }

    //= Sprite.Create(value, new Rect(0, 0, value.width, value.height), new UnityEngine.Vector2(0f, 0f));

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
