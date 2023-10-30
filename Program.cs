using GymCompanion.Modules;

Console.WriteLine("Bem Vindo ao Gym Companion");

Exercicio novoExercicio = new("crucifixo", "peito");
Exercicio novoExercicio2 = new("legpress", "pernas");
Exercicio novoExercicio3 = new("remada", "costas");

Serie tipoSerie = new(4,20,"ativo");
Serie tipoSerie2 = new(4,20);
Serie tipoSerie3 = new(3,20,"ativo");

TreinoExercicio novotreino = new(novoExercicio, tipoSerie);
TreinoExercicio novotreino2 = new(novoExercicio2, tipoSerie2);
TreinoExercicio novotreino3 = new(novoExercicio3, tipoSerie2);

Exercicios todosExercicios = new("geral");

todosExercicios.AddExercicio(novotreino);
todosExercicios.AddExercicio(novotreino2);
todosExercicios.AddExercicio(novotreino3);

todosExercicios.ExibirExercicios();

todosExercicios.RemoveExercicio(novotreino3);

todosExercicios.ExibirExercicios();

