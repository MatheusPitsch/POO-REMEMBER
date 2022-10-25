using PraticandoPoo.Person;
using PraticandoPoo.Student;

#region Alunos
/*
Crie 3 alunos que possuem nome, nota1,nota2,nota3 e uma função que retorna a média.
Peça para o usuario preencher o nome, nota1, nota2 e nota3 deste aluno, em seguida, diga a
média do aluno e se passou (para passar basta ter uma média > 7)

Student pedro = new Student("Pedro", 7.9, 10, 0.2);
Student jose = new Student("José", 8.0, 5.7, 9);
Student ricardo = new Student("Pedro", 5.5, 2.2, 9.2);

Console.WriteLine(pedro.GrabMedia());
Console.WriteLine(jose.GrabMedia());
Console.WriteLine(ricardo.GrabMedia());
*/
#endregion

#region Estacionamento
/*Crie 10 pessoas com nome, idade e uma função que retorna verdadeiro caso a pessoa
seja adulta. Peça para o usuário preencher todas as pessoas, em seguida, mostre em ordem
do mais velho para o mais novo apenas aqueles que são adultos
ps: deve - se usar o retorno da função para avalaiar se é adulto ou não*/

List<string> personName = new List<string>();
List<byte> personAge = new List<byte>();


for (int i = 0; i < 2; i++)
{
    Person person = new Person();
    Console.WriteLine("Digite o nome:");
    person.Name = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("Digite a idade:");
    person.Age = Convert.ToByte(Console.ReadLine());
    Console.Clear();

    if (person.Adulthood())
    {
        personName.Add(person.Name);
        personAge.Add(person.Age);
    }
}

foreach (var item in personName)
{
    Console.WriteLine(item);
    foreach (var age in personAge)
    {
        Console.WriteLine(age);
    }
}

#endregion

Console.ReadLine();
