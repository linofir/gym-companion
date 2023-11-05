namespace GymCompanion.DataBase;
using System.Text.Json;
using System.IO;
using GymCompanion.Modules;

class CreateDB 
{
    //é preciso mudar os valores das propriedades de acordo com o JSON.
    public static void ExtractData(Exercicios listaDB )
    {
        try{
            
            string basePath = "C:/Users/lino/Projetos_Programação/exercises.json/exercises/";
            string destinationBasePath = "C:/Users/lino/Projetos_Programação/gym-companion/assats/exercisesDB/";
            if(Directory.Exists(basePath))
            {
                foreach(string exercicioFolder in Directory.GetDirectories(basePath))
                {
                    string folderName = Path.GetFileNameWithoutExtension(exercicioFolder)!;
                    string folderDesinationPath = Path.Combine(destinationBasePath, $"{folderName}");
                    Directory.CreateDirectory(Path.GetDirectoryName(folderDesinationPath)!);

                    string imageDesinationPath = Path.Combine(folderDesinationPath, "images\\");
                    Directory.CreateDirectory(Path.GetDirectoryName(imageDesinationPath)!);


                    string images = Path.Combine(exercicioFolder, "images\\");
                    List<string> imagesPaths = new();
                    if(Directory.Exists(images))
                    {
                        foreach (string image in Directory.GetFiles(images))
                        {
                            string imageFileName = Path.GetFileName(image);
                            string imageFullDesinationPath = Path.Combine(imageDesinationPath, imageFileName);

                            File.Copy(image, imageFullDesinationPath, true);
                            imagesPaths.Add(imageFullDesinationPath);
                        }
                    }


                    string exercicioPath = Path.Combine(exercicioFolder, "exercise.json");
                    if(File.Exists(exercicioPath))
                    {
                        string content = File.ReadAllText(exercicioPath);
                        var exercicio = JsonSerializer.Deserialize<Exercicio>(content);

                        listaDB.AddExercicio(exercicio!);
                        listaDB.AddImagesPath(imagesPaths, exercicio!);
                        listaDB.CreateJSON(exercicio!, folderDesinationPath ); 
                    }   
                }
            }

        }
        catch(Exception ex)
        {
            Console.WriteLine($"Existe um erro: {ex.Message}");

        }

    } 

    public static void ConsultDB(Exercicios listaDB )
    {
        try{
            
            string basePath = "C:/Users/lino/Projetos_Programação/gym-companion/assats/exercisesDB/";
            if(Directory.Exists(basePath))
            {
                foreach(string exercicioFolder in Directory.GetDirectories(basePath))
                {
                    // string folderName = Path.GetFileNameWithoutExtension(exercicioFolder)!;
                    // string folderDesinationPath = Path.Combine(destinationBasePath, $"{folderName}");
                    // Directory.CreateDirectory(Path.GetDirectoryName(folderDesinationPath)!);

                    //string imageDesinationPath = Path.Combine(folderDesinationPath, "images\\");
                    //Directory.CreateDirectory(Path.GetDirectoryName(imageDesinationPath)!);


                    string images = Path.Combine(exercicioFolder, "images\\");
                    List<string> imagesPaths = new();
                    if(Directory.Exists(images))
                    {
                        foreach (string image in Directory.GetFiles(images))
                        {
                            //string imageFileName = Path.GetFileName(image);
                            //string imageFullDesinationPath = Path.Combine(imageDesinationPath, imageFileName);

                            //File.Copy(image, imageFullDesinationPath, true);
                            imagesPaths.Add(image);
                        }
                    }


                    string exercicioPath = Path.Combine(exercicioFolder, "exercicio.json");
                    if(File.Exists(exercicioPath))
                    {
                        string content = File.ReadAllText(exercicioPath);
                        var exercicio = JsonSerializer.Deserialize<Exercicio>(content);

                        listaDB.AddExercicio(exercicio!);
                        listaDB.AddImagesPath(imagesPaths, exercicio!);
                        //listaDB.CreateJSON(exercicio!, folderDesinationPath ); 
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