using GymCompanion.DataBase;
using GymCompanion.Modules;


Console.WriteLine("Bem Vindo ao Gym Companion");

Exercicios listaData = new("listaDB");
CreateDB.ConsultDB(listaData);


//listaData.ExibirExercicios();
// Filter.FilterByName(listaData, "Zercher Squats");
// Filter.FilterByID(listaData, "9db21b40-e86f-43ea-ab34-e8430bb0a637");
// Filter.FilterByCategoria(listaData, "strength");
// Filter.ExibirGruposMusculares(listaData);

var listaFiltradaMusc = Filter.FilterByGrupoMuscular(listaData, Musculos.Biceps);

//var listaFiltradaCategoria = Filter.FilterByCategoria(listaFiltradaMusc, "strength");

//var listaFiltradaEquip = Filter.FilterByGrupoEquip(listaFiltradaMusc, "machine");

//var listaFiltradaNivel = Filter.FilterByNivel(listaFiltradaEquip, "beginner");

//Filter.FilterByName(listaFiltradaMusc,"Hip");


List<string> treinoTriceps = new(){"Standing One-Arm Dumbbell Triceps Extension", "Dip Machine"};
List<string> treinoTricepsId = new(){"3551cc89-1417-4160-b89e-edf1fbac78d0", "ab7c67c4-2dff-4046-bc2c-15946af9fb20"};

List<string> treinoPeito = new(){"Barbell Bench Press - Medium Grip", "Barbell Incline Bench Press - Medium Grip", "Straight-Arm Dumbbell Pullover", "Butterfly"}; 
List<string> treinoPeitoId = new(){"766364a8-b555-4d21-9766-2f0a85a08e71", "4c25fa61-84a2-4f05-a07d-a70aaba61f0b", "1d807b2e-ab35-4aff-b5f2-048ed4140e35", "7a987c80-08b7-4051-8e3d-d9bf45cc7696"};

List<string> treinoAbs = new(){"Sit-Up", "Plank", "Oblique Crunches - On The Floor","Knee/Hip Raise On Parallel Bars"};
List<string> treinoAbsId = new(){"67487e95-3db4-4ab0-9126-51f9337d6786", "340a26b5-a644-4496-99ff-262f82d1b03f","272027ea-7f52-46be-b3ac-9eccfa5c8e4d", "9ef17b2a-b798-4881-af7a-4fac94e2f95a"};




