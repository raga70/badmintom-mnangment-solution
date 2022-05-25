namespace Entities;

public record Fight
{
    public int id { get; init; }


    public GamePlayer Player1 { get; init; }
    public GamePlayer Player2 { get; init; }
    public bool isB { get; init; }


    //badminton data validation 
    public bool isValid_PointsIncrease()
    {
        if (Player1.Score != 21 && Player2.Score != 21)
        {
            if (Player1.Score - Player2.Score != 2 && Player1.Score - Player2.Score != -2)
            {
                if ((Player1.Score == 30 && Player2.Score == 29) ||
                    (Player2.Score == 30 && Player1.Score == 29))
                    return false;

                return false;
            }

            return false;
        }

        else //increase player score
        {    
            if (Player1.Score > Player2.Score)
                Player1.Player.IncresePoints();
            else
                Player2.Player.IncresePoints();
        }

        return true;
    }
}