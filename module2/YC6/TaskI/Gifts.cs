using System;

public static class GiftCreator
{
    public static int phone_id = -1;
    public static int ps_id = -1;
    public static Gift CreateGift(string giftName)
    {
        if (giftName == "Phone")
        {
            phone_id++;
            return new Phone(phone_id);
            
        }
        else
        {
            ps_id++;
            return new PlayStation(ps_id);
        }
        
    }


}

public class Phone : Gift
{
    public Phone(int id) : base(id)
    {
        ID = id;
    }
 
}

public class PlayStation : Gift
{
    public PlayStation(int id) : base(id)
    {
        ID = id;
    }
}

