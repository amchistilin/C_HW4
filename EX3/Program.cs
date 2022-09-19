// Напишите программу, которая задаёт массив из N элементов и выводит их на экран. 
//N - вводится с клавиатуры. Элементы тоже вводятся с клавиатуры.


int[] FillArray(int size)
            {
            int[] mas = new int[size];

            for (int i=0;i<size;i++) 
                {
                    mas[i]= new Random().Next(-9,10);
                }
            return mas;
            }
            
        void PrintArray(int[] mmm)
            {
           
            for (int i=0;i<mmm.Length;i++) 
                {
                    if (i!=mmm.Length-1) Console.Write($"{mmm[i]}, ");
                    else Console.WriteLine($"{mmm[i]}");
                }

            }
int[] FindSums(int[] mmm)
            {
            int[] sums=new int[2];
            foreach (int item in mmm)
                {
                    if (item>0) sums[1]+=item;
                    else sums[0]+=item;
                }
            return sums;
            }
Console.WriteLine("Введите количество элементов массива ");
int arrNumber = Convert.ToInt32(Console.ReadLine());
int[] array=FillArray(arrNumber);
PrintArray(array);
       