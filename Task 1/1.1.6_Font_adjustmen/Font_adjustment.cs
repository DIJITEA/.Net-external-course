using used_frequently;

namespace _1._1._6_Font_adjustmen
{
    public class FontAdjustment
    {
        public static void Main()
        {
            Console.WriteLine("Font adjustment");
            string LabelParameters = "None";
            string[] TextStyles = { "Bolid", "Italic", "Underline", "exit" };
            int[] examinationArr = new int[TextStyles.Length];


            Output(ref LabelParameters,ref examinationArr, TextStyles);
        }
        public static void Output(ref string LabelParameters, ref int[] examinationArr, string[] TextStyles)
        {
            int input = 0;
            do
            {
                string str = $"Параметры надписи: {LabelParameters}";
                Console.WriteLine(str);

                Console.WriteLine("Введите:");
                for (int i = 0; i < TextStyles.Length; i++)
                {

                    Console.WriteLine("       " + (i + 1) + ": " + TextStyles[i]);
                }

                input = UsedFrequently.Try2ParseLessThenN(TextStyles.Length);

                if (examinationArr[input - 1] == 0)
                {
                    examinationArr[input - 1] = 1;
                }
                else
                {
                    examinationArr[input - 1] = 0;
                }
                LabelParameters = "";
                bool NoneException = true;
                for (int i = 0; i < examinationArr.Length; i++)
                {
                    if (examinationArr[i] == 1)
                    {
                        LabelParameters += TextStyles[i] + ", ";
                        NoneException = false;
                    }
                }

                if (NoneException)
                {
                    LabelParameters = "None";
                }
                else
                {
                    LabelParameters = LabelParameters.Remove(LabelParameters.Length - 2);
                }
            } while (input != 4);
        }
    }
}