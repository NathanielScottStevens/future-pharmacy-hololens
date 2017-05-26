using UnityEngine;
using System.Collections;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Runtime.InteropServices;
using System.Drawing;

public class egmu_cv :MonoBehaviour {
    public Texture2D texture;

    void Awake()
    {
        CascadeClassifier face = new CascadeClassifier("haarcascade_frontalface_default.xml");
        //byte[,,] rawImage = new byte[texture.height, texture.width, 1];
        //for (int i = 0; i < texture.height; i++)
        //{
        //    for (int j = 0; j < texture.width; j++)
        //    {
        //        rawImage[i, j] = texture.GetRawTextureData()[i * texture.height + j];
        //    }
        //}
        //Image<Rgb, byte> image = new Image<Rgb, byte>(rawImage);
        face.DetectMultiScale(new Image<Rgb, byte>(100, 100));
        //CvInvoke.Imread()
    }

}

