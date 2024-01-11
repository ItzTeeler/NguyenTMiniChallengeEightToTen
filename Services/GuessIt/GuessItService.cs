namespace NguyenTMiniChallengeEightToTen.Services.GuessIt;

public class GuessItService : IGuessItService
{
    public string GuessItEasy(string input1)
    {
        double num1 = 0;
        if (Double.TryParse(input1, out num1))
        {
            if (num1 >= 1 && num1 <= 10)
            {
                Random easyRandom = new Random();
                int easyRandomGen = easyRandom.Next(1, 11);

                if(easyRandomGen == num1){
                    return $"You Guessed the right number of {num1}";
                }else{
                    return $"Your number of {num1} was wrong. Your one try was over... RESTART";
                }
            }
            else
            {
                return "Please Enter a number 1-10";
            }

        }
        else
        {
            return "Please Enter a valid NUMBER";
        }
    }

    public string GuessItHard(string input1)
    {
        double num1 = 0;
        if (Double.TryParse(input1, out num1))
        {
            if (num1 >= 1 && num1 <= 10)
            {
                Random hardRandom = new Random();
                int hardRandomGen = hardRandom.Next(1, 101);

                if(hardRandomGen == num1){
                    return $"You Guessed the right number of {num1}";
                }else{
                    return $"Your number of {num1} was wrong. Your one try was over... RESTART";
                }
            }
            else
            {
                return "Please Enter a number 1-10";
            }

        }
        else
        {
            return "Please Enter a valid NUMBER";
        }
    }

    public string GuessItMedium(string input1)
    {
        double num1 = 0;
        if (Double.TryParse(input1, out num1))
        {
            if (num1 >= 1 && num1 <= 10)
            {
                Random medRandom = new Random();
                int medRandomGen = medRandom.Next(1, 51);

                if(medRandomGen == num1){
                    return $"You Guessed the right number of {num1}";
                }else{
                    return $"Your number of {num1} was wrong. Your one try was over... RESTART";
                }
            }
            else
            {
                return "Please Enter a number 1-10";
            }

        }
        else
        {
            return "Please Enter a valid NUMBER";
        }
    }
}
