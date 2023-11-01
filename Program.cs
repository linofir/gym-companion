using GymCompanion.DataBase;
using GymCompanion.Modules;


Console.WriteLine("Bem Vindo ao Gym Companion");

Exercicios listaData = new("listaDB");
CreateDB.ConsultDB(listaData);


//listaData.ExibirExercicios();
// Filter.FilterByName(listaData, "Zercher Squats");
// Filter.FilterByID(listaData, "9db21b40-e86f-43ea-ab34-e8430bb0a637");
//Filter.FilterByNivel(listaData, "intermediate");
// Filter.FilterByCategoria(listaData, "strength");
// Filter.FilterByGrupoMuscular(listaData, "biceps");


Filter.ExibirGruposMusculares(listaData);




