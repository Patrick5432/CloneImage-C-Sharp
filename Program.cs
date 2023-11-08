// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        string imagePath = "./testimg/cat-animals-pet-kitten.jpeg";
        byte[] imageBytes = System.IO.File.ReadAllBytes(imagePath);
        Console.WriteLine("Размер массива байтов изображения: " + imageBytes.Length);
        string path = "./cloneImg/clone.jpeg";
        File.WriteAllBytes(path, imageBytes);
        Console.WriteLine("Файл успешно скопирован");
    }
}