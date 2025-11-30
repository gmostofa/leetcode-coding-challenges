
public class Solution 
{
    public int DayOfYear(string date) 
    {
        string[] parts = date.Split('-');
        int year = int.Parse(parts[0]);
        int month = int.Parse(parts[1]);
        int day = int.Parse(parts[2]);
        
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) 
        {
            daysInMonth[1] = 29;
        }
        int totalDays = 0;
        for (int i = 0; i < month - 1; i++) {
            totalDays += daysInMonth[i];
        }
        totalDays += day;
        return totalDays;
    }
}