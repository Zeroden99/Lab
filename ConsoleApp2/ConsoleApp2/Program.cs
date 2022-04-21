using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double group_one_quest_one = Convert.ToInt32(Console.ReadLine());
            double group_one_quest_two = Convert.ToInt32(Console.ReadLine());
            double group_one_quest_three = Convert.ToInt32(Console.ReadLine());
            double group_one_quest_four = Convert.ToInt32(Console.ReadLine());
            double group_two_quest_one = Convert.ToInt32(Console.ReadLine());
            double group_two_quest_two = Convert.ToInt32(Console.ReadLine());
            double group_two_quest_three = Convert.ToInt32(Console.ReadLine());
            double group_three_quest_one = Convert.ToInt32(Console.ReadLine());
            double group_three_quest_two = Convert.ToInt32(Console.ReadLine());
            double group_four_quest_one = Convert.ToInt32(Console.ReadLine());
            double group_four_quest_two = Convert.ToInt32(Console.ReadLine());
            double group_four_quest_three = Convert.ToInt32(Console.ReadLine());
            double group_four_quest_four = Convert.ToInt32(Console.ReadLine());
            double group_four_quest_five = Convert.ToInt32(Console.ReadLine());
            double group_four_quest_six = Convert.ToInt32(Console.ReadLine());
            double group_four_quest_seven = Convert.ToInt32(Console.ReadLine());
            double group_five_quest_one = Convert.ToInt32(Console.ReadLine());
            double group_five_quest_two = Convert.ToInt32(Console.ReadLine());
            double group_five_quest_three = Convert.ToInt32(Console.ReadLine());
            double group_five_quest_four = Convert.ToInt32(Console.ReadLine());
            double group_five_quest_five = Convert.ToInt32(Console.ReadLine());
            //найгірнші відповіді
            double group_one_min = 20;
            double group_two_min = 15;
            double group_three_min = 10;
            double group_four_min = 50;
            double group_five_min = 25;
            //найкращі відповіді
            double group_one_max = 115;
            double group_two_max = 60;
            double group_three_max = 50;
            double group_four_max = 225;
            double group_five_max = 90;


            //Бажані значення
            double group_one_desired_value = Convert.ToInt32(Console.ReadLine());
            double group_two_desired_value = Convert.ToInt32(Console.ReadLine());
            double group_three_desired_value = Convert.ToInt32(Console.ReadLine());
            double group_four_desired_value = Convert.ToInt32(Console.ReadLine());
            double group_five_desired_value = Convert.ToInt32(Console.ReadLine());

            //Обчисення суми по групах
            double group_one_amount = group_one_quest_one + group_one_quest_two + group_one_quest_three + group_one_quest_four;
            double group_two_amount = group_two_quest_one + group_two_quest_two + group_two_quest_three;
            double group_three_amount = group_three_quest_one + group_three_quest_two;
            double group_four_amount = group_four_quest_one + group_four_quest_two + group_four_quest_three + group_four_quest_four + group_four_quest_five + group_four_quest_six + group_four_quest_seven;
            double group_five_amount = group_five_quest_one + group_five_quest_two + group_five_quest_three + group_five_quest_four + group_five_quest_five;

            //Обчислення функції належності
            double group_one_function_membership = 1 - 2 * Math.Pow((group_one_max - group_one_amount) / (group_one_max - group_one_min), 2);
            double group_two_function_membership = 1 - 2 * Math.Pow((group_two_max - group_two_amount) / (group_two_max - group_two_min), 2);
            double group_three_function_membership = 1 - 2 * Math.Pow((group_three_max - group_three_amount) / (group_three_max - group_three_min), 2);
            double group_four_function_membership = 1 - 2 * Math.Pow((group_four_max - group_four_amount) / (group_four_max - group_four_min), 2);
            double group_five_function_membership = 1 - 2 * Math.Pow((group_five_max - group_five_amount) / (group_five_max - group_five_min), 2);

            // Обчислення функції бажаної належності
            double group_one_function_desired_membership = 1 - 2 * Math.Pow((group_one_max - group_one_desired_value) / (group_one_max - group_one_min), 2);
            double group_two_function_desired_membership = 1 - 2 * Math.Pow((group_two_max - group_two_desired_value) / (group_two_max - group_two_min), 2);
            double group_three_function_desired_membership = 1 - 2 * Math.Pow((group_three_max - group_three_desired_value) / (group_three_max - group_three_min), 2);
            double group_four_function_desired_membership = 1 - 2 * Math.Pow((group_four_max - group_four_desired_value) / (group_four_max - group_four_min), 2);
            double group_five_function_desired_membership = 1 - 2 * Math.Pow((group_five_max - group_five_desired_value) / (group_five_max - group_five_min), 2);


            // Обчислення функції лінгвістиних змінних
            double group_one_linguistic_variable = (4 * group_one_function_membership - 4 * group_one_function_desired_membership) / group_one_function_desired_membership;
            double group_two_linguistic_variable = (4 * group_two_function_membership - 4 * group_two_function_desired_membership) / group_two_function_desired_membership;
            double group_three_linguistic_variable = (5 * group_three_function_desired_membership - 4 * group_three_function_membership) / group_three_function_desired_membership;
            double group_four_linguistic_variable = (4 * group_four_function_membership - 4 * group_four_function_desired_membership) / group_four_function_desired_membership;
            double group_five_linguistic_variable = 1;

            //Обчислення наступної функції належності
            double group_one_next_function_membership = group_one_linguistic_variable / 2;
            double group_two_next_function_membership = group_two_linguistic_variable;
            double group_three_next_function_membership = group_three_linguistic_variable / 2;
            double group_four_next_function_membership = group_four_linguistic_variable / 2;
            double group_five_next_function_membership = 0;

            //Вагові коефіціенти
            double group_one_weight_variable = Convert.ToInt32(Console.ReadLine());
            double group_two_weight_variable = Convert.ToInt32(Console.ReadLine());
            double group_three_weight_variable = Convert.ToInt32(Console.ReadLine());
            double group_four_weight_variable = Convert.ToInt32(Console.ReadLine());
            double group_five_weight_variable = Convert.ToInt32(Console.ReadLine());

            //Обчислення суми вагових коефіціентів
            double weight_amount = group_one_weight_variable + group_two_weight_variable + group_three_weight_variable + group_four_weight_variable + group_five_weight_variable;

            //Обчислення нормованих вагових коефіціентів
            double group_one_normalized_weight = group_one_weight_variable / weight_amount;
            double group_two_normalized_weight = group_two_weight_variable / weight_amount;
            double group_three_normalized_weight = group_three_weight_variable / weight_amount;
            double group_four_normalized_weight = group_four_weight_variable / weight_amount;
            double group_five_normalized_weight = group_five_weight_variable / weight_amount;


            //Обчислення агрегованої оцінки
            double mark = group_one_linguistic_variable * group_one_normalized_weight + group_two_linguistic_variable * group_two_normalized_weight + group_three_linguistic_variable * group_three_normalized_weight + group_four_linguistic_variable * group_four_normalized_weight + group_five_linguistic_variable * group_five_normalized_weight;
            Console.WriteLine(mark);

            //Вивід даних
            
            if (mark > 0.67)
            {
                Console.WriteLine("оцінка ідеї висока");
            }
            else if (mark > 0.47 && mark <= 0.67)
            {
                Console.WriteLine("оцінка ідеї вище середнього");
            }
            else if (mark > 0.36 && mark <= 0.47)
            {
                Console.WriteLine("оцінка ідеї середня");
            }
            else if (mark > 0.21 && mark <= 0.36)
            {
                Console.WriteLine("оцінка ідеї низька");
            }
            else if (mark >= 0 && mark <= 0.21)
            {
                Console.WriteLine("оцінка ідеї дуже низька");
            }
            else Console.WriteLine("це точно стартап?");



            Console.WriteLine(group_one_amount.ToString());
            Console.WriteLine(group_two_amount.ToString());
            Console.WriteLine(group_three_amount.ToString());
            Console.WriteLine(group_four_amount.ToString());
            Console.WriteLine(group_five_amount.ToString());
        }
    }
}
