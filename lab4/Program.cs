using lab4;
using System;
using System.IO;


namespace Ocinka
{
   
    class Program
    {
        
       


        static void Main(string[] args)
        {

            double[,] exp1= Read.Expert1();
            double[,] exp2 = Read.Expert2();
            double[,] exp3 = Read.Expert3();
            double[,] exp4 = Read.Expert4();
            string[] book = Read.Book();
            string[] parametr = Read.Parametrs();
            double[] weight = Read.GetWeight();

            Console.WriteLine("Книги:");
            for (int i = 0; i < book.Length; i++)
            {
                Console.WriteLine($"{i + 1} {book[i]}");
            }

            Console.WriteLine("\n Необхiднi параметри :");
            for (int i = 0; i < parametr.Length; i++)
            {
                Console.WriteLine($"{i + 1} {parametr[i]}");
            }

            Console.WriteLine("\nШкала оцiнювання: 1-5");
            

            double book1_genre =Math.Round(weight[0]*( exp1[0, 0] + exp2[0, 0] + exp3[0, 0] + exp4[0, 0]),1);
            double book2_genre = Math.Round(weight[0] *( exp1[1, 0] + exp2[1, 0] + exp3[1, 0] + exp4[1, 0]), 1);
            double book3_genre = Math.Round(weight[0] *( exp1[2, 0] + exp2[2, 0] + exp3[2, 0] + exp4[2, 0]), 1);
            double book4_genre = Math.Round(weight[0] * (exp1[3, 0] + exp2[3, 0] + exp3[3, 0] + exp4[3, 0]), 1);
            double book5_genre = Math.Round(weight[0] * (exp1[4, 0] + exp2[4, 0] + exp3[4, 0] + exp4[4, 0]), 1);

            double book1_price = Math.Round(weight[1] * (exp1[0, 1] + exp2[0, 1] + exp3[0, 1] + exp4[0, 1]),1);
            double book2_price = Math.Round(weight[1] * (exp1[1, 1] + exp2[1, 1] + exp3[1, 1] + exp4[1, 1]), 1);
            double book3_price = Math.Round(weight[1] * (exp1[2, 1] + exp2[2, 1] + exp3[2, 1] + exp4[2, 1]), 1);
            double book4_price = Math.Round(weight[1] * (exp1[3, 1] + exp2[3, 1] + exp3[3, 1] + exp4[3, 1]), 1);
            double book5_price = Math.Round(weight[1] * (exp1[4, 1] + exp2[4, 1] + exp3[4, 1] + exp4[4, 1]), 1);

            double book1_cover = Math.Round(weight[2] * (exp1[0, 2] + exp2[0, 2] + exp3[0, 2] + exp4[0, 2]), 1);
            double book2_cover = Math.Round(weight[2] * (exp1[1, 2] + exp2[1, 2] + exp3[1, 2] + exp4[1, 1]), 1);
            double book3_cover = Math.Round(weight[2] * (exp1[2, 2] + exp2[2, 2] + exp3[2, 2] + exp4[2, 2]), 1);
            double book4_cover = Math.Round(weight[2] * (exp1[3, 2] + exp2[3, 2] + exp3[3, 2] + exp4[3, 2]), 1);
            double book5_cover = Math.Round(weight[2] * (exp1[4, 2] + exp2[4, 2] + exp3[4, 2] + exp4[4, 2]), 1);

            double book1_rating = Math.Round(weight[3] * (exp1[0, 3] + exp2[0, 3] + exp3[0, 3] + exp4[0, 3]), 1);
            double book2_rating= Math.Round(weight[3] * (exp1[1, 3] + exp2[1, 3] + exp3[1, 3] + exp4[1, 3]), 1);
            double book3_rating= Math.Round(weight[3] * (exp1[2, 3] + exp2[2, 3] + exp3[2, 3] + exp4[2, 3]), 1);
            double book4_rating= Math.Round(weight[3] * (exp1[3, 3] + exp2[3, 3] + exp3[3, 3] + exp4[3, 3]), 1);
            double book5_rating= Math.Round(weight[3] * (exp1[4, 3] + exp2[4, 3] + exp3[4, 3] + exp4[4, 3]), 1);

            double book1_sum = Math.Round(book1_genre + book1_price + book1_cover + book1_rating,1);
            double book2_sum = Math.Round( book2_genre + book2_price + book2_cover + book2_rating, 1);
            double book3_sum = Math.Round(book3_genre + book3_price + book3_cover + book3_rating, 1);
            double book4_sum = Math.Round(book4_genre + book4_price + book4_cover + book4_rating, 1);
            double book5_sum = Math.Round(book5_genre + book5_price + book5_cover + book5_rating, 1);

            Console.WriteLine("Результат");

            Console.WriteLine("№ Параметр      |  Вага  |  Звiянi вiтром  |  Вино з кульбаб  |  Немає виходу  |  Володар перснiв  |  Ловець невинних душ  | ");
            Console.WriteLine($"1 Жанр          |  {weight[0]}       {book1_genre}                {book2_genre}                 {book3_genre}               {book4_genre}                  {book5_genre} ");
            Console.WriteLine($"2 Цiна          |  {weight[1]}       {book1_price}                {book2_price}                 {book3_price}             {book4_price}                {book5_price} ");
            Console.WriteLine($"3 Обкладинка    |  {weight[2]}       {book1_cover}                  {book2_cover}                 {book3_cover}             {book4_cover}                {book5_cover}");
            Console.WriteLine($"4 Рейтинг       |  {weight[3]}       {book1_rating}                {book2_rating}                   {book3_rating}               {book4_rating}                {book5_rating}");
            Console.WriteLine($"Сума            |            {book1_sum}               {book2_sum}                {book3_sum}            {book4_sum}               {book5_sum} ");



        }
       



    }
}
