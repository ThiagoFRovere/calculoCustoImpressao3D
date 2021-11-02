using System;

namespace CustoImpressao {

    class Program {        

        class Operacoes {

            /*
            static string fabricante, nomeMaterial;
            static double valorKg = 0;
            static double valorFrete = 0;
            static double quantidadeMaterialGasto = 0;
            static double valorEnergia = 0;
            static double tempoImpressao = 0;
            static double consumoImpressora = 0;            
            static double despesaInicial = 0;
            static double depreciacao = 0;
            static double despesasExtras = 0;
            static double diaSemana = 0;
            static double horasTrabalhadas = 0;
            static double lucro = 0;
            */          

            public double somaMaterial(double valorKg, double valorFrete, double quantidadeMaterialGasto){ 

                double resultadoSomaMaterial = (valorKg + valorFrete) * quantidadeMaterialGasto;                
                return resultadoSomaMaterial;
            }

            public double somaEnergia(double valorEnergia, double tempoImpressao, double consumoImpressora) { 

                double resultadoSomaEnergia = (consumoImpressora * (valorEnergia / 1000)) * tempoImpressao;               
                return resultadoSomaEnergia;
            }    
                      
            public double somaDespessas(double despesaInicial, double depreciacao, double diaSemana, double horasTrabalhadas,double tempoImpressao) { 

                double resultadoSomaDespessas = (despesaInicial / (diaSemana * horasTrabalhadas * depreciacao))*tempoImpressao;
                return resultadoSomaDespessas;
            }

            public double somaTotal(double resultadoSomaMaterial, double resultadoSomaEnergia, double resultadoSomaDespessas, double lucro){

                double v = resultadoSomaMaterial+resultadoSomaEnergia+resultadoSomaDespessas;
                double resultadoSomaTotal = v + (v * lucro);
                return resultadoSomaTotal;
            }

            public double somaTotalR(double resultadoSomaMaterial, double resultadoSomaEnergia, double resultadoSomaDespessas, double lucro, double resultadoSomalimpeza){

                double v = resultadoSomaMaterial + resultadoSomaEnergia + resultadoSomaDespessas + resultadoSomalimpeza;
                double resultadoSomaTotal = v + (v * lucro);
                return resultadoSomaTotal;
            }

            public double somaLimpeza(double v12, double v13, double v14, double v15, double v16, double v17, double v18, double v19){

                double n1 = (v12 / v13) * v14;
                double n2 = (v15 / v16) * v17;
                double n3 = (v18/1000)*v19;
                double resultadoSomalimpeza = n1 + n2 + n3;
                return resultadoSomalimpeza;
            }
        }


        static void TelaInicial(){

            Console.Clear();
            Console.WriteLine("Programa para calcular custo da impressão 3D");
            Console.WriteLine("Desenvolvido por Thiago Ferreira Rovere\nV.1.0\n ");
        }

        static void Fim(){

            Console.Clear();
            Console.WriteLine("Fim do programa!!! ");            
        }


        static void Filamento(){

       

            double v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11;
            double retornoSomaMaterial, retornoSomaEnergia, retornoSomaDespesas,retornoTotal;
            char resposta;

            Operacoes Fila = new Operacoes();

            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.Write("Informe o valor Kg do filamento..............................: ");
            v1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do frete.....................................: ");
            v2 = double.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de material gasto.......................: ");
            v3 = double.Parse(Console.ReadLine());
            retornoSomaMaterial = Fila.somaMaterial(v1, v2, v3);
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.Write("Informe o consumo(watts da fonte) da impressora..............: ");
            v4 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor da energia da sua regiao (ex: 0.6 0.7).......: ");
            v5 = double.Parse(Console.ReadLine());
            Console.Write("Informe o tempo de impressão em horas........................: ");
            v6 = double.Parse(Console.ReadLine());
            retornoSomaEnergia = Fila.somaEnergia(v5, v6, v4);
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.Write("Informe a despesa inicial....................................: ");
            v7 = double.Parse(Console.ReadLine());
            Console.Write("Informe o tempo desejado para recuperar a despesa (MESES)....: ");
            v8 = double.Parse(Console.ReadLine());
            Console.Write("Informe quantidade de dias da semana trabalhados.............: ");
            v9 = double.Parse(Console.ReadLine());
            Console.Write("Informe quantidade de horas trabalhadas por semana...........: ");
            v10 = double.Parse(Console.ReadLine());
            retornoSomaDespesas = Fila.somaDespessas(v7, v8, v9, v10, v6);
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.Write("Informe a (%) de lucro desejado..............................: ");
            v11 = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------------------------");
            retornoTotal = Fila.somaTotal(retornoSomaMaterial, retornoSomaEnergia, retornoSomaDespesas,v11);
            Console.WriteLine("valor material gasto foi.................................: {0:C}", retornoSomaMaterial);
            Console.WriteLine("valor energia  gasta foi.................................: {0:C}", retornoSomaEnergia);
            Console.WriteLine("valor despesas gasto foi.................................: {0:C}", retornoSomaDespesas);                     
            Console.WriteLine("valor total da peça  foi.................................: {0:C}", retornoTotal);
            Console.WriteLine("---------------------------------------------------------------------------------");

            Console.Write("Deseja fazer nova consulta: [S]sim [N]não ");
            resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S'){
                TelaInicial();
            }if (resposta == 'n' || resposta == 'N'){
                Fim();
            }else{
                Console.WriteLine("Opção Invalida!!!! ");
                Console.WriteLine("Deseja Tentar Novamente: [S]sim [N]não ");
                resposta = char.Parse(Console.ReadLine());

                if (resposta == 's' || resposta == 'S'){
                    TelaInicial();
                }else{
                    Fim();
                }

            }
        }

