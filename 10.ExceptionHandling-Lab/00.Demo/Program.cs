using System;
using System.Numerics;

namespace _00.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Method1();
                }
                catch (Exception  ex)
                {
                    Console.WriteLine("Stack Trace:" + Environment.NewLine + ex.StackTrace);

                    //Как работи StackTrace?
                    //1.Стекът на извикванията записва всички методи, които са били извикани преди да се стигне до изключението.
                    //2.Най-новото извикване (най-горната част на стека) е методът, който реално е хвърлил изключението.
                    //3.По-старите извиквания (надолу по стека) показват пътя, по който е стигнало изпълнението до този метод.

                    //Защо StackTrace е полезен?
                    //✔ Помага за откриване на първопричината за грешки.
                    //✔ Улеснява дебъгването, като показва точния ред на грешката.
                    //✔ Полезен е за логване и диагностика в production среди.
                }

                try
                {
                    // въвеждаме от конзолата: 5.5, което предизвиква FormatException
                    int num = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Invalid format!", ex);
                }

            }
            catch (Exception ex)
            {
                // Извеждаме на конзолата съобщението на InvalidOperationException
                Console.WriteLine(ex.Message);

                // Извеждаме на конзолата съобщението на FormatException, който се явява InnerException
                if (ex.InnerException != null)
                    Console.WriteLine(ex.InnerException.Message);

                //В C# свойството InnerException се използва за вграждане на оригиналното изключение (Exception), което е довело до текущото изключение. Това е полезно за проследяване на веригата от грешки.

                //Обяснение:
                //Вътрешният try блок предизвиква FormatException.
                //Този FormatException се прихваща и се вгражда като InnerException в InvalidOperationException.
                //Външният try блок прихваща InvalidOperationException и извежда съобщенията и на двете изключения.
            }

            Console.WriteLine("End program!");
        }

        private static void Method1()
        {
            Method2();
        }

        private static void Method2()
        {
            int num = int.Parse(Console.ReadLine());
        }
    }
}
