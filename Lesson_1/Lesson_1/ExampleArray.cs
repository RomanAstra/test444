using System;
using System.Collections.Generic;


namespace Lesson_2
{
    public class ExampleArray
    {
        private View _view = new View();

        private class MyClass
        {

        }

        public void ExampleOne()
        {
            int[] arr = new int[5];

            arr[0] = 45;
            arr[1] = 43;
            arr[2] = 2;
            arr[3] = 4;
            arr[4] = 1;

            _view.PrintArray(arr);

            int[] t = { 2, 5, 2, 4, 2, 5 };

            MyClass[] myClasses = new MyClass[5];
        }

        public void InputArray()
        {
            _view.Print("Введите размер массива");
            int size = _view.GetInt();
            int[] arr = new int[size];

            _view.Print("Вводите данные массива");
            for (int i = 0; i < size; i++)
            {
                arr[i] = _view.GetInt();
            }

            _view.PrintArray(arr);
        }

        public int SumArray(int[] valueArr)
        {
            int result = 0;

            for (int i = 0; i < valueArr.Length; i++)
            {
                result += valueArr[i];
            }

            _view.Print(result);

            return result;
        }

        public void ExampleTwo()
        {
            int[,] arrD = new int[5,5];

            _view.Print($"Размерность массива = {arrD.Rank}");

            _view.Print($"Длина массива = {arrD.Length}");


            Random random = new Random();
            for (var i = 0; i < arrD.GetLength(0); i++)
            {
                for (var j = 0; j < arrD.GetLength(1); j++)
                {
                    arrD[i, j] = random.Next(10);
                }
            }

            arrD[2, 3] = -55;
            _view.PrintMatrix(arrD);
        }

        public void ExampleThree()
        {
            double[][] arrD = new double[5][];

            Random random = new Random();

            arrD[0] = new double[9];
            arrD[1] = new double[6];
            arrD[2] = new double[12];
            arrD[3] = new double[3];
            arrD[4] = new double[1];

            for (var i = 0; i < arrD.Length; i++)
            {
                for (var j = 0; j < arrD[i].Length; j++)
                {
                    arrD[i][j] = random.Next(10);
                    _view.Print($" {arrD[i][j]}", false);
                }
                _view.Print(" ");
            }
        }
    }
}
