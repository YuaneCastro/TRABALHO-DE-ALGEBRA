public class Program
{
    public static void Main(string[] args)
    {
        void error()
        {
            Console.Clear();
            Console.WriteLine(
                "\n===================================\n          OPÇÃO INVÁLIDA\n===================================\n\n"
            );
        }
        
        void Matrix_Print(double[,] Matriz)
        {
            Console.Clear();
            // preenche a matriz com os valores digitados pelo usuario
            // bom dia 
            Console.WriteLine("===================================\n         ESTÁ É A SUA MATRIZ\n===================================");
            Console.Write("\n");
            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {  
                    Console.Write($"{Matriz[i, j], 8}");
                }
                Console.Write("   |\n");
            }
            Console.Write("\n");
        }
        double[,] Matrix_Read(int Num_mat)
        {
            Console.Clear();
            int N_linha;
            bool verif_retor_lin;
            do
            {
                if(Num_mat == 1 || Num_mat == 2)
                {
                    Console.WriteLine($"\n===================================\n          MATRIZ {Num_mat}\n===================================\n\n");
                    Console.Write($"DIGITE O NUMERO DE LINHAS DA MATRIZ {Num_mat}: ");
                }
                else
                {
                    Console.Write("DIGITE O NUMERO DE LINHAS DA MATRIZ: ");
                }
                verif_retor_lin = int.TryParse(Console.ReadLine(), out N_linha);
                Console.Clear();
                if (N_linha <= 0 || verif_retor_lin == false)
                {
                    error();
                }
            } while (N_linha <= 0 || verif_retor_lin == false);
            
            Console.Clear();
            int N_coluna;
            bool verif_retor_col;
            do
            {
                if(Num_mat == 1 || Num_mat == 2)
                {
                    Console.WriteLine($"\n===================================\n          MATRIZ {Num_mat}\n===================================\n\n");
                    Console.Write($"DIGITE O NUMERO DE COLUNAS DA MATRIZ {Num_mat}: ");
                }
                else
                {
                    Console.Write("DIGITE O NUMERO DE COLUNAS DA MATRIZ: ");
                }
                verif_retor_col = int.TryParse(Console.ReadLine(), out N_coluna);
                Console.Clear();
                if (N_coluna <= 0 || verif_retor_col == false)
                {
                    error();
                }
            } while (N_coluna <= 0 || verif_retor_col == false);
            // cria a matriz com o numero de linhas e colunas digitado pelo usuario
            double[,] Matriz = new double[N_linha, N_coluna];
            // preenche a matriz com os valores digitados pelo usuario
            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Console.Clear();
                    bool verif_retor;
                    do
                    {   if(Num_mat==1 || Num_mat==2)Console.WriteLine($"\n===================================\n          MATRIZ {Num_mat}\n===================================\n\n");
                        Console.Write($"DIGITE O VALOR DA POSICAO [{i + 1},{j + 1}]: ");
                        verif_retor = double.TryParse(Console.ReadLine(), out Matriz[i, j]);
                        if (verif_retor == false)
                        {
                            error();
                        }
                    } while (verif_retor == false);
                }
            }
            return Matriz;
        }

        double[,] Matrix_Scalar_Mult(double[,] Matriz)
        {
            double escalar;
            bool verif_retor;
            do
            {
                Matrix_Print(Matriz);
                Console.Write("\n\nDIGITE O ESCALAR: ");
                verif_retor = double.TryParse(Console.ReadLine(), out escalar);
                Console.Clear();
                if (verif_retor == false)
                {
                    error();
                }
            } while (verif_retor == false);
            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Matriz[i, j] *= escalar;
                }
            }
            return Matriz;
        }
        double[,] Matrix_Add(double[,] Matriz1, double[,] Matriz2)
        {
            double[,] Matriz_resultante = new double[Matriz1.GetLength(0), Matriz1.GetLength(1)];
            for (int i = 0; i < Matriz_resultante.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_resultante.GetLength(1); j++)
                {
                    Matriz_resultante[i, j] = Matriz1[i, j] + Matriz2[i, j];
                }
            }
            return Matriz_resultante;
        }
        double[,] Matrix_Mult(double[,] Matriz1, double[,] Matriz2)
        {
            double[,] Matriz_resultante = new double[Matriz1.GetLength(0), Matriz2.GetLength(1)];
            for (int i = 0; i < Matriz_resultante.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_resultante.GetLength(1); j++)
                {
                    for (int k=0; k<Matriz1.GetLength(1); k++)
                    {
                        Matriz_resultante[i, j] += Matriz1[i, k] * Matriz2[k, j];
                    }
                }
            }
            return Matriz_resultante;
        }
        double[,] Matriz_Transpose(double[,] Matriz)
        {
            double[,] Matriz_transposta = new double[Matriz.GetLength(1), Matriz.GetLength(0)];
            for(int i +)
            
            return Matriz_transposta;
        }
        bool a = true;
        while (a == true)
        {
            //Console.Clear();
            // verifica se o usuario quer continuar ou nao
            // int b = 0;
            Console.Write("\n===================================\n   BEM VINDO AO ALGEBRA SOLUTION\n===================================\n\n");

            // verifica se o usuario digitou uuma das opcoes validas, caso contrario pede para digitar novamente
            // Verifica se o número digitado esta no intervalo de solucoes
            // verifica se nao e uma leetra digitada
            int op;
            bool verif_retor_op;
            do
            {
                Console.Write(
                    "QUE OPERACAO PRETENDE EXECUTAR NA MATRIZ?\n1 - Multiplicação por um escalar\n2 - Soma de matrizes\n3 - Multiplicação de matrizes\n4 - Transposta de uma matriz\n5 - Verificar se uma matriz é diagonal\n6 - Verificar se uma matriz é triangular superior \n7 - Inversa de uma matriz 2×2 \n8 - Determinante de uma matriz 3×3 por Laplace \n "
                );
                Console.WriteLine("\n0 - Sair");
                Console.Write("DIGITE O NUMERO DA OPCAO: ");
                verif_retor_op = int.TryParse(Console.ReadLine(), out op);
                Console.Clear();
                if (verif_retor_op == false || op < 0 || op > 8)
                {
                    error();
                }
            } while (verif_retor_op == false || op < 0 || op > 8);
            Console.Clear();
            int Num_mat;
            switch (op)
            {
                case 0:
                    return;
                case 1:
                    //1 - Multiplicação por um escalar
                    Num_mat = 0;
                    double[,] Matriz_result_scalar = Matrix_Read(Num_mat);
                    Matriz_result_scalar = Matrix_Scalar_Mult(Matriz_result_scalar);
                    Matrix_Print(Matriz_result_scalar);
                    break;
                case 2:
                    //2 - Soma de matrizes
                    Num_mat = 1;
                    double[ ,] Matriz1 = Matrix_Read(Num_mat);
                    Num_mat = 2;
                    double[ ,] Matriz2 = Matrix_Read(Num_mat);
                    if(Matriz1.GetLength(0) != Matriz2.GetLength(0) || Matriz1.GetLength(1) != Matriz2.GetLength(1))
                    {
                        Console.WriteLine("AS MATRIZES NAO TEM O MESMO TAMANHO, NAO E POSSIVEL SOMA-LAS");
                        break;
                    }
                    double[,] Matriz_result_soma = Matrix_Add(Matriz1, Matriz2);
                    Matrix_Print(Matriz_result_soma);
                    break;
                case 3:
                    //3 - Multiplicação de matrizes
                    Num_mat = 1;
                    double[ ,] MatrizM1 = Matrix_Read(Num_mat);
                    Num_mat = 2;
                    double[ ,] MatrizM2 = Matrix_Read(Num_mat);
                    if(MatrizM1.GetLength(1) != MatrizM2.GetLength(0))
                    {
                        Console.WriteLine("AS MATRIZES NAO TEM O TAMANHO COMPATIVEL, NAO E POSSIVEL MULTIPLICA-LAS");
                        break;
                    }
                    double[,] Matriz_result_mult = Matrix_Mult(MatrizM1, MatrizM2);
                    Matrix_Print(Matriz_result_mult);
                    break;
                case 4:
                    //4 - Transposta de uma matriz
                    Num_mat=0;
                    double[,] Matriz = Matrix_Read(Num_mat);
                    double[,] Matriz_transposta = Matriz_Transpose(Matriz);
                    Matrix_Print(Matriz_transposta);
                    break;
                case 5:
                    //5 - Verificar se uma matriz é diagonal

                    break;
                case 6:
                    //6 - Verificar se uma matriz é triangular superior

                    break;
                case 7:
                    //7 - Inversa de uma matriz 2×2

                    break;
                case 8:
                    //8 - Determinante de uma matriz 3×3 por Laplace
                    break;
            }

            int opcao_continuar = 0;
            do
            {
                Console.Write("\n\nPRETENDE CONTINUAR? (S/N): ");
                string? resposta = Console.ReadLine();
                Console.Clear();
                if (resposta == "N" || resposta == "n")
                {
                    return;
                }
                else if (resposta == "S" || resposta == "s")
                {
                    opcao_continuar = 1;
                    continue;
                }
                else
                {
                    Console.WriteLine("RESPOSTA INVALIDA, DIGITE NOVAMENTE");
                    continue;
                }
            } while (opcao_continuar == 0);
            Console.Clear();
        }
    }
}
