namespace GymCompanion.DataBase;
using System.Text.Json;
using System.IO;
using GymCompanion.Modules;

class CreateDB 
{
    public static async void ExtractData(Exercicios listaDB )
    {
        //List<Exercicio> lista = new();
        try{
            //
            string basePath = "C:/Users/lino/Projetos_Programação/exercises.json/exercises/";
            if(Directory.Exists(basePath))
            {
                //IEnumerable<string> test = Directory.EnumerateDirectories(basePath);
                foreach(string exercicioJSON in Directory.GetDirectories(basePath))
                {
                    string images = Path.Combine(exercicioJSON, "images\\");
                    List<string> imagesPaths = new();
                    //Console.WriteLine(images);
                    if(Directory.Exists(images))
                    {
                        foreach (string image in Directory.GetFiles(images))
                        {
                            imagesPaths.Add(image);
                            //Console.WriteLine(image);
                        }
                    }
                    string exercicioPath = Path.Combine(exercicioJSON, "exercise.json");
                    //Console.WriteLine($"{exercicioPath}");
                    if(File.Exists(exercicioPath))
                    {
                        string content = File.ReadAllText(exercicioPath);
                        var exercicio = JsonSerializer.Deserialize<Exercicio>(content);
                        //lista.Add(exercicio);
                        listaDB.AddExercicio(exercicio!);
                        listaDB.AddImagesPath(imagesPaths, exercicio!);
                    }   
                }
            }

        }
        catch(Exception ex)
        {
            Console.WriteLine($"Existe um erro: {ex.Message}");

        }

    } 
}