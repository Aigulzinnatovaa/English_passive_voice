using System;

namespace Passive_void_English
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите функцию: 1 - ввести предложение ; 2- вывод примера предложения ");
            string i = Console.ReadLine();
            int j = Convert.ToInt32(i);
            if (j == 1) 
            {
                Console.WriteLine("Введи предложение");
                string sentence =Console.ReadLine();
                string  pr_simple1 = "am";
                string pr_simple2 = "is";
                string pr_simple3 = "are";
                string pr_cont1 = "am being";
                string pr_cont2 = "is being";
                string pr_cont3 = "are being";
                string pr_perfect1 = " have been ";
                string pr_perfect2 = " has been ";

                string past_simple1 = " was";
                string past_simple2 = " were";
                string past_cont1 = " was being";
                string past_cont2 = " were being";
                string past_perfect = " had been";

                string f_simple = "will be";
                string f_perfect = "will have been";



                string negative_form_pr_simple1 ="am not";
                string negative_form_pr_simple2 ="is not";
                string negative_form_pr_simple3 = "are not";
                string negative_form_pr_cont1 ="am not being";
                string negative_form_pr_cont2 ="is not being";
                string negative_form_pr_cont3 ="are not being";
                string negative_form_pr_perfect1 ="have not been";
                string negative_form_pr_perfect2 ="has not been";

                string negative_form_past_simple1 ="was not";
                string negative_form_past_simple2 ="were not";
                string negative_form_past_cont1 ="was not being";
                string negative_form_past_cont2 ="were not being";
                string negative_form_past_perfect ="had not been";

                string negative_form_f_simple ="will not be";
                string negative_form_f_perfect =" will not have been";


                bool bool_pr_simple1 = sentence.Contains(pr_simple1); bool bool_negative_form_pr_simple1=sentence.Contains(negative_form_pr_simple1); if (bool_pr_simple1==true | bool_negative_form_pr_simple1==true) { Console.WriteLine("Present Simple"); }
                bool bool_pr_simple2 = sentence.Contains(pr_simple2); bool bool_negative_form_pr_simple2=sentence.Contains(negative_form_pr_simple2); if (bool_pr_simple2==true | bool_negative_form_pr_simple2==true) { Console.WriteLine("Present Simple"); }
                bool bool_pr_simple3= sentence.Contains(pr_simple3); bool bool_negative_form_pr_simple3=sentence.Contains(negative_form_pr_simple3); if (bool_pr_simple3==true | bool_negative_form_pr_simple3==true) { Console.WriteLine("Present Simple"); }

                bool bool_pr_cont1= sentence.Contains(pr_cont1); bool bool_negative_form_pr_cont1=sentence.Contains(negative_form_pr_cont1); if (bool_pr_cont1==true | bool_negative_form_pr_cont1==true) { Console.WriteLine("Present Continious"); }
                bool bool_pr_cont2= sentence.Contains(pr_cont2); bool bool_negative_form_pr_cont2=sentence.Contains(negative_form_pr_cont2); if (bool_pr_cont2==true | bool_negative_form_pr_cont2==true) { Console.WriteLine("Present Continious"); }
                bool bool_pr_cont3= sentence.Contains(pr_cont3); bool bool_negative_form_pr_cont3=sentence.Contains(negative_form_pr_cont3); if (bool_pr_cont3==true | bool_negative_form_pr_cont3==true) { Console.WriteLine("Present Continious"); }

                bool bool_pr_perfect1= sentence.Contains(pr_perfect1); bool bool_negative_form_pr_perfect1 = sentence.Contains(negative_form_pr_perfect1); if (bool_pr_perfect1 ==true | bool_negative_form_pr_perfect1 ==true) { Console.WriteLine("Present Perfect"); }
                bool bool_pr_perfect2= sentence.Contains(pr_perfect2); bool bool_negative_form_pr_perfect2 = sentence.Contains(negative_form_pr_perfect2); if (bool_pr_perfect2 ==true | bool_negative_form_pr_perfect2 ==true) { Console.WriteLine("Present Perfect"); }



                bool bool_past_simple1 = sentence.Contains(past_simple1); bool bool_negative_form_past_simple1 = sentence.Contains(negative_form_past_simple1); if (bool_past_simple1 == true | bool_negative_form_past_simple1 == true) { Console.WriteLine("Past Simple"); }
                bool bool_past_simple2 = sentence.Contains(past_simple2); bool bool_negative_form_past_simple2 = sentence.Contains(negative_form_past_simple2); if (bool_past_simple2 == true | bool_negative_form_past_simple2 == true) { Console.WriteLine("Past Simple"); }

                bool bool_past_cont1 = sentence.Contains(past_cont1); bool bool_negative_form_past_cont1 = sentence.Contains(negative_form_past_cont1); if(bool_past_cont1== true | bool_negative_form_past_cont1 == true) { Console.WriteLine("Past Continious"); }
                bool bool_past_cont2 = sentence.Contains(past_cont2); bool bool_negative_form_past_cont2 = sentence.Contains(negative_form_past_cont2); if(bool_past_cont2== true | bool_negative_form_past_cont2 == true) { Console.WriteLine("Past Continious"); }

                bool bool_past_perfect = sentence.Contains(past_perfect); bool bool_negative_form_past_perfect = sentence.Contains(negative_form_past_perfect); if(bool_past_perfect == true | bool_negative_form_past_perfect == true) { Console.WriteLine("Past Perfect"); }




                bool bool_f_simple = sentence.Contains(f_simple); bool bool_negative_form_f_simple = sentence.Contains(negative_form_f_simple); if (bool_f_simple == true | bool_negative_form_f_simple == true) { Console.WriteLine("Future Simple"); }

                bool bool_f_perfect = sentence.Contains(f_perfect); bool bool_negative_form_f_perfect = sentence.Contains(negative_form_f_perfect); if (bool_f_perfect == true | bool_negative_form_f_perfect == true) { Console.WriteLine("Future Perfect"); }


            }
            if (j == 2) 
            {
                Console.WriteLine("Выберите время для примера предложения: 1-Present; 2-Past; 3-Future");
                string ii =Console.ReadLine();
                int jj = Convert.ToInt32(ii);
                if (jj == 1) 
                {
                    Console.WriteLine("Уточните время: 1-Simple; 2-Continuous; 3 -Perfect");
                    string present_a = Console.ReadLine();
                    int present_ = Convert.ToInt32(present_a);
                    if (present_ == 1)
                    {
                        Console.WriteLine("Present Simple");
                        Console.WriteLine("пример: Two cars are sold.");
                        Console.WriteLine("-Две машины проданы .");
                        Console.WriteLine("построение: am/is/are + V3");
                    }
                    if (present_ == 2)
                    {
                        Console.WriteLine("Present Continious");
                        Console.WriteLine("пример: I am being manipulated somehow ");
                        Console.WriteLine("- Мной каким-то образом манипулируют.");
                        Console.WriteLine("построение: am/is/are + being + V3");
                    }
                    if (present_ == 3)
                    {
                        Console.WriteLine("present perfect");
                        Console.WriteLine("пример:These documents have been brought by your secretary ");
                        Console.WriteLine("- Эти документы принес твой секретарь.");
                        Console.WriteLine("построение: have/has + been + V3");
                    }
                    if (present_ != 1 & present_ != 2 & present_ != 3) { Console.WriteLine("Ошибка! Попробуйте снова("); }
                }
                
                if (jj == 2)
                {
                    Console.WriteLine("Уточните время: 1-Simple; 2-Continuous; 3 -Perfect");
                    string past_a = Console.ReadLine();
                    int past_ = Convert.ToInt32(past_a);
                    if (past_ == 1)
                    {
                        Console.WriteLine("Past Simple");
                        Console.WriteLine("пример: Mike was killed by John    ");
                        Console.WriteLine("-Майк был убит Джоном.");
                        Console.WriteLine("построение: was/were + V3");
                    }

                    if (past_ == 2)
                    {
                        Console.WriteLine("Past Continious");
                        Console.WriteLine("пример:The book was being read ");
                        Console.WriteLine("-Книгу читали. ");
                        Console.WriteLine("построение: was/were + being + V3");
                    }
                    if (past_ == 3)
                    {
                        Console.WriteLine("Past Perfect");
                        Console.WriteLine("пример: Had he been accus ed of stealing?");
                        Console.WriteLine("- Его обвинили в воровстве?");
                        Console.WriteLine("построение: had + been + V3");
                    }
                    if (past_ != 1 & past_ != 2 & past_ != 3) { Console.WriteLine("Ошибка! Попробуйте снова("); }
                }

                if (jj == 3)
                {
                    Console.WriteLine("Уточните время: 1-Simple; 2-Perfect");
                    string future_a = Console.ReadLine();
                    int future_ = Convert.ToInt32(future_a);
                    if (future_ == 1)
                    {
                        Console.WriteLine("Future Simple");
                        Console.WriteLine("пример: He will not be forgotten");
                        Console.WriteLine("- Он не будет забыт");
                        Console.WriteLine("построение: will + be + V3");
                    }
                    if (future_ == 2)
                    {
                        Console.WriteLine("future perfect");
                        Console.WriteLine("пример: the door will have been closed by Masha");
                        Console.WriteLine("- дверь будет закрыта Машей");
                        Console.WriteLine("построение: will + have + been + V3");
                    }
                    
                    if (future_ != 1 & future_ != 2 ) { Console.WriteLine("Ошибка! Попробуйте снова("); }

                }

            }
            if (j != 1 & j != 2) { Console.WriteLine("Ошибка!Попробуйте заново"); }
            
            Console.ReadLine();

        
        }
    }
}
