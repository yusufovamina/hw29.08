//task1
#region task1
//int[] A = new int[5];
//Console.WriteLine("Enter 5 integers to fill array A:");
//for (int i = 0; i < 5; i++)
//{
//    A[i] = int.Parse(Console.ReadLine());
//}

//int[,] B = new int[3, 4];
//Random random = new Random();
//Console.WriteLine("Array B (random numbers):");
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        B[i, j] = random.Next(1, 100); 
//        Console.Write(B[i, j] + "\t");
//    }
//    Console.WriteLine();
//}

//int maxA = A[0], minA = A[0];
//int maxB = B[0, 0], minB = B[0, 0];
//foreach (int num in A)
//{
//    maxA = (num > maxA) ? num : maxA;
//    minA = (num < minA) ? num : minA;
//}
//foreach (int num in B)
//{
//    maxB = (num > maxB) ? num : maxB;
//    minB = (num < minB) ? num : minB;
//}


//int sumA = 0, productA = 1;
//int sumB = 0, productB = 1;
//foreach (int num in A)
//{
//    sumA += num;
//    productA *= num;
//}
//foreach (int num in B)
//{
//    sumB += num;
//    productB *= num;
//}

//int sumEvenA = 0;
//foreach (int num in A)
//{
//    if (num % 2 == 0)
//    {
//        sumEvenA += num;
//    }
//}


//int sumOddColumnsB = 0;
//for (int j = 0; j < 4; j++)
//{
//    if (j % 2 == 0) //из за того что индексы идут с 0, я взяла на 1 больше
//    {
//        for (int i = 0; i < 3; i++)
//        {
//            sumOddColumnsB += B[i, j];
//        }
//    }
//}


//Console.WriteLine("\nArray A:");
//foreach (int num in A)
//{
//    Console.Write(num + " ");
//}
//Console.WriteLine();

//Console.WriteLine("\nOverall maximum element: " + Math.Max(maxA, maxB));
//Console.WriteLine("Overall minimum element: " + Math.Min(minA, minB));
//Console.WriteLine("Overall sum of all elements: " + (sumA + sumB));
//Console.WriteLine("Overall product of all elements: " + (productA * productB));
//Console.WriteLine("Sum of even elements in array A: " + sumEvenA);
//Console.WriteLine("Sum of odd columns in array B: " + sumOddColumnsB);

#endregion


#region task2
//task2


//int[,] array = new int[5, 5];
//Random random = new Random();

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        array[i, j] = random.Next(-100, 101);
//    }
//}

//int minValue = array[0, 0];
//int maxValue = array[0, 0];
//int minRowIndex = 0, minColIndex = 0, maxRowIndex = 0, maxColIndex = 0;

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        if (array[i, j] < minValue)
//        {
//            minValue = array[i, j];
//            minRowIndex = i;
//            minColIndex = j;
//        }
//        if (array[i, j] > maxValue)
//        {
//            maxValue = array[i, j];
//            maxRowIndex = i;
//            maxColIndex = j;
//        }
//    }
//}


//int sum = 0;
//int startRow = minRowIndex < maxRowIndex ? minRowIndex : maxRowIndex;
//int endRow = minRowIndex > maxRowIndex ? minRowIndex : maxRowIndex;
//int startCol = minColIndex < maxColIndex ? minColIndex : maxColIndex;
//int endCol = minColIndex > maxColIndex ? minColIndex : maxColIndex;


//bool isBetween = false;

//foreach (int element in array)
//{
//    if (element == minValue)
//    {
//        isBetween = true;
//    }
//    else if (element == maxValue)
//    {
//        isBetween = false;
//    }
//    else if (isBetween)
//    {
//        sum += element;
//    }
//}


//Console.WriteLine("Array:");
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        Console.Write(array[i, j] + "\t");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine($"Summ between minimal ({minValue}) and maximal ({maxValue}) elements is {sum}");
#endregion

#region task3
//task3
//Console.WriteLine("Enter text to encrypt: ");
//string originalText = Console.ReadLine();

//Console.WriteLine("Enter the key:");
//int key = int.Parse(Console.ReadLine());

//string encryptedText = "";
//string decryptedText = "";

//foreach (char symbol in originalText)
//{
//    if (char.IsLetter(symbol))
//    {
//        char shiftedChar = (char)(symbol + key);


//        if (char.IsUpper(symbol) && shiftedChar > 'Z')
//        {
//            shiftedChar = (char)(shiftedChar - 26);
//        }
//        else if (char.IsLower(symbol) && shiftedChar > 'z')
//        {
//            shiftedChar = (char)(shiftedChar - 26);
//        }

//        encryptedText += shiftedChar;
//    }
//    else
//    {
//        encryptedText += symbol; 
//    }
//}


//foreach (char symbol in encryptedText)
//{
//    if (char.IsLetter(symbol))
//    {
//        char shiftedChar = (char)(symbol - key);


