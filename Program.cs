using System;
using System.Collections.Generic;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] answer5 = { 7, 9, 9, 2, 7, 3, 9, 8, 7, 1, 3 };
            Solve(answer5);
           
        }
        private static void Solve(int[] answer)
        {
            List <string> options = new List<string>();
            int[] answer1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            
            for (int z=0;z<=answer.Length-1;z++)
            {
                answer1[z] = answer[z];
            }
            for (int z = 0; z <= answer.Length - 1; z++)
            {
                Console.Write(answer1[z]);
            }
            Console.WriteLine();

            for (int a = 0; a < 10; a++)
            {
                if(answer[0]==-1)
                {                    
                    answer1[0] = a;
                }
                for (int b = 0; b < 10; b++)
                {
                    if (answer[1] == -1)
                    {
                        answer1[1] = b;
                    }
                    for (int c = 0; c < 10; c++)
                    {
                        if (answer[2] == -1)
                        {
                            answer1[2] = c;
                        }
                        for (int d = 0; d < 10; d++)
                        {                           
                            if (answer[3] == -1)
                            {                              
                                answer1[3] = d;
                            }
                            for (int e = 0; e < 10; e++)
                            {
                                if (answer[4] == -1)
                                {
                                    answer1[4] = e;
                                }
                                for (int f = 0; f < 10; f++)
                                {
                                    if (answer[5] == -1)
                                    {
                                        answer1[5] = f;
                                    }
                                    for (int h = 0; h < 10; h++)
                                    {
                                        if (answer[6] == -1)
                                        {                                            
                                            answer1[6] = h;
                                        }
                                        for (int i = 0; i < 10; i++)
                                        {
                                            if (answer[7] == -1)
                                            {
                                                answer1[7] = i;
                                            }
                                            for (int j = 0; j < 10; j++)
                                            {
                                                if (answer[8] == -1)
                                                {
                                                    answer1[8] = j;
                                                }
                                                for (int k = 0; k < 10; k++)
                                                {
                                                    if (answer[9] == -1)
                                                    {
                                                        answer1[9] = k;
                                                    }                                                   
                                                    for (int l = 0; l < 10; l++)
                                                    {
                                                        if (answer[10] == -1)
                                                        {
                                                            answer1[10] = l;
                                                        }                                                      
                                                        if (Iscorrect(answer1))
                                                        {
                                                            
                                                            string num1="0";                                                           
                                                            for (int z =0; z <= answer.Length - 1; z++)
                                                            {                                                                
                                                                num1= num1.Insert(num1.Length-1, answer1[z].ToString());                                                             
                                                            }
                                                            num1 = num1.Substring(0, 11);
                                                            Console.WriteLine(num1);
                                                            options.Add(num1);                                                            
                                                        }
                                                        if (answer[10] != -1)
                                                        {
                                                            break;
                                                        }
                                                    }
                                                    if (answer[9] != -1)
                                                    {
                                                        break;
                                                    }

                                                }
                                                if (answer[8] != -1)
                                                {
                                                    break;
                                                }

                                            }
                                            if (answer[7] != -1)
                                            {
                                                break;
                                            }

                                        }
                                        if (answer[6] != -1)
                                        {
                                            break;
                                        }

                                    }
                                    if (answer[5] != -1)
                                    {
                                        break;
                                    }

                                }
                                if (answer[4] != -1)
                                {
                                    break;
                                }

                            }
                            if (answer[3] != -1)
                            {
                                break;
                            }

                        }
                        if (answer[2] != -1)
                        {
                            break;
                        }

                    }
                    if (answer[1] != -1)
                    {
                        break;
                    }

                }
                if (answer[0] != -1)
                {
                    break;
                }

            }
            for (int z = 0; z <= options.Count- 1; z++)
            {               
                Console.WriteLine(options[z]);
            }
            Console.WriteLine(options.Count);



        }
        private static bool Iscorrect(int[] answered )
        {
            int[] answer2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int x = 0; x <= answered.Length - 1; x++)
            {
                answer2[x] = answered[x];
            }
            int checksum = 0;
            int last = answer2[10];
            for (int i = 0; i < answered.Length-1; i++)
            {                
                if (i%2!=0)
                {
                    answer2[i] = answer2[i] * 2;
                }
                answer2[i] = answer2[i] % 10 + answer2[i] / 10;
                checksum = answer2[i]+checksum;                
            }
            int final = 10 - checksum % 10;
            return (final == last) ;            
        }
    }
}