        static void Resina(){

       

            double v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19;
            double retornoSomaMaterial, retornoSomaEnergia, retornoSomaDespesas, retornoTotal, retornoLimpeza;
            char resposta;

            Operacoes res = new Operacoes();

            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.Write("Informe o valor Kg da Resina.................................: ");
            v1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do frete.....................................: ");
            v2 = double.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de material gasto.......................: ");
            v3 = double.Parse(Console.ReadLine());
            retornoSomaMaterial = res.somaMaterial(v1, v2, v3);
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.Write("Informe o valor do papel toalha..............................: ");
            v12 = double.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de rolo que vem no pacote...............: ");
            v13 = double.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de rolo gasto...........................: ");
            v14 = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.Write("Informe o valor da caixa da luva.............................: ");
            v15 = double.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de luva da caixa........................: ");
            v16 = double.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de luvas gasta..........................: ");
            v17 = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.Write("Informe o valor do litro do alcool...........................: ");
            v18 = double.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de alcool gasta.........................: ");
            v19 = double.Parse(Console.ReadLine());
            retornoLimpeza = res.somaLimpeza(v12, v13, v14, v15, v16, v17, v18, v19);
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.Write("Informe o consumo(watts da fonte) da impressora..............: ");
            v4 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor da energia da sua regiao (ex: 0.6 0.7).......: ");
            v5 = double.Parse(Console.ReadLine());
            Console.Write("Informe o tempo de impressão em horas........................: ");
            v6 = double.Parse(Console.ReadLine());
            retornoSomaEnergia = res.somaEnergia(v5, v6, v4);
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.Write("Informe a despesa inicial....................................: ");
            v7 = double.Parse(Console.ReadLine());
            Console.Write("Informe o tempo desejado para recuperar a despesa (MESES)....: ");
            v8 = double.Parse(Console.ReadLine());
            Console.Write("Informe quantidade de dias da semana trabalhados.............: ");
            v9 = double.Parse(Console.ReadLine());
            Console.Write("Informe quantidade de horas trabalhadas por semana...........: ");
            v10 = double.Parse(Console.ReadLine());
            retornoSomaDespesas = res.somaDespessas(v7, v8, v9, v10, v6);
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.Write("Informe a (%) de lucro desejado..............................: ");
            v11 = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------------------------");
            retornoTotal = res.somaTotalR(retornoSomaMaterial, retornoSomaEnergia, retornoSomaDespesas, v11, retornoLimpeza);
            Console.WriteLine("valor material gasto foi.................................: {0:C}", retornoSomaMaterial);
            Console.WriteLine("valor Limpeza  gasta foi.................................: {0:C}", retornoLimpeza);
            Console.WriteLine("valor energia  gasta foi.................................: {0:C}", retornoSomaEnergia);
            Console.WriteLine("valor despesas gasto foi.................................: {0:C}", retornoSomaDespesas);
            Console.WriteLine("valor total da peça  foi.................................: {0:C}", retornoTotal);
            Console.WriteLine("---------------------------------------------------------------------------------");

            Console.Write("Deseja fazer nova consulta: [S]sim [N]não ");
            resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S'){
                TelaInicial();
            }if (resposta == 'n' || resposta == 'N'){
                Fim();
            }else{
                Console.WriteLine("Opção Invalida!!!! ");
                Console.WriteLine("Deseja Tentar Novamente: [S]sim [N]não ");
                resposta = char.Parse(Console.ReadLine());

                if (resposta == 's' || resposta == 'S'){
                    TelaInicial();
                }else{
                    Fim();
                }

            }
        }


        static void Main(string[] args){

        inicio:

            Console.Clear();
            TelaInicial();

            char resposta;

            Console.Write("Digiti a Opção desejada: ( R ) = Resina | ( F ) = Filamento: ");
            resposta = char.Parse(Console.ReadLine());

            if (resposta == 'r' || resposta == 'R'){
                Resina();
            }
            if (resposta == 'f' || resposta == 'F')
            {
                Filamento();
            }else{

                Console.WriteLine("Opção Invalida!!!! ");
                Console.WriteLine("Deseja Tentar Novamente: [S]sim [N]não ");
                resposta = char.Parse(Console.ReadLine());

                if (resposta == 's' || resposta == 'S'){
                    goto inicio;
                }else{
                    Fim();
                }

            }                                 

        }
    }
}