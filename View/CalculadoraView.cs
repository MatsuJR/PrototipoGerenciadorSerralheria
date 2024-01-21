using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemory.Controller;

namespace InMemory.View
{
    public class CalculadoraView
    {
        public int idMaterial1;
        public int idMaterial2;
        public double altura;
        public double largura;
        public double larguraBaseMesa;
        public double comprimento;
        public double espaçamento;
        CalculadoraController controller = new CalculadoraController();

        public void MenuCalculadora()
        {
            int op;
            do
            {

                System.Console.WriteLine("escolha um opcao:");
                System.Console.WriteLine("0- sair");
                System.Console.WriteLine("1- mesa ");
                System.Console.WriteLine("2- grade");
                System.Console.WriteLine("3- ");
                System.Console.WriteLine("4- ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        InformacaoMesa();
                        controller.Mesa(idMaterial1, idMaterial2, altura, largura, larguraBaseMesa, comprimento);
                        ApagaInformacao();
                        break;
                    case 2:
                        InformacaoGrade();
                        controller.Grade(idMaterial1, altura, largura, espaçamento);
                        break;
                    case 3:

                        break;
                    case 4:

                        break;

                    default: Console.WriteLine("Opcao incorreta"); MenuCalculadora(); break;
                }
            } while (op != 0);
            Program.Menu();
        }

        public void InformacaoMesa()
        {
            System.Console.WriteLine("digite 1- trapezio ou 2- retangulo");
            string opMesa = Console.ReadLine();
            if (opMesa.Equals("1"))
            {
                System.Console.WriteLine("digite o id do material dos pes da mesa");
                idMaterial1 = int.Parse(Console.ReadLine());
                System.Console.WriteLine("digite o id do material da superficie da mesa");
                idMaterial2 = int.Parse(Console.ReadLine());
                System.Console.WriteLine("digite a altura da mesa (metros)");
                altura = double.Parse(Console.ReadLine());
                System.Console.WriteLine("digite a largura da superficie da mesa (metros)");
                largura = double.Parse(Console.ReadLine());
                System.Console.WriteLine("digite a largura da base da mesa (metros)");
                larguraBaseMesa = double.Parse(Console.ReadLine());
                System.Console.WriteLine("digite o comprimento da mesa (metros)");
                comprimento = double.Parse(Console.ReadLine());
            }
            else if (opMesa.Equals("2"))
            {
                larguraBaseMesa = 0;
                System.Console.WriteLine("digite o id do material dos pes da mesa");
                idMaterial1 = int.Parse(Console.ReadLine());
                System.Console.WriteLine("digite o id do material da superficie da mesa");
                idMaterial2 = int.Parse(Console.ReadLine());
                System.Console.WriteLine("digite a altura da mesa (metros)");
                altura = double.Parse(Console.ReadLine());
                System.Console.WriteLine("digite a largura da superficie da mesa (metros)");
                largura = double.Parse(Console.ReadLine());
                System.Console.WriteLine("digite o comprimento da mesa (metros)");
                comprimento = double.Parse(Console.ReadLine());
            }
            else
            {
                System.Console.WriteLine("opcao invalida. Digite 1 ou 2");
                InformacaoMesa();
            }

        }



        public void InformacaoGrade()
        {
            System.Console.WriteLine("digite o id do material da grade");
            idMaterial1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite a altura da grade (metros)");
            altura = double.Parse(Console.ReadLine());
            System.Console.WriteLine("digite a largura da grade (metros)");
            largura = double.Parse(Console.ReadLine());
            System.Console.WriteLine("digite o espaçamento entre as grade (centimetros)");
            espaçamento = double.Parse(Console.ReadLine());
        }

        public void ApagaInformacao()
        {
            idMaterial1 = 0;
            idMaterial2 = 0;
            altura = 0;
            largura = 0;
            larguraBaseMesa = 0;
            comprimento = 0;
            espaçamento = 0;
        }





    }
}