using UnityEngine;

public interface IFace {
    Texture2D FaceTexture { get; set; }
    Texture2D HairTexture { get; set; }
    Texture2D NoseTexture { get; set; }
    Texture2D MouthTexture { get; set; }
    Texture2D EyesTexture { get; set; }
}