//        if (char.IsUpper(symbol) && shiftedChar < 'A')
//        {
//            shiftedChar = (char)(shiftedChar + 26);
//        }
//        else if (char.IsLower(symbol) && shiftedChar < 'a')
//        {
//            shiftedChar = (char)(shiftedChar + 26);
//        }

//        decryptedText += shiftedChar;
//    }
//    else
//    {
//        decryptedText += symbol; 
//    }
//}

//Console.WriteLine("Encrypted text: " + encryptedText);
//Console.WriteLine("Decrypted text: " + decryptedText);

#endregion

#region task4
//task4 



Console.WriteLine("ENter size of the matrix A(rows and cols): ");
int rowsA = int.Parse(Console.ReadLine());
int colsA = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the elements of the matrix A");
int[,] matrixA = new int[rowsA,colsA];
for (int i = 0; i < rowsA; i++)
{
   
    for (int j = 0; j < colsA; j++)
    {
        matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}


Console.WriteLine("ENter size of the matrix B(rows and cols): ");
int rowsB = int.Parse(Console.ReadLine());
int colsB = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the elements of the matrix B");
int[,] matrixB = new int[rowsB,colsB];
for (int i = 0; i < rowsB; i++)
{
    
    for (int j = 0; j < colsB; j++)
    {
        matrixB[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Choose the operaiton:");
Console.WriteLine("1) Multiplying a matrix by a number");
Console.WriteLine("2) Matrix addition");
Console.WriteLine("3) Product of matrices.");
int choice = Convert.ToInt32(Console.ReadLine());



switch (choice)
{
    case 1:
        Console.WriteLine("Enter the number:");
        int numb = Convert.ToInt32(Console.ReadLine());
        int[,] result = new int[rowsA, colsA];
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsA; j++)
            {
                result[i, j] = matrixA[i, j] * numb;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Result: ");
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsA; j++)
            {
                Console.Write(result[i, j] + "  ");
            }
            Console.WriteLine();
        }

        break;
    case 2:
        if (rowsA != rowsB || colsA != colsB)
        {
            Console.WriteLine("Inpossible operation. Matrix must be the same size");
        }
        else
        {
            int[,] result2 = new int[rowsA, colsA];
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    result2[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Result: ");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    Console.Write(result2[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        break;
    case 3:
        if (colsA != rowsB)
        {
            Console.WriteLine("Multyplication is impossible(count of colums of matrix A are not equal to count of rows of matrix B)");
        }
        else
        {
            int[,] result3 = new int[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    result3[i, j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        result3[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Result: ");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    Console.Write(result3[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        break;
    default:
        Console.WriteLine("Incorrect choice");
        break;
}

#endregion

#region task5
//task5
//string expression;
//Console.WriteLine("Enter your expression: ");
//expression=Console.ReadLine();

//int result = 0;
//string[] parts = expression.Split('+', '-');

//if (!int.TryParse(parts[0], out result))
//{
//    Console.WriteLine("Error");
//}
//for (int i = 1; i < parts.Length; i++)
//{
//    char operation = expression[parts[i - 1].Length];
//    int operand;

//    if (!int.TryParse(parts[i], out operand))
//    {
//        Console.WriteLine("Error");

//    }

//    if (operation == '+')
//    {
//        result += operand;
//    }
//    else if (operation == '-')
//    {
//        result -= operand;
//    }
//}
//Console.WriteLine($"Result is {result}");
#endregion

#region task6
//task6

//Console.WriteLine("Enter the text:");
//string inputText = Console.ReadLine();

//string[] sentences = inputText.Split(new[] { '.' });

//for (int i = 0; i < sentences.Length; i++)
//{
//    if (!string.IsNullOrWhiteSpace(sentences[i]))
//    {
//        char[] charArray = sentences[i].ToCharArray();
//        for (int j = 0; j < charArray.Length; j++)
//        {
//            if (char.IsLetter(charArray[j]))
//            {
//                charArray[j] = char.ToUpper(charArray[j]);
//                break;
//            }
//        }
//        sentences[i] = new string(charArray);
//    }
//}

//string resultText = string.Join(". ", sentences) + ".";

//Console.WriteLine("Changed text :");
//Console.WriteLine(resultText);
#endregion
#region task7
//task7
//Console.WriteLine("Enter the text:");
//string inputText = Console.ReadLine();

//Console.WriteLine("Enter the foridden word:");
//string forbiddenWord = Console.ReadLine();

//int replacementsCount = 0;
//int index = 0;

//while (index < inputText.Length)
//{
//    index = inputText.IndexOf(forbiddenWord, index);

//    if (index == -1)
//    {
//        break;
//    }


//    inputText = inputText.Remove(index, forbiddenWord.Length).Insert(index, new string('*', forbiddenWord.Length));

//    index += forbiddenWord.Length;
//    replacementsCount++;
//}
//Console.WriteLine("The result:");
//Console.WriteLine(inputText);
//Console.WriteLine($"Statistics : {replacementsCount} of word \"{forbiddenWord}\" was replased");

#endregion