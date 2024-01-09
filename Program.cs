using System;
using System.Configuration;
using System.IO;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

class Program
{
    static void Main()
    {
        //Definimos las rutas donde se encuentra el video y se guardarán los frames.
        string rutaVideo = "C:/Users/USER/Downloads/Video/video.mp4";
        string carpetaImagenes = "C:/Users/USER/Downloads/Frames";

        //Llama al método para extraer frames del video
        ExtraerFrames(rutaVideo, carpetaImagenes);
    }

    static void ExtraerFrames(string rutaVideo, string carpetaImagenes)
    {
        //Abrimos el video
        using (VideoCapture capture = new VideoCapture(rutaVideo))
        {
            //Obtenemos el frameRate/fps del video 
            int frameRate = (int)capture.Get(CapProp.Fps);
            // Calcula el número total de frames que se extraerán (10 segundos de video)

            int FrameCount = 10 * frameRate; // 10 segundos

            int frameActual = 0;

            while (frameActual < FrameCount)
            {
                Mat frame = new Mat();
                capture.Read(frame);

                // Si no hay más frames o si ya alcanzamos el límite, rompemos el ciclo.
                if (frame.IsEmpty || frameActual >= FrameCount)
                    break;

                // Construye la ruta de salida para guardar la imagen
                string nombreArchivo = $"frame_{frameActual}.png";
                Console.WriteLine("Se guardó el frame " + frameActual);
                string rutaSalida = Path.Combine(carpetaImagenes, nombreArchivo);

                // Guarda el frame como una imagen en la carpeta especificada
                CvInvoke.Imwrite(rutaSalida, frame);


                // Incrementa el índice del frame actual
                frameActual++;
            }
        }

    }

}
