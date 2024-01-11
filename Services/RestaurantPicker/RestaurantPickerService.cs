namespace NguyenTMiniChallengeEightToTen.Services.RestaurantPicker;

public class RestaurantPickerService : IRestaurantPickerService
{
    public string RestaurantPicker(string categoryNumber)
    {

        int categoryChosen = 0;
        if (Int32.TryParse(categoryNumber, out categoryChosen))
        {
            if (categoryChosen >= 1 && categoryChosen <= 3)
            {
                string[] category1 = new string[10];
                category1[0] = "Sushi Star";
                category1[1] = "Satori Sushi and Teriyaki Grill";
                category1[2] = "Takumi Izakaya Bar";
                category1[3] = "Mikuni Japanese Restaurant & Sushi Bar";
                category1[4] = "Binchoyaki Izakaya Dining";
                category1[5] = "Kodaiko Ramen & Bar";
                category1[6] = "Kru Contemporary Japanese Cuisine";
                category1[7] = "Osaka Sushi";
                category1[8] = "Koja Kitchen Sac Town";
                category1[9] = "Ramen House Ryujin";

                string[] category2 = new string[10];
                category2[0] = "Seoul St Midtown";
                category2[1] = "Pocha House";
                category2[2] = "Koja Kitchen Sac Town";
                category2[3] = "Southside Super";
                category2[4] = "Kindred Seoul";
                category2[5] = "Heat Shabu Baru";
                category2[6] = "Origami Asian Grill";
                category2[7] = "JJ Korean BBQ";
                category2[8] = "Jang Su Korean";
                category2[9] = "Tank House BBQ and Bar";

                string[] category3 = new string[10];
                category3[0] = "Frank Fat's";
                category3[1] = "Ming Dynasty";
                category3[2] = "T&Z Chinese Restaurant";
                category3[3] = "Peace Cuisine";
                category3[4] = "Fortune Chinese Food";
                category3[5] = "Hao Bao Dumplings";
                category3[6] = "Lam Kwong Market";
                category3[7] = "Dumpling House";
                category3[8] = "I Shanghai Delight";
                category3[9] = "Hidden Dumpling House Midtown";

                string[] chosenCategory;
                string categoryName;

                switch (categoryChosen)
                {
                    case 1:
                        chosenCategory = category1;
                        categoryName = "Japanese";
                        break;

                    case 2:
                        chosenCategory = category2;
                        categoryName = "Korean";
                        break;

                    case 3:
                        chosenCategory = category3;
                        categoryName = "Chinese";
                        break;

                    default:
                        chosenCategory = category1;
                        categoryName = "Sushi";
                        break;
                }

                Random random = new Random();
                int randomRestNum = random.Next(0, 10);
                string randomRestaurant = chosenCategory[randomRestNum];

                return $"You chose the Category of {categoryName}. We have chose this restaurant - {randomRestaurant}";
            }
            else
            {
                return "PLEASE ENTER A VALID CATEGORY NUMBER 1-3";
            }
        }
        else
        {
            return "PLEASE ENTER A VALID CATEGORY NUMBER 1-3";
        }
    }

}
