using System;

namespace Lesson_2
{
    public class Example
    {
        private View _view = new View();
        public void Start(ExampleType type)
        {
            switch (type)
            {
                case ExampleType.First:
                    new ExampleArray().ExampleOne();
                    break;
                case ExampleType.Second:
                    new ExampleArray().InputArray();
                    break;
                case ExampleType.Third:
                    new ExampleArray().SumArray(new []{5, 5, 5});
                    break;
                case ExampleType.Fourth:
                    new ExampleArray().ExampleTwo();
                    break;
                case ExampleType.Fifth:
                    new ExampleArray().ExampleThree();
                    break;
                case ExampleType.Sixth:
                    new ExampleStream().ExampleWrite("Text.txt"); 
                    break;
                case ExampleType.Seventh:
                    new ExampleStream().ExampleReader("Text.txt");
                    break;
                case ExampleType.Eighth:
                    try
                    {
                        ExampleException();
                    }
                    catch (Exception e)
                    {
                        _view.Print(e.Message);
                    } 
                    break;
                case ExampleType.Ninth:
                    new ExampleStream().ExampleFile();
                    break;
                case ExampleType.Tenth:
                    break;
                case ExampleType.Eleventh:
                    break;
                case ExampleType.Twelfth:
                    break;
                default:
                    break;
            }

            _view.Pause();
        }

        private void ExampleException()
        {
            int a = _view.GetInt();
            int b = _view.GetInt();

            if (b == 0)
            {
                throw new Exception("Кто догадался поделить на 0?");
                return;
            }

            //int c = 0;
            //try
            //{
            //    c = a / b;
            //    _view.Print(c);
            //}
            //catch (DivideByZeroException e)
            //{
            //    throw new DivideByZeroException("Кто догадался поделить на 0?");
            //}
            //finally
            //{
            //    _view.Print("finally");
            //}

            //_view.Print("No finally");
        }
    }
}
