﻿using System;

namespace ConsoleApp6
{
    internal class Program
      {
        static void Main(string[] args)
        {
            INGREDIENTESP PIngrediente1 = new INGREDIENTESP("Harina", 1, 200, "Gramos");
            INGREDIENTESP PIngrediente3 = new INGREDIENTESP("Huevo", 2, 1, "kilo");
            INGREDIENTESP PIngrediente2 = new INGREDIENTESP("Leche", 2, 1, "litro");
            INGREDIENTESP PIngrediente4 = new INGREDIENTESP("Polvo de Hornear", 2 , 10, "Gramos");
            INGREDIENTESP PIngrediente5 = new INGREDIENTESP("Mantequilla", 5 , 226, "Gramos");
            INGREDIENTESP PIngrediente6 = new INGREDIENTESP("canela", 1, 100, "Gramos");


            //creamos el pastel con todos los ingredientes



            PastelCOMPOSITE PPastel = new PastelCOMPOSITE("Pastel de Vainilla");
            PPastel.Add(PIngrediente1);
            PPastel.Add(PIngrediente2);
            PPastel.Add(PIngrediente3);
            PPastel.Add(PIngrediente4);
            PPastel.Add(PIngrediente5);
            PPastel.Add(PIngrediente6);


            // Console.WriteLine(PPastel.Valor);

            INGREDIENTESP PIngrediente7 = new INGREDIENTESP("Chocolate ",4,200,"Gramos");
            PastelCOMPOSITE PPastelChocolateYvainilla =new PastelCOMPOSITE("Pastel compuesto");

            PPastelChocolateYvainilla.Add(PIngrediente7);
            PPastelChocolateYvainilla.Add(PPastel);

            Console.WriteLine("EL VALOR TOTAL DE LOS INGREDIENTES ES :");

            Console.WriteLine(PPastelChocolateYvainilla.ValorTotal);



           
        }
    }
}
