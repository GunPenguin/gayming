using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CharacterFactory : ICharacterFactory
{
    private const string pathToFaceParts = @"Assets/Sprites/FaceParts";
    public IClientCharacter CreateCop(IFace face, IDrug drug)
    {
        
        Texture2D faceTexture = new Texture2D(128, 128);
        faceTexture.LoadImage(GetRandomFaceImageDataFromDir(false, false));

        Texture2D hairTexture = new Texture2D(128, 128);
        hairTexture.LoadImage(GetRandomHairImageDataFromDir(false));

        Texture2D mouthTexture = new Texture2D(128, 128);
        mouthTexture.LoadImage(GetRandomMouthImageDataFromDir());

        Texture2D noseTexture = new Texture2D(128, 128);
        noseTexture.LoadImage(GetRandomNoseImageDataFromDir());

        Texture2D eyesTexture = new Texture2D(128, 128);
        eyesTexture.LoadImage(GetRandomEyesImageDataFromDir());

        face.FaceTexture = faceTexture;
        face.EyesTexture = eyesTexture;
        face.HairTexture = hairTexture;
        face.MouthTexture = mouthTexture;
        face.NoseTexture = noseTexture;

        IClientCharacter cop = new Cop(face, drug);

        return cop;
    }

    public IClientCharacter CreateDrugsBuyer(IFace face, IDrug drug)
    {
        int randomBool = Random.Range(0, 2);

        bool isGirl = randomBool == 1 ? true : false;
        Debug.Log(isGirl);
        randomBool = Random.Range(0, 2);

        bool isYoung = randomBool == 1 && !isGirl ? false : true;

        Texture2D faceTexture = new Texture2D(128, 128);
        faceTexture.LoadImage(GetRandomFaceImageDataFromDir(isGirl, isYoung));

        Texture2D hairTexture = new Texture2D(128, 128);
        hairTexture.LoadImage(GetRandomHairImageDataFromDir(isGirl));

        Texture2D mouthTexture = new Texture2D(128, 128);
        mouthTexture.LoadImage(GetRandomMouthImageDataFromDir());

        Texture2D noseTexture = new Texture2D(128, 128);
        noseTexture.LoadImage(GetRandomNoseImageDataFromDir());

        Texture2D eyesTexture = new Texture2D(128, 128);
        eyesTexture.LoadImage(GetRandomEyesImageDataFromDir());

        face.FaceTexture = faceTexture;
        face.EyesTexture = eyesTexture;
        face.HairTexture = hairTexture;
        face.MouthTexture = mouthTexture;
        face.NoseTexture = noseTexture;

        IClientCharacter drugBuyer = new DrugBuyer(face, drug);

        return drugBuyer;
    }

    public IClientCharacter CreateGoodsBuyer(IFace face, IProduct goods)
    {
        int randomBool = Random.Range(0, 2);

        bool isGirl = randomBool == 1 ? true : false;

        randomBool = Random.Range(0, 2);

        bool isYoung = randomBool == 1 && !isGirl ? false : true;

        Texture2D faceTexture = new Texture2D(128, 128);
        faceTexture.LoadImage(GetRandomFaceImageDataFromDir(isGirl, isYoung));

        Texture2D hairTexture = new Texture2D(128, 128);
        hairTexture.LoadImage(GetRandomHairImageDataFromDir(isGirl));

        Texture2D mouthTexture = new Texture2D(128, 128);
        mouthTexture.LoadImage(GetRandomMouthImageDataFromDir());

        Texture2D noseTexture = new Texture2D(128, 128);
        noseTexture.LoadImage(GetRandomNoseImageDataFromDir());

        Texture2D eyesTexture = new Texture2D(128, 128);
        eyesTexture.LoadImage(GetRandomEyesImageDataFromDir());

        face.FaceTexture = faceTexture;
        face.EyesTexture = eyesTexture;
        face.HairTexture = hairTexture;
        face.MouthTexture = mouthTexture;
        face.NoseTexture = noseTexture;



        IClientCharacter goodsBuyer = new GoodsBuyer(face, goods);

        return goodsBuyer;
    }

    private byte[] GetRandomFaceImageDataFromDir(bool isGirl, bool isYoung)
    {
        string path = string.Concat(pathToFaceParts, @"/Faces");
        string searchFilter = string.Empty;
        searchFilter += isGirl ? "Girl" : "Man"; 
        searchFilter += isYoung ? "Y" : "O";
        ICollection<string> filePathes = 
            Directory
            .GetFiles(path)
            .Where(p => {
                return !p.EndsWith("meta") &&
                        p.Contains(searchFilter);
            })
            .ToList();

        int randomFilePathIndex = Random.Range(0, filePathes.Count);
        var filePath = filePathes.ElementAt(randomFilePathIndex);

        Debug.Log(filePath);

        return File.ReadAllBytes(filePath);
    }

    private byte[] GetRandomHairImageDataFromDir(bool isGirl)
    {
        Debug.Log(isGirl);
        string path = string.Concat(pathToFaceParts, @"/Hairs");
        string searchFilter = string.Empty;
        searchFilter += isGirl ? "Girl" : "Man";
        Debug.Log("search: " + searchFilter);
        ICollection<string> filePathes =
            Directory
            .GetFiles(path)
            .Where(p => {
                return !p.EndsWith("meta") &&
                        p.Contains(searchFilter);
            })
            .ToList();

        int randomFilePathIndex = Random.Range(0, filePathes.Count);
        var filePath = filePathes.ElementAt(randomFilePathIndex);

        Debug.Log(filePath);

        return File.ReadAllBytes(filePath);
    }

    private byte[] GetRandomEyesImageDataFromDir()
    {
        string path = string.Concat(pathToFaceParts, @"/Eyes");
        ICollection<string> filePathes =
            Directory
            .GetFiles(path)
            .Where(p => {
                return !p.EndsWith("meta");
            })
            .ToList();

        int randomFilePathIndex = Random.Range(0, filePathes.Count);
        var filePath = filePathes.ElementAt(randomFilePathIndex);

        Debug.Log(filePath);

        return File.ReadAllBytes(filePath);
    }

    private byte[] GetRandomMouthImageDataFromDir()
    {
        string path = string.Concat(pathToFaceParts, @"/Mouthes");
        ICollection<string> filePathes =
            Directory
            .GetFiles(path)
            .Where(p => {
                return !p.EndsWith("meta");
            })
            .ToList();

        int randomFilePathIndex = Random.Range(0, filePathes.Count);
        var filePath = filePathes.ElementAt(randomFilePathIndex);

        Debug.Log(filePath);

        return File.ReadAllBytes(filePath);
    }

    private byte[] GetRandomNoseImageDataFromDir()
    {
        string path = string.Concat(pathToFaceParts, @"/Noses");
        ICollection<string> filePathes =
            Directory
            .GetFiles(path)
            .Where(p => {
                return !p.EndsWith("meta");
            })
            .ToList();

        int randomFilePathIndex = Random.Range(0, filePathes.Count);
        var filePath = filePathes.ElementAt(randomFilePathIndex);

        Debug.Log(filePath);

        return File.ReadAllBytes(filePath);
    }
}
