using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace Assignment1;
public class CalculateCenturies
{
   public void calculateCenturies()
    {
        int year = this.Centuries * 100;
        int days = year * 365;
        int hours = days * 24;
        long minutes = hours * 60L;
        long seconds = minutes * 60L;
        long milliseconds = seconds * 1000L;
        long microseconds = milliseconds * 1000L;
        decimal nanoseconds = (decimal)microseconds * 1000M;
        Console.WriteLine($"Output: {Centuries} centuries = {year} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
    public int Centuries
    {
        get;
        set;
    }
}


