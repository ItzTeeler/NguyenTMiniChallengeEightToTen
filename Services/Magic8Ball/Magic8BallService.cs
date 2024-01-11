namespace NguyenTMiniChallengeEightToTen.Services.Magic8Ball;

public class Magic8BallService : IMagic8BallService
{
    public string Magic8Ball()
    {
        Random r = new Random();
        int randomNum = r.Next(0, 8);
        switch(randomNum){
            case 0: 
            return "You should ask your mom...";
            case 1: 
            return "You should ask your dad..";
            case 2: 
            return "Go do it!";
            case 3: 
            return "I don't think so..";
            case 4: 
            return "Ask again";
            case 5: 
            return "You shouldn't do it";
            case 6: 
            return "Who are you?";
            case 7: 
            return "No";
            default:
            return "Yes";
        }
    }
}
