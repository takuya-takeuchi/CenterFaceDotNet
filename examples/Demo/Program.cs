using System;
using System.Linq;
using NcnnDotNet.OpenCV;
using CenterFaceDotNet;

namespace Demo
{

    internal class Program
    {

        #region Methods

        private static int Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine(" .exe mode_path image_file");
                return -1;
            }

            var binPath = args[0];
            var paramPath = args[1];

            var param = new CenterFaceParameter
            {
                BinFilePath = binPath,
                ParamFilePath = paramPath
            };

            using(var centerFace = CenterFace.Create(param))
            {
                var imageFile = args[2];
                Console.WriteLine($"Processing {imageFile}");

                using var image = Cv2.ImRead(imageFile);
                using var inMat = NcnnDotNet.Mat.FromPixels(image.Data, NcnnDotNet.PixelType.Bgr2Rgb, image.Cols, image.Rows);

                var faceInfos = centerFace.Detect(inMat, image.Cols, image.Rows).ToArray();
                for (var i = 0; i < faceInfos.Length; i++)
                {
                    var face = faceInfos[i];
                    var pt1 = new Point<float>(face.X1, face.Y1);
                    var pt2 = new Point<float>(face.X2, face.Y2);
                    Cv2.Rectangle(image, pt1, pt2, new Scalar<double>(0, 255, 0), 2);
                    for (var j = 0; j < 5; j++)
                    {
                        var center = new Point<float>(face.Landmarks[2 * j], face.Landmarks[2 * j + 1]);
                        Cv2.Circle(image, center, 2, new Scalar<double>(255, 255, 0), 2);
                    }
                }

                Cv2.ImShow("Test", image);
                Cv2.WaitKey();
            }

            return 0;
        }

        #endregion

    }

}
