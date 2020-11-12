using System;
using System.IO;
using System.Text;
using static Lesson_2.View;


namespace Lesson_2
{
    public class ExampleStream
    {
        private View _view = new View();
        public void ExampleWrite(string path)
        {
            if (String.IsNullOrEmpty(path)) return;
            StreamWriter sw = new StreamWriter(path,false, Encoding.ASCII);

            int[] arr = { 5, 5, 5, 8, 2, 5, 45, 285, 8, 1 };
            for (int index = 0; index < arr.Length; index++)
            {
                var i = arr[index];
                sw.WriteLine(i);
            }

            sw.Flush();
            sw.Close();
        }


        /// <summary>
        ///
        /// <exception cref="MyExc">gdfhfghgfj</exception>
        /// </summary>
        public void ExampleFile()
        {
            string str = "My name \nRoman";
            string str2 = "\nМеня зовут Роман";
            File.WriteAllText("data.bat", str);
            File.AppendAllText("data.bat", str2);

            if (!File.Exists("data.bat"))
            {
                return;
            }

            try
            {
                string[] arrayStr = File.ReadAllLines("data.bat");

                for (int i = 0; i < arrayStr.Length; i++)
                {
                    _view.Print(arrayStr[i]);
                }
            }
            catch (DirectoryNotFoundException e)
            {
                _view.Print(e.Message);
            }
            catch (Exception e)
            {
                _view.Print(e.Message);
            }
        }

        public void ExampleReader(string path)
        {
            if (String.IsNullOrEmpty(path) || !File.Exists(path)) return;

            StreamReader sr = new StreamReader(path);
            int a = 0;
            try
            {
                while (!sr.EndOfStream)
                {
                    a = Int32.Parse(sr.ReadLine());
                    _view.Print($"{a}");
                }
            }
            catch (FormatException e) when (a > 4)
            {
                _view.Print($"Error {e.Message}");
                //throw new Exception("Что-то пошло не так");
            }
            catch (Exception e)
            {

            }
            finally
            {
                sr.Close();
                _view.Print("Error");
            }
            _view.Print("Error2");
        }
    }
}
