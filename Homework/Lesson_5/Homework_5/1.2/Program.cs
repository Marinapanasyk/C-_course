// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
int[] RandomArrayOne(int size)

  {
    int[] RandomArray = new int[size];
                for (int i = 0; i < size; i++)
  { RandomArray[i] = new Random().Next();}
  return RandomArray;
  }          
  void PrintArray(int[] Array1)
            {
                for (int i = 0; i < Array1.Length; i++)
                {
                    Console.WriteLine(Convert.ToString(Array1[i]));
                }
            }
           int Sum1(int[] myArray2)
            { int Sum = 0;
                for (int i = 0; i < myArray2.Length; i++)
                    if (i % 2 != 0)
                    {
                        Sum = Sum + myArray2[i];
                    }
                return Sum;}
                int[] myArray = new int[9];
            myArray = RandomArrayOne(5);
            PrintArray(myArray);
            Console.WriteLine("Cумма чисел нечетных элементов = " +Sum1(myArray));