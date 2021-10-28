using System;
using System.Collections.Generic;
using System.Globalization;

namespace exemplolistas_29_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //crando uma variavel char para comparar no final
            string letra = "A";
            char letrinha = char.Parse(letra);
            //Criando o array com strings
            List<string> list = new List<string>();
            //Adicionando os nomes no array
            list.Add("Fábio"); list.Add("Wilson"); list.Add("Angelina"); list.Add("Eliney"); list.Add("Andre");
            //Adiciona um nome em uma posição especifica
            list.Insert(2, "Lucas");
            //Realizando um loop de leitura dos nomes inseridos
            foreach (string obj in list) {
                //Conto quantos elementos tem na minha lista
                Console.WriteLine("Qnt de elementos na Lista: " +list.Count);
                //Encontrar o elemento que inicia com a letra A com uma função lambda
                string s1 = list.Find(x => x[0] == letrinha);
                Console.WriteLine("Primeiro elemento que começa com a letra A: " +s1);
            }
}

}
}
