using System;
using System.Collections.Generic;
using System.Globalization;

namespace exemplolistas_29_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra = "A";
            char letrinha = char.Parse(letra);
            //Criando a lista de strings
            List<string> list = new List<string>();
            //Adiciono elementos na lista
            list.Add("Fábio"); list.Add("Wilson"); list.Add("Angelina"); list.Add("Eliney"); list.Add("Andre");
            //Adiciona um elemento na posição sugerida
            list.Insert(2, "Lucas");
            //Realizo um loop de leitura dos elementos inseridos
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
