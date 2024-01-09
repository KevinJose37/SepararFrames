# Proyecto de Extracción de Frames de Video con OpenCV y Emgu.CV en .NET

## Librerías Utilizadas:
- **Emgu.CV:** Biblioteca de visión por computadora basada en OpenCV para .NET.

## Paquetes Nuget instalados:
- **Emgu.CV** versión 4.8.1.5350
- **Emgu.CV.runtime.windows** versión 4.8.1.5350

## Primera parte de la prueba:

En primer lugar, es necesario que crees un programa en .NET, con C# de consola para leer con OpenCV un video de 10 segundos y transformar ese video en imágenes (Frames) y que se guarde en una carpeta a parte.

## Funcionamiento de la solución

En el método Main, se definen las rutas del video y la carpeta de imágenes, y se llama al método ExtraerFrames para iniciar el proceso de extracción de frames. En este caso por simplicidad, usé la URL en el mismo código, y no un archivo de configuración con los argumentos de las rutas, esto puede ser un aspecto a mejorar si se desea continuar trabajando con el código.

En el método ExtraerFrames, se utiliza la clase VideoCapture de Emgu.CV para abrir el video especificado. Luego, se obtiene la tasa de frames por segundo, después de esto se itera a través de los frames del video. Cada frame se guarda como una imagen en la carpeta especificada y se muestra un mensaje en la consola. El bucle se detiene cuando no hay más frames o se alcanza el límite de tiempo especificado.
