using static System.Console;
using System;
public class Auction
{
    static void Main()
    {
        string input = ReadLine();
        double bid;
        const int MIN = 10;

        
        if(Double.TryParse(input, out bid))
        {
            AcceptBid(bid, MIN);
        }
        else
        {
            AcceptBid(input, MIN);
        }         
        
            
    }

    public static void AcceptBid(int bid, int min)
    {
        if(bid >= min)
        {
            WriteLine("Bid accepted");
        }
        else
        {
            WriteLine("Bid not high enough");
        }
    }
    public static void AcceptBid(double bid, int min)
    {
        if (bid >= min)
        {
            WriteLine("Bid accepted");
        }
        else
        {
            WriteLine("Bid not high enough");
        }
    }
    public static void AcceptBid(string bid, int min)
    {
        bid.ToLower();
        int dollarSignPost = bid.IndexOf("$"); //find position of $
        int dollarsPost = bid.IndexOf("dollars"); //find position of 'dollars'
        bool acceptedBid = false;
        double bidNumber = -1;

        if(dollarSignPost == 0) //checks if '$' is in the front (postion '0')
        {
            
            bid = bid.Remove(0, 1); //remove $ from the front
            acceptedBid = Double.TryParse(bid, out bidNumber);
        }
        
        if(dollarsPost > 0) //checks if 'dollars' not in the front of the number
        {
            bid = bid.Remove(dollarsPost, 7); //remove the text 'dollars'
            acceptedBid = Double.TryParse(bid, out bidNumber);
        }

        //check to see if bid is acceptable
        if(acceptedBid && bidNumber >= min)
        {
            WriteLine("Bid accepted");
        }
        else if (acceptedBid == false)
        {
            WriteLine("Bid was not in correct format");
        }
        else
        {
            WriteLine("Bid not high enough");
        }
    }

